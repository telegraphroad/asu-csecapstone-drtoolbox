using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.TechniqueParameters
{
    public partial class LandmarkIsomapForm : Form
    {
        #region Class Objects
        private int kValue = 0;
        private double precentage = 0.0;
        #endregion

        #region Class Properties
        public int KValue
        {
            get
            {
                return kValue;
            }
        }
        public double Precentage
        {
            get
            {
                return precentage;
            }
        }
        #endregion

        #region Constructors
        public LandmarkIsomapForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void btnRun_Click(object sender, EventArgs e)
        {
            // Get param values
            kValue = Convert.ToInt32(nudKValue.Value);
            precentage = Convert.ToDouble(nudPrecentage.Value);
        }
        #endregion
    }
}