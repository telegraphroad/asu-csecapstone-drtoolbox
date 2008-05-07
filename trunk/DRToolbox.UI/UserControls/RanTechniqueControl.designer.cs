namespace DRToolbox.UI.UserControls
{
    partial class RanTechniqueControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTechniqueName = new System.Windows.Forms.Label();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTechniqueName
            // 
            this.lblTechniqueName.AutoSize = true;
            this.lblTechniqueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechniqueName.ForeColor = System.Drawing.Color.White;
            this.lblTechniqueName.Location = new System.Drawing.Point(18, 19);
            this.lblTechniqueName.Name = "lblTechniqueName";
            this.lblTechniqueName.Size = new System.Drawing.Size(94, 13);
            this.lblTechniqueName.TabIndex = 0;
            this.lblTechniqueName.Text = "Ran Technique";
            // 
            // btnViewResults
            // 
            this.btnViewResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnViewResults.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewResults.ForeColor = System.Drawing.Color.Black;
            this.btnViewResults.Location = new System.Drawing.Point(449, 14);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(93, 23);
            this.btnViewResults.TabIndex = 1;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.UseVisualStyleBackColor = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // RanTechniqueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(112)))), ((int)(((byte)(89)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnViewResults);
            this.Controls.Add(this.lblTechniqueName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RanTechniqueControl";
            this.Size = new System.Drawing.Size(560, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTechniqueName;
        private System.Windows.Forms.Button btnViewResults;
    }
}
