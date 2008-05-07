using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI
{
    public partial class DatasetForm : Form
    {
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public DatasetForm(string formTitle, DataTable displayData)
        {
            // Initialize designer support
            InitializeComponent();

            // Update form's title
            this.Text = "DataSet View - " + formTitle;

            // Display data in the grid view
            gvData.DataSource = displayData;
        }
        #endregion
    }
}