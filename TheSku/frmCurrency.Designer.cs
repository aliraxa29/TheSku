﻿namespace TheSku
{
    partial class frmCurrency
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.BaseFormattingObject baseFormattingObject1 = new Telerik.WinControls.UI.BaseFormattingObject();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            txtLimit = new System.Windows.Forms.NumericUpDown();
            txtNameFilter = new Telerik.WinControls.UI.RadTextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnDisplay = new Telerik.WinControls.UI.RadButton();
            gvList = new Telerik.WinControls.UI.RadGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tpList = new System.Windows.Forms.TabPage();
            txtCurrencyName = new Telerik.WinControls.UI.RadTextBox();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            chkEnabled = new Telerik.WinControls.UI.RadCheckBox();
            txtFraction = new Telerik.WinControls.UI.RadTextBox();
            label6 = new System.Windows.Forms.Label();
            txtFractionUnits = new Telerik.WinControls.UI.RadTextBox();
            label7 = new System.Windows.Forms.Label();
            txtSmallestFractionValue = new Telerik.WinControls.UI.RadSpinEditor();
            label8 = new System.Windows.Forms.Label();
            txtSymbol = new Telerik.WinControls.UI.RadTextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            panel3 = new System.Windows.Forms.Panel();
            btnClose = new Telerik.WinControls.UI.RadButton();
            btnNew = new Telerik.WinControls.UI.RadButton();
            brnRefreshFields = new Telerik.WinControls.UI.RadButton();
            btnSave = new Telerik.WinControls.UI.RadButton();
            btnCopyNameToClipboard = new Telerik.WinControls.UI.RadMenuItem();
            btnDelete = new Telerik.WinControls.UI.RadMenuItem();
            btnReload = new Telerik.WinControls.UI.RadMenuItem();
            radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            panel2 = new System.Windows.Forms.Panel();
            lblID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)txtLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNameFilter).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).BeginInit();
            groupBox2.SuspendLayout();
            tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCurrencyName).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chkEnabled).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFraction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFractionUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSmallestFractionValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSymbol).BeginInit();
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
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1086, 89);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // btnDisplay
            // 
            btnDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDisplay.Location = new System.Drawing.Point(993, 47);
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
            gvList.Dock = System.Windows.Forms.DockStyle.Fill;
            gvList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            gvList.ForeColor = System.Drawing.SystemColors.ControlText;
            gvList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            gvList.Location = new System.Drawing.Point(3, 21);
            // 
            // 
            // 
            gvList.MasterTemplate.AllowAddNewRow = false;
            gvList.MasterTemplate.AllowColumnChooser = false;
            gvList.MasterTemplate.AllowDragToGroup = false;
            gvList.MasterTemplate.AllowRowResize = false;
            gvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CurrencyName";
            gridViewTextBoxColumn1.HeaderText = "Currency Name";
            gridViewTextBoxColumn1.Name = "currency_name";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 469;
            baseFormattingObject1.CellBackColor = System.Drawing.Color.Empty;
            baseFormattingObject1.CellForeColor = System.Drawing.Color.Empty;
            baseFormattingObject1.Name = "Enabled";
            baseFormattingObject1.RowBackColor = System.Drawing.Color.Empty;
            baseFormattingObject1.RowForeColor = System.Drawing.Color.Empty;
            gridViewTextBoxColumn2.ConditionalFormattingObjectList.Add(baseFormattingObject1);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Enabled";
            gridViewTextBoxColumn2.HeaderText = "Status";
            gridViewTextBoxColumn2.Name = "status";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 241;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.HeaderText = "Name";
            gridViewTextBoxColumn3.Name = "name";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 351;
            gvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3 });
            gvList.MasterTemplate.EnableFiltering = true;
            gvList.MasterTemplate.EnableGrouping = false;
            gvList.MasterTemplate.EnablePaging = true;
            gvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gvList.Name = "gvList";
            gvList.ReadOnly = true;
            gvList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            gvList.Size = new System.Drawing.Size(1080, 374);
            gvList.TabIndex = 0;
            gvList.ThemeName = "Windows8";
            gvList.CellFormatting += gvList_CellFormatting;
            gvList.CellDoubleClick += gvList_CellDoubleClick;
            gvList.KeyDown += gvList_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvList);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(3, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1086, 398);
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
            tpList.Padding = new System.Windows.Forms.Padding(3);
            tpList.Size = new System.Drawing.Size(1092, 493);
            tpList.TabIndex = 1;
            tpList.Text = "List";
            tpList.UseVisualStyleBackColor = true;
            // 
            // txtCurrencyName
            // 
            txtCurrencyName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCurrencyName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCurrencyName.Location = new System.Drawing.Point(273, 5);
            txtCurrencyName.Name = "txtCurrencyName";
            txtCurrencyName.Size = new System.Drawing.Size(264, 23);
            txtCurrencyName.TabIndex = 0;
            txtCurrencyName.ThemeName = "Windows8";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(165, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 17);
            label2.TabIndex = 0;
            label2.Text = "Currency Name";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(749, 8);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 17);
            label5.TabIndex = 0;
            label5.Text = "Fraction";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(chkEnabled, 1, 1);
            tableLayoutPanel1.Controls.Add(txtCurrencyName, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtFraction, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 1);
            tableLayoutPanel1.Controls.Add(txtFractionUnits, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 2);
            tableLayoutPanel1.Controls.Add(txtSmallestFractionValue, 3, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSymbol, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1080, 100);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chkEnabled.Location = new System.Drawing.Point(273, 40);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new System.Drawing.Size(63, 18);
            chkEnabled.TabIndex = 1;
            chkEnabled.Text = "Enabled";
            chkEnabled.ThemeName = "Windows8";
            // 
            // txtFraction
            // 
            txtFraction.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFraction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFraction.Location = new System.Drawing.Point(813, 5);
            txtFraction.Name = "txtFraction";
            txtFraction.Size = new System.Drawing.Size(264, 23);
            txtFraction.TabIndex = 3;
            txtFraction.ThemeName = "Windows8";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(713, 41);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 17);
            label6.TabIndex = 0;
            label6.Text = "Fraction Units";
            // 
            // txtFractionUnits
            // 
            txtFractionUnits.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFractionUnits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFractionUnits.Location = new System.Drawing.Point(813, 38);
            txtFractionUnits.Name = "txtFractionUnits";
            txtFractionUnits.Size = new System.Drawing.Size(264, 23);
            txtFractionUnits.TabIndex = 4;
            txtFractionUnits.ThemeName = "Windows8";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(597, 74);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(210, 17);
            label7.TabIndex = 0;
            label7.Text = "Smallest Currency Fraction Value";
            // 
            // txtSmallestFractionValue
            // 
            txtSmallestFractionValue.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSmallestFractionValue.DecimalPlaces = 3;
            txtSmallestFractionValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtSmallestFractionValue.Location = new System.Drawing.Point(813, 71);
            txtSmallestFractionValue.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            txtSmallestFractionValue.Name = "txtSmallestFractionValue";
            txtSmallestFractionValue.Size = new System.Drawing.Size(264, 23);
            txtSmallestFractionValue.TabIndex = 5;
            txtSmallestFractionValue.ThemeName = "Windows8";
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(213, 74);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(54, 17);
            label8.TabIndex = 0;
            label8.Text = "Symbol";
            // 
            // txtSymbol
            // 
            txtSymbol.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSymbol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSymbol.Location = new System.Drawing.Point(273, 71);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.Size = new System.Drawing.Size(264, 23);
            txtSymbol.TabIndex = 2;
            txtSymbol.ThemeName = "Windows8";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(1086, 126);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Details";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tpList);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1100, 523);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1092, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Currency";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(200, 71);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1100, 523);
            panel3.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.ForeColor = System.Drawing.Color.Black;
            btnClose.Image = Properties.Resources.Delete_24;
            btnClose.Location = new System.Drawing.Point(3, 174);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(194, 36);
            btnClose.TabIndex = 4;
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
            btnNew.TabIndex = 3;
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
            brnRefreshFields.TabIndex = 2;
            brnRefreshFields.Text = "Refresh Fields";
            brnRefreshFields.ThemeName = "Windows8";
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.Save_24;
            btnSave.Location = new System.Drawing.Point(3, 48);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(194, 36);
            btnSave.TabIndex = 1;
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
            radDropDownButton1.TabIndex = 0;
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
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(200, 523);
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
            label1.Size = new System.Drawing.Size(127, 37);
            label1.TabIndex = 0;
            label1.Text = "Currency";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1300, 71);
            panel1.TabIndex = 2;
            // 
            // frmCurrency
            // 
            ClientSize = new System.Drawing.Size(1300, 594);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmCurrency";
            Text = "Currency";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            KeyDown += frmCurrency_KeyDown;
            ((System.ComponentModel.ISupportInitialize)txtLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNameFilter).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList).EndInit();
            groupBox2.ResumeLayout(false);
            tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtCurrencyName).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chkEnabled).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFraction).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFractionUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSmallestFractionValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSymbol).EndInit();
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
        private Telerik.WinControls.UI.RadTextBox txtCurrencyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
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
        private Telerik.WinControls.UI.RadCheckBox chkEnabled;
        private Telerik.WinControls.UI.RadTextBox txtFraction;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txtFractionUnits;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadSpinEditor txtSmallestFractionValue;
        private System.Windows.Forms.Label label8;
        private Telerik.WinControls.UI.RadTextBox txtSymbol;
    }
}