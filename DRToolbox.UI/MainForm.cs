using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DRToolbox.UI.FileImport.CSV;
using DRToolbox.UI.FileImport.Images;
using DRToolbox.UI.Graphs;
using DRToolbox.Techniques;

namespace DRToolbox.UI
{
    public partial class MainForm : Form
	{
		#region Class Objects
        AboutForm frmAbout = null;
		CSVImportDialog csvImportDialog = null;
        ImagesImportDialog imageImportDialog = null;
		#endregion

        #region Class Properties
        public string StatusMsg
        {
            set
            {
                tssProgressMsg.Text = value;
            }
        }
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Local Variables
            MdiClient found = null;

            // Find the Mdi Client control
            foreach(Control current in this.Controls)
            {
                // Is the current control a Mdi Client?
                if(current is MdiClient)
                {   // Yes
                    // Update found control
                    found = (current as MdiClient);

                    // Update the bg color
                    if(found != null)
                        //found.BackColor = Color.FromArgb(96, 128, 192);
                        found.BackColor = System.Drawing.SystemColors.AppWorkspace;

                    // Stop looking
                    break;
                }
            }
        }
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
                ErrorMessageForm.Show(ex.Message, "Exit Application");
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
                try
                {
                    // Open the Imported File Form
                    ImportedFileForm file = new ImportedFileForm(csvImportDialog.ImportFile);
                    file.MdiParent = this;
                    file.Show();
                }
                catch(Exception ex)
                {
                    // Display error
                    ErrorMessageForm.Show(ex.Message, "CSV Import Error");
                }
            }
        }
        private void menuImportFileImages_Click(object sender, EventArgs e)
        {
            // Is there an Images import dialog created?
            if(imageImportDialog == null)
                // No, create one
                imageImportDialog = new ImagesImportDialog();

            // Was import dialog box successful?
            if(imageImportDialog.ShowDialog(this) == DialogResult.OK)
            {   // Yes
                try
                {
                    // Open the Imported File Form
                    ImportedFileForm file = new ImportedFileForm(imageImportDialog.ImportFile);
                    file.MdiParent = this;
                    file.Show();
                }
                catch(Exception ex)
                {
                    // Display error
                    ErrorMessageForm.Show(ex.Message, "Image Import Error");
                }
            }
        }
        /// <summary>
        /// Click Help -> About
        /// </summary>
        private void mItemAbout_Click(object sender, EventArgs e)
        {
            try
            {
                //Create AboutForm and show it
                if (frmAbout == null)
                {
                    frmAbout = new AboutForm();
                    frmAbout.MdiParent = this;
                    frmAbout.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageForm.Show(ex.Message, "About D. R. Toolbox");
            }
        }

        /// <summary>
        /// Click Window -> Cascade
        /// </summary>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Cascade all open child forms
                this.LayoutMdi(MdiLayout.Cascade);
            }
            catch (Exception ex)
            {
                ErrorMessageForm.Show(ex.Message, "Error Cascading");
            }
        }

        /// <summary>
        /// Click Window -> Tile Horizontal
        /// </summary>
        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Tile horizontal all open child forms
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }
            catch (Exception ex)
            {
                ErrorMessageForm.Show(ex.Message, "Error Tiling Horizontally");
            }
        }

        /// <summary>
        /// Click Window -> Tile Vertical
        /// </summary>
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Tile vertical all open child forms
                this.LayoutMdi(MdiLayout.TileVertical);
            }
            catch (Exception ex)
            {
                ErrorMessageForm.Show(ex.Message, "Error Tiling Vertically");
            }
        }

        /// <summary>
        /// Click Window -> Minimize All
        /// </summary>
        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Minimize all MDI child forms
                foreach (Form mdiChild in this.MdiChildren)
                {
                    mdiChild.WindowState = FormWindowState.Minimized;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageForm.Show(ex.Message, "Error Minimizing All Open Windows");
            }
        }

        /// <summary>
        /// Click Window -> Maximize All
        /// </summary>
        private void maximizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Maximize all MDI child forms
                foreach (Form mdiChild in this.MdiChildren)
                {
                    mdiChild.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageForm.Show(ex.Message, "Error Minimizing All Open Windows");
            }
        }

        /// <summary>
        /// Click Window -> Restore Open Windows
        /// </summary>
        private void restoreOpenWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Restore all MDI child forms
                foreach (Form mdiChild in this.MdiChildren)
                {
                    mdiChild.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageForm.Show(ex.Message, "Error Minimizing All Open Windows");
            }
        }
        #endregion
    }
}