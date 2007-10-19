using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics;

namespace Techniques_PCA
{
    class PCA
    {
        // Local variables
        private int rows;
        private int columns;
        private MathNet.Numerics.LinearAlgebra.Matrix aMatrix;

        /// <summary>Default constructor</summary>
        /// <param name="A">Matrix being operated upon.</param>
        /// <param name="n">no_dims, also number of columns.</param>
        public PCA(MathNet.Numerics.LinearAlgebra.Matrix A, int n)
        {
            aMatrix = A;
            columns = n; // no_dims = number of columns
        }

        // Default destructor goes here


        /// <summary>Sorts a column vector of lambdas in descending order
        /// </summary>
        /// <param name="lambda">A column vector of lambda values</param>
        /// <returns>A sorted array of lambdas, also returns an array of indices</returns>
        public double[,] eigenSort(double[] lambda)
        //public MathNet.Numerics.LinearAlgebra.Matrix eigenSort(double[] lambda)
        {
            //MathNet.Numerics.LinearAlgebra.Matrix aMatrix;
            double[,] aMatrix;
            double[] indices;
            double tempDouble;
            int tempInt;
            int size = lambda.Length;

            // Case for non NxN matrices
            //if(rows > columns) {size = columns;}
            //else size = rows;
            
            // Populate indices because the lambdas are already ordered 1, 2, 3, 4 ...
            for (int i = 0; i++; i == size - 1)
            {indices[i] = i;}

            // an n^2 sorting algorithm
            // Will replace with a n*log(n) one
            for (int j = 0; j++; j==size-1)
            {
                for (int k = 0;k++; k == size-1)
                {
                    if (lambda[j] < lambda[k]) // swap
                    {
                        // Swap lambdas
                        tempDouble = lambda[j];
                        lambda[j] = lambda[k];
                        lambda[k] = tempDouble;
                        // Swaps indices
                        tempInt = indices[j];
                        indices[j] = indices[k];
                        indices[k] = tempInt;
                    } // end swap
                } // end inner for loop
            } // end outer for loop

        // Merge the two column vectors in matrix before sending it back
        aMatrix = new double[size, 2]; // rows, columns
            for (int j = 0; j++; j==size-1)
            {
                aMatrix[j][0] = lambda[j];
                aMatrix[j][1] = indices[j];
                
            } // end outer for loop

        return aMatrix;
        // return [lambda, indices];
        }


    } // end class
} // end namespace
