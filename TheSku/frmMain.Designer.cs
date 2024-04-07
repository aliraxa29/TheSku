namespace TheSku
{
    partial class frmMain
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            supplierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ssMain = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            lblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            ssMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, supplierToolStripMenuItem1, accountingToolStripMenuItem, userManagementToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { changePasswordToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // supplierToolStripMenuItem1
            // 
            supplierToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { supplierToolStripMenuItem });
            supplierToolStripMenuItem1.Name = "supplierToolStripMenuItem1";
            supplierToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            supplierToolStripMenuItem1.Text = "Supplier";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            supplierToolStripMenuItem.Text = "Supplier";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // accountingToolStripMenuItem
            // 
            accountingToolStripMenuItem.Name = "accountingToolStripMenuItem";
            accountingToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            accountingToolStripMenuItem.Text = "Accounting";
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { userToolStripMenuItem });
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            userManagementToolStripMenuItem.Text = "User Management";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Image = Properties.Resources.User_Security_24;
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutUsToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // ssMain
            // 
            ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, lblUsername });
            ssMain.Location = new System.Drawing.Point(0, 428);
            ssMain.Name = "ssMain";
            ssMain.Size = new System.Drawing.Size(800, 22);
            ssMain.TabIndex = 3;
            ssMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            toolStripStatusLabel1.Text = "User:";
            // 
            // lblUsername
            // 
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(30, 17);
            lblUsername.Text = "User";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(ssMain);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Main";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ssMain.ResumeLayout(false);
            ssMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsername;
    }
}