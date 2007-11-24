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

        #region Class Methods
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
                // Open the Imported File Form
                ImportedFileForm file = new ImportedFileForm(csvImportDialog.ImportFile);
                file.MdiParent = this;
                file.Show();
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
        #endregion

    }
}