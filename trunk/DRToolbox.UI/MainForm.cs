using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DRToolbox.UI.FileImport.CSV;
using DRToolbox.UI.Graphs;

namespace DRToolbox.UI
{
    public partial class MainForm : Form
    {
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
            // Local Variables
            CSVImportDialog importDialog = new CSVImportDialog();

            // Was import dialog box successful?
            if (importDialog.ShowDialog(this) == DialogResult.OK)
            {	// Yes
                // Show Results
                MessageBox.Show("File '" + importDialog.ImportFile.FileName + "' was imported.");
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
            //TEST
            //-------------------------------
            XYScatterPlot xyPlot = new XYScatterPlot();
            xyPlot.GraphTitle = "Principle Component Analysis (PCA)";
            xyPlot.XAxisTitle = "X-Axis TEST";
            xyPlot.YAxisTitle = "Y-Axis TEST";

            ZedGraph.PointPairList list = new ZedGraph.PointPairList();
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                double x = rand.NextDouble() * 20.0 + 1;
                double y = Math.Log(10.0 * (x - 1.0) + 1.0) * (rand.NextDouble() * 0.2 + 0.9);
                list.Add(x, y);
            }
            xyPlot.GraphDataList = list;

            xyPlot.MdiParent = this;
            xyPlot.DrawXYScatterPlot();
            xyPlot.Show();           
            //-------------------------------
        }
        #endregion



    }
}