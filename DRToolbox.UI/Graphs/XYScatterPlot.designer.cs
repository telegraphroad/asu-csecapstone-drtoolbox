namespace DRToolbox.UI.Graphs
{
    partial class XYScatterPlot
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
            this.components = new System.ComponentModel.Container();
            this.zGraph = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zGraph
            // 
            this.zGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zGraph.IsShowPointValues = true;
            this.zGraph.Location = new System.Drawing.Point(20, 20);
            this.zGraph.Name = "zGraph";
            this.zGraph.ScrollGrace = 0;
            this.zGraph.ScrollMaxX = 0;
            this.zGraph.ScrollMaxY = 0;
            this.zGraph.ScrollMaxY2 = 0;
            this.zGraph.ScrollMinX = 0;
            this.zGraph.ScrollMinY = 0;
            this.zGraph.ScrollMinY2 = 0;
            this.zGraph.Size = new System.Drawing.Size(752, 533);
            this.zGraph.TabIndex = 4;
            // 
            // XYScatterPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.zGraph);
            this.Location = new System.Drawing.Point(2, 24);
            this.Name = "XYScatterPlot";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "XY Scatter Plot";
            this.ResumeLayout(false);

        }

        #endregion

    }
}