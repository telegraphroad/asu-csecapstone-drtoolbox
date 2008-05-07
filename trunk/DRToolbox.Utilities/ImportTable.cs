using System;
using System.Data;

using MathWorks.MATLAB.NET.Arrays;

namespace DRToolbox.Utilities
{
    public class ImportTable
    {
        #region Class Objects
        private DataTable theTable = null;
        #endregion

        #region Class Properties
        public MWNumericArray NumericArrayData
        {
            get
            {
                return (theTable == null ? null : ListConversions.ConvertToNumericArray(theTable));
            }
        }
        public DataTable TableData
        {
            get
            {
                return theTable;
            }
        }
        #endregion

        #region Class Methods
        private DataTable BuildImportTable(int numColumns)
        {
            // Local Variables
            DataTable importData = new DataTable("ImportedData");
            DataColumn rowID = new DataColumn("Row ID", System.Type.GetType("System.Int32"));
            DataColumn[] primaryKey = new DataColumn[1];

            // Setup id column
            rowID.AutoIncrement = true;
            rowID.AutoIncrementSeed = 1;
            rowID.AutoIncrementStep = 1;

            // Add id column to table
            importData.Columns.Add(rowID);

            // Add each data column
            for(int i = 1; i <= numColumns; i++)
                importData.Columns.Add("Dimension " + i, System.Type.GetType("System.Double"));

            // Set primary key
            primaryKey = new DataColumn[1];
            primaryKey[0] = rowID;
            importData.PrimaryKey = primaryKey;

            // Return built table
            return importData;
        }

        public int AddNewRow(double[] rowValues)
        {
            // Local Variables
            int newID = -1;
            DataRow newRow = null;

            // Does the table exist?
            if(theTable != null)
            {   // Yes
                // Get new row
                newRow = theTable.NewRow();

                // Add values to the row
                for(int i = 1; (i < theTable.Columns.Count) && (i <= rowValues.Length); i++)
                {
                    // Set this column's value
                    newRow[i] = rowValues[(i - 1)];
                }

                // Add new row to table
                theTable.Rows.Add(newRow);

                try
                {
                    // Get new row's id
                    newID = Convert.ToInt32(newRow[0]);
                }
                catch(InvalidCastException ex)
                {
                    // Throw new exception with more info
                    throw new InvalidCastException("Can't convert ImportTable new row's id to an int.", ex);
                }
            }

            // Return the new id
            return newID;
        }
        #endregion

        #region Constructors
        public ImportTable(int numColumns)
        {
            // Build import table
            theTable = BuildImportTable(numColumns);
        }
        #endregion
    }
}