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
            pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pOSInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            customerGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            buyingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            supplierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            supplierGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            chartOfAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sessionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ssMain = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            lblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ssMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, sellingToolStripMenuItem, buyingToolStripMenuItem, accountingToolStripMenuItem, userManagementToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pOSToolStripMenuItem, changePasswordToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // pOSToolStripMenuItem
            // 
            pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            pOSToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            pOSToolStripMenuItem.Text = "POS";
            pOSToolStripMenuItem.Click += pOSToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pOSInvoicesToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // pOSInvoicesToolStripMenuItem
            // 
            pOSInvoicesToolStripMenuItem.Name = "pOSInvoicesToolStripMenuItem";
            pOSInvoicesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            pOSInvoicesToolStripMenuItem.Text = "POS Invoices";
            // 
            // sellingToolStripMenuItem
            // 
            sellingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { customerToolStripMenuItem });
            sellingToolStripMenuItem.Name = "sellingToolStripMenuItem";
            sellingToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            sellingToolStripMenuItem.Text = "Selling";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { customerToolStripMenuItem1, customerGroupToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // customerToolStripMenuItem1
            // 
            customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            customerToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            customerToolStripMenuItem1.Text = "Customer";
            customerToolStripMenuItem1.Click += customerToolStripMenuItem_Click;
            // 
            // customerGroupToolStripMenuItem
            // 
            customerGroupToolStripMenuItem.Name = "customerGroupToolStripMenuItem";
            customerGroupToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            customerGroupToolStripMenuItem.Text = "Customer Group";
            // 
            // buyingToolStripMenuItem
            // 
            buyingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { supplierToolStripMenuItem, brandToolStripMenuItem });
            buyingToolStripMenuItem.Name = "buyingToolStripMenuItem";
            buyingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            buyingToolStripMenuItem.Text = "Buying";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { supplierToolStripMenuItem1, supplierGroupToolStripMenuItem });
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // supplierToolStripMenuItem1
            // 
            supplierToolStripMenuItem1.Name = "supplierToolStripMenuItem1";
            supplierToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            supplierToolStripMenuItem1.Text = "Supplier";
            supplierToolStripMenuItem1.Click += supplierToolStripMenuItem_Click;
            // 
            // supplierGroupToolStripMenuItem
            // 
            supplierGroupToolStripMenuItem.Name = "supplierGroupToolStripMenuItem";
            supplierGroupToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            supplierGroupToolStripMenuItem.Text = "Supplier Group";
            supplierGroupToolStripMenuItem.Click += supplierGroupToolStripMenuItem_Click;
            // 
            // accountingToolStripMenuItem
            // 
            accountingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { accountToolStripMenuItem, chartOfAccountsToolStripMenuItem, reportToolStripMenuItem });
            accountingToolStripMenuItem.Name = "accountingToolStripMenuItem";
            accountingToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            accountingToolStripMenuItem.Text = "Accounting";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            accountToolStripMenuItem.Text = "Account";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // chartOfAccountsToolStripMenuItem
            // 
            chartOfAccountsToolStripMenuItem.Name = "chartOfAccountsToolStripMenuItem";
            chartOfAccountsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            chartOfAccountsToolStripMenuItem.Text = "Chart Of Accounts";
            chartOfAccountsToolStripMenuItem.Click += chartOfAccountsToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            reportToolStripMenuItem.Text = "Reports";
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { userToolStripMenuItem, countryToolStripMenuItem, currencyToolStripMenuItem, companyToolStripMenuItem, sessionSettingsToolStripMenuItem });
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            userManagementToolStripMenuItem.Text = "Management";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Image = Properties.Resources.User_Security_24;
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // countryToolStripMenuItem
            // 
            countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            countryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            countryToolStripMenuItem.Text = "Country";
            countryToolStripMenuItem.Click += countryToolStripMenuItem_Click;
            // 
            // currencyToolStripMenuItem
            // 
            currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            currencyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            currencyToolStripMenuItem.Text = "Currency";
            currencyToolStripMenuItem.Click += currencyToolStripMenuItem_Click;
            // 
            // companyToolStripMenuItem
            // 
            companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            companyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            companyToolStripMenuItem.Text = "Company";
            companyToolStripMenuItem.Click += companyToolStripMenuItem_Click;
            // 
            // sessionSettingsToolStripMenuItem
            // 
            sessionSettingsToolStripMenuItem.Name = "sessionSettingsToolStripMenuItem";
            sessionSettingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            sessionSettingsToolStripMenuItem.Text = "System Settings";
            sessionSettingsToolStripMenuItem.Click += sessionSettingsToolStripMenuItem_Click;
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
            // brandToolStripMenuItem
            // 
            brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            brandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            brandToolStripMenuItem.Text = "Brand";
            brandToolStripMenuItem.Click += brandToolStripMenuItem_Click;
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
        private System.Windows.Forms.ToolStripMenuItem accountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsername;
        private System.Windows.Forms.ToolStripMenuItem sellingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supplierGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
    }
}