namespace DRToolbox.UI.FileImport.Images
{
    partial class ImagesImportDialog
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
            this.components = new System.ComponentModel.Container();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdFileToImport = new System.Windows.Forms.OpenFileDialog();
            this.lblFilesToImport = new System.Windows.Forms.Label();
            this.txtFilesToImport = new System.Windows.Forms.TextBox();
            this.epValidationErrors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epValidationErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(250, 139);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Files";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(371, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnBrowse.CausesValidation = false;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(598, 98);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdFileToImport
            // 
            this.ofdFileToImport.DefaultExt = "*.jpg";
            this.ofdFileToImport.Filter = "Image Files (*.bmp;*.jpg;*.png;*.tiff)|*.bmp;*.jpg;*.png;*.tiff|All Files (*.*)|*" +
                ".*";
            this.ofdFileToImport.Multiselect = true;
            // 
            // lblFilesToImport
            // 
            this.lblFilesToImport.AutoSize = true;
            this.lblFilesToImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesToImport.ForeColor = System.Drawing.Color.Black;
            this.epValidationErrors.SetIconAlignment(this.lblFilesToImport, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.lblFilesToImport.Location = new System.Drawing.Point(34, 22);
            this.lblFilesToImport.Name = "lblFilesToImport";
            this.lblFilesToImport.Size = new System.Drawing.Size(91, 13);
            this.lblFilesToImport.TabIndex = 0;
            this.lblFilesToImport.Text = "Files to Import:";
            // 
            // txtFilesToImport
            // 
            this.txtFilesToImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.txtFilesToImport.ForeColor = System.Drawing.Color.Black;
            this.txtFilesToImport.Location = new System.Drawing.Point(131, 19);
            this.txtFilesToImport.Multiline = true;
            this.txtFilesToImport.Name = "txtFilesToImport";
            this.txtFilesToImport.Size = new System.Drawing.Size(542, 73);
            this.txtFilesToImport.TabIndex = 1;
            this.txtFilesToImport.WordWrap = false;
            this.txtFilesToImport.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilesToImport_Validating);
            // 
            // epValidationErrors
            // 
            this.epValidationErrors.BlinkRate = 500;
            this.epValidationErrors.ContainerControl = this;
            // 
            // ImagesImportDialog
            // 
            this.AcceptButton = this.btnImport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(697, 181);
            this.ControlBox = false;
            this.Controls.Add(this.txtFilesToImport);
            this.Controls.Add(this.lblFilesToImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImagesImportDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Images";
            ((System.ComponentModel.ISupportInitialize)(this.epValidationErrors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdFileToImport;
        private System.Windows.Forms.Label lblFilesToImport;
        private System.Windows.Forms.TextBox txtFilesToImport;
        private System.Windows.Forms.ErrorProvider epValidationErrors;
    }
}