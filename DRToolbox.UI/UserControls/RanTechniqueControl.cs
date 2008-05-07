using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using DRToolbox.Techniques;
using DRToolbox.UI.Menus;
using DRToolbox.Utilities;

namespace DRToolbox.UI.UserControls
{
    public partial class RanTechniqueControl : UserControl
    {
        #region Class Objects
        private TechniqueResults results = null;
        private GraphMenu menuGraphs = null;
        #endregion

        #region Class Methods
        private void SetupControl()
        {
            // Set technique name
            lblTechniqueName.Text = results.TechniqueName;
        }
        #endregion

        #region Constructors
        public RanTechniqueControl(TechniqueResults resultData)
        {
            // Perform designer work
            InitializeComponent();

            // Initialize object
            results = resultData;

            // Set control up
            SetupControl();
        }
        #endregion

        #region Event Handlers
        private void btnViewResults_Click(object sender, EventArgs e)
        {
            // Does the menu already exist?
            if(menuGraphs == null)
                // No, create it
                menuGraphs = new GraphMenu(results);

            // Show menu
            menuGraphs.Show(btnViewResults, new Point(0, btnViewResults.Height));
        }
        #endregion
    }
}