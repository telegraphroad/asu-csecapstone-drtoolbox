using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.TechniqueParameters
{
    public partial class LLCForm : Form
    {
        #region Class Objects
        private int kValue = 0;
        private int maxIterations = 0;
        private int numAnalyzers = 0;
        #endregion

        #region Class Properties
        public int KValue
        {
            get
            {
                return kValue;
            }
        }
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
        public LLCForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void btnRun_Click(object sender, EventArgs e)
        {
            // Get param values
            kValue = Convert.ToInt32(nudKValue.Value);
            maxIterations = Convert.ToInt32(nudMaxIterations.Value);
            numAnalyzers = Convert.ToInt32(nudNumAnalyzers.Value);
        }
        #endregion
    }
}