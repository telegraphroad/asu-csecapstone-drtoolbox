using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

// updated 11/27/07

namespace DRToolbox.Techniques
{
    /// <summary>
    /// Contains often-used matrix functions not provided by the MathNet APIs.  Functions included are eigenSort, cov
    /// to compute covariance matrix, and transpose.
    /// </summary>
    public class MatrixFunctions
    {
        double[,] indices;

        public MatrixFunctions()
        {
        }

        /// <summary>Sorts a column vector of lambdas in descending order
        /// </summary>
        /// <param name="lambda">A Matrix of lambda values.  The Matrix must be a column vector(1 column, no bound on rows)</param>
        /// <returns>A sorted(in descending order) Matrix of lambdas in the first column, in the second column are the original indices</returns>
        public Matrix eigenSort(Matrix lambda, string s)
        {
            Matrix aMatrix;
            double[,] a2DArray;
            double tempDouble;
            int rows = lambda.RowCount; // same as double[].Length
            int columns = lambda.ColumnCount;
            indices = new double[rows, 1]; // column vector

            // Case for non NxN matrices
            //if(rows > columns) {size = columns;}
            //else size = rows;

            if (s == "descending")
            {
                // Convert from Matrix representation to a column vector
                // Populate indices because the lambdas are already ordered 1, 2, 3, 4 ...
                for (int i = 0; i < rows; i++)
                {
                    indices[i, 0] = (Double)i;
                }

                // an n^2 sorting algorithm
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < rows; k++)
                    {
                        if (lambda[j, 0] > lambda[k, 0]) // swap condition -- sorts high to low
                        {
                            // Swap lambdas
                            tempDouble = lambda[j, 0]; // lambda[row, column]
                            lambda[j, 0] = lambda[k, 0];
                            lambda[k, 0] = tempDouble;
                            // Swaps indices
                            tempDouble = indices[j, 0];
                            indices[j, 0] = indices[k, 0];
                            indices[k, 0] = tempDouble;
                        } // end swap
                    } // end inner for loop
                } // end outer for loop

                // Merge the two column vectors in matrix before sending it back
                // First column is sorted lambdas, second is their corresponding indices
                a2DArray = new double[rows, 2]; // rows, columns
                for (int j = 0; j < rows; j++)
                {
                    a2DArray[j, 0] = lambda[j, 0];
                    a2DArray[j, 1] = indices[j,0];

                } // end outer for loop

                // Puts the 2d array a2DArray into aMatrix
                aMatrix = Matrix.Create(a2DArray);

