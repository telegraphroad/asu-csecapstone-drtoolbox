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
            this.menuImportFileImages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreOpenWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tssProgressMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.statusBar.SuspendLayout();
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
            this.menuMain.Size = new System.Drawing.Size(1016, 24);
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
            this.mItemFile.Size = new System.Drawing.Size(37, 20);
            this.mItemFile.Text = "&File";
            // 
            // mItemImportFile
            // 
            this.mItemImportFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImportFileCSV,
            this.menuImportFileImages});
            this.mItemImportFile.Name = "mItemImportFile";
            this.mItemImportFile.Size = new System.Drawing.Size(140, 22);
            this.mItemImportFile.Text = "Import &File...";
            // 
            // menuImportFileCSV
            // 
            this.menuImportFileCSV.Name = "menuImportFileCSV";
            this.menuImportFileCSV.Size = new System.Drawing.Size(203, 22);
            this.menuImportFileCSV.Text = "Comma Delimited (CSV)";
            this.menuImportFileCSV.Click += new System.EventHandler(this.menuImportFileCSV_Click);
            // 
            // menuImportFileImages
            // 
            this.menuImportFileImages.Name = "menuImportFileImages";
            this.menuImportFileImages.Size = new System.Drawing.Size(203, 22);
            this.menuImportFileImages.Text = "Images";
            this.menuImportFileImages.Click += new System.EventHandler(this.menuImportFileImages_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 6);
            // 
            // mItemExit
            // 
            this.mItemExit.Name = "mItemExit";
            this.mItemExit.Size = new System.Drawing.Size(140, 22);
            this.mItemExit.Text = "E&xit";
            this.mItemExit.Click += new System.EventHandler(this.mItemExit_Click);
            // 
            // mItemWindow
            // 
            this.mItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.toolStripSeparator1,
            this.minimizeAllToolStripMenuItem,
            this.maximizeAllToolStripMenuItem,
            this.restoreOpenWindowsToolStripMenuItem,
            this.toolStripSeparator2,
            this.windowsToolStripMenuItem});
            this.mItemWindow.Name = "mItemWindow";
            this.mItemWindow.Size = new System.Drawing.Size(63, 20);
            this.mItemWindow.Text = "&Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tileToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // minimizeAllToolStripMenuItem
            // 
            this.minimizeAllToolStripMenuItem.Name = "minimizeAllToolStripMenuItem";
            this.minimizeAllToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.minimizeAllToolStripMenuItem.Text = "&Minimize All";
            this.minimizeAllToolStripMenuItem.Click += new System.EventHandler(this.minimizeAllToolStripMenuItem_Click);
            // 
            // maximizeAllToolStripMenuItem
            // 
            this.maximizeAllToolStripMenuItem.Name = "maximizeAllToolStripMenuItem";
            this.maximizeAllToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.maximizeAllToolStripMenuItem.Text = "Ma&ximize All";
            this.maximizeAllToolStripMenuItem.Click += new System.EventHandler(this.maximizeAllToolStripMenuItem_Click);
            // 
            // restoreOpenWindowsToolStripMenuItem
            // 
            this.restoreOpenWindowsToolStripMenuItem.Name = "restoreOpenWindowsToolStripMenuItem";
            this.restoreOpenWindowsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.restoreOpenWindowsToolStripMenuItem.Text = "&Restore Windows";
            this.restoreOpenWindowsToolStripMenuItem.Click += new System.EventHandler(this.restoreOpenWindowsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.windowsToolStripMenuItem.Text = "Current &Windows";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemTutorial,
            this.mItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mItemTutorial
            // 
            this.mItemTutorial.Enabled = false;
            this.mItemTutorial.Name = "mItemTutorial";
            this.mItemTutorial.Size = new System.Drawing.Size(115, 22);
            this.mItemTutorial.Text = "T&utorial";
            // 
            // mItemAbout
            // 
            this.mItemAbout.Name = "mItemAbout";
            this.mItemAbout.Size = new System.Drawing.Size(115, 22);
            this.mItemAbout.Text = "&About";
            this.mItemAbout.Click += new System.EventHandler(this.mItemAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssProgressMsg});
            this.statusBar.Location = new System.Drawing.Point(0, 719);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1016, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "Status Bar";
            // 
            // tssProgressMsg
            // 
            this.tssProgressMsg.Name = "tssProgressMsg";
            this.tssProgressMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dimension Reduction Toolbox .NET";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menuImportFileImages;
        private System.Windows.Forms.ToolStripMenuItem maximizeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreOpenWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel tssProgressMsg;
    }
}

