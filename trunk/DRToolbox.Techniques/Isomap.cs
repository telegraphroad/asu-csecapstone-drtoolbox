
/**
 * Author: Kartik Talamadupula
 * **/

using System;
using System.Collections.Generic;
using System.Text;

using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace DRToolbox.Techniques
{
    public class Isomap
    {
        private Matrix aMatrix;
        private double radius;
        private int num_dims;

        MatrixFunctions functions = new MatrixFunctions();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Isomap() { }

        
        /// <summary>
        /// Constructor for Isomap
        /// </summary>
        /// <param name="A">The original matrix with data points</param>
        /// <param name="n">The number of dimensions that data is to be reduced to</param>
        /// <param name="r">The radius used for computing nearest neighbors, for geodesic calculation</param>
        public Isomap(Matrix A, int n, double r)
        {
            aMatrix = A;
            radius = r;
            num_dims = n;
        }
        
        /// <summary>
        /// Applies Isomap technique onto the given matrix.
        /// </summary>
        /// <param name="origMatrix">The matrix with the original data</param>
        /// <param name="num_dims">The number of dimensions that data is to be reduced to</param>
        /// <param name="rad">The radius used for computing nearest neighbors, for geodesic calculation</param>
        /// <returns>A Matrix object that contains the data to be projected onto the reduced dimensions</returns>
        public static Matrix doIsomap(Matrix origMatrix, int num_dims, double rad)
        {

            /**
             * Pseudocode
             * 
             * Call euclideanDistance (sqForm) in MDS   -> distMatrix
             * pass distMatrix to rnn( )                -> distMatrix_r
             * pass distMatrix_r to floyd-warshall      -> distMatrix_g
             * do eigenDecomposition of distMatrix_g    -> eVM
             * take first n rows of eVM                 -> eVM_top
             * take transpose of eVM_top                -> eVM_t_top
             * provide eVM_t_top as output
             * 
             **/

            Matrix distMatrix = euclideanDistance(origMatrix);
            Matrix distMatrix_r = rnn(distMatrix, rad);
            Matrix distMatrix_g = floydWarshall(distMatrix_r);
            EigenvalueDecomposition eV = new EigenvalueDecomposition(distMatrix_g);
            Matrix eVM = eV.EigenVectors;
            Matrix eVM_top = eVM.GetMatrix(0, (num_dims - 1), 0, (eVM.ColumnCount - 1));
            Matrix eVM_t_top = Matrix.Transpose(eVM_top);

            return eVM_t_top;
        }

        /**
         * The code for the below method needs to come from MDS
         * 
         * OR
         * 
         * the below method needs to call MDS
         * 
         * */

        /// <summary>
        /// Computes the pair-wise euclidean distance between the points given
        /// through the parameter matrix.
        /// </summary>
        /// <param name="A">The matrix that contains the points.</param>
        /// <returns>A Matrix containing the pair-wise euclidean distances between points.</returns>
        public static Matrix euclideanDistance(Matrix A)
        {
            int x = A.RowCount;
            int y = A.ColumnCount;
            double p = 0.0;
            double q = 0.0;

            Matrix B = new Matrix(x,x);

            for (int i = 0; i < x; i++)
            {
                for ( int j = 0; j < x; j++)
                {
	                if(i == j)
	                {
		                B[i,j] = 0;
	                }
	                else
	                {
        			
		                for ( int k = 0; k < y; k++)
		                {
			                p = p + Math.Pow((A[i,k] - A[j,k]),2.0);
		                }

                        q = Math.Pow(p,0.5);        				
		                B[i,j] = q;
	                }
                }
            }

            return B;	
        }

        /// <summary>
        /// Computes the nearest neighbors in terms of a given radius r; i.e., this method changes
        /// the distances of all points that are beyond a certain radius r from a given point to an
        /// extremely high value, which is int.MaxValue defined in C#.
        /// 
        /// This helps when running the shortest paths algorithm since those points that are beyond
        /// the fixed radius "r" are never considered in the computation of the shortest path, and
        /// hence we calculate an approximation of the geodesic distance.
        /// </summary>
        /// <remarks>Can be made a bit more efficient by cutting half the for loop inside</remarks>
        /// <param name="distMatrix">The matrix containing pairwise distances between points</param>
        /// <param name="radius">The radius in which neighbors will be considered (r)</param>
        /// <returns>The matrix containing pairwise distances between points, with those points that
        /// were originally further than 'r' away from a given point having their distances set to
        /// a large value.</returns>
        public static Matrix rnn(Matrix distMatrix, double rad)
        {
            Matrix retMatrix;
            retMatrix = distMatrix;

            for (int i = 0; i < retMatrix.RowCount; i++)
            {
                for (int j = 0; j < retMatrix.ColumnCount; j++)
                {
                    if (retMatrix[i, j] > rad)
                        retMatrix[i, j] = int.MaxValue;
                }
            }

            return retMatrix;
        }

        /// <summary>
        /// Applies the Floyd-Warshall dynamic programming algorithm to n points to
        /// determine the shortest distance between all pairs of points
        /// </summary>
        /// <param name="distMatrix">The matrix containing pairwise distances between points</param>
        /// <returns>A Matrix containing the lengths of the shortest paths between pairs of points</returns>        
        public static Matrix floydWarshall(Matrix distMatrix)
        {
            Matrix retMatrix;
            retMatrix = distMatrix;

            int numPoints = retMatrix.RowCount;

            for (int k = 0; k < numPoints; k++)
            {
                for (int i = 0; i < retMatrix.RowCount; i++)
                {
                    for (int j = 0; j < retMatrix.ColumnCount; j++)
                    {
                        retMatrix[i, j] = Math.Min(retMatrix[i, j], (retMatrix[i, k] + retMatrix[k, j]));
                    }
                }
            }

            return retMatrix;
        }
    }
}
