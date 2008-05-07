using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.FileImport.Images
{
    public partial class ImagesImportDialog : Form
    {
        #region Class Objects
        private ImportedFile importFile = null;
        #endregion

        #region Class Properties
        public ImportedFile ImportFile
        {
            get
            {
                return importFile;
            }
        }
        #endregion

        #region Constructors
        public ImagesImportDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Was the open file dialog successful?
            if(ofdFileToImport.ShowDialog(this) == DialogResult.OK)
            {   // Yes
                // Update files textbox
                txtFilesToImport.Lines = ofdFileToImport.FileNames;
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            // Is the form valid?
            if(this.ValidateChildren())
            {   // Yes
                // Import images
                importFile = ImageImporter.ImportImages(txtFilesToImport.Lines);
            }
        }
        private void txtFilesToImport_Validating(object sender, CancelEventArgs e)
        {
            // Is there something in the textbox?
            if(txtFilesToImport.Lines.Length > 0)
            {   // Yes
                // Clear errors
                epValidationErrors.SetError(lblFilesToImport, "");
            }
            else
            {   // No
                // Show error
                epValidationErrors.SetError(lblFilesToImport, "Please specify at least one file.");

                // Cancel event
                e.Cancel = true;
            }
        }
        #endregion


    }
}