using System;
using System.Windows.Forms;

using DRToolbox.Techniques;
using DRToolbox.UI.FileImport;
using DRToolbox.UI.UserControls;
using DRToolbox.Utilites;
using MathNet.Numerics.LinearAlgebra;

namespace DRToolbox.UI.Menus
{
    public class TechniqueMenu : ContextMenu
    {
        #region Class Objects
        private int numControlsAdded = 0;
        private Panel pnlTechniques = null;
        private ImportedFile importFile = null;
        #endregion

        #region Class Methods
        private void BuildTechniqueMenu()
        {
            // Add each technique to the menu
            this.MenuItems.Add(TechniqueNames.Isomap, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.LLE, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.MDS, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.PCA, menuTechnique_Click);
        }
        private Matrix RunTechnique(string techniqueName)
        {
            // Local Variables
            Matrix results = null;

            // Which technique is this?
            if(techniqueName == TechniqueNames.PCA)
            {
                // Run PCA technique
                results = PCA.getPCA(importFile.ImportedData, 3);
            }

            // Return results
            return results;
        }
        #endregion

        #region Constructors
        public TechniqueMenu(Panel parentAttachPoint, ImportedFile fileData)
        {
            // Save parent panel
            pnlTechniques = parentAttachPoint;

            // Save import data
            importFile = fileData;

            // Build technique menu
            BuildTechniqueMenu();
        }
        #endregion

        #region Event Handlers
        private void menuTechnique_Click(object sender, EventArgs e)
        {
            // Local Variables
            MenuItem selectedItem = (sender as MenuItem);
            RanTechniqueControl techniqueControl = null;
            Matrix results = null;

            // Was a menu item selected?
            if(selectedItem != null)
            {
                // Run technique
                results = RunTechnique(selectedItem.Text);

                // Add technique control to form
                techniqueControl = new RanTechniqueControl(selectedItem.Text, results);
                pnlTechniques.Controls.Add(techniqueControl);
                techniqueControl.Top = numControlsAdded * techniqueControl.Height;

                // Update number of controls added to the form
                numControlsAdded++;

                // Disable technique from being ran again
                selectedItem.Enabled = false;
            }
        }
        #endregion
    }
}