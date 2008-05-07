using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.TechniqueParameters
{
    public partial class DiffusionMapsForm : Form
    {
        #region Class Objects
        private double tValue = 0.0;
        private double sigma = 0.0;
        #endregion

        #region Class Properties
        public double TValue
        {
            get
            {
                return tValue;
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
        public DiffusionMapsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void btnRun_Click(object sender, EventArgs e)
        {
            // Get param values
            tValue = Convert.ToDouble(nudTValue.Value);
            sigma = Convert.ToDouble(nudSigma.Value);
        }
        #endregion
    }
}