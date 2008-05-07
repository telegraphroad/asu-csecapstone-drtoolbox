using System;
using System.Data;

using MathWorks.MATLAB.NET.Arrays;
using ZedGraph;

namespace DRToolbox.Utilities
{
    public class ResultTable
    {
        #region Class Objects
        private DataTable theTable = null;
        #endregion

        #region Class Properties
        public bool IsEmpty
        {
            get
            {
                return (theTable == null || (theTable != null && theTable.Rows.Count == 0));
            }
        }
        public DataTable TableData
        {
            get
            {
                return theTable;
            }
        }
        public PointPairList GraphData2D
        {
            get
            {
                return Build2DGraphData();
            }
        }
        #endregion

        #region Class Methods
        private PointPairList Build2DGraphData()
        {
            // Local Variables
            PointPairList graphData = null;

            // Is there data in the result table?
            if(theTable != null && theTable.Rows.Count > 0  && theTable.Columns.Count >= 3)
            {   // Yes
                // Create new point pair list
                graphData = new PointPairList();

                // Add result table to list
                foreach(DataRow currentRow in theTable.Rows)
                {
                    try
                    {
                        // Add current row to list
                        graphData.Add(Convert.ToDouble(currentRow[1]), Convert.ToDouble(currentRow[2]));
                    }
                    catch(InvalidCastException ex)
                    {
                        // Throw new exception with more info
                        throw new InvalidCastException("Cannot convert Result Table row to a PointPair.", ex);
                    }
                }
            }

            // Return graph data
            return graphData;
        }
        private DataTable BuildResultTable(int numColumns)
        {
            // Local Variables
            DataTable resultTable = new DataTable("ResultsTable");
            DataColumn rowID = new DataColumn("Row ID", System.Type.GetType("System.Int32"));
            DataColumn[] primaryKey = new DataColumn[1];

            // Setup id column
            rowID.AutoIncrement = true;
            rowID.AutoIncrementSeed = 1;
            rowID.AutoIncrementStep = 1;

            // Add id column to table
            resultTable.Columns.Add(rowID);

            // Add each data column
            for(int i = 1; i <= numColumns; i++)
                resultTable.Columns.Add("Dimension " + i, System.Type.GetType("System.Double"));

            // Set primary key
            primaryKey = new DataColumn[1];
            primaryKey[0] = rowID;
            resultTable.PrimaryKey = primaryKey;

            // Return built table
            return resultTable;
        }
        private void FillResultTable(MWNumericArray results)
        {
            // Local Variables
            DataRow newRow = null;
            Array resultContents = null;

            // Does table exist?
            if(theTable != null)
            {   // Yes
                // Get result contents
                resultContents = results.ToArray(MWArrayComponent.Real);

                // Add results to table
                for(int i = 0; i < resultContents.GetLength(0); i++)
                {
                    // Get new table row
                    newRow = theTable.NewRow();

                    // Add values to row
                    for(int j = 1; j <= resultContents.GetLength(1); j++)
                    {
                        // Add current value to row
                        newRow[j] = resultContents.GetValue(i, (j - 1));
                    }

                    // Add row to table
                    theTable.Rows.Add(newRow);
                }
            }
        }
        #endregion

        #region Constructors
        public ResultTable(MWNumericArray results)
        {
            // Build results table
            theTable = BuildResultTable(results.NumberofDimensions + 1);

            // Store results in created table
            FillResultTable(results);
        }
        #endregion
    }
}
