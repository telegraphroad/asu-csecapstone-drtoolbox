using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using DRToolbox.UI.Menus;
using MathNet.Numerics.LinearAlgebra;

namespace DRToolbox.UI.UserControls
{
    public partial class RanTechniqueControl : UserControl
    {
        #region Class Objects
        private string techniqueName = "";
        private Matrix techniqueResults = null;
        private GraphMenu menuGraphs = null;
        #endregion

        #region Class Properties
        
        #endregion

        #region Class Methods
        private void SetupControl()
        {
            // Set technique name
            lblTechniqueName.Text = techniqueName;
        }
        #endregion

        #region Constructors
        public RanTechniqueControl(string technique, Matrix results)
        {
            // Perform designer work
            InitializeComponent();

            // Save technique name and results
            techniqueName = technique;
            techniqueResults = results;

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
                menuGraphs = new GraphMenu(techniqueName, techniqueResults);

            // Show menu
            menuGraphs.Show(btnViewResults, new Point(0, btnViewResults.Height));
        }
        #endregion
    }
}