namespace DRToolbox.UI
{
    partial class MainForm
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemImportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTechniques = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.mItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemPCA = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemMDS = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemLLE = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemIsomap = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemFile,
            this.mItemTechniques,
            this.mItemWindow,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(840, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "Main Menu";
            // 
            // mItemFile
            // 
            this.mItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemImportFile,
            this.mItemExit});
            this.mItemFile.Name = "mItemFile";
            this.mItemFile.Size = new System.Drawing.Size(35, 20);
            this.mItemFile.Text = "&File";
            // 
            // mItemImportFile
            // 
            this.mItemImportFile.Name = "mItemImportFile";
            this.mItemImportFile.Size = new System.Drawing.Size(152, 22);
            this.mItemImportFile.Text = "Import &File...";
            // 
            // mItemExit
            // 
            this.mItemExit.Name = "mItemExit";
            this.mItemExit.Size = new System.Drawing.Size(152, 22);
            this.mItemExit.Text = "E&xit";
            this.mItemExit.Click += new System.EventHandler(this.mItemExit_Click);
            // 
            // mItemTechniques
            // 
            this.mItemTechniques.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemPCA,
            this.mItemMDS,
            this.mItemLLE,
            this.mItemIsomap});
            this.mItemTechniques.Name = "mItemTechniques";
            this.mItemTechniques.Size = new System.Drawing.Size(98, 20);
            this.mItemTechniques.Text = "D.R. &Techniques";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemTutorial,
            this.mItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mItemTutorial
            // 
            this.mItemTutorial.Name = "mItemTutorial";
            this.mItemTutorial.Size = new System.Drawing.Size(152, 22);
            this.mItemTutorial.Text = "T&utorial";
            // 
            // mItemAbout
            // 
            this.mItemAbout.Name = "mItemAbout";
            this.mItemAbout.Size = new System.Drawing.Size(152, 22);
            this.mItemAbout.Text = "&About";
            this.mItemAbout.Click += new System.EventHandler(this.mItemAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 652);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(840, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "Status Bar";
            // 
            // mItemWindow
            // 
            this.mItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.cascadeToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.mItemWindow.Name = "mItemWindow";
            this.mItemWindow.Size = new System.Drawing.Size(57, 20);
            this.mItemWindow.Text = "&Window";
            // 
            // mItemPCA
            // 
            this.mItemPCA.Name = "mItemPCA";
            this.mItemPCA.Size = new System.Drawing.Size(244, 22);
            this.mItemPCA.Text = "Principle Component Analysis (PCA)";
            this.mItemPCA.Click += new System.EventHandler(this.mItemPCA_Click);
            // 
            // mItemMDS
            // 
            this.mItemMDS.Name = "mItemMDS";
            this.mItemMDS.Size = new System.Drawing.Size(244, 22);
            this.mItemMDS.Text = "Multidimensional Scalling (MDS)";
            // 
            // mItemLLE
            // 
            this.mItemLLE.Name = "mItemLLE";
            this.mItemLLE.Size = new System.Drawing.Size(244, 22);
            this.mItemLLE.Text = "Local Linear Embedding (LLE)";
            // 
            // mItemIsomap
            // 
            this.mItemIsomap.Name = "mItemIsomap";
            this.mItemIsomap.Size = new System.Drawing.Size(244, 22);
            this.mItemIsomap.Text = "Isomap";
            // 
            // minimizeAllToolStripMenuItem
            // 
            this.minimizeAllToolStripMenuItem.Name = "minimizeAllToolStripMenuItem";
            this.minimizeAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minimizeAllToolStripMenuItem.Text = "&Minimize All";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileToolStripMenuItem.Text = "Tile &Horizontal";
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // frmToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(840, 674);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmToolbox";
            this.Text = "Dimension Reduction Toolbox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mItemFile;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem mItemExit;
        private System.Windows.Forms.ToolStripMenuItem mItemTechniques;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemTutorial;
        private System.Windows.Forms.ToolStripMenuItem mItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mItemImportFile;
        private System.Windows.Forms.ToolStripMenuItem mItemWindow;
        private System.Windows.Forms.ToolStripMenuItem mItemPCA;
        private System.Windows.Forms.ToolStripMenuItem mItemMDS;
        private System.Windows.Forms.ToolStripMenuItem mItemLLE;
        private System.Windows.Forms.ToolStripMenuItem mItemIsomap;
        private System.Windows.Forms.ToolStripMenuItem minimizeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

