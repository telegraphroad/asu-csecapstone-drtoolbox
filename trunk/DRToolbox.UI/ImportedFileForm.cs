using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DRToolbox.UI.FileImport;
using DRToolbox.UI.Menus;

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
            // Local Variables
            int slashIndex = importFile.FileName.LastIndexOf('\\');
            string fileName = "";

            // Get file name without path
            switch(slashIndex)
            {
                case -1:    // Not found    
                    fileName = importFile.FileName;
                    break;
                default:    // Grab everything after the slash
                    fileName = importFile.FileName.Substring((slashIndex == importFile.FileName.Length - 1) ? importFile.FileName.Length : slashIndex + 1);
                    break;
            }

            // Display just file name as window title
            this.Text = fileName;

            // Display path on form
            lblImportFile.Text = importFile.FileName;
        }
        #endregion

        #region Constructors
        public ImportedFileForm(ImportedFile file)
        {
            // Initialize designer objects
            InitializeComponent();

            // Save import file
            importFile = file;

            // Setup form
            SetupForm();
        }
        #endregion

        #region Event Handlers
        private void btnRunTechnique_Click(object sender, EventArgs e)
        {
            // Has the menu been created?
            if(menuTechniques == null)
                // No, create it
                menuTechniques = new TechniqueMenu(pnlTechniques, importFile);

            // Show menu
            menuTechniques.Show(btnRunTechnique, new Point(0, btnRunTechnique.Height));
        }
        #endregion
    }
}