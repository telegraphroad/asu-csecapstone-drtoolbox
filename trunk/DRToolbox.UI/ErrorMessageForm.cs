using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI
{
    public partial class ErrorMessageForm : Form
    {
        #region Class Methods
        public static DialogResult Show(string message)
        {
            // Return dialog result
            return Show(message, "");
        }
        public static DialogResult Show(string message, string caption)
        {
            // Local Variables
            ErrorMessageForm errorForm = new ErrorMessageForm(message, caption);

            // Return dialog result
            return errorForm.ShowDialog();
        }
        #endregion

        #region Constructors
        public ErrorMessageForm(string message, string caption)
        {
            // Perform designer work
            InitializeComponent();

            // Set form title
            this.Text = "DR Toolbox" + (caption == "" ? "" : " - " + caption);

            // Set message
            lblErrorMsg.Text = message;

            // Center OK button
            btnOK.Left = (this.Width / 2) - (btnOK.Width / 2);
            btnOK.Top = (lblErrorMsg.Top + lblErrorMsg.Height) + 20;
        }
        #endregion
    }
}