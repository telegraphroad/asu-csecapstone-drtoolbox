namespace DRToolbox.UI
{
    partial class ImportedFileForm
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
            if (disposing && (components != null))
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
            this.btnRunTechnique = new System.Windows.Forms.Button();
            this.pnlTechniques = new System.Windows.Forms.Panel();
            this.lblImportFileHeader = new System.Windows.Forms.Label();
            this.lblImportFile = new System.Windows.Forms.Label();
            this.btnViewDataset = new System.Windows.Forms.Button();
            this.lblTechniques = new System.Windows.Forms.Label();
            this.pnlImportFileNames = new System.Windows.Forms.Panel();
            this.pnlImportFileNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunTechnique
            // 
            this.btnRunTechnique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnRunTechnique.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunTechnique.ForeColor = System.Drawing.Color.Black;
            this.btnRunTechnique.Location = new System.Drawing.Point(534, 19);
            this.btnRunTechnique.Name = "btnRunTechnique";
            this.btnRunTechnique.Size = new System.Drawing.Size(105, 23);
            this.btnRunTechnique.TabIndex = 0;
            this.btnRunTechnique.Text = "Run Technique";
            this.btnRunTechnique.UseVisualStyleBackColor = false;
            this.btnRunTechnique.Click += new System.EventHandler(this.btnRunTechnique_Click);
            // 
            // pnlTechniques
            // 
            this.pnlTechniques.AutoScroll = true;
            this.pnlTechniques.ForeColor = System.Drawing.Color.Black;
            this.pnlTechniques.Location = new System.Drawing.Point(54, 116);
            this.pnlTechniques.Name = "pnlTechniques";
            this.pnlTechniques.Size = new System.Drawing.Size(580, 250);
            this.pnlTechniques.TabIndex = 1;
            // 
            // lblImportFileHeader
            // 
            this.lblImportFileHeader.AutoSize = true;
            this.lblImportFileHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportFileHeader.ForeColor = System.Drawing.Color.Black;
            this.lblImportFileHeader.Location = new System.Drawing.Point(12, 17);
            this.lblImportFileHeader.Name = "lblImportFileHeader";
            this.lblImportFileHeader.Size = new System.Drawing.Size(96, 15);
            this.lblImportFileHeader.TabIndex = 2;
            this.lblImportFileHeader.Text = "File Imported:";
            // 
            // lblImportFile
            // 
            this.lblImportFile.AutoSize = true;
            this.lblImportFile.ForeColor = System.Drawing.Color.Black;
            this.lblImportFile.Location = new System.Drawing.Point(0, 2);
            this.lblImportFile.MaximumSize = new System.Drawing.Size(295, 0);
            this.lblImportFile.Name = "lblImportFile";
            this.lblImportFile.Size = new System.Drawing.Size(129, 13);
            this.lblImportFile.TabIndex = 3;
            this.lblImportFile.Text = "File Name of Imported File";
            // 
            // btnViewDataset
            // 
            this.btnViewDataset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnViewDataset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDataset.ForeColor = System.Drawing.Color.Black;
            this.btnViewDataset.Location = new System.Drawing.Point(423, 19);
            this.btnViewDataset.Name = "btnViewDataset";
            this.btnViewDataset.Size = new System.Drawing.Size(105, 23);
            this.btnViewDataset.TabIndex = 4;
            this.btnViewDataset.Text = "View Imported File";
            this.btnViewDataset.UseVisualStyleBackColor = false;
            this.btnViewDataset.Click += new System.EventHandler(this.btnViewDataset_Click);
            // 
            // lblTechniques
            // 
            this.lblTechniques.AutoSize = true;
            this.lblTechniques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechniques.ForeColor = System.Drawing.Color.Black;
            this.lblTechniques.Location = new System.Drawing.Point(12, 89);
            this.lblTechniques.Name = "lblTechniques";
            this.lblTechniques.Size = new System.Drawing.Size(115, 15);
            this.lblTechniques.TabIndex = 5;
            this.lblTechniques.Text = "Ran Techniques:";
            // 
            // pnlImportFileNames
            // 
            this.pnlImportFileNames.AutoScroll = true;
            this.pnlImportFileNames.Controls.Add(this.lblImportFile);
            this.pnlImportFileNames.Location = new System.Drawing.Point(114, 17);
            this.pnlImportFileNames.Name = "pnlImportFileNames";
            this.pnlImportFileNames.Size = new System.Drawing.Size(303, 71);
            this.pnlImportFileNames.TabIndex = 6;
            // 
            // ImportedFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(656, 438);
            this.Controls.Add(this.pnlImportFileNames);
            this.Controls.Add(this.lblTechniques);
            this.Controls.Add(this.btnViewDataset);
            this.Controls.Add(this.lblImportFileHeader);
            this.Controls.Add(this.pnlTechniques);
            this.Controls.Add(this.btnRunTechnique);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.Name = "ImportedFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ImportedFileForm";
            this.pnlImportFileNames.ResumeLayout(false);
            this.pnlImportFileNames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunTechnique;
        private System.Windows.Forms.Panel pnlTechniques;
        private System.Windows.Forms.Label lblImportFileHeader;
        private System.Windows.Forms.Label lblImportFile;
        private System.Windows.Forms.Button btnViewDataset;
        private System.Windows.Forms.Label lblTechniques;
        private System.Windows.Forms.Panel pnlImportFileNames;
    }
}