using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.TechniqueParameters
{
    public partial class CFAForm : Form
    {
        #region Class Objects
        private int maxIterations = 0;
        private int numAnalyzers = 0;
        #endregion

        #region Class Properties
        public int MaxInterations
        {
            get
            {
                return maxIterations;
            }
        }
        public int NumAnalyzers
        {
            get
            {
                return numAnalyzers;
            }
        }
        #endregion

        #region Constructors
        public CFAForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void btnRun_Click(object sender, EventArgs e)
        {
            // Get param values
            maxIterations = Convert.ToInt32(nudMaxIterations.Value);
            numAnalyzers = Convert.ToInt32(nudNumAnalyzers.Value);
        }
        #endregion
    }
}