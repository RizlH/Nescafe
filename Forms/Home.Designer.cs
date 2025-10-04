namespace Nescafe.Forms
{
    partial class Home
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
            MenuHome = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem = new ToolStripMenuItem();
            savingToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            exchangeToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            terminologiToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            MenuHome.SuspendLayout();
            SuspendLayout();
            // 
            // MenuHome
            // 
            MenuHome.ImageScalingSize = new Size(24, 24);
            MenuHome.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, profileToolStripMenuItem, loanToolStripMenuItem, savingToolStripMenuItem, transferToolStripMenuItem, exchangeToolStripMenuItem, historyToolStripMenuItem });
            MenuHome.Location = new Point(0, 0);
            MenuHome.Name = "MenuHome";
            MenuHome.Size = new Size(1090, 33);
            MenuHome.TabIndex = 0;
            MenuHome.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, terminologiToolStripMenuItem, logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(78, 29);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // loanToolStripMenuItem
            // 
            loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            loanToolStripMenuItem.Size = new Size(66, 29);
            loanToolStripMenuItem.Text = "Loan";
            // 
            // savingToolStripMenuItem
            // 
            savingToolStripMenuItem.Name = "savingToolStripMenuItem";
            savingToolStripMenuItem.Size = new Size(81, 29);
            savingToolStripMenuItem.Text = "Saving";
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(89, 29);
            transferToolStripMenuItem.Text = "Transfer";
            // 
            // exchangeToolStripMenuItem
            // 
            exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            exchangeToolStripMenuItem.Size = new Size(102, 29);
            exchangeToolStripMenuItem.Text = "Exchange";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(85, 29);
            historyToolStripMenuItem.Text = "History";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(270, 34);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // terminologiToolStripMenuItem
            // 
            terminologiToolStripMenuItem.Name = "terminologiToolStripMenuItem";
            terminologiToolStripMenuItem.Size = new Size(270, 34);
            terminologiToolStripMenuItem.Text = "Terminologi";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(270, 34);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 450);
            Controls.Add(MenuHome);
            MainMenuStrip = MenuHome;
            Name = "Home";
            Text = "Home";
            MenuHome.ResumeLayout(false);
            MenuHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuHome;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem terminologiToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem;
        private ToolStripMenuItem savingToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
    }
}