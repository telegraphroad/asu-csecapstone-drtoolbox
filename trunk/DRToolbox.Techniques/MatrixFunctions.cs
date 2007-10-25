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


    /// <summary>
    /// Given a matrix, computes the covariance and returns the covariance matrix.
    /// </summary>
    /// <param name="origMatrix">The matrix whose covariance is to be computed.</param>
    /// <returns>The covariance matrix of the matrix passed as a parameter.</returns>
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
                retArray[i, j] = 1.0;

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

        resultMatrix = new double[matrixOneRows, matrixTwoCols];

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
