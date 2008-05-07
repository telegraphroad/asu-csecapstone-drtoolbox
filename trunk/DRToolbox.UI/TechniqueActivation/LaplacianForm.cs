using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.TechniqueParameters
{
    public partial class LaplacianForm : Form
    {
        #region Class Objects
        private int kValue = 0;
        private double sigma = 0.0;
        #endregion

        #region Class Properties
        public int KValue
        {
            get
            {
                return kValue;
            }
        }
        public double Sigma
        {
            get
            {
                return sigma;
            }
        }
        #endregion

        #region Constructors
        public LaplacianForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void btnRun_Click(object sender, EventArgs e)
        {
            // Get param values
            kValue = Convert.ToInt32(nudKValue.Value);
            sigma = Convert.ToDouble(nudSigma.Value);
        }
        #endregion
    }
}