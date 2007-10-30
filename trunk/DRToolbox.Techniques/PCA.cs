using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace Techniques
{
    class PCA
    {
        // Local variables
        private int rows;
        private int columns;

        /// <summary>Default constructor</summary>
        /// <param name="A">Matrix being operated upon.</param>
        /// <param name="n">no_dims, also number of columns.</param>
        //public PCA(MathNet.Numerics.LinearAlgebra.Matrix A)
        public PCA(Matrix A)
        {
           // aMatrix = A;

            //columns = n; // no_dims = number of columns
        }

        // Default destructor goes here

        public Matrix getPCA(Matrix A, int num_dims)
        {
            //aMatrix = A - repmat(mean(A,1), [size(A,1) 1]); // Abhishikth needs to change to repmat params
            // <summary>Subtraction of matrices</summary>
		    // public static Matrix operator -(Matrix m1, Matrix m2)
            Matrix aMatrix = null;  // Added by Bobby so code would build
            // Get the covariance
            //Matrix B = cov(aMatrix);

            // Perform eigendecomposition
            // blah = eig(something); // Returns TWO matrices!  A matrix of eigen-vectors(In columns) and a diagonal matrix of eigen-values
            Matrix eigenVectors = null; // Added by Bobby so code would build
            //= new Matrix();// = something;
            Matrix eigenValues; 
            Matrix lambda;// = new Matrix();// = something;
            //lambda = diag(eigenValues); // J L will do this
            // Sort eigen values

      //      Matrix sortedLambdas = eigenSort(lambda);

            // Sort the matrix of eigenvectors according to the indices in the sortedLambdas matrix(second column is indices)
            // Depends on return values from eigendecomposition and sortedLambdas

            // Map the data via matrix multiplication
            Matrix aMappedMatrix = Matrix.ArrayMultiply(eigenVectors, aMatrix);

            return aMappedMatrix;
        }
    } // end class
} // end namespace
