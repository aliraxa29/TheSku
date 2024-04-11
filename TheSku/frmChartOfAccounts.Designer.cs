namespace TheSku
{
    partial class frmChartOfAccounts
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            btnClose = new Telerik.WinControls.UI.RadButton();
            radDropDownButton3 = new Telerik.WinControls.UI.RadDropDownButton();
            btnRefreshAll = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            btnExpandAll = new Telerik.WinControls.UI.RadButton();
            radDropDownButton2 = new Telerik.WinControls.UI.RadDropDownButton();
            radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            tvAccounts = new Telerik.WinControls.UI.RadTreeView();
            bwAccounts = new System.ComponentModel.BackgroundWorker();
            btnNew = new Telerik.WinControls.UI.RadButton();
            cmbCompany = new Telerik.WinControls.UI.RadDropDownList();
            label2 = new System.Windows.Forms.Label();
            cMenu = new Telerik.WinControls.UI.RadContextMenu(components);
            add_child_account = new Telerik.WinControls.UI.RadMenuItem();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExpandAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tvAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCompany).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(8, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 25);
            label1.TabIndex = 1;
            label1.Text = "Chart Of Accounts";
            // 
            // radDropDownButton1
            // 
            radDropDownButton1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            radDropDownButton1.Items.AddRange(new Telerik.WinControls.RadItem[] { radMenuItem5, radMenuItem6, radMenuItem7, radMenuItem8, radMenuItem9, radMenuItem10, radMenuItem11 });
            radDropDownButton1.Location = new System.Drawing.Point(919, 14);
            radDropDownButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radDropDownButton1.Name = "radDropDownButton1";
            radDropDownButton1.Size = new System.Drawing.Size(186, 48);
            radDropDownButton1.TabIndex = 3;
            radDropDownButton1.Text = "Financial Statements";
            radDropDownButton1.ThemeName = "Windows8";
            // 
            // radMenuItem5
            // 
            radMenuItem5.Name = "radMenuItem5";
            radMenuItem5.Text = "Trial Balance";
            // 
            // radMenuItem6
            // 
            radMenuItem6.Name = "radMenuItem6";
            radMenuItem6.Text = "General Ledger";
            // 
            // radMenuItem7
            // 
            radMenuItem7.Name = "radMenuItem7";
            radMenuItem7.Text = "Balance Sheet";
            radMenuItem7.Click += radMenuItem7_Click;
            // 
            // radMenuItem8
            // 
            radMenuItem8.Name = "radMenuItem8";
            radMenuItem8.Text = "Profit and Loss Statement";
            // 
            // radMenuItem9
            // 
            radMenuItem9.Name = "radMenuItem9";
            radMenuItem9.Text = "Cash Flow Statement";
            // 
            // radMenuItem10
            // 
            radMenuItem10.Name = "radMenuItem10";
            radMenuItem10.Text = "Accounts Payable";
            // 
            // radMenuItem11
            // 
            radMenuItem11.Name = "radMenuItem11";
            radMenuItem11.Text = "Accounts Receivable";
            radMenuItem11.Click += radMenuItem11_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClose.Location = new System.Drawing.Point(527, 14);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(99, 48);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.ThemeName = "Windows8";
            btnClose.Click += btnClose_Click;
            // 
            // radDropDownButton3
            // 
            radDropDownButton3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radDropDownButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            radDropDownButton3.Items.AddRange(new Telerik.WinControls.RadItem[] { btnRefreshAll, radMenuItem3, radMenuItem4 });
            radDropDownButton3.Location = new System.Drawing.Point(846, 14);
            radDropDownButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radDropDownButton3.Name = "radDropDownButton3";
            radDropDownButton3.Size = new System.Drawing.Size(66, 48);
            radDropDownButton3.TabIndex = 3;
            radDropDownButton3.Text = "View";
            radDropDownButton3.ThemeName = "Windows8";
            // 
            // btnRefreshAll
            // 
            btnRefreshAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRefreshAll.Name = "btnRefreshAll";
            btnRefreshAll.Text = "Refresh All";
            btnRefreshAll.Click += btnRefreshAll_Click;
            // 
            // radMenuItem3
            // 
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "Chart Of Cost Center";
            // 
            // radMenuItem4
            // 
            radMenuItem4.Name = "radMenuItem4";
            radMenuItem4.Text = "Period Closing Voucher";
            // 
            // btnExpandAll
            // 
            btnExpandAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExpandAll.Location = new System.Drawing.Point(634, 14);
            btnExpandAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new System.Drawing.Size(120, 48);
            btnExpandAll.TabIndex = 4;
            btnExpandAll.Text = "Expand All";
            btnExpandAll.ThemeName = "Windows8";
            btnExpandAll.Click += btnExpandAll_Click;
            // 
            // radDropDownButton2
            // 
            radDropDownButton2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radDropDownButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            radDropDownButton2.Items.AddRange(new Telerik.WinControls.RadItem[] { radMenuItem1, radMenuItem2 });
            radDropDownButton2.Location = new System.Drawing.Point(761, 14);
            radDropDownButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radDropDownButton2.Name = "radDropDownButton2";
            radDropDownButton2.Size = new System.Drawing.Size(78, 48);
            radDropDownButton2.TabIndex = 3;
            radDropDownButton2.Text = "Create";
            radDropDownButton2.ThemeName = "Windows8";
            // 
            // radMenuItem1
            // 
            radMenuItem1.Name = "radMenuItem1";
            radMenuItem1.Text = "Journal Entry";
            // 
            // radMenuItem2
            // 
            radMenuItem2.Name = "radMenuItem2";
            radMenuItem2.Text = "Company";
            // 
            // tvAccounts
            // 
            tvAccounts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tvAccounts.BackColor = System.Drawing.Color.FromArgb(191, 219, 255);
            tvAccounts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tvAccounts.ForeColor = System.Drawing.Color.Black;
            tvAccounts.ItemHeight = 27;
            tvAccounts.LineColor = System.Drawing.Color.FromArgb(96, 96, 96);
            tvAccounts.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
            tvAccounts.LineWidth = 1.16666663F;
            tvAccounts.Location = new System.Drawing.Point(14, 69);
            tvAccounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tvAccounts.Name = "tvAccounts";
            tvAccounts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tvAccounts.Size = new System.Drawing.Size(1197, 422);
            tvAccounts.SpacingBetweenNodes = -1;
            tvAccounts.TabIndex = 1;
            tvAccounts.ThemeName = "Windows8";
            tvAccounts.TreeIndent = 23;
            tvAccounts.SelectedNodesChanged += tvAccounts_SelectedNodesChanged;
            tvAccounts.KeyDown += tvAccounts_KeyDown;
            // 
            // bwAccounts
            // 
            bwAccounts.DoWork += bwAccounts_DoWork;
            bwAccounts.RunWorkerCompleted += bwAccounts_RunWorkerCompleted;
            // 
            // btnNew
            // 
            btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnNew.Location = new System.Drawing.Point(1112, 14);
            btnNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(99, 48);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.ThemeName = "Windows8";
            btnNew.Click += btnNew_Click;
            // 
            // cmbCompany
            // 
            cmbCompany.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cmbCompany.DisplayMember = "name";
            cmbCompany.DropDownAnimationEnabled = true;
            cmbCompany.DropDownHeight = 124;
            cmbCompany.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            cmbCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cmbCompany.ItemHeight = 21;
            cmbCompany.Location = new System.Drawing.Point(284, 36);
            cmbCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new System.Drawing.Size(233, 23);
            cmbCompany.TabIndex = 5;
            cmbCompany.ThemeName = "Windows8";
            cmbCompany.ValueMember = "name";
            cmbCompany.SelectedIndexChanged += cmbCompany_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(284, 14);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Company";
            // 
            // cMenu
            // 
            cMenu.AnimationType = Telerik.WinControls.UI.PopupAnimationTypes.Easing;
            cMenu.Items.AddRange(new Telerik.WinControls.RadItem[] { add_child_account });
            // 
            // add_child_account
            // 
            add_child_account.EnableBorderHighlight = false;
            add_child_account.Name = "add_child_account";
            add_child_account.Text = "Add Child Account";
            add_child_account.Click += btnAddChildAccount_Click;
            // 
            // frmChartOfAccounts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1223, 503);
            Controls.Add(label2);
            Controls.Add(cmbCompany);
            Controls.Add(label1);
            Controls.Add(tvAccounts);
            Controls.Add(radDropDownButton1);
            Controls.Add(btnNew);
            Controls.Add(btnClose);
            Controls.Add(radDropDownButton2);
            Controls.Add(radDropDownButton3);
            Controls.Add(btnExpandAll);
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmChartOfAccounts";
            Text = "COA Tree View";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            KeyDown += frmAccountTreeView_KeyDown;
            ((System.ComponentModel.ISupportInitialize)radDropDownButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExpandAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tvAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCompany).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton1;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton3;
        private Telerik.WinControls.UI.RadButton btnExpandAll;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton2;
        private Telerik.WinControls.UI.RadTreeView tvAccounts;
        private Telerik.WinControls.UI.RadMenuItem btnRefreshAll;
        private System.ComponentModel.BackgroundWorker bwAccounts;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadDropDownList cmbCompany;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadContextMenu cMenu;
        private Telerik.WinControls.UI.RadMenuItem add_child_account;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}
