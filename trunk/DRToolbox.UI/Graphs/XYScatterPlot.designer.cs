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
            this.zGraph.IsShowPointValues = true;
            this.zGraph.Location = new System.Drawing.Point(12, 12);
            this.zGraph.Name = "zGraph";
            this.zGraph.ScrollGrace = 0;
            this.zGraph.ScrollMaxX = 0;
            this.zGraph.ScrollMaxY = 0;
            this.zGraph.ScrollMaxY2 = 0;
            this.zGraph.ScrollMinX = 0;
            this.zGraph.ScrollMinY = 0;
            this.zGraph.ScrollMinY2 = 0;
            this.zGraph.Size = new System.Drawing.Size(461, 317);
            this.zGraph.TabIndex = 4;
            // 
            // XYScatterPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 338);
            this.Controls.Add(this.zGraph);
            this.MaximizeBox = false;
            this.Name = "XYScatterPlot";
            this.Text = "XY Scatter Plot";
            this.ResumeLayout(false);

        }

        #endregion

    }
}