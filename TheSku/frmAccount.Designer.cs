using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace TheSku
{
    partial class frmAccount
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
            GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            txtLimit = new NumericUpDown();
            txtNameFilter = new RadTextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnDisplay = new RadButton();
            gvList = new RadGridView();
            groupBox2 = new GroupBox();
            tpList = new TabPage();
            txtAccountNumber = new RadTextBox();
            label2 = new Label();
            label5 = new Label();
            cmbCompany = new RadDropDownList();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbAccountType = new ComboBox();
            label6 = new Label();
            txtAccountName = new RadTextBox();
            chkDisabled = new RadCheckBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbParentAccount = new RadDropDownList();
            chkIsGroup = new RadCheckBox();
            label10 = new Label();
            cmbBalanceMustBe = new ComboBox();
            chkFrozen = new RadCheckBox();
            cmbCurrency = new RadDropDownList();
            label11 = new Label();
            label12 = new Label();
            cmbRootType = new ComboBox();
            cmbReportType = new ComboBox();
            txtTaxRate = new RadSpinEditor();
            lblTaxRate = new Label();
            groupBox3 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            btnClose = new RadButton();
            btnNew = new RadButton();
            brnRefreshFields = new RadButton();
            btnSave = new RadButton();
            btnCopyNameToClipboard = new RadMenuItem();
            btnDelete = new RadMenuItem();
            btnReload = new RadMenuItem();
            radDropDownButton1 = new RadDropDownButton();
            panel2 = new Panel();
            lblID = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)txtLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNameFilter).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).BeginInit();
            groupBox2.SuspendLayout();
            tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAccountNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCompany).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAccountName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkDisabled).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbParentAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkIsGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkFrozen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTaxRate).BeginInit();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brnRefreshFields).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLimit
            // 
            txtLimit.Location = new System.Drawing.Point(165, 58);
            txtLimit.Maximum = new decimal(new int[] { -915455471, -439557943, 2, 0 });
            txtLimit.Name = "txtLimit";
            txtLimit.Size = new System.Drawing.Size(90, 25);
            txtLimit.TabIndex = 4;
            txtLimit.Value = new decimal(new int[] { 100, 0, 0, 0 });
            txtLimit.KeyDown += txtNameFilter_KeyDown;
            // 
            // txtNameFilter
            // 
            txtNameFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtNameFilter.Location = new System.Drawing.Point(6, 60);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.Size = new System.Drawing.Size(153, 23);
            txtNameFilter.TabIndex = 3;
            txtNameFilter.ThemeName = "Windows8";
            txtNameFilter.KeyDown += txtNameFilter_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 38);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 17);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(165, 38);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 17);
            label3.TabIndex = 2;
            label3.Text = "Limit";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLimit);
            groupBox1.Controls.Add(txtNameFilter);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnDisplay);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1087, 89);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // btnDisplay
            // 
            btnDisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDisplay.Location = new System.Drawing.Point(994, 47);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new System.Drawing.Size(90, 36);
            btnDisplay.TabIndex = 1;
            btnDisplay.Text = "Display";
            btnDisplay.ThemeName = "Windows8";
            btnDisplay.Click += btnDisplay_Click;
            // 
            // gvList
            // 
            gvList.BackColor = System.Drawing.Color.Transparent;
            gvList.Dock = DockStyle.Fill;
            gvList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            gvList.ForeColor = System.Drawing.SystemColors.ControlText;
            gvList.ImeMode = ImeMode.NoControl;
            gvList.Location = new System.Drawing.Point(3, 21);
            // 
            // 
            // 
            gvList.MasterTemplate.AllowAddNewRow = false;
            gvList.MasterTemplate.AllowColumnChooser = false;
            gvList.MasterTemplate.AllowDragToGroup = false;
            gvList.MasterTemplate.AllowRowResize = false;
            gvList.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "AccountName";
            gridViewTextBoxColumn1.HeaderText = "Account Name";
            gridViewTextBoxColumn1.Name = "account_name";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 470;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Disabled";
            gridViewTextBoxColumn2.HeaderText = "Status";
            gridViewTextBoxColumn2.Name = "status";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 212;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.HeaderText = "Name";
            gridViewTextBoxColumn3.Name = "name";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 380;
            gvList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3 });
            gvList.MasterTemplate.EnableFiltering = true;
            gvList.MasterTemplate.EnableGrouping = false;
            gvList.MasterTemplate.EnablePaging = true;
            gvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gvList.Name = "gvList";
            gvList.ReadOnly = true;
            gvList.RightToLeft = RightToLeft.No;
            gvList.Size = new System.Drawing.Size(1081, 372);
            gvList.TabIndex = 0;
            gvList.ThemeName = "Windows8";
            gvList.CellFormatting += gvList_CellFormatting;
            gvList.CellDoubleClick += gvList_CellDoubleClick;
            gvList.KeyDown += gvList_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvList);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(3, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1087, 396);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "List";
            // 
            // tpList
            // 
            tpList.Controls.Add(groupBox2);
            tpList.Controls.Add(groupBox1);
            tpList.Location = new System.Drawing.Point(4, 26);
            tpList.Name = "tpList";
            tpList.Padding = new Padding(3);
            tpList.Size = new System.Drawing.Size(1093, 491);
            tpList.TabIndex = 1;
            tpList.Text = "List";
            tpList.UseVisualStyleBackColor = true;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtAccountNumber.Location = new System.Drawing.Point(273, 3);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new System.Drawing.Size(264, 23);
            txtAccountNumber.TabIndex = 1;
            txtAccountNumber.ThemeName = "Windows8";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(155, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 17);
            label2.TabIndex = 0;
            label2.Text = "Account Number";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(741, 6);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 17);
            label5.TabIndex = 0;
            label5.Text = "Company";
            // 
            // cmbCompany
            // 
            cmbCompany.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCompany.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCompany.DisplayMember = "CompanyName";
            cmbCompany.DropDownAnimationEnabled = true;
            cmbCompany.Enabled = false;
            cmbCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbCompany.Location = new System.Drawing.Point(813, 3);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new System.Drawing.Size(265, 23);
            cmbCompany.TabIndex = 2;
            cmbCompany.ThemeName = "Windows8";
            cmbCompany.ValueMember = "Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(cmbAccountType, 0, 5);
            tableLayoutPanel1.Controls.Add(txtAccountNumber, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(cmbCompany, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(txtAccountName, 1, 1);
            tableLayoutPanel1.Controls.Add(chkDisabled, 1, 2);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label8, 2, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 3);
            tableLayoutPanel1.Controls.Add(cmbParentAccount, 3, 3);
            tableLayoutPanel1.Controls.Add(chkIsGroup, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 2, 4);
            tableLayoutPanel1.Controls.Add(cmbBalanceMustBe, 3, 4);
            tableLayoutPanel1.Controls.Add(chkFrozen, 1, 4);
            tableLayoutPanel1.Controls.Add(cmbCurrency, 3, 5);
            tableLayoutPanel1.Controls.Add(label11, 2, 5);
            tableLayoutPanel1.Controls.Add(label12, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbRootType, 3, 1);
            tableLayoutPanel1.Controls.Add(cmbReportType, 3, 2);
            tableLayoutPanel1.Controls.Add(txtTaxRate, 1, 6);
            tableLayoutPanel1.Controls.Add(lblTaxRate, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28531F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881641F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1081, 206);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // cmbAccountType
            // 
            cmbAccountType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbAccountType.DisplayMember = "SupplierGroupName";
            cmbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccountType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbAccountType.Items.AddRange(new object[] { "Accumulated Depreciation", "Asset Received But Not Billed", "Bank", "Cash", "Chargeable", "Capital Work in Progress", "Cost of Goods Sold", "Depreciation", "Equity", "Expense Account", "Expenses Included In Asset Valuation", "Expenses Included In Valuation", "Fixed Asset", "Income Account", "Payable", "Receivable", "Round Off", "Stock", "Stock Adjustment", "Stock Received But Not Billed", "Service Received But Not Billed", "Tax", "Temporary" });
            cmbAccountType.Location = new System.Drawing.Point(273, 148);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new System.Drawing.Size(264, 25);
            cmbAccountType.TabIndex = 13;
            cmbAccountType.ValueMember = "Name";
            cmbAccountType.SelectedIndexChanged += cmbAccountType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(169, 35);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(98, 17);
            label6.TabIndex = 0;
            label6.Text = "Account Name";
            // 
            // txtAccountName
            // 
            txtAccountName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAccountName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtAccountName.Location = new System.Drawing.Point(273, 32);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new System.Drawing.Size(264, 23);
            txtAccountName.TabIndex = 1;
            txtAccountName.ThemeName = "Windows8";
            // 
            // chkDisabled
            // 
            chkDisabled.Anchor = AnchorStyles.Left;
            chkDisabled.Location = new System.Drawing.Point(273, 63);
            chkDisabled.Name = "chkDisabled";
            chkDisabled.Size = new System.Drawing.Size(66, 18);
            chkDisabled.TabIndex = 3;
            chkDisabled.Text = "Disabled";
            chkDisabled.ThemeName = "Windows8";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(737, 35);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 17);
            label7.TabIndex = 0;
            label7.Text = "Root Type";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(725, 64);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(82, 17);
            label8.TabIndex = 0;
            label8.Text = "Report Type";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(705, 93);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(102, 17);
            label9.TabIndex = 0;
            label9.Text = "Parent Account";
            // 
            // cmbParentAccount
            // 
            cmbParentAccount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbParentAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbParentAccount.DisplayMember = "AccountName";
            cmbParentAccount.DropDownAnimationEnabled = true;
            cmbParentAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbParentAccount.Location = new System.Drawing.Point(813, 90);
            cmbParentAccount.Name = "cmbParentAccount";
            cmbParentAccount.Size = new System.Drawing.Size(265, 23);
            cmbParentAccount.TabIndex = 2;
            cmbParentAccount.ThemeName = "Windows8";
            cmbParentAccount.ValueMember = "Name";
            // 
            // chkIsGroup
            // 
            chkIsGroup.Anchor = AnchorStyles.Left;
            chkIsGroup.Location = new System.Drawing.Point(273, 92);
            chkIsGroup.Name = "chkIsGroup";
            chkIsGroup.Size = new System.Drawing.Size(66, 18);
            chkIsGroup.TabIndex = 3;
            chkIsGroup.Text = "Is Group";
            chkIsGroup.ThemeName = "Windows8";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(698, 122);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(109, 17);
            label10.TabIndex = 0;
            label10.Text = "Balance Must Be";
            // 
            // cmbBalanceMustBe
            // 
            cmbBalanceMustBe.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBalanceMustBe.DisplayMember = "SupplierGroupName";
            cmbBalanceMustBe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBalanceMustBe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbBalanceMustBe.Items.AddRange(new object[] { "", "Credit", "Debit" });
            cmbBalanceMustBe.Location = new System.Drawing.Point(813, 119);
            cmbBalanceMustBe.Name = "cmbBalanceMustBe";
            cmbBalanceMustBe.Size = new System.Drawing.Size(265, 25);
            cmbBalanceMustBe.TabIndex = 2;
            cmbBalanceMustBe.ValueMember = "Name";
            // 
            // chkFrozen
            // 
            chkFrozen.Anchor = AnchorStyles.Left;
            chkFrozen.Location = new System.Drawing.Point(273, 121);
            chkFrozen.Name = "chkFrozen";
            chkFrozen.Size = new System.Drawing.Size(57, 18);
            chkFrozen.TabIndex = 3;
            chkFrozen.Text = "Frozen";
            chkFrozen.ThemeName = "Windows8";
            // 
            // cmbCurrency
            // 
            cmbCurrency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCurrency.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCurrency.DisplayMember = "CurrencyName";
            cmbCurrency.DropDownAnimationEnabled = true;
            cmbCurrency.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbCurrency.Location = new System.Drawing.Point(813, 148);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new System.Drawing.Size(265, 23);
            cmbCurrency.TabIndex = 2;
            cmbCurrency.ThemeName = "Windows8";
            cmbCurrency.ValueMember = "Name";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(745, 151);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(62, 17);
            label11.TabIndex = 0;
            label11.Text = "Currency";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(176, 151);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(91, 17);
            label12.TabIndex = 0;
            label12.Text = "Account Type";
            // 
            // cmbRootType
            // 
            cmbRootType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbRootType.DisplayMember = "SupplierGroupName";
            cmbRootType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRootType.Enabled = false;
            cmbRootType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbRootType.Items.AddRange(new object[] { "", "Expense", "Income", "Asset", "Liability", "Equity" });
            cmbRootType.Location = new System.Drawing.Point(813, 32);
            cmbRootType.Name = "cmbRootType";
            cmbRootType.Size = new System.Drawing.Size(265, 25);
            cmbRootType.TabIndex = 13;
            cmbRootType.ValueMember = "Name";
            // 
            // cmbReportType
            // 
            cmbReportType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbReportType.DisplayMember = "SupplierGroupName";
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Enabled = false;
            cmbReportType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbReportType.Items.AddRange(new object[] { "", "Balance Sheet", "Profit and Loss" });
            cmbReportType.Location = new System.Drawing.Point(813, 61);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new System.Drawing.Size(265, 25);
            cmbReportType.TabIndex = 13;
            cmbReportType.ValueMember = "Name";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTaxRate.DecimalPlaces = 2;
            txtTaxRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTaxRate.Location = new System.Drawing.Point(273, 178);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new System.Drawing.Size(264, 23);
            txtTaxRate.TabIndex = 14;
            txtTaxRate.ThemeName = "Windows8";
            txtTaxRate.Visible = false;
            // 
            // lblTaxRate
            // 
            lblTaxRate.Anchor = AnchorStyles.Right;
            lblTaxRate.AutoSize = true;
            lblTaxRate.Location = new System.Drawing.Point(207, 181);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new System.Drawing.Size(60, 17);
            lblTaxRate.TabIndex = 0;
            lblTaxRate.Text = "Tax Rate";
            lblTaxRate.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(1087, 230);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Details";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tpList);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1101, 521);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new System.Drawing.Size(1093, 491);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(200, 71);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1101, 521);
            panel3.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.ForeColor = System.Drawing.Color.Black;
            btnClose.Image = Properties.Resources.Delete_24;
            btnClose.Location = new System.Drawing.Point(3, 174);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(194, 36);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.ThemeName = "Windows8";
            btnClose.Click += btnClose_Click;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources.New_24;
            btnNew.Location = new System.Drawing.Point(3, 132);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(194, 36);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.ThemeName = "Windows8";
            btnNew.Click += btnNew_Click;
            // 
            // brnRefreshFields
            // 
            brnRefreshFields.Image = Properties.Resources.Refresh_24;
            brnRefreshFields.Location = new System.Drawing.Point(3, 90);
            brnRefreshFields.Name = "brnRefreshFields";
            brnRefreshFields.Size = new System.Drawing.Size(194, 36);
            brnRefreshFields.TabIndex = 4;
            brnRefreshFields.Text = "Refresh Fields";
            brnRefreshFields.ThemeName = "Windows8";
            brnRefreshFields.Click += brnRefreshFields_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.Save_24;
            btnSave.Location = new System.Drawing.Point(3, 48);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(194, 36);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.ThemeName = "Windows8";
            btnSave.Click += btnSave_Click;
            // 
            // btnCopyNameToClipboard
            // 
            btnCopyNameToClipboard.Image = Properties.Resources.Copy__2__24;
            btnCopyNameToClipboard.Name = "btnCopyNameToClipboard";
            btnCopyNameToClipboard.Text = "Copy To Clipboard";
            btnCopyNameToClipboard.UseCompatibleTextRendering = false;
            btnCopyNameToClipboard.Click += btnCopyNameToClipboard_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Image = Properties.Resources.Delete_File_24;
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseCompatibleTextRendering = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.Refresh_24;
            btnReload.Name = "btnReload";
            btnReload.Text = "Reload";
            btnReload.UseCompatibleTextRendering = false;
            btnReload.Click += btnReload_Click;
            // 
            // radDropDownButton1
            // 
            radDropDownButton1.Image = Properties.Resources.Configuration_24;
            radDropDownButton1.Items.AddRange(new Telerik.WinControls.RadItem[] { btnReload, btnDelete, btnCopyNameToClipboard });
            radDropDownButton1.Location = new System.Drawing.Point(3, 6);
            radDropDownButton1.Name = "radDropDownButton1";
            radDropDownButton1.Size = new System.Drawing.Size(194, 36);
            radDropDownButton1.TabIndex = 5;
            radDropDownButton1.Text = "Actions";
            radDropDownButton1.ThemeName = "Windows8";
            // 
            // panel2
            // 
            panel2.Controls.Add(radDropDownButton1);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(brnRefreshFields);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(200, 521);
            panel2.TabIndex = 4;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = System.Drawing.Color.White;
            lblID.Location = new System.Drawing.Point(162, 31);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(13, 15);
            lblID.TabIndex = 1;
            lblID.Text = "0";
            lblID.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 37);
            label1.TabIndex = 0;
            label1.Text = "Account";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1301, 71);
            panel1.TabIndex = 2;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1301, 592);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmAccount";
            Text = "Account";
            WindowState = FormWindowState.Maximized;
            KeyDown += frmAccount_KeyDown;
            ((System.ComponentModel.ISupportInitialize)txtLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNameFilter).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList).EndInit();
            groupBox2.ResumeLayout(false);
            tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtAccountNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCompany).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAccountName).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkDisabled).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbParentAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkIsGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkFrozen).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTaxRate).EndInit();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)brnRefreshFields).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.NumericUpDown txtLimit;
        private Telerik.WinControls.UI.RadTextBox txtNameFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnDisplay;
        private Telerik.WinControls.UI.RadGridView gvList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tpList;
        private Telerik.WinControls.UI.RadTextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadDropDownList cmbCompany;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadButton brnRefreshFields;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadMenuItem btnCopyNameToClipboard;
        private Telerik.WinControls.UI.RadMenuItem btnDelete;
        private Telerik.WinControls.UI.RadMenuItem btnReload;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txtAccountName;
        private Telerik.WinControls.UI.RadCheckBox chkDisabled;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadDropDownList cmbParentAccount;
        private Telerik.WinControls.UI.RadCheckBox chkIsGroup;
        private System.Windows.Forms.Label label10;
        private ComboBox cmbBalanceMustBe;
        private Telerik.WinControls.UI.RadCheckBox chkFrozen;
        private Telerik.WinControls.UI.RadDropDownList cmbCurrency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.ComboBox cmbRootType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private RadSpinEditor txtTaxRate;
        private System.Windows.Forms.Label lblTaxRate;
    }
}