                return aMatrix; // Returns a matrix with column 1 of lambda values, column 2 of indices
            }
            else if (s == "ascending")
            {

                // Populate indices because the lambdas are already ordered 1, 2, 3, 4 ...
                for (int i = 0; i < rows; i++)
                {
                    indices[i, 0] = (Double)i;
                }

                // an n^2 sorting algorithm, performed for each dimension(column) in the matrix
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < rows; k++)
                    {
                        for (int l = k; l < rows; l++)
                        {
                            if (lambda[l, j] < lambda[k, j]) // swap condition -- sorts low to high
                            {
                                // Swap entries
                                tempDouble = lambda[k, j]; // lambda[row, column]
                                lambda[k, j] = lambda[l, j];
                                lambda[l, j] = tempDouble;

                                // Swaps indices
                                tempDouble = indices[j, 0];
                                indices[j, 0] = indices[k, 0];
                                indices[k, 0] = tempDouble;
                            } // end swap
                        } // end inner for(rows)
                    } // end inner for loop(rows)
                } // end outer for loop(columns)

                return lambda;
            }
            else
                return null;
        }

        // code by abhishikth chandra
        // this is the code for function repmat
        // it increases the dinention of matrix mXn times
        public Matrix Repmat(Matrix A, int m, int n)
        {
            int x = A.RowCount;
            int y = A.ColumnCount;

            int C = m * x;
            int D = n * y;
            int E;
            int F;

            Matrix B = new Matrix(C, D);

            for (int i = 0; i < C; i++)
            {
                for (int j = 0; j < D; j++)
                {
                    E = i % x;
                    F = j % y;
                    B[i, j] = A[E, F];
                }
            }

            return B;
        }

        /* Code by KRT: Last Updated Fri 10/26/07 */
        /* * Pseudocode for Cov function
         * X:input --> n x p matrix
         * A = X - [(ones(n,1) * mean(X)] -> demeaning step
         * Y = [A * A'] / (n-1)
         * where A' -> transpose(A)
         * Y: output matrix*/
        /// <summary>
        /// Given a matrix (of type MathNet.Numerics.LinearAlgebra.Matrix), computes the covariance and returns the covariance matrix.
        /// </summary>
        /// <param name="origMatrix">The original matrix, of type MathNet.Numerics.LinearAlgebra.Matrix, whose covariance is to be computed.</param>
        /// <returns>A Matrix (of type MathNet.Numerics.LinearAlgebra.Matrix) which is the covariance matrix of the parameter.</returns>
        public Matrix cov(Matrix origMatrix)
        {
            int numRows = 0;
            int numCols = 0;

            Matrix demeanedMatrix;      // This is A of the pseudocode
            Matrix onesMatrix;          // This is ones(n,n)
            Matrix demeaner;            // This is [ones(n,1) * mean(X)]
            Matrix transposeMatrix;     // This is A'
            Matrix retMatrix;           // The matrix to be returned: Y

            numRows = origMatrix.RowCount;
            numCols = origMatrix.ColumnCount;
            onesMatrix = Matrix.Ones(numRows);
            onesMatrix = onesMatrix.GetMatrix(0, (numRows - 1), 0, 0);

            demeaner = onesMatrix * computeMean(origMatrix);

            demeanedMatrix = origMatrix - demeaner;

            transposeMatrix = Matrix.Transpose(demeanedMatrix);

            // should be the other way round
            //retMatrix = demeanedMatrix * transposeMatrix;

            // changed code, ensures that cov now returns dim x dim
            // where dim --> orig number of dimensions (eg. 4 for the first sample file)
            retMatrix = transposeMatrix * demeanedMatrix;
            //retMatrix = demeanedMatrix * transposeMatrix;
            retMatrix = retMatrix * (1.0 / (double)(numRows - 1));

            return retMatrix;
        }

        /// <summary>
        /// Provides the dimension-wise mean of a given matrix.
        /// </summary>
        /// <param name="origMatrix">The matrix (of type MathNet.Numerics.LinearAlgebra.Matrix) whose dimension-wise mean is to be computed.</param>
        /// <returns>A 1 x m Matrix that contains the columnwise means of the parameter matrix.</returns>
        public Matrix computeMean(Matrix origMatrix)
        {
            int numRows = 0;
            int numCols = 0;

            Matrix means;

            double sum = 0.0;
            double mean = 0.0;

            numRows = origMatrix.RowCount;
            numCols = origMatrix.ColumnCount;

            means = new Matrix(1, numCols);

            for (int i = 0; i < numCols; i++)
            {
                sum = 0.0;

                for (int j = 0; j < numRows; j++)
                {
                    sum += origMatrix[j, i];
                }

                mean = sum / (double)numRows;
                means[0, i] = mean;
            }

            return means;
        } /* END CODE BY KRT */

        /// <summary>
        /// Generates a matrix dataset depending on the type of distribution indicated.  Currently only 3-D(3 columns)
        /// of "swiss" type data may be generated.
        /// </summary>
        /// <param name="type">The type of dataset to generate, such as swiss, twinkpeaks, or helix</param>
        /// <param name="n">Number of datapoints to generate</param>
        /// <param name="noise">Amount of noise, try 0.05 or 5%</param>
        /// <returns></returns>
        public Matrix generate_data(string type, int n, double noise)
        {
            double[] temp = new Double[n];
            double randDouble;
            double[,] tempMatrix = new Double[n, 3];
            double height;
            MathNet.Numerics.LinearAlgebra.Matrix aMatrix;// = new MathNet.Numerics.LinearAlgebra.Matrix(n,n); // rows,columns

            switch (type)
            {
                case "swiss":
                    System.Random rand = new System.Random();
                    double cosine = 0.0;
                    double sine = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        cosine = MathNet.Numerics.Trig.Cosine(temp[i]);
                        sine = MathNet.Numerics.Trig.Sine(temp[i]);
                        randDouble = rand.NextDouble() * n; // Generates a random number between 0 and n
                        temp[i] = 3 * 3.14 / 2 * (1 + 2 * (randDouble));
                        randDouble = rand.NextDouble() * n; // Generates a random number between 0 and n
                        height = 21 * randDouble;
                        tempMatrix[i, 0] = temp[i] * cosine + noise * rand.NextDouble();
                        tempMatrix[i, 1] = height + noise * rand.NextDouble();
                        tempMatrix[i, 2] = temp[i] * sine + noise * rand.NextDouble();
                    }
                    aMatrix = new MathNet.Numerics.LinearAlgebra.Matrix(tempMatrix);
                    return aMatrix;
            } // end switch
            // Default case :
            aMatrix = new MathNet.Numerics.LinearAlgebra.Matrix(n, n);
            return aMatrix;
        }

        /// <summary>
        /// Puts the Nth column of the Matrix into a single double array.
        /// Used to find lambda values during eigenSort.
        /// </summary>
        /// <param name="M">Matrix having it's column converted to a double[]</param>
        /// <param name="N">The Nth column to convert to double[]</param>
        /// <returns></returns>
        public double[] matrixColumnToDoubleArray(Matrix M, int N)
        {
            double[] vals = new double[M.RowCount];
            int j = M.RowCount;
            for (int i = 0; i < j; i++)
            {
                vals[i] = M[i, N - 1];
            }
            return vals;
        }

        /// <summary>
        /// Converts a single column of a matrix into an integer array.
        /// Used to find indice values during eigenSort.
        /// </summary>
        /// <param name="M"></param>
        /// <param name="N">The column number to be put in the array</param>
        /// <returns>An array of integers</returns>
        public int[] matrixColumnToIntArray(Matrix M, int N)
        {
            int[] vals = new int[M.RowCount];

            try
            {
                int j = M.RowCount;
                for (int i = 0; i < j; i++)
                {
                    vals[i] = (int)M[i, N - 1];
                }
                return vals;
            }
            catch { return vals; }
        }

        /// <summary>
        /// Forces all negative entries in a matrix to become positive.
        /// </summary>
        /// <param name="N">Matrix being operated upon</param>
        /// <returns>An all-positive matrix</returns>
        public Matrix absolute(Matrix N)
        {
            int numRows = N.RowCount;
            int numColumns = N.ColumnCount;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    if (N[i, j] < 0.0)
                        N[i, j] = N[i, j] * -1.0;
                }
            }
            return N;
        } // end absolute


        /// <summary>
        /// Find the indices of the nearest neighbors for each data point in M.
        /// Works for NxN matrices
        /// Works for NxM matrices
        /// </summary>
        /// <param name="M"></param>
        /// <param name="k">Number of desired nearest neighbors</param>
        /// <returns>Adjacency matrix X</returns>
        public Matrix find_nearestNeighbors(Matrix M, int k)
        {
            int index = 0;
            Matrix indicesMatrix;
            Matrix transposeM = Matrix.Transpose(M);
            int numColumns = transposeM.ColumnCount;

            Matrix sparseMatrix = Matrix.Zeros(numColumns);
            

            // Squares each entry // rows i, columns j
            Matrix squaredM = Matrix.Create(transposeM);
            for (int i = 0; i < numColumns; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    squaredM[i, j] = squaredM[i, j] * squaredM[i, j];
                }
            }
            // Returns a row vector
            double[,] rowVector = new Double[1, M.ColumnCount];
            Matrix sumSquaredM = Matrix.Create(rowVector);
            double columnSum = 0.0;
            for (int i = 0; i < numColumns; i++)
            {
                columnSum = 0;
                for (int j = 0; j < numColumns; j++)
                {
                    columnSum = columnSum + squaredM[j, i];
                }
                sumSquaredM[0, i] = columnSum;
            }

            // an 1xN matrix of ones
            double[,] ones = new Double[1, numColumns];
            Matrix onesMatrix = Matrix.Create(ones);

            double[,] column = new Double[M.RowCount, 1]; // A column vector
            Matrix columnMatrix;
            double sumOfSquares = 0.0;
            Matrix squaredMatrix;
            Matrix sumMatrix;
            Matrix absoluteSumMatrix;
            for (int i = 0; i < numColumns; i++)
            {
                //column = matrixColumnToDoubleArray(transposeM, i + 1); // For columns 1 to numColumns
                columnMatrix = transposeM.GetMatrix(0, transposeM.RowCount - 1, i, i); // Get the i'th column
                //columnMatrix = new Matrix(column.Length, 1); // columns, rows
                //columnMatrix.SetMatrix(0, column.Length - 1, 0, 0);

                for ( int j = 0; j < columnMatrix.RowCount; j++ )
                {
                    // Squares each entry in the column vector
                    sumOfSquares = sumOfSquares + (columnMatrix[j,0] * columnMatrix[j,0]); // Row, column
                }
                squaredMatrix = Matrix.Transpose(columnMatrix) * M;

                sumMatrix = (sumOfSquares * onesMatrix) + (sumSquaredM - (2 * squaredMatrix));
                absoluteSumMatrix = absolute(sumMatrix);

                // Sort each column in ascending order
                absoluteSumMatrix = eigenSort(sumMatrix, "ascending");

                // Indices column is available globally
                // Grab the first k columns
                absoluteSumMatrix = absoluteSumMatrix.GetMatrix(0, absoluteSumMatrix.RowCount - 1, 0, k - 1);
                indicesMatrix = Matrix.Create(indices);
                indicesMatrix = indicesMatrix.GetMatrix(0, absoluteSumMatrix.RowCount - 1, 0, k - 1);
                absoluteSumMatrix = nonzero(absoluteSumMatrix); // changes zero entries into 0.0000001
                
                
                // Populate the row(given by for loop iteration) of the sparse matrix
                // with the entry in absoluteSumMatrix.  Note that each entry in this 
                for(int j = 0; j < indices.Length; j++)
                {
                    index = (int)indices[j,0];
                    sparseMatrix[i, index] = absoluteSumMatrix[i, index];
                } // end inner for
            } // end outer for

            return sparseMatrix;
        } // end find_nearestNeighbors

        /// <summary>
        /// Turns any zero entries in the matrix into a small number(0.0000001)
        /// </summary>
        /// <param name="M">The matrix with potential zero entries</param>
        /// <returns>The matrix with all zero entries modified.</returns>
        public Matrix nonzero(Matrix M)
        {
            int rowCount = M.RowCount;
            int colCount = M.ColumnCount;

            // [rows, columns]
            for (int i = 0; i < colCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    if (M[j, i] == 0.0)
                    { M[j, i] = 0.0000001; }
                }
            }
            return M;
        } // end nonzero


        /// <summary>
        /// Creates a sparse matrix, with a number of non-zero entries.
        /// </summary>
        /// <param name="rows">Dimensions of desired matrix in rows</param>
        /// <param name="columns">Dimensions of desired matrix in columns</param>
        /// <param name="k">Value for the nonzero entries</param>
        /// <param name="l">Maximum number of non-zero entries in the matrix</param>
        /// <returns>A sparse matrix.</returns>
        public Matrix sparse(int rows, int columns, double k, int l)
        {
            int counter = 0;
            Matrix M = new Matrix(rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    counter++;
                    if (counter <= l)
                    {
                        M[i, j] = k;
                    }
                    else
                        M[i, j] = 0;

                } // end inner for
            } // end outer for
            return M;
        }

        /// <summary>
        /// Divides the entries of a matrix by a certain double value.
        /// Also checks for divide by zero.
        /// </summary>
        /// <param name="M">Matrix whose entries are to be divided</param>
        /// <param name="val">Divisor.</param>
        /// <returns>A matrix with entries that are smaller(for val > 1) or larger(for val < 1)</returns>
        public Matrix matrixDivide(Matrix M, double val)
        {
            int rowCount = M.RowCount;
            int colCount = M.ColumnCount;

            if (val != 0.0)
            {
                // [rows, columns]
                for (int i = 0; i < colCount; i++)
                {
                    for (int j = 0; j < rowCount; j++)
                    {
                        if (M[i, j] != 0.0)
                        {
                            M[i, j] = M[i, j] / val;
                        }
                    }
                }
            } // end check for zero
            return M;
        }

    } // End Class
}// end namespace Techniques
