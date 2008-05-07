namespace DRToolbox.UI.TechniqueParameters
{
    partial class LandmarkIsomapForm
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
            this.lblPrecentage = new System.Windows.Forms.Label();
            this.nudPrecentage = new System.Windows.Forms.NumericUpDown();
            this.nudKValue = new System.Windows.Forms.NumericUpDown();
            this.lblKValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKValue)).BeginInit();
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
            // lblPrecentage
            // 
            this.lblPrecentage.AutoSize = true;
            this.lblPrecentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecentage.Location = new System.Drawing.Point(63, 48);
            this.lblPrecentage.Name = "lblPrecentage";
            this.lblPrecentage.Size = new System.Drawing.Size(76, 13);
            this.lblPrecentage.TabIndex = 2;
            this.lblPrecentage.Text = "Precentage:";
            // 
            // nudPrecentage
            // 
            this.nudPrecentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.nudPrecentage.DecimalPlaces = 2;
            this.nudPrecentage.ForeColor = System.Drawing.Color.Black;
            this.nudPrecentage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudPrecentage.Location = new System.Drawing.Point(145, 46);
            this.nudPrecentage.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecentage.Name = "nudPrecentage";
            this.nudPrecentage.Size = new System.Drawing.Size(66, 20);
            this.nudPrecentage.TabIndex = 3;
            this.nudPrecentage.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // nudKValue
            // 
            this.nudKValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.nudKValue.ForeColor = System.Drawing.Color.Black;
            this.nudKValue.Location = new System.Drawing.Point(145, 22);
            this.nudKValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudKValue.Name = "nudKValue";
            this.nudKValue.Size = new System.Drawing.Size(66, 20);
            this.nudKValue.TabIndex = 5;
            this.nudKValue.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblKValue
            // 
            this.lblKValue.AutoSize = true;
            this.lblKValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKValue.Location = new System.Drawing.Point(65, 24);
            this.lblKValue.Name = "lblKValue";
            this.lblKValue.Size = new System.Drawing.Size(74, 13);
            this.lblKValue.TabIndex = 4;
            this.lblKValue.Text = "Value for K:";
            // 
            // LandmarkIsomapForm
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(305, 133);
            this.ControlBox = false;
            this.Controls.Add(this.nudKValue);
            this.Controls.Add(this.lblKValue);
            this.Controls.Add(this.nudPrecentage);
            this.Controls.Add(this.lblPrecentage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRun);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LandmarkIsomapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LandmarkIsomap Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrecentage;
        private System.Windows.Forms.NumericUpDown nudPrecentage;
        private System.Windows.Forms.NumericUpDown nudKValue;
        private System.Windows.Forms.Label lblKValue;
    }
}