using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics;
//using MathNet.Numerics.LinearAlgebra;

namespace Techniques
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
        public PCA(MathNet.Numerics.LinearAlgebra.Matrix A)
        {
            aMatrix = A;
            //columns = n; // no_dims = number of columns
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

        /* CODE BY KRT */


        /*
         * Pseudocode:
         * 
         * X:input -> n x p matrix
         * A = X - [ones(n,1) * mean(X)] --> demeaning step
         * Y = [A * A'] / (n-1)
         * where A' -> transpose(A)
         * Y: return value
         * 
         */

        /// <summary>
        /// Given a matrix, computes the covariance and returns the covariance matrix.
        /// </summary>
        /// <param name="origMatrix">The matrix whose covariance is to be computed.</param>
        /// <returns>The covariance matrix of the matrix passed as a parameter.</returns>
        /// 

        public double[,] cov(double[,] origMatrix)
        {
            int numRows = 0, numCols = 0;
            double[,] demeanedMatrix;   // This is A of hte pseudocode
            double[,] demeaner;         // This is [ones(n,1) * mean(X)]
            double[,] retMatrix;        // Matrix to return: Y

            numRows = origMatrix.GetLength(0);
            numCols = origMatrix.GetLength(1);

            demeaner = matrixMult(ones(numRows, 1), computeMean(origMatrix));
            demeanedMatrix = new double[numRows, numCols];

            // ************************************
            // Can this be done?
            
            demeanedMatrix = origMatrix - demeaner;

            // ************************************

            retMatrix = matrixMult(demeanedMatrix, transpose(demeanedMatrix));

            retMatrix = (retMatrix / (numRows - 1));

            return retMatrix;
        }

        /// <summary>
        /// Given 2 dimensions m and n, returns an mxn all of whose elements are 1s.
        /// </summary>
        /// <param name="rows">m = Number of Rows of Output Matrix</param>
        /// <param name="cols">n = Number of Columns of Output Matrix</param>
        /// <returns>A matrix M of dimensions m x n all of whose elements are 1s.</returns>

        public double[,] ones(int rows, int cols)
        {
            double[,] retArray = new double[rows, cols];
            
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    retArray[i,j] = 1.0;

            return retArray;
        }

        /// <summary>
        /// Provides the dimension-wise mean of a given matrix.
        /// </summary>
        /// <param name="origMatrix">The matrix whose dimension-wise mean is to be computed.</param>
        /// <returns>A 1xm matrix that contains the columnwise means of the parameter matrix.</returns>
        
        public double[,] computeMean(double[,] origMatrix)
        {
            double[,] means;
            int numRows = 0, numCols = 0;
            double sum = 0.0;
            double mean = 0.0;
            
            numRows = origMatrix.GetLength(0);
            numCols = origMatrix.GetLength(1);

            for (int i = 0; i < numCols; i++)
            {
                for (int j = 0; j < numRows; j++)
                {
                    sum += origMatrix[j, i];
                }
                mean = sum / numRows;
                means[0, i] = mean;

            }

            return means;
        }

        public double[,] matrixMult(double[,] matrixOne, double[,] matrixTwo)
        {
            double[,] resultMatrix;
            double iterSum = 0.0;
            int matrixOneRows = 0, matrixOneCols = 0, matrixTwoRows = 0, matrixTwoCols = 0;

            matrixOneRows = matrixOne.GetLength(0);
            matrixTwoRows = matrixTwo.GetLength(0);
            matrixOneCols = matrixOne.GetLength(1);
            matrixTwoCols = matrixTwo.GetLength(1);

            if (matrixOneCols != matrixTwoRows)
                return null;

            resultMatrix = new double[matrixOneRows,matrixTwoCols];

            for (int i = 0; i < matrixOneRows; i++)
            {
                for (int j = 0; j < matrixTwoCols; j++)
                {
                    iterSum = 0.0;
                    for (int k = 0; k < matrixOneCols; k++)
                    {
                        iterSum += matrixOne[i, k] * matrixTwo[k, j];
                    }
                    resultMatrix[i, j] = iterSum;
                }
            }

            return resultMatrix;
        }

        public double[,] transpose(double[,] origMatrix)
        {
            int numRows = origMatrix.GetLength(0);
            int numCols = origMatrix.GetLength(1);

            double[,] retMatrix = new double[numCols, numRows];

            for (int i = 0; i < numRows; i++)
                for (int j = 0; j < numCols; j++)
                    retMatrix[numCols, numRows] = origMatrix[numRows, numCols];

            return retMatrix;
        }

        /* END CODE BY KRT */


    } // end class
} // end namespace
