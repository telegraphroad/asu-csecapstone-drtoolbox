using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.TechniqueParameters
{
    public partial class ProbPCAForm : Form
    {
        #region Class Objects
        private int maxIterationsValue = 0;
        #endregion

        #region Class Properties
        public int MaxInterations
        {
            get
            {
                return maxIterationsValue;
            }
        }
        #endregion

        #region Constructors
        public ProbPCAForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                // Set k value
                maxIterationsValue = Convert.ToInt32(nudMaxIterations.Value);
            }
            catch(InvalidCastException ex)
            {
                // throw new exception with more info
                throw new InvalidCastException("Cannot convert KValue from decimal to integer.", ex);
            }
        }
        #endregion
    }
}