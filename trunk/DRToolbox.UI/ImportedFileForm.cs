using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DRToolbox.UI.FileImport;
using DRToolbox.UI.Menus;
using DRToolbox.Utilities;

namespace DRToolbox.UI
{
    public partial class ImportedFileForm : Form
    {
        #region Class Objects
        private TechniqueMenu menuTechniques = null;
        private ImportedFile importFile = null;
        #endregion

        #region Class Methods
        private void SetupForm()
        {
            // Display just file name as window title
            this.Text = "Imported File - " + importFile.FileName;

            // Display path on form
            lblImportFile.Text = importFile.FilePath;
        }
        #endregion

        #region Constructors
        public ImportedFileForm(ImportedFile file)
        {
            // Initialize designer objects
            InitializeComponent();

            // Was a file passed in?
            if(file != null)
            {   // Yes
                // Save file
                importFile = file;
            }
            else
            {   // No
                // Throw exception
                throw new ArgumentNullException("file", "Please import a file before trying to open the Imported File Form.");
            }

            // Setup form
            SetupForm();
        }
        #endregion

        #region Event Handlers
        private void btnRunTechnique_Click(object sender, EventArgs e)
        {
            // Local Variables
            MainForm parentForm = (this.ParentForm as MainForm);

            // Has the menu been created?
            if(menuTechniques == null)
                // No, create it
                menuTechniques = new TechniqueMenu(pnlTechniques, importFile);

            // Show menu
            menuTechniques.Show(btnRunTechnique, new Point(0, btnRunTechnique.Height));
        }
        private void btnViewDataset_Click(object sender, EventArgs e)
        {
            // Local Variables
            DatasetForm dataForm = null;

            try
            {
                // Display Data imported in a DataGridView
                dataForm = new DatasetForm(importFile.FileName + " (Not Processed Yet)", importFile.FileData.TableData);
                dataForm.MdiParent = MainForm.ActiveForm;
                dataForm.Show();
            }
            catch(InvalidOperationException)
            {
                // Display error message
                ErrorMessageForm.Show("You cannot use this form to view data with more than 650 dimensions.\nThe form will now close.");

                // Close form
                if(dataForm != null)
                    dataForm.Hide();
            }
        }
        #endregion
    }
}