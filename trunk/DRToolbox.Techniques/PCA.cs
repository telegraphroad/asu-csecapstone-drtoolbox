using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

// updated 10/30/07

namespace Techniques
{
    class PCA
    {
        // Local variables
        private Matrix aMatrix;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PCA() {}
        public PCA(Matrix A)
        {
            aMatrix = A;
        }

        /// <summary>Constructor</summary>
        /// <param name="A">Matrix being operated upon.</param>
        /// <param name="n">no_dims</param>
        //public PCA(MathNet.Numerics.LinearAlgebra.Matrix A)
        public PCA(Matrix A, int n)
        {
            aMatrix = A;
        }

        /// <summary>
        /// Returns the matrix mapped onto the first few eigenvectors.
        /// </summary>
        /// <param name="A">Data matrix being operated upon</param>
        /// <param name="num_dims">Number of desired dimensions.  This is the number of columns in the returned matrix.  This is also the number of eigenvectors the data is being mapped to.</param>
        /// <returns></returns>
        public Matrix getPCA(Matrix A, int num_dims)
        {
            
            // Local variables
            Matrix C; // Stores covariance matrix to find eigen-values/eigen-vectors
            MatrixFunctions functions = new MatrixFunctions(); // Access matrix functions
            Matrix lambdas; // Matrix representation of lambda values and indices
            double[] lambda; // A sorted array of lambda values
            int[] indicesColumn; // A sorted array of indices corresponding to lambda values
            int[] indices = new int[num_dims]; // Contains the first num_dims entries in the indicesColumn
            Matrix eigenVectors; // Each column in an eigen-vector

            // Zeroes out the mean of the data IE data centered about zero
            A = A - functions.Repmat(functions.computeMean(A), num_dims, num_dims);

            // Gets the covariance of the demeaned input Matrix
            C = functions.cov(A);

            // Sort out the eigenvalues and eigenvectors into two separate Matrices
            // Use the covariance matrix for these e-values/e-vectors
            MathNet.Numerics.LinearAlgebra.EigenvalueDecomposition eVals = new EigenvalueDecomposition(C);
            // eVals contains eigen values and eigen vectors
            lambda = eVals.RealEigenvalues; // Returns real(diag(eVals));
            lambdas = new Matrix(lambda, lambda.Length); // Constructs a 'column vector'-based Matrix of length given by lambda
            eigenVectors = eVals.EigenVectors; // Returns a matrix of eigenvectors.  Each e-vector is in a column

            // Sort the eigen values
            lambdas = functions.eigenSort(lambdas); // Returns a two-column matrix of e-vals and indices
            indicesColumn = functions.matrixColumnToIntArray(lambdas, 2); // Returns the second column
            
            // Puts the first num_dims indices into the finalized indices array
            for(int i = 0; i < num_dims; i++)
            {
                indices[i] = indicesColumn[i];
            }

            // Create a new matrix with num_dims of eigen-vector columns
            Matrix eVects = new Matrix(eigenVectors.RowCount, num_dims);
            
            // Sets the matrix, with columns given by eigenVectors at the indices provided.
            eVects.SetMatrix(0, eigenVectors.RowCount - 1, indices, eigenVectors); // Sets the matrix to be a collection of columns from the eigenVectors column

            // Map the data via matrix multiplication
            // Number of columns in A must be equal to the number of rows in eVects
            Matrix aMappedMatrix = functions.MatrixMulu(A, eVects);
            // Soft requirement -- eVects # of rows must be equal to the number of columns in A
                // IE - length of eigen-vectors will be the number of dimensions given in the input data
            

            return aMappedMatrix;
        }
    } // end class
} // end namespace
