using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.TechniqueParameters
{
    public partial class IsomapForm : Form
    {
        #region Class Objects
        private int kValue = 0;
        #endregion

        #region Class Properties
        public int KValue
        {
            get
            {
                return kValue;
            }
        }
        #endregion

        #region Constructors
        public IsomapForm()
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
                kValue = Convert.ToInt32(nudRValue.Value);
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