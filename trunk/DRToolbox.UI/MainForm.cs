using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DRToolbox.UI.FileImport.CSV;
using DRToolbox.UI.Graphs;
using DRToolbox.Techniques;
using MathNet.Numerics.LinearAlgebra;

namespace DRToolbox.UI
{
    public partial class MainForm : Form
	{
		#region Class Objects
		CSVImportDialog csvImportDialog = null;
		#endregion

		#region Constructors
		/// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// Click File -> Exit
        /// </summary>
        private void mItemExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Close the application
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exit Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Click File -> Import File... -> Comma Delimited File (CSV)
        /// </summary>
        private void menuImportFileCSV_Click(object sender, EventArgs e)
        {
			// Is there a CSV import dialog created?
			if(csvImportDialog == null)
				// No, create one
				csvImportDialog = new CSVImportDialog();

            // Was import dialog box successful?
			if(csvImportDialog.ShowDialog(this) == DialogResult.OK)
            {	// Yes
                // Show Results
				MessageBox.Show("File '" + csvImportDialog.ImportFile.FileName + "' was imported.");
            }
            else
            {	// No
                // Show error
                MessageBox.Show("Import was canceled.");
            }
        }

        /// <summary>
        /// Click Help -> About
        /// </summary>
        private void mItemAbout_Click(object sender, EventArgs e)
        {
            try
            {
                //TEST - Change this in phase 3
                string aboutMessage = "This is a prototype.";
                MessageBox.Show(aboutMessage, "About DR Toolbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exit Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Click DR Techniques -> Principle Component Analysis (PCA)
        /// </summary>
        private void mItemPCA_Click(object sender, EventArgs e)
        {
			// Local Variables
			Matrix pcaResults = null;

			// Is a file imported?
			if(csvImportDialog != null && csvImportDialog.ImportFile != null)
			{	// Yes
				// Perform the PCA technique
				pcaResults = PCA.getPCA(csvImportDialog.ImportFile.ImportedData, 2);

                //Display the data in a XY scatter plot
                XYScatterPlot xyPlot = new XYScatterPlot();
                ZedGraph.PointPairList list = Convert2DMatrixToPointPairList(pcaResults);
                xyPlot.GraphTitle = "Principle Component Analysis (PCA)";
                xyPlot.XAxisTitle = "PCA X-Axis";
                xyPlot.YAxisTitle = "PCA Y-Axis";
                xyPlot.GraphDataList = list;
                xyPlot.MdiParent = this;
                xyPlot.DrawXYScatterPlot();
                xyPlot.Show();
			}
			else
			{	// No
				// Display error
				MessageBox.Show("Please import a data file before trying to perform the PCA technique.");
			}
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Convert a 2D Matrix to a PointPairList
        /// </summary>
        private ZedGraph.PointPairList Convert2DMatrixToPointPairList(Matrix techniqueResults)
        {
            //local vars
            ZedGraph.PointPairList resultsList = new ZedGraph.PointPairList();
            ZedGraph.PointPair point =  new ZedGraph.PointPair();

            try
            {
                for (int i = 0; i < techniqueResults.RowCount; i++)
                {
                    //add each row in the matrix as a point pair
                    point.X = (double)techniqueResults[i, 0];
                    point.Y = (double)techniqueResults[i, 1];
                    resultsList.Add(point);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Convert Matrix to PointPairList", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //return the pointpairlist
            return resultsList;
        }
        #endregion
    }
}