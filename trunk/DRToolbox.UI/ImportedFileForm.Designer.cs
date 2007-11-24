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
            this.SuspendLayout();
            // 
            // btnRunTechnique
            // 
            this.btnRunTechnique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunTechnique.Location = new System.Drawing.Point(529, 17);
            this.btnRunTechnique.Name = "btnRunTechnique";
            this.btnRunTechnique.Size = new System.Drawing.Size(105, 23);
            this.btnRunTechnique.TabIndex = 0;
            this.btnRunTechnique.Text = "Run Technique";
            this.btnRunTechnique.UseVisualStyleBackColor = true;
            this.btnRunTechnique.Click += new System.EventHandler(this.btnRunTechnique_Click);
            // 
            // pnlTechniques
            // 
            this.pnlTechniques.AutoScroll = true;
            this.pnlTechniques.Location = new System.Drawing.Point(54, 105);
            this.pnlTechniques.Name = "pnlTechniques";
            this.pnlTechniques.Size = new System.Drawing.Size(580, 250);
            this.pnlTechniques.TabIndex = 1;
            // 
            // lblImportFileHeader
            // 
            this.lblImportFileHeader.AutoSize = true;
            this.lblImportFileHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportFileHeader.Location = new System.Drawing.Point(12, 17);
            this.lblImportFileHeader.Name = "lblImportFileHeader";
            this.lblImportFileHeader.Size = new System.Drawing.Size(84, 13);
            this.lblImportFileHeader.TabIndex = 2;
            this.lblImportFileHeader.Text = "File Imported:";
            // 
            // lblImportFile
            // 
            this.lblImportFile.Location = new System.Drawing.Point(98, 17);
            this.lblImportFile.Name = "lblImportFile";
            this.lblImportFile.Size = new System.Drawing.Size(303, 60);
            this.lblImportFile.TabIndex = 3;
            this.lblImportFile.Text = "File Name of Imported File";
            // 
            // btnViewDataset
            // 
            this.btnViewDataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDataset.Location = new System.Drawing.Point(418, 17);
            this.btnViewDataset.Name = "btnViewDataset";
            this.btnViewDataset.Size = new System.Drawing.Size(105, 23);
            this.btnViewDataset.TabIndex = 4;
            this.btnViewDataset.Text = "View Dataset";
            this.btnViewDataset.UseVisualStyleBackColor = true;
            // 
            // lblTechniques
            // 
            this.lblTechniques.AutoSize = true;
            this.lblTechniques.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechniques.Location = new System.Drawing.Point(12, 89);
            this.lblTechniques.Name = "lblTechniques";
            this.lblTechniques.Size = new System.Drawing.Size(104, 13);
            this.lblTechniques.TabIndex = 5;
            this.lblTechniques.Text = "Ran Techniques:";
            // 
            // ImportedFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.lblTechniques);
            this.Controls.Add(this.btnViewDataset);
            this.Controls.Add(this.lblImportFile);
            this.Controls.Add(this.lblImportFileHeader);
            this.Controls.Add(this.pnlTechniques);
            this.Controls.Add(this.btnRunTechnique);
            this.Name = "ImportedFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImportedFileForm";
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
    }
}