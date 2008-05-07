namespace DRToolbox.UI
{
    partial class ErrorMessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.picErrorIcon = new System.Windows.Forms.PictureBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(270, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // picErrorIcon
            // 
            this.picErrorIcon.Image = global::DRToolbox.UI.Properties.Resources.error;
            this.picErrorIcon.Location = new System.Drawing.Point(12, 12);
            this.picErrorIcon.Name = "picErrorIcon";
            this.picErrorIcon.Size = new System.Drawing.Size(34, 37);
            this.picErrorIcon.TabIndex = 1;
            this.picErrorIcon.TabStop = false;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.Location = new System.Drawing.Point(52, 12);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(46, 17);
            this.lblErrorMsg.TabIndex = 2;
            this.lblErrorMsg.Text = "label1";
            // 
            // ErrorMessageForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(614, 155);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.picErrorIcon);
            this.Controls.Add(this.btnOK);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ErrorMessageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorMessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.picErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox picErrorIcon;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}