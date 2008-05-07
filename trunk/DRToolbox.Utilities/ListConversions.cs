using System;
using System.Data;

using MathWorks.MATLAB.NET.Arrays;

namespace DRToolbox.Utilities
{
    public class ListConversions
    {
        #region Class Methods
        /// <summary>
        /// Converts a string array to a double array
        /// </summary>
        /// <param name="toConvert">A string array filled with valid double values</param>
        /// <returns>The created double array</returns>
        public static double[] ConvertToDoubleArray(string[] toConvert)
        {
            // Local Variables
            double[] converted = null;

            // Is there an array to convert?
            if(toConvert != null)
            {   // Yes
                // Get converted array
                converted = new double[toConvert.Length];

                // Convert each value
                for(int i = 0; i < toConvert.Length; i++)
                {
                    try
                    {
                        // Convert the current value
                        converted[i] = Convert.ToDouble(toConvert[i]);
                    }
                    catch(InvalidCastException ex)
                    {
                        // Throw new exception with more info
                        throw new InvalidCastException("Cannot convert the current string array value to a double value.", ex);
                    }
                }
            }

            // Return converted array
            return converted;
        }
        public static MWNumericArray ConvertToNumericArray(DataTable toConvert)
        {
            // Local Variables
            MWNumericArray converted = null;
            double[,] tableContents = null;

            // Was data passed in?
            if(toConvert != null && toConvert.Rows.Count > 0 && toConvert.Columns.Count > 1)
            {   // Yes
                // Create table contents array
                tableContents = new double[toConvert.Rows.Count, (toConvert.Columns.Count - 1)];

                // Add each row to table contents
                for(int i = 0; i < toConvert.Rows.Count; i++)
                {
                    // Add each column (except row id) to table contents
                    for(int j = 1; j < toConvert.Columns.Count; j++)
                    {
                        // Add current value to table contents
                        tableContents[i, (j - 1)] = Convert.ToDouble(toConvert.Rows[i][j]);
                    }
                }

                // Create numeric array
                converted = new MWNumericArray(tableContents);
            }
            else
            {   // No
                // Throw exception
                throw new ArgumentNullException("toConvert");
            }

            // Return converted array
            return converted;
        }
/*
        /// <summary>
        /// Convert a 2D Matrix to a PointPairList
        /// </summary>
        public static PointPairList MatrixToPointPairList(Matrix techniqueResults, int desiredDimensions)
        {
            // Local Variables
            PointPairList pointList = new PointPairList();
            PointPair currentPoint = null;

            // Add each row in the matrix to the point pair list
            for(int i = 0; i < techniqueResults.RowCount; i++)
            {
                // What's the desired dimensions?
                switch(desiredDimensions)
                {
                    case 2:
                        // Convert to 2D point
                        currentPoint = new PointPair(techniqueResults[i, 0], techniqueResults[i, 1]);
                        break;

                    case 3:
                        // Convert to 3D point
                        currentPoint = new PointPair(techniqueResults[i, 0], techniqueResults[i, 1], techniqueResults[i, 2]);
                        break;
                }

                // Add current point to list
                pointList.Add(currentPoint);
            }

            //return the pointpairlist
            return pointList;
        }

        /// <summary>
        /// Convert a Matrix to a DataTable
        /// </summary>
        public static DataTable MatrixToDataTable(Matrix techniqueResults)
        {
            //Local Vars
            DataTable dtData = new DataTable();

            //Create columns in datatable from the matrix
            for (int i = 1; i < techniqueResults.ColumnCount + 1; i++)
            {
                DataColumn dcData = new DataColumn("Dimension " + i, System.Type.GetType("System.Double"));
                dtData.Columns.Add(dcData);
            }

            //Add each row in the matrix to the datatable
            for (int i = 0; i < techniqueResults.RowCount; i++)
            {
                //New row in the data table
                DataRow drData = dtData.NewRow();

                for (int j = 1; j < dtData.Columns.Count + 1; j++)
                {
                    //Add columns to the row
                    string columnName = "Dimension " + j.ToString();
                    drData[columnName] = techniqueResults[i, j-1];
                }

                //Add row to the table
                dtData.Rows.Add(drData);
            }

            //Return the datatable
            return dtData;
        }
*/
        #endregion
    }
}