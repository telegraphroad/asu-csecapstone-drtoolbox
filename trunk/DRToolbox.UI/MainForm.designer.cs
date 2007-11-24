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
            this.menuImportFileCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemFile,
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
            this.toolStripMenuItem1,
            this.mItemExit});
            this.mItemFile.Name = "mItemFile";
            this.mItemFile.Size = new System.Drawing.Size(35, 20);
            this.mItemFile.Text = "&File";
            // 
            // mItemImportFile
            // 
            this.mItemImportFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImportFileCSV});
            this.mItemImportFile.Name = "mItemImportFile";
            this.mItemImportFile.Size = new System.Drawing.Size(148, 22);
            this.mItemImportFile.Text = "Import &File...";
            // 
            // menuImportFileCSV
            // 
            this.menuImportFileCSV.Name = "menuImportFileCSV";
            this.menuImportFileCSV.Size = new System.Drawing.Size(196, 22);
            this.menuImportFileCSV.Text = "Comma Delimited (CSV)";
            this.menuImportFileCSV.Click += new System.EventHandler(this.menuImportFileCSV_Click);
            // 
            // mItemExit
            // 
            this.mItemExit.Name = "mItemExit";
            this.mItemExit.Size = new System.Drawing.Size(148, 22);
            this.mItemExit.Text = "E&xit";
            this.mItemExit.Click += new System.EventHandler(this.mItemExit_Click);
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
            // minimizeAllToolStripMenuItem
            // 
            this.minimizeAllToolStripMenuItem.Name = "minimizeAllToolStripMenuItem";
            this.minimizeAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minimizeAllToolStripMenuItem.Text = "&Minimize All";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
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
            this.mItemTutorial.Size = new System.Drawing.Size(121, 22);
            this.mItemTutorial.Text = "T&utorial";
            // 
            // mItemAbout
            // 
            this.mItemAbout.Name = "mItemAbout";
            this.mItemAbout.Size = new System.Drawing.Size(121, 22);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(840, 674);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dimension Reduction Toolbox";
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemTutorial;
        private System.Windows.Forms.ToolStripMenuItem mItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mItemImportFile;
        private System.Windows.Forms.ToolStripMenuItem mItemWindow;
        private System.Windows.Forms.ToolStripMenuItem minimizeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuImportFileCSV;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

