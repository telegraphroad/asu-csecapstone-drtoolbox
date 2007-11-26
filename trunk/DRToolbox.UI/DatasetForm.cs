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
        #region Global Var/Objects
        /// <summary>
        /// Global Variables.
        /// </summary>
        private string title = "";
        private DataTable data = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public DatasetForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Form title.
        /// </summary>
        public string FormTitle
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// Dataset to display
        /// </summary>
        public DataTable Dataset
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Populate the data grid
        /// </summary>
        public void FillDataGridView()
        {
            //Display form title
            this.Text = this.FormTitle;

            //populate datagrid
            if (this.Dataset.Rows.Count > 0)
            {
                lblNote.Visible = false;
                dgvData.DataSource = this.Dataset;
            }
            else
            {
                lblNote.Visible = true;
                lblNote.Text = "There is no data to display!";
            }
        }
        #endregion
    }
}