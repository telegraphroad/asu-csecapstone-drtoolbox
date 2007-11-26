using System;
using System.Data;

using MathNet.Numerics.LinearAlgebra;
using ZedGraph;

namespace DRToolbox.Utilites
{
    public class ListConversions
    {
        #region Class Methods
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
                DataColumn dcData = new DataColumn();
                dcData.ColumnName = "Dimension " + Convert.ToString(i);
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
        #endregion
    }
}
