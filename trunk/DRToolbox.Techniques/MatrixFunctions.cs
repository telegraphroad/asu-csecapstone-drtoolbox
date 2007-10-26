using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

/// <summary>
/// Contains often-used matrix functions not provided by the MathNet APIs.  Functions included are eigenSort, cov
/// to compute covariance matrix, and transpose.
/// </summary>
public class MatrixFunctions
{
	public MatrixFunctions()
	{
	}

    /// <summary>Sorts a column vector of lambdas in descending order
    /// </summary>
    /// <param name="lambda">A Matrix of lambda values.  The Matrix must be a column vector(1 column, no bound on rows)</param>
    /// <returns>A sorted(in descending order) Matrix of lambdas in the first column, in the second column are the original indices</returns>
    public Matrix eigenSort(Matrix lambda)
    {
        Matrix aMatrix;
        double[,] a2DArray;
        double tempDouble;
        int rows = lambda.RowCount;
        double[] indices = new double[rows];

        // Case for non NxN matrices
        //if(rows > columns) {size = columns;}
        //else size = rows;

        // Convert from Matrix representation to a column vector

        // Populate indices because the lambdas are already ordered 1, 2, 3, 4 ...
        for (int i = 0; i < rows; i++)
        {
            tempDouble = (Double)i;
            indices[i] = tempDouble;
        }

        // an n^2 sorting algorithm
        // Will replace with a n*log(n) one
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < rows; k++)
            {
                if (lambda[j, 1] < lambda[k, 1]) // swap
                {
                    // Swap lambdas
                    tempDouble = lambda[j, 1]; // lambda[row, column]
                    lambda[j, 1] = lambda[k, 1];
                    lambda[k, 1] = tempDouble;
                    // Swaps indices
                    tempDouble = indices[j];
                    indices[j] = indices[k];
                    indices[k] = tempDouble;
                } // end swap
            } // end inner for loop
        } // end outer for loop

        // Merge the two column vectors in matrix before sending it back
        a2DArray = new double[rows, 2]; // rows, columns
        for (int j = 0; j < rows; j++)
        {
            a2DArray[j, 0] = lambda[j, 1];
            a2DArray[j, 1] = indices[j];

        } // end outer for loop

        // Puts the 2d array a2DArray into aMatrix
        aMatrix = Matrix.Create(a2DArray);

        return aMatrix; // Returns a matrix with column 1 of lambda values, column 2 of indices
    }

    /* Code by KRT: Last Updated Fri 10/26/07 */

    /*
     * Pseudocode for Cov function
     * 
     * X:input --> n x p matrix
     * A = X - [(ones(n,1) * mean(X)] -> demeaning step
     * Y = [A * A'] / (n-1)
     * where A' -> transpose(A)
     * Y: output matrix
     * 
     */

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
        onesMatrix = onesMatrix.GetMatrix(0, numRows, 0, 1);

        demeaner = onesMatrix * computeMean(origMatrix);

        demeanedMatrix = origMatrix - demeaner;

        transposeMatrix = Matrix.Transpose(demeanedMatrix);

        retMatrix = demeanedMatrix * transposeMatrix;
        retMatrix = retMatrix * ((double)(1 / (numRows - 1)));

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

        means = new Matrix(1, numRows);

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
        double[,] tempMatrix = new Double[n,3];
        double height;
        MathNet.Numerics.LinearAlgebra.Matrix aMatrix;// = new MathNet.Numerics.LinearAlgebra.Matrix(n,n); // rows,columns

        switch (type)
        {
            /* case 'helix'
                for (int i = 0; i++; i >= n-1)
                {
                    temp[i] = i / n;
                    temp[i] = temp[i]
                } // end for loop
            */
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
                //public Matrix(double[,] A)
                aMatrix = new MathNet.Numerics.LinearAlgebra.Matrix(tempMatrix);
                return aMatrix;
            //case "changing_swiss":
            //    temp[n-1] = 1;
        } // end switch
        aMatrix = new MathNet.Numerics.LinearAlgebra.Matrix(n,n);
        return aMatrix;
    }




} // End Class
