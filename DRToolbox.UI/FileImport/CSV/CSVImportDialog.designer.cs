namespace DRToolbox.UI.FileImport.CSV
{
	partial class CSVImportDialog
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
            this.lblFileToImport = new System.Windows.Forms.Label();
            this.txtFileToImport = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ofdFileToImport = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblFileToImport
            // 
            this.lblFileToImport.AutoSize = true;
            this.lblFileToImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileToImport.Location = new System.Drawing.Point(12, 29);
            this.lblFileToImport.Name = "lblFileToImport";
            this.lblFileToImport.Size = new System.Drawing.Size(89, 13);
            this.lblFileToImport.TabIndex = 0;
            this.lblFileToImport.Text = "File To Import:";
            // 
            // txtFileToImport
            // 
            this.txtFileToImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.txtFileToImport.ForeColor = System.Drawing.Color.Black;
            this.txtFileToImport.Location = new System.Drawing.Point(107, 26);
            this.txtFileToImport.Name = "txtFileToImport";
            this.txtFileToImport.Size = new System.Drawing.Size(406, 20);
            this.txtFileToImport.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(519, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImportFile
            // 
            this.btnImportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnImportFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnImportFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportFile.ForeColor = System.Drawing.Color.Black;
            this.btnImportFile.Location = new System.Drawing.Point(209, 72);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(75, 23);
            this.btnImportFile.TabIndex = 5;
            this.btnImportFile.Text = "Import File";
            this.btnImportFile.UseVisualStyleBackColor = false;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(323, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ofdFileToImport
            // 
            this.ofdFileToImport.DefaultExt = "*.csv";
            this.ofdFileToImport.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            this.ofdFileToImport.Title = "Select File To Import";
            // 
            // CSVImportDialog
            // 
            this.AcceptButton = this.btnImportFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(606, 109);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImportFile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileToImport);
            this.Controls.Add(this.lblFileToImport);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CSVImportDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import CSV File";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFileToImport;
		private System.Windows.Forms.TextBox txtFileToImport;
        private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnImportFile;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.OpenFileDialog ofdFileToImport;
	}
}