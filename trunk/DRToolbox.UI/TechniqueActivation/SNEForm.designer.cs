namespace DRToolbox.UI.TechniqueParameters
{
    partial class SNEForm
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSigma = new System.Windows.Forms.Label();
            this.nudSigma = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(32, 96);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(108, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run Technique";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(143)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(165, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblSigma
            // 
            this.lblSigma.AutoSize = true;
            this.lblSigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigma.Location = new System.Drawing.Point(94, 39);
            this.lblSigma.Name = "lblSigma";
            this.lblSigma.Size = new System.Drawing.Size(45, 13);
            this.lblSigma.TabIndex = 2;
            this.lblSigma.Text = "Sigma:";
            // 
            // nudSigma
            // 
            this.nudSigma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.nudSigma.DecimalPlaces = 1;
            this.nudSigma.ForeColor = System.Drawing.Color.Black;
            this.nudSigma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSigma.Location = new System.Drawing.Point(145, 37);
            this.nudSigma.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudSigma.Name = "nudSigma";
            this.nudSigma.Size = new System.Drawing.Size(66, 20);
            this.nudSigma.TabIndex = 3;
            this.nudSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // SNEForm
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(305, 133);
            this.ControlBox = false;
            this.Controls.Add(this.nudSigma);
            this.Controls.Add(this.lblSigma);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRun);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SNEForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SNE Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSigma;
        private System.Windows.Forms.NumericUpDown nudSigma;
    }
}