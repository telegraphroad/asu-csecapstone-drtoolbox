using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

// updated 12/01/07

namespace DRToolbox.Techniques
{

    public class LLE
    {
        private Matrix aMatrix;

        public LLE(Matrix A)
        {
            aMatrix = A;
        }
        public LLE()
        {
        }

        /// <summary>
        /// Local linear embedding
        /// </summary>
        /// <param name="A">The input matrix</param>
        /// <param name="numdims">Number of dimensions being reduced to</param>
        /// <param name="k">Number of nearest neighbors, default is 12</param>
        /// <returns>Mapped eigenvectors</returns>
        public static Matrix getLLE(Matrix A, int num_dims, int k)
        {
            MatrixFunctions functions = new MatrixFunctions(); // Access matrix functions
            Matrix dividend;

            // Get dimensionality and number of dimensions
            int rowCount = A.RowCount;
            int colCount = A.ColumnCount; // Number of dimensions
            double sum, columnSum;
            double tolerance;
            if (k > rowCount) { tolerance = 0.00001; }
            else tolerance = 0.0;

            // Compute pairwise distances
            // Find nearest neighbors
            Matrix neighbors = functions.find_nearestNeighbors(A, k + 1);
            A = Matrix.Transpose(A);
            neighbors = Matrix.Transpose(neighbors);

            // Grab rows 1 to k(Each data point is nearest to itself, of course)
            // XXX may need to be columns 2 to k+1
            neighbors = neighbors.GetMatrix(1, k, 0, neighbors.ColumnCount - 1);

            // Construct reconstruction weight matrix
            // Construct a sparse matrix that is k X rowCount(of the parameter matrix)
            // Note : this matrix is not NxN
            double[,] zerosArray = new Double[k, rowCount];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    zerosArray[i, j] = 0.0;
                }
            } // end outer for

            Matrix weightsMatrix = Matrix.Create(zerosArray);
            Matrix weightsColumn;
            Matrix ones = Matrix.Ones(k);
            ones = ones.GetMatrix(0, k-1, 0, 0); // Row vector
            //double[] ones = new Double[k]
            Matrix sub, columns;
            int[] neighborsArray = new int[neighbors.RowCount];
            for (int i = 0; i < colCount; i++)
            {
                // Get a neighborhood column
                for(int j = 0; j < neighbors.RowCount; j++)
                {
                    neighborsArray[j] = (int)neighbors[j, i];
                }
                // grab the columns of A given by the i'th column of neighbors
                sub = A.GetMatrix(0, A.RowCount - 1, neighborsArray) - functions.Repmat(A.GetMatrix(0, A.RowCount - 1, i, i), 1, k); // <- ith column of A 
                columns = Matrix.Transpose(sub) * sub;

                // Compute covariance
                // First : Find sum
                sum = 0.0;
                for(int j = 0; j < columns.RowCount; j++)
                {
                    sum = sum + columns[j, j];
                }


                // Next : Find covariance
                columns = columns + Matrix.Identity(k, k) * tolerance * sum; // Sum is the sum of the diagonal entries of columns
                // Regularize covariance
                //columns = columns.Inverse();
                weightsColumn = new Matrix(columns * ones);
                // Finally : Solve the system
                columnSum = 0.0;
                for (int j = 0; j < weightsMatrix.RowCount; j++)
                {
                    columnSum = columnSum + weightsColumn[j, 0];
                }
                //weightsMatrix.SetMatrix(0, weightsMatrix.RowCount - 1, 0, weightsMatrix.ColumnCount - 1, functions.matrixDivide(weightsMatrix.GetMatrix(0, weightsMatrix.RowCount - 1, 0, weightsMatrix.ColumnCount - 1), columnSum));
                dividend = functions.matrixDivide(weightsColumn.GetMatrix(0, weightsColumn.RowCount - 1, 0, weightsColumn.ColumnCount - 1), columnSum);
                weightsMatrix.SetMatrix(0, dividend.RowCount - 1, i, i, dividend);
            } // end outer for loop

            // Define sparse cost matrix
            // Create a matrix with columns and rows from 0 to rowCount-1
            // Creates an rowCount x rowCount matrix with entries of 1
            // Up to 4 * k * rowCount entries that have the value of 1, the rest will be zero
            Matrix reconstructionWeightsMatrix = functions.sparse(rowCount, rowCount, 1.0, 4 * k * rowCount);
            
            Matrix modifiedWeights;
            int[] columnVector2;
            for (int i = 0; i < rowCount; i++)
            {
                modifiedWeights = weightsMatrix.GetMatrix(0, weightsMatrix.RowCount - 1, i, i); // Gets the i'th column of the weights matrix
                columnVector2 = functions.matrixColumnToIntArray(neighbors.GetMatrix(0, neighbors.RowCount - 1, i, i), 1); // Gets i'th column
                // Three step process
                // Validate indices first
                for (int j = 0; j < columnVector2.Length; j++)
                {
                    if (columnVector2[j] < 0) columnVector2[j] = 0;
                    else if (columnVector2[j] >= rowCount) columnVector2[j] = rowCount - 1;
                }
                reconstructionWeightsMatrix.SetMatrix(i, i, columnVector2, (reconstructionWeightsMatrix.GetMatrix(i, i, columnVector2) - Matrix.Transpose(modifiedWeights)));

                reconstructionWeightsMatrix.SetMatrix(columnVector2, i, i, (reconstructionWeightsMatrix.GetMatrix(columnVector2, i, i) - modifiedWeights));

                reconstructionWeightsMatrix.SetMatrix(columnVector2, columnVector2, (reconstructionWeightsMatrix.GetMatrix(columnVector2, columnVector2) + (modifiedWeights * Matrix.Transpose(modifiedWeights))));
            } // end for

            // Get the eigenvectors of the cost matrix
            // The bottom-most eigen vectors will be used
            MathNet.Numerics.LinearAlgebra.EigenvalueDecomposition eVals = new EigenvalueDecomposition(reconstructionWeightsMatrix);
            double[] lambda = eVals.RealEigenvalues; // Returns real(diag(eVals));
            //Matrix lambdas = new Matrix(reconstructionWeightsMatrix); // Constructs a 'column vector'-based Matrix of length given by lambda
            Matrix lambdas = new Matrix(lambda, lambda.Length); // Constructs a 'column vector'-based Matrix of length given by lambda
            int[] indicesColumn = new int[k]; // A sorted array of indices corresponding to lambda values
            
            int[] indices = new int[num_dims]; // Contains the first num_dims entries in the indicesColumn

            lambdas = functions.eigenSort(lambdas, "ascending"); // Returns a two-column matrix of e-vals and indices
            indicesColumn = functions.matrixColumnToIntArray(lambdas, 2); // Returns the second column

            Matrix eigenVectors = eVals.EigenVectors; // Each column is an eigen-vector


            // Puts the first num_dims indices into the finalized indices array
            // Throw away the first index
            for (int i = 1; i < num_dims; i++)
            {
                indices[i] = indicesColumn[i];
            }
            Matrix mappedMatrix;
            mappedMatrix = eigenVectors.GetMatrix(indices, 0, eigenVectors.ColumnCount - 1);
            mappedMatrix = Matrix.Transpose(mappedMatrix);
            return mappedMatrix;
        } // end getLLE
    } // end class LLE
} // end namespace
