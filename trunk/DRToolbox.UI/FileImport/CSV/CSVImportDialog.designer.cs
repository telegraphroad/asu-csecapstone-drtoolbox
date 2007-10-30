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
			this.grpHasLabels = new System.Windows.Forms.GroupBox();
			this.rbLabeledYes = new System.Windows.Forms.RadioButton();
			this.rbLabeledNo = new System.Windows.Forms.RadioButton();
			this.grpDataSize = new System.Windows.Forms.GroupBox();
			this.lblDataNumRows = new System.Windows.Forms.Label();
			this.nudNumRows = new System.Windows.Forms.NumericUpDown();
			this.lblDataNumColumns = new System.Windows.Forms.Label();
			this.nudNumColumns = new System.Windows.Forms.NumericUpDown();
			this.btnImportFile = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.ofdFileToImport = new System.Windows.Forms.OpenFileDialog();
			this.grpHasLabels.SuspendLayout();
			this.grpDataSize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumRows)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNumColumns)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFileToImport
			// 
			this.lblFileToImport.AutoSize = true;
			this.lblFileToImport.Location = new System.Drawing.Point(12, 29);
			this.lblFileToImport.Name = "lblFileToImport";
			this.lblFileToImport.Size = new System.Drawing.Size(74, 13);
			this.lblFileToImport.TabIndex = 0;
			this.lblFileToImport.Text = "File To Import:";
			// 
			// txtFileToImport
			// 
			this.txtFileToImport.Location = new System.Drawing.Point(92, 26);
			this.txtFileToImport.Name = "txtFileToImport";
			this.txtFileToImport.Size = new System.Drawing.Size(333, 20);
			this.txtFileToImport.TabIndex = 1;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(431, 24);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// grpHasLabels
			// 
			this.grpHasLabels.Controls.Add(this.rbLabeledNo);
			this.grpHasLabels.Controls.Add(this.rbLabeledYes);
			this.grpHasLabels.Location = new System.Drawing.Point(15, 73);
			this.grpHasLabels.Name = "grpHasLabels";
			this.grpHasLabels.Size = new System.Drawing.Size(139, 76);
			this.grpHasLabels.TabIndex = 3;
			this.grpHasLabels.TabStop = false;
			this.grpHasLabels.Text = "Are data points labeled?";
			// 
			// rbLabeledYes
			// 
			this.rbLabeledYes.AutoSize = true;
			this.rbLabeledYes.Checked = true;
			this.rbLabeledYes.Location = new System.Drawing.Point(48, 22);
			this.rbLabeledYes.Name = "rbLabeledYes";
			this.rbLabeledYes.Size = new System.Drawing.Size(43, 17);
			this.rbLabeledYes.TabIndex = 0;
			this.rbLabeledYes.TabStop = true;
			this.rbLabeledYes.Text = "Yes";
			this.rbLabeledYes.UseVisualStyleBackColor = true;
			// 
			// rbLabeledNo
			// 
			this.rbLabeledNo.AutoSize = true;
			this.rbLabeledNo.Location = new System.Drawing.Point(48, 45);
			this.rbLabeledNo.Name = "rbLabeledNo";
			this.rbLabeledNo.Size = new System.Drawing.Size(39, 17);
			this.rbLabeledNo.TabIndex = 1;
			this.rbLabeledNo.Text = "No";
			this.rbLabeledNo.UseVisualStyleBackColor = true;
			// 
			// grpDataSize
			// 
			this.grpDataSize.Controls.Add(this.nudNumColumns);
			this.grpDataSize.Controls.Add(this.lblDataNumColumns);
			this.grpDataSize.Controls.Add(this.nudNumRows);
			this.grpDataSize.Controls.Add(this.lblDataNumRows);
			this.grpDataSize.Location = new System.Drawing.Point(245, 73);
			this.grpDataSize.Name = "grpDataSize";
			this.grpDataSize.Size = new System.Drawing.Size(261, 90);
			this.grpDataSize.TabIndex = 4;
			this.grpDataSize.TabStop = false;
			this.grpDataSize.Text = "Data Size:";
			// 
			// lblDataNumRows
			// 
			this.lblDataNumRows.AutoSize = true;
			this.lblDataNumRows.Location = new System.Drawing.Point(30, 29);
			this.lblDataNumRows.Name = "lblDataNumRows";
			this.lblDataNumRows.Size = new System.Drawing.Size(89, 13);
			this.lblDataNumRows.TabIndex = 0;
			this.lblDataNumRows.Text = "Number of Rows:";
			// 
			// nudNumRows
			// 
			this.nudNumRows.Location = new System.Drawing.Point(125, 27);
			this.nudNumRows.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
			this.nudNumRows.Name = "nudNumRows";
			this.nudNumRows.Size = new System.Drawing.Size(120, 20);
			this.nudNumRows.TabIndex = 1;
			this.nudNumRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// lblDataNumColumns
			// 
			this.lblDataNumColumns.AutoSize = true;
			this.lblDataNumColumns.Location = new System.Drawing.Point(17, 55);
			this.lblDataNumColumns.Name = "lblDataNumColumns";
			this.lblDataNumColumns.Size = new System.Drawing.Size(102, 13);
			this.lblDataNumColumns.TabIndex = 2;
			this.lblDataNumColumns.Text = "Number of Columns:";
			// 
			// nudNumColumns
			// 
			this.nudNumColumns.Location = new System.Drawing.Point(125, 53);
			this.nudNumColumns.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
			this.nudNumColumns.Name = "nudNumColumns";
			this.nudNumColumns.Size = new System.Drawing.Size(120, 20);
			this.nudNumColumns.TabIndex = 3;
			this.nudNumColumns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// btnImportFile
			// 
			this.btnImportFile.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnImportFile.Location = new System.Drawing.Point(171, 215);
			this.btnImportFile.Name = "btnImportFile";
			this.btnImportFile.Size = new System.Drawing.Size(75, 23);
			this.btnImportFile.TabIndex = 5;
			this.btnImportFile.Text = "Import File";
			this.btnImportFile.UseVisualStyleBackColor = true;
			this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(285, 215);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// ofdFileToImport
			// 
			this.ofdFileToImport.DefaultExt = "*.csv";
			this.ofdFileToImport.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
			this.ofdFileToImport.Title = "Select File To Import";
			// 
			// CSVImportDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 262);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnImportFile);
			this.Controls.Add(this.grpDataSize);
			this.Controls.Add(this.grpHasLabels);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFileToImport);
			this.Controls.Add(this.lblFileToImport);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CSVImportDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Import CSV File";
			this.grpHasLabels.ResumeLayout(false);
			this.grpHasLabels.PerformLayout();
			this.grpDataSize.ResumeLayout(false);
			this.grpDataSize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumRows)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNumColumns)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFileToImport;
		private System.Windows.Forms.TextBox txtFileToImport;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.GroupBox grpHasLabels;
		private System.Windows.Forms.RadioButton rbLabeledNo;
		private System.Windows.Forms.RadioButton rbLabeledYes;
		private System.Windows.Forms.GroupBox grpDataSize;
		private System.Windows.Forms.NumericUpDown nudNumColumns;
		private System.Windows.Forms.Label lblDataNumColumns;
		private System.Windows.Forms.NumericUpDown nudNumRows;
		private System.Windows.Forms.Label lblDataNumRows;
		private System.Windows.Forms.Button btnImportFile;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog ofdFileToImport;
	}
}