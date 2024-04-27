using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TheSku
{
    partial class frmPos
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            GridViewTextBoxColumn gridViewTextBoxColumn58 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn59 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn60 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn61 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn62 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn63 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn64 = new GridViewTextBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn70 = new GridViewDecimalColumn();
            GridViewComboBoxColumn gridViewComboBoxColumn7 = new GridViewComboBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn71 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn72 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn73 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn74 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn75 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn76 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn77 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn78 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn79 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn80 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn81 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn82 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn83 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn84 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn85 = new GridViewDecimalColumn();
            GridViewComboBoxColumn gridViewComboBoxColumn8 = new GridViewComboBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn86 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn87 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn88 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn89 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn90 = new GridViewDecimalColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn65 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn66 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn67 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn68 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn69 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn70 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn71 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn72 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn73 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn74 = new GridViewTextBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn91 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn92 = new GridViewDecimalColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn75 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new GridViewCheckBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn76 = new GridViewTextBoxColumn();
            GridViewSummaryItem gridViewSummaryItem34 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem35 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem36 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem37 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem38 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem39 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem40 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem41 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem42 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem43 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem44 = new GridViewSummaryItem();
            TableViewDefinition tableViewDefinition4 = new TableViewDefinition();
            gvItemList = new DataGridView();
            item_name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            txtFilter = new RadTextBox();
            label1 = new Label();
            txtPatient = new RadTextBox();
            label3 = new Label();
            txtRemarks = new RadTextBox();
            label4 = new Label();
            txtAddress = new RadTextBox();
            label5 = new Label();
            gvSalesList = new RadGridView();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            chkStandardDiscount = new RadCheckBox();
            PrintDoc = new PrintDocument();
            lblHelp = new LinkLabel();
            radGroupBox1 = new RadGroupBox();
            label11 = new Label();
            label2 = new Label();
            txtExtraDiscount = new NumericUpDown();
            txtAdditionalDiscountAmount = new RadTextBox();
            txtGrandTotal = new RadTextBox();
            txtTotalTaxesAdded = new RadTextBox();
            txtDiscount = new RadTextBox();
            txtGrossTotal = new RadTextBox();
            label6 = new Label();
            radGroupBox2 = new RadGroupBox();
            btnSaveAsTemplate = new RadButton();
            lblPosProfile = new Label();
            radGroupBox3 = new RadGroupBox();
            cmbCustomer = new RadDropDownList();
            btnAddCustomer = new RadButton();
            radGroupBox4 = new RadGroupBox();
            btnSubmit = new RadButton();
            label7 = new Label();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            btnClose = new RadButton();
            ((ISupportInitialize)gvItemList).BeginInit();
            ((ISupportInitialize)txtFilter).BeginInit();
            ((ISupportInitialize)txtPatient).BeginInit();
            ((ISupportInitialize)txtRemarks).BeginInit();
            ((ISupportInitialize)txtAddress).BeginInit();
            ((ISupportInitialize)gvSalesList).BeginInit();
            ((ISupportInitialize)gvSalesList.MasterTemplate).BeginInit();
            ((ISupportInitialize)chkStandardDiscount).BeginInit();
            ((ISupportInitialize)radGroupBox1).BeginInit();
            radGroupBox1.SuspendLayout();
            ((ISupportInitialize)txtExtraDiscount).BeginInit();
            ((ISupportInitialize)txtAdditionalDiscountAmount).BeginInit();
            ((ISupportInitialize)txtGrandTotal).BeginInit();
            ((ISupportInitialize)txtTotalTaxesAdded).BeginInit();
            ((ISupportInitialize)txtDiscount).BeginInit();
            ((ISupportInitialize)txtGrossTotal).BeginInit();
            ((ISupportInitialize)radGroupBox2).BeginInit();
            radGroupBox2.SuspendLayout();
            ((ISupportInitialize)btnSaveAsTemplate).BeginInit();
            ((ISupportInitialize)radGroupBox3).BeginInit();
            radGroupBox3.SuspendLayout();
            ((ISupportInitialize)cmbCustomer).BeginInit();
            ((ISupportInitialize)btnAddCustomer).BeginInit();
            ((ISupportInitialize)radGroupBox4).BeginInit();
            radGroupBox4.SuspendLayout();
            ((ISupportInitialize)btnSubmit).BeginInit();
            ((ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // gvItemList
            // 
            gvItemList.AllowUserToAddRows = false;
            gvItemList.AllowUserToDeleteRows = false;
            gvItemList.AllowUserToResizeColumns = false;
            gvItemList.AllowUserToResizeRows = false;
            gvItemList.BackgroundColor = SystemColors.Control;
            gvItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvItemList.Columns.AddRange(new DataGridViewColumn[] { item_name, description, name });
            gvItemList.Location = new Point(10, 139);
            gvItemList.MultiSelect = false;
            gvItemList.Name = "gvItemList";
            gvItemList.ReadOnly = true;
            gvItemList.RowHeadersVisible = false;
            gvItemList.ScrollBars = ScrollBars.Vertical;
            gvItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvItemList.Size = new Size(389, 307);
            gvItemList.TabIndex = 0;
            gvItemList.CellDoubleClick += gvItemList_CellDoubleClick;
            gvItemList.KeyDown += gvItemList_KeyDown;
            // 
            // item_name
            // 
            item_name.DataPropertyName = "item_name";
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            item_name.DefaultCellStyle = dataGridViewCellStyle7;
            item_name.HeaderText = "Item Name";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            item_name.Width = 300;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.DefaultCellStyle = dataGridViewCellStyle8;
            description.HeaderText = "Print On Receipt";
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 150;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Visible = false;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(88, 116);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(311, 23);
            txtFilter.TabIndex = 0;
            txtFilter.ThemeName = "Windows8";
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyDown += txtFilter_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 119);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Search Item:";
            // 
            // txtPatient
            // 
            txtPatient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPatient.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPatient.Location = new Point(106, 28);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(287, 23);
            txtPatient.TabIndex = 10;
            txtPatient.ThemeName = "Windows8";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 31);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 2;
            label3.Text = "Patient Name:";
            // 
            // txtRemarks
            // 
            txtRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRemarks.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRemarks.Location = new Point(106, 60);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(287, 23);
            txtRemarks.TabIndex = 9;
            txtRemarks.ThemeName = "Windows8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 63);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 2;
            label4.Text = "Remarks:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(106, 92);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(287, 23);
            txtAddress.TabIndex = 8;
            txtAddress.ThemeName = "Windows8";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 95);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 2;
            label5.Text = "Address:";
            // 
            // gvSalesList
            // 
            gvSalesList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gvSalesList.BackColor = Color.FromArgb(191, 219, 255);
            gvSalesList.EnterKeyMode = RadGridViewEnterKeyMode.EnterMovesToNextRow;
            gvSalesList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            gvSalesList.ForeColor = Color.Black;
            gvSalesList.ImeMode = ImeMode.NoControl;
            gvSalesList.Location = new Point(413, 110);
            // 
            // 
            // 
            gvSalesList.MasterTemplate.AddNewRowPosition = SystemRowPosition.Bottom;
            gvSalesList.MasterTemplate.AllowAddNewRow = false;
            gvSalesList.MasterTemplate.AllowCellContextMenu = false;
            gvSalesList.MasterTemplate.AllowColumnChooser = false;
            gvSalesList.MasterTemplate.AllowDragToGroup = false;
            gvSalesList.MasterTemplate.AllowRowResize = false;
            gvSalesList.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn58.EnableExpressionEditor = false;
            gridViewTextBoxColumn58.HeaderText = "Sr. No.";
            gridViewTextBoxColumn58.Name = "srno";
            gridViewTextBoxColumn58.ReadOnly = true;
            gridViewTextBoxColumn58.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn58.Width = 48;
            gridViewTextBoxColumn59.EnableExpressionEditor = false;
            gridViewTextBoxColumn59.HeaderText = "Item Code";
            gridViewTextBoxColumn59.IsVisible = false;
            gridViewTextBoxColumn59.Name = "item_code";
            gridViewTextBoxColumn59.ReadOnly = true;
            gridViewTextBoxColumn59.Width = 87;
            gridViewTextBoxColumn60.EnableExpressionEditor = false;
            gridViewTextBoxColumn60.HeaderText = "Barcode";
            gridViewTextBoxColumn60.IsVisible = false;
            gridViewTextBoxColumn60.Name = "barcode";
            gridViewTextBoxColumn60.ReadOnly = true;
            gridViewTextBoxColumn60.Width = 46;
            gridViewTextBoxColumn61.EnableExpressionEditor = false;
            gridViewTextBoxColumn61.HeaderText = "Item Name";
            gridViewTextBoxColumn61.Name = "item_name";
            gridViewTextBoxColumn61.ReadOnly = true;
            gridViewTextBoxColumn61.Width = 188;
            gridViewTextBoxColumn62.EnableExpressionEditor = false;
            gridViewTextBoxColumn62.HeaderText = "Description";
            gridViewTextBoxColumn62.IsVisible = false;
            gridViewTextBoxColumn62.Name = "description";
            gridViewTextBoxColumn62.ReadOnly = true;
            gridViewTextBoxColumn62.Width = 88;
            gridViewTextBoxColumn63.EnableExpressionEditor = false;
            gridViewTextBoxColumn63.HeaderText = "Packing Type";
            gridViewTextBoxColumn63.IsVisible = false;
            gridViewTextBoxColumn63.Name = "packing_type";
            gridViewTextBoxColumn63.ReadOnly = true;
            gridViewTextBoxColumn63.Width = 100;
            gridViewTextBoxColumn64.EnableExpressionEditor = false;
            gridViewTextBoxColumn64.HeaderText = "Packing";
            gridViewTextBoxColumn64.IsVisible = false;
            gridViewTextBoxColumn64.Name = "packing";
            gridViewTextBoxColumn64.ReadOnly = true;
            gridViewTextBoxColumn64.Width = 61;
            gridViewDecimalColumn70.DecimalPlaces = 0;
            gridViewDecimalColumn70.EnableExpressionEditor = false;
            gridViewDecimalColumn70.HeaderText = "Qty";
            gridViewDecimalColumn70.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn70.Name = "qty";
            gridViewDecimalColumn70.ShowUpDownButtons = false;
            gridViewDecimalColumn70.Step = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn70.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewComboBoxColumn7.DisplayMember = "uom";
            gridViewComboBoxColumn7.EnableExpressionEditor = false;
            gridViewComboBoxColumn7.HeaderText = "UOM";
            gridViewComboBoxColumn7.Name = "uom";
            gridViewComboBoxColumn7.ValueMember = "uom";
            gridViewComboBoxColumn7.VisibleInColumnChooser = false;
            gridViewComboBoxColumn7.Width = 77;
            gridViewDecimalColumn71.EnableExpressionEditor = false;
            gridViewDecimalColumn71.HeaderText = "Conv. Factor";
            gridViewDecimalColumn71.Name = "conversion_factor";
            gridViewDecimalColumn71.ReadOnly = true;
            gridViewDecimalColumn71.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn71.Width = 85;
            gridViewDecimalColumn72.EnableExpressionEditor = false;
            gridViewDecimalColumn72.HeaderText = "Buying Rate";
            gridViewDecimalColumn72.Name = "buying_rate";
            gridViewDecimalColumn72.ReadOnly = true;
            gridViewDecimalColumn72.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn72.Width = 86;
            gridViewDecimalColumn73.EnableExpressionEditor = false;
            gridViewDecimalColumn73.FormatString = "{0:0.00}";
            gridViewDecimalColumn73.HeaderText = "Price";
            gridViewDecimalColumn73.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn73.Name = "price_list_rate";
            gridViewDecimalColumn73.ShowUpDownButtons = false;
            gridViewDecimalColumn73.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewDecimalColumn73.Width = 83;
            gridViewDecimalColumn74.EnableExpressionEditor = false;
            gridViewDecimalColumn74.FormatString = "{0:0.00}";
            gridViewDecimalColumn74.HeaderText = "Base Price";
            gridViewDecimalColumn74.IsVisible = false;
            gridViewDecimalColumn74.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn74.Name = "base_price_list_rate";
            gridViewDecimalColumn74.ReadOnly = true;
            gridViewDecimalColumn74.Width = 49;
            gridViewDecimalColumn75.EnableExpressionEditor = false;
            gridViewDecimalColumn75.HeaderText = "Qty As Per Stock UOM";
            gridViewDecimalColumn75.IsVisible = false;
            gridViewDecimalColumn75.Name = "stock_qty";
            gridViewDecimalColumn75.ReadOnly = true;
            gridViewDecimalColumn76.EnableExpressionEditor = false;
            gridViewDecimalColumn76.HeaderText = "Total";
            gridViewDecimalColumn76.Name = "total";
            gridViewDecimalColumn76.ReadOnly = true;
            gridViewDecimalColumn76.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn76.Width = 77;
            gridViewDecimalColumn77.EnableExpressionEditor = false;
            gridViewDecimalColumn77.HeaderText = "Base Total";
            gridViewDecimalColumn77.IsVisible = false;
            gridViewDecimalColumn77.Name = "base_total";
            gridViewDecimalColumn77.ReadOnly = true;
            gridViewDecimalColumn77.VisibleInColumnChooser = false;
            gridViewDecimalColumn78.EnableExpressionEditor = false;
            gridViewDecimalColumn78.HeaderText = "Disc %";
            gridViewDecimalColumn78.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn78.Name = "discount_percentage";
            gridViewDecimalColumn78.ShowUpDownButtons = false;
            gridViewDecimalColumn78.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewDecimalColumn78.Width = 55;
            gridViewDecimalColumn79.EnableExpressionEditor = false;
            gridViewDecimalColumn79.FormatString = "{0:0.00}";
            gridViewDecimalColumn79.HeaderText = "Disc Amount";
            gridViewDecimalColumn79.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn79.Name = "discount_amount";
            gridViewDecimalColumn79.ReadOnly = true;
            gridViewDecimalColumn79.ShowUpDownButtons = false;
            gridViewDecimalColumn79.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn79.Width = 94;
            gridViewDecimalColumn80.EnableExpressionEditor = false;
            gridViewDecimalColumn80.HeaderText = "Base Discount Percentage";
            gridViewDecimalColumn80.IsVisible = false;
            gridViewDecimalColumn80.Name = "base_discount_percentage";
            gridViewDecimalColumn80.ReadOnly = true;
            gridViewDecimalColumn80.VisibleInColumnChooser = false;
            gridViewDecimalColumn80.Width = 40;
            gridViewDecimalColumn81.EnableExpressionEditor = false;
            gridViewDecimalColumn81.FormatString = "{0:0.00}";
            gridViewDecimalColumn81.HeaderText = "Rate";
            gridViewDecimalColumn81.Name = "rate";
            gridViewDecimalColumn81.ReadOnly = true;
            gridViewDecimalColumn81.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn81.Width = 72;
            gridViewDecimalColumn82.EnableExpressionEditor = false;
            gridViewDecimalColumn82.FormatString = "{0:0.00}";
            gridViewDecimalColumn82.HeaderText = "Amount";
            gridViewDecimalColumn82.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn82.Name = "amount";
            gridViewDecimalColumn82.ReadOnly = true;
            gridViewDecimalColumn82.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn82.Width = 89;
            gridViewDecimalColumn83.EnableExpressionEditor = false;
            gridViewDecimalColumn83.HeaderText = "Base Rate";
            gridViewDecimalColumn83.IsVisible = false;
            gridViewDecimalColumn83.Name = "base_rate";
            gridViewDecimalColumn83.ReadOnly = true;
            gridViewDecimalColumn83.VisibleInColumnChooser = false;
            gridViewDecimalColumn83.Width = 42;
            gridViewDecimalColumn84.EnableExpressionEditor = false;
            gridViewDecimalColumn84.HeaderText = "Base Amount";
            gridViewDecimalColumn84.IsVisible = false;
            gridViewDecimalColumn84.Name = "base_amount";
            gridViewDecimalColumn84.ReadOnly = true;
            gridViewDecimalColumn84.VisibleInColumnChooser = false;
            gridViewDecimalColumn84.Width = 49;
            gridViewDecimalColumn85.EnableExpressionEditor = false;
            gridViewDecimalColumn85.HeaderText = "Stock UOM Rate";
            gridViewDecimalColumn85.IsVisible = false;
            gridViewDecimalColumn85.Name = "stock_uom_rate";
            gridViewDecimalColumn85.ReadOnly = true;
            gridViewComboBoxColumn8.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gridViewComboBoxColumn8.DisplayMember = "title";
            gridViewComboBoxColumn8.DropDownStyle = RadDropDownStyle.DropDown;
            gridViewComboBoxColumn8.EnableExpressionEditor = false;
            gridViewComboBoxColumn8.HeaderText = "Item Tax Template";
            gridViewComboBoxColumn8.Name = "item_tax_template";
            gridViewComboBoxColumn8.ValueMember = "name";
            gridViewComboBoxColumn8.Width = 137;
            gridViewDecimalColumn86.EnableExpressionEditor = false;
            gridViewDecimalColumn86.FormatString = "{0:0.00}";
            gridViewDecimalColumn86.HeaderText = "Tax Amount";
            gridViewDecimalColumn86.Name = "tax_amount";
            gridViewDecimalColumn86.ReadOnly = true;
            gridViewDecimalColumn86.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn86.Width = 84;
            gridViewDecimalColumn87.EnableExpressionEditor = false;
            gridViewDecimalColumn87.FormatString = "{0:0.00}";
            gridViewDecimalColumn87.HeaderText = "Net Rate";
            gridViewDecimalColumn87.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn87.Name = "net_rate";
            gridViewDecimalColumn87.ReadOnly = true;
            gridViewDecimalColumn87.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn87.Width = 90;
            gridViewDecimalColumn88.EnableExpressionEditor = false;
            gridViewDecimalColumn88.FormatString = "{0:0.0000}";
            gridViewDecimalColumn88.HeaderText = "Net Amount";
            gridViewDecimalColumn88.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn88.Name = "net_amount";
            gridViewDecimalColumn88.ReadOnly = true;
            gridViewDecimalColumn88.Width = 111;
            gridViewDecimalColumn89.EnableExpressionEditor = false;
            gridViewDecimalColumn89.HeaderText = "Base Net Rate";
            gridViewDecimalColumn89.IsVisible = false;
            gridViewDecimalColumn89.Name = "base_net_rate";
            gridViewDecimalColumn89.ReadOnly = true;
            gridViewDecimalColumn89.VisibleInColumnChooser = false;
            gridViewDecimalColumn89.Width = 45;
            gridViewDecimalColumn90.EnableExpressionEditor = false;
            gridViewDecimalColumn90.HeaderText = "Base Net Amount";
            gridViewDecimalColumn90.IsVisible = false;
            gridViewDecimalColumn90.Name = "base_net_amount";
            gridViewDecimalColumn90.ReadOnly = true;
            gridViewDecimalColumn90.VisibleInColumnChooser = false;
            gridViewTextBoxColumn65.EnableExpressionEditor = false;
            gridViewTextBoxColumn65.HeaderText = "Rack Location";
            gridViewTextBoxColumn65.IsVisible = false;
            gridViewTextBoxColumn65.Name = "rack_location";
            gridViewTextBoxColumn65.ReadOnly = true;
            gridViewTextBoxColumn65.VisibleInColumnChooser = false;
            gridViewTextBoxColumn66.EnableExpressionEditor = false;
            gridViewTextBoxColumn66.HeaderText = "Doctor Name";
            gridViewTextBoxColumn66.IsVisible = false;
            gridViewTextBoxColumn66.Name = "doctor_name";
            gridViewTextBoxColumn66.ReadOnly = true;
            gridViewTextBoxColumn66.VisibleInColumnChooser = false;
            gridViewTextBoxColumn67.EnableExpressionEditor = false;
            gridViewTextBoxColumn67.HeaderText = "Is Non Returnable";
            gridViewTextBoxColumn67.IsVisible = false;
            gridViewTextBoxColumn67.Name = "is_non_returnable";
            gridViewTextBoxColumn67.ReadOnly = true;
            gridViewTextBoxColumn67.VisibleInColumnChooser = false;
            gridViewTextBoxColumn68.EnableExpressionEditor = false;
            gridViewTextBoxColumn68.HeaderText = "Is Fridge";
            gridViewTextBoxColumn68.IsVisible = false;
            gridViewTextBoxColumn68.Name = "is_fridge_item";
            gridViewTextBoxColumn68.ReadOnly = true;
            gridViewTextBoxColumn69.EnableExpressionEditor = false;
            gridViewTextBoxColumn69.HeaderText = "Disabled";
            gridViewTextBoxColumn69.IsVisible = false;
            gridViewTextBoxColumn69.Name = "disabled";
            gridViewTextBoxColumn69.ReadOnly = true;
            gridViewTextBoxColumn69.VisibleInColumnChooser = false;
            gridViewTextBoxColumn70.EnableExpressionEditor = false;
            gridViewTextBoxColumn70.HeaderText = "Is Narcotic";
            gridViewTextBoxColumn70.IsVisible = false;
            gridViewTextBoxColumn70.Name = "is_narcotic";
            gridViewTextBoxColumn70.ReadOnly = true;
            gridViewTextBoxColumn70.VisibleInColumnChooser = false;
            gridViewTextBoxColumn71.EnableExpressionEditor = false;
            gridViewTextBoxColumn71.HeaderText = "column1";
            gridViewTextBoxColumn71.IsVisible = false;
            gridViewTextBoxColumn71.Name = "is_expiry_item";
            gridViewTextBoxColumn71.ReadOnly = true;
            gridViewTextBoxColumn71.VisibleInColumnChooser = false;
            gridViewTextBoxColumn72.EnableExpressionEditor = false;
            gridViewTextBoxColumn72.HeaderText = "Brand";
            gridViewTextBoxColumn72.IsVisible = false;
            gridViewTextBoxColumn72.Name = "brand";
            gridViewTextBoxColumn72.ReadOnly = true;
            gridViewTextBoxColumn72.VisibleInColumnChooser = false;
            gridViewTextBoxColumn73.EnableExpressionEditor = false;
            gridViewTextBoxColumn73.HeaderText = "Item Group";
            gridViewTextBoxColumn73.IsVisible = false;
            gridViewTextBoxColumn73.Name = "item_group";
            gridViewTextBoxColumn73.ReadOnly = true;
            gridViewTextBoxColumn73.VisibleInColumnChooser = false;
            gridViewTextBoxColumn74.EnableExpressionEditor = false;
            gridViewTextBoxColumn74.HeaderText = "Is Lock Disc";
            gridViewTextBoxColumn74.IsVisible = false;
            gridViewTextBoxColumn74.Name = "is_lock_discount";
            gridViewTextBoxColumn74.ReadOnly = true;
            gridViewTextBoxColumn74.VisibleInColumnChooser = false;
            gridViewDecimalColumn91.EnableExpressionEditor = false;
            gridViewDecimalColumn91.HeaderText = "Unit Price List Rate";
            gridViewDecimalColumn91.IsVisible = false;
            gridViewDecimalColumn91.Name = "unit_price_list_rate";
            gridViewDecimalColumn91.ReadOnly = true;
            gridViewDecimalColumn92.EnableExpressionEditor = false;
            gridViewDecimalColumn92.HeaderText = "Base Unit Price List Rate";
            gridViewDecimalColumn92.IsVisible = false;
            gridViewDecimalColumn92.Name = "base_unit_price_list_rate";
            gridViewTextBoxColumn75.EnableExpressionEditor = false;
            gridViewTextBoxColumn75.HeaderText = "Stock UOM";
            gridViewTextBoxColumn75.IsVisible = false;
            gridViewTextBoxColumn75.Name = "stock_uom";
            gridViewTextBoxColumn75.ReadOnly = true;
            gridViewCheckBoxColumn4.EnableExpressionEditor = false;
            gridViewCheckBoxColumn4.HeaderText = "Is Rule Applied";
            gridViewCheckBoxColumn4.IsVisible = false;
            gridViewCheckBoxColumn4.MinWidth = 20;
            gridViewCheckBoxColumn4.Name = "is_pricing_rule_applied";
            gridViewCheckBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn76.EnableExpressionEditor = false;
            gridViewTextBoxColumn76.HeaderText = "Rule Name";
            gridViewTextBoxColumn76.IsVisible = false;
            gridViewTextBoxColumn76.Name = "pricing_rule_name";
            gridViewTextBoxColumn76.ReadOnly = true;
            gvSalesList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn58, gridViewTextBoxColumn59, gridViewTextBoxColumn60, gridViewTextBoxColumn61, gridViewTextBoxColumn62, gridViewTextBoxColumn63, gridViewTextBoxColumn64, gridViewDecimalColumn70, gridViewComboBoxColumn7, gridViewDecimalColumn71, gridViewDecimalColumn72, gridViewDecimalColumn73, gridViewDecimalColumn74, gridViewDecimalColumn75, gridViewDecimalColumn76, gridViewDecimalColumn77, gridViewDecimalColumn78, gridViewDecimalColumn79, gridViewDecimalColumn80, gridViewDecimalColumn81, gridViewDecimalColumn82, gridViewDecimalColumn83, gridViewDecimalColumn84, gridViewDecimalColumn85, gridViewComboBoxColumn8, gridViewDecimalColumn86, gridViewDecimalColumn87, gridViewDecimalColumn88, gridViewDecimalColumn89, gridViewDecimalColumn90, gridViewTextBoxColumn65, gridViewTextBoxColumn66, gridViewTextBoxColumn67, gridViewTextBoxColumn68, gridViewTextBoxColumn69, gridViewTextBoxColumn70, gridViewTextBoxColumn71, gridViewTextBoxColumn72, gridViewTextBoxColumn73, gridViewTextBoxColumn74, gridViewDecimalColumn91, gridViewDecimalColumn92, gridViewTextBoxColumn75, gridViewCheckBoxColumn4, gridViewTextBoxColumn76 });
            gvSalesList.MasterTemplate.EnableAlternatingRowColor = true;
            gvSalesList.MasterTemplate.EnableGrouping = false;
            gvSalesList.MasterTemplate.EnableSorting = false;
            gridViewSummaryItem34.Aggregate = GridAggregateFunction.Count;
            gridViewSummaryItem34.AggregateExpression = null;
            gridViewSummaryItem34.FormatString = "Total Items = {0}";
            gridViewSummaryItem34.Name = "item_name";
            gridViewSummaryItem35.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem35.AggregateExpression = null;
            gridViewSummaryItem35.FormatString = "{0}";
            gridViewSummaryItem35.Name = "qty";
            gridViewSummaryItem36.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem36.AggregateExpression = null;
            gridViewSummaryItem36.FormatString = "{0:0.00}";
            gridViewSummaryItem36.Name = "price_list_rate";
            gridViewSummaryItem37.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem37.AggregateExpression = null;
            gridViewSummaryItem37.FormatString = "{0:0.00}";
            gridViewSummaryItem37.Name = "discount_amount";
            gridViewSummaryItem38.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem38.AggregateExpression = null;
            gridViewSummaryItem38.FormatString = "{0:0.00}";
            gridViewSummaryItem38.Name = "rate";
            gridViewSummaryItem39.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem39.AggregateExpression = null;
            gridViewSummaryItem39.FormatString = "{0:0.00}";
            gridViewSummaryItem39.Name = "amount";
            gridViewSummaryItem40.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem40.AggregateExpression = null;
            gridViewSummaryItem40.FormatString = "{0:0.00}";
            gridViewSummaryItem40.Name = "net_rate";
            gridViewSummaryItem41.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem41.AggregateExpression = null;
            gridViewSummaryItem41.FormatString = "{0:0.00}";
            gridViewSummaryItem41.Name = "net_amount";
            gridViewSummaryItem42.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem42.AggregateExpression = null;
            gridViewSummaryItem42.FormatString = "{0:0.00}";
            gridViewSummaryItem42.Name = "total";
            gridViewSummaryItem43.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem43.AggregateExpression = null;
            gridViewSummaryItem43.FormatString = "{0:0.00}";
            gridViewSummaryItem43.Name = "buying_rate";
            gridViewSummaryItem44.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem44.AggregateExpression = null;
            gridViewSummaryItem44.FormatString = "{0:0.00}";
            gridViewSummaryItem44.Name = "tax_amount";
            gvSalesList.MasterTemplate.SummaryRowsTop.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { gridViewSummaryItem34, gridViewSummaryItem35, gridViewSummaryItem36, gridViewSummaryItem37, gridViewSummaryItem38, gridViewSummaryItem39, gridViewSummaryItem40, gridViewSummaryItem41, gridViewSummaryItem42, gridViewSummaryItem43, gridViewSummaryItem44 }));
            gvSalesList.MasterTemplate.ViewDefinition = tableViewDefinition4;
            gvSalesList.Name = "gvSalesList";
            gvSalesList.RightToLeft = RightToLeft.No;
            gvSalesList.Size = new Size(947, 382);
            gvSalesList.TabIndex = 1;
            gvSalesList.ThemeName = "Windows8";
            gvSalesList.CellFormatting += gvSalesList_CellFormatting;
            gvSalesList.CellBeginEdit += gvSalesList_CellBeginEdit;
            gvSalesList.CellEditorInitialized += gvSalesList_CellEditorInitialized;
            gvSalesList.UserDeletedRow += gvSalesList_UserDeletedRow;
            gvSalesList.CellValueChanged += gvSalesList_CellValueChanged;
            gvSalesList.KeyDown += gvSalesList_KeyDown;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(657, 23);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 6;
            label8.Text = "Gross Total";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.Location = new Point(676, 62);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 6;
            label9.Text = "Discount";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label10.Location = new Point(651, 142);
            label10.Name = "label10";
            label10.Size = new Size(116, 25);
            label10.TabIndex = 6;
            label10.Text = "Grand Total";
            // 
            // chkStandardDiscount
            // 
            chkStandardDiscount.CheckState = CheckState.Checked;
            chkStandardDiscount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkStandardDiscount.Location = new Point(4, 66);
            chkStandardDiscount.Name = "chkStandardDiscount";
            chkStandardDiscount.Size = new Size(178, 21);
            chkStandardDiscount.TabIndex = 3;
            chkStandardDiscount.Text = "Apply Standard Discount";
            chkStandardDiscount.ThemeName = "ControlDefault";
            chkStandardDiscount.ToggleState = ToggleState.On;
            chkStandardDiscount.ToggleStateChanged += chkStandardDiscount_ToggleStateChanged;
            // 
            // PrintDoc
            // 
            PrintDoc.PrintPage += PrintDoc_PrintPage;
            // 
            // lblHelp
            // 
            lblHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHelp.AutoSize = true;
            lblHelp.Location = new Point(66, 158);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(32, 15);
            lblHelp.TabIndex = 10;
            lblHelp.TabStop = true;
            lblHelp.Text = "Help";
            lblHelp.LinkClicked += lblHelp_LinkClicked;
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radGroupBox1.Controls.Add(btnClose);
            radGroupBox1.Controls.Add(label11);
            radGroupBox1.Controls.Add(label2);
            radGroupBox1.Controls.Add(txtExtraDiscount);
            radGroupBox1.Controls.Add(lblHelp);
            radGroupBox1.Controls.Add(txtAdditionalDiscountAmount);
            radGroupBox1.Controls.Add(txtGrandTotal);
            radGroupBox1.Controls.Add(txtTotalTaxesAdded);
            radGroupBox1.Controls.Add(txtDiscount);
            radGroupBox1.Controls.Add(txtGrossTotal);
            radGroupBox1.Controls.Add(label8);
            radGroupBox1.Controls.Add(label6);
            radGroupBox1.Controls.Add(label10);
            radGroupBox1.Controls.Add(label9);
            radGroupBox1.HeaderMargin = new Padding(1);
            radGroupBox1.HeaderText = "Totals";
            radGroupBox1.Location = new Point(413, 498);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new Size(947, 178);
            radGroupBox1.TabIndex = 11;
            radGroupBox1.Text = "Totals";
            radGroupBox1.ThemeName = "Windows8";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(4, 71);
            label11.Name = "label11";
            label11.Size = new Size(186, 17);
            label11.TabIndex = 12;
            label11.Text = "Additional Discount Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 20);
            label2.Name = "label2";
            label2.Size = new Size(157, 17);
            label2.TabIndex = 12;
            label2.Text = "Additional Discount (%)";
            // 
            // txtExtraDiscount
            // 
            txtExtraDiscount.DecimalPlaces = 2;
            txtExtraDiscount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExtraDiscount.Location = new Point(4, 42);
            txtExtraDiscount.Name = "txtExtraDiscount";
            txtExtraDiscount.Size = new Size(131, 25);
            txtExtraDiscount.TabIndex = 11;
            txtExtraDiscount.ValueChanged += txtExtraDiscount_ValueChanged;
            // 
            // txtAdditionalDiscountAmount
            // 
            txtAdditionalDiscountAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtAdditionalDiscountAmount.Location = new Point(4, 93);
            txtAdditionalDiscountAmount.Name = "txtAdditionalDiscountAmount";
            txtAdditionalDiscountAmount.ReadOnly = true;
            txtAdditionalDiscountAmount.Size = new Size(131, 23);
            txtAdditionalDiscountAmount.TabIndex = 2;
            txtAdditionalDiscountAmount.Text = "0.00";
            txtAdditionalDiscountAmount.ThemeName = "Windows8";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtGrandTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtGrandTotal.Location = new Point(773, 139);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(169, 31);
            txtGrandTotal.TabIndex = 2;
            txtGrandTotal.Text = "0.00";
            txtGrandTotal.ThemeName = "Windows8";
            // 
            // txtTotalTaxesAdded
            // 
            txtTotalTaxesAdded.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotalTaxesAdded.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtTotalTaxesAdded.Location = new Point(773, 100);
            txtTotalTaxesAdded.Name = "txtTotalTaxesAdded";
            txtTotalTaxesAdded.ReadOnly = true;
            txtTotalTaxesAdded.Size = new Size(169, 31);
            txtTotalTaxesAdded.TabIndex = 2;
            txtTotalTaxesAdded.Text = "0.00";
            txtTotalTaxesAdded.ThemeName = "Windows8";
            // 
            // txtDiscount
            // 
            txtDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtDiscount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtDiscount.Location = new Point(773, 60);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(169, 31);
            txtDiscount.TabIndex = 2;
            txtDiscount.Text = "0.00";
            txtDiscount.ThemeName = "Windows8";
            // 
            // txtGrossTotal
            // 
            txtGrossTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtGrossTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtGrossTotal.Location = new Point(773, 21);
            txtGrossTotal.Name = "txtGrossTotal";
            txtGrossTotal.ReadOnly = true;
            txtGrossTotal.Size = new Size(169, 31);
            txtGrossTotal.TabIndex = 2;
            txtGrossTotal.Text = "0.00";
            txtGrossTotal.ThemeName = "Windows8";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(595, 102);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 6;
            label6.Text = "Total Taxes Added";
            // 
            // radGroupBox2
            // 
            radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radGroupBox2.Controls.Add(btnSaveAsTemplate);
            radGroupBox2.Controls.Add(label3);
            radGroupBox2.Controls.Add(txtPatient);
            radGroupBox2.Controls.Add(txtRemarks);
            radGroupBox2.Controls.Add(txtAddress);
            radGroupBox2.Controls.Add(label4);
            radGroupBox2.Controls.Add(label5);
            radGroupBox2.HeaderMargin = new Padding(1);
            radGroupBox2.HeaderText = "Other Info";
            radGroupBox2.Location = new Point(10, 498);
            radGroupBox2.Name = "radGroupBox2";
            radGroupBox2.Size = new Size(398, 179);
            radGroupBox2.TabIndex = 12;
            radGroupBox2.Text = "Other Info";
            radGroupBox2.ThemeName = "Windows8";
            // 
            // btnSaveAsTemplate
            // 
            btnSaveAsTemplate.Location = new Point(290, 125);
            btnSaveAsTemplate.Name = "btnSaveAsTemplate";
            btnSaveAsTemplate.Size = new Size(103, 24);
            btnSaveAsTemplate.TabIndex = 11;
            btnSaveAsTemplate.Text = "Save as Template";
            btnSaveAsTemplate.ThemeName = "Windows8";
            // 
            // lblPosProfile
            // 
            lblPosProfile.AutoSize = true;
            lblPosProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosProfile.ForeColor = Color.DarkGreen;
            lblPosProfile.Location = new Point(126, 30);
            lblPosProfile.Name = "lblPosProfile";
            lblPosProfile.Size = new Size(30, 21);
            lblPosProfile.TabIndex = 2;
            lblPosProfile.Text = "PP";
            // 
            // radGroupBox3
            // 
            radGroupBox3.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox3.Controls.Add(cmbCustomer);
            radGroupBox3.Controls.Add(btnAddCustomer);
            radGroupBox3.HeaderMargin = new Padding(1);
            radGroupBox3.HeaderText = "Customer";
            radGroupBox3.Location = new Point(10, 10);
            radGroupBox3.Name = "radGroupBox3";
            radGroupBox3.Size = new Size(389, 93);
            radGroupBox3.TabIndex = 1;
            radGroupBox3.Text = "Customer";
            radGroupBox3.ThemeName = "Windows8";
            // 
            // cmbCustomer
            // 
            cmbCustomer.AllowDrop = true;
            cmbCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCustomer.DropDownAnimationEnabled = true;
            cmbCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCustomer.Location = new Point(7, 36);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(278, 31);
            cmbCustomer.TabIndex = 1;
            cmbCustomer.ThemeName = "Windows8";
            cmbCustomer.TextChanged += cmbCustomer_TextChanged;
            cmbCustomer.KeyDown += cmbCustomer_KeyDown;
            cmbCustomer.Enter += cmbCustomer_Enter;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCustomer.Location = new Point(290, 35);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(94, 33);
            btnAddCustomer.TabIndex = 5;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCustomer.ThemeName = "Windows8";
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // radGroupBox4
            // 
            radGroupBox4.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radGroupBox4.Controls.Add(chkStandardDiscount);
            radGroupBox4.Controls.Add(btnSubmit);
            radGroupBox4.Controls.Add(label7);
            radGroupBox4.Controls.Add(lblPosProfile);
            radGroupBox4.HeaderMargin = new Padding(1);
            radGroupBox4.HeaderText = "POS";
            radGroupBox4.Location = new Point(413, 10);
            radGroupBox4.Name = "radGroupBox4";
            radGroupBox4.Size = new Size(947, 93);
            radGroupBox4.TabIndex = 13;
            radGroupBox4.Text = "POS";
            radGroupBox4.ThemeName = "Windows8";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubmit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(807, 36);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(136, 53);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit Sale";
            btnSubmit.ThemeName = "Windows8";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(4, 30);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 2;
            label7.Text = "POS Terminal:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(5, 125);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 48);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.ThemeName = "Windows8";
            btnClose.Click += btnClose_Click;
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1370, 689);
            Controls.Add(radGroupBox4);
            Controls.Add(radGroupBox2);
            Controls.Add(radGroupBox1);
            Controls.Add(gvSalesList);
            Controls.Add(radGroupBox3);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(gvItemList);
            KeyPreview = true;
            Name = "frmPos";
            Text = "Point Of Sale";
            WindowState = FormWindowState.Maximized;
            KeyDown += frmSale_KeyDown;
            ((ISupportInitialize)gvItemList).EndInit();
            ((ISupportInitialize)txtFilter).EndInit();
            ((ISupportInitialize)txtPatient).EndInit();
            ((ISupportInitialize)txtRemarks).EndInit();
            ((ISupportInitialize)txtAddress).EndInit();
            ((ISupportInitialize)gvSalesList.MasterTemplate).EndInit();
            ((ISupportInitialize)gvSalesList).EndInit();
            ((ISupportInitialize)chkStandardDiscount).EndInit();
            ((ISupportInitialize)radGroupBox1).EndInit();
            radGroupBox1.ResumeLayout(false);
            radGroupBox1.PerformLayout();
            ((ISupportInitialize)txtExtraDiscount).EndInit();
            ((ISupportInitialize)txtAdditionalDiscountAmount).EndInit();
            ((ISupportInitialize)txtGrandTotal).EndInit();
            ((ISupportInitialize)txtTotalTaxesAdded).EndInit();
            ((ISupportInitialize)txtDiscount).EndInit();
            ((ISupportInitialize)txtGrossTotal).EndInit();
            ((ISupportInitialize)radGroupBox2).EndInit();
            radGroupBox2.ResumeLayout(false);
            radGroupBox2.PerformLayout();
            ((ISupportInitialize)btnSaveAsTemplate).EndInit();
            ((ISupportInitialize)radGroupBox3).EndInit();
            radGroupBox3.ResumeLayout(false);
            radGroupBox3.PerformLayout();
            ((ISupportInitialize)cmbCustomer).EndInit();
            ((ISupportInitialize)btnAddCustomer).EndInit();
            ((ISupportInitialize)radGroupBox4).EndInit();
            radGroupBox4.ResumeLayout(false);
            radGroupBox4.PerformLayout();
            ((ISupportInitialize)btnSubmit).EndInit();
            ((ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvItemList;

        private RadTextBox txtFilter;

        private Label label1;

        private RadTextBox txtPatient;

        private Label label3;

        private RadTextBox txtRemarks;

        private Label label4;

        private RadTextBox txtAddress;

        private Label label5;

        private RadButton btnSubmit;

        private RadButton btnAddCustomer;

        private RadGridView gvSalesList;

        private Label label8;

        private Label label9;

        private Label label10;

        private RadCheckBox chkStandardDiscount;

        private PrintDocument PrintDoc;

        private LinkLabel lblHelp;
        private RadGroupBox radGroupBox1;
        private RadTextBox txtGrossTotal;
        private RadTextBox txtGrandTotal;
        private RadTextBox txtDiscount;
        private RadGroupBox radGroupBox2;
        private Label label2;
        private NumericUpDown txtExtraDiscount;
        private Label lblPosProfile;
        private RadGroupBox radGroupBox3;
        private RadGroupBox radGroupBox4;
        private Label label7;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn name;
        private RadTextBox txtTotalTaxesAdded;
        private Label label6;
        private RadTextBox txtAdditionalDiscountAmount;
        private Label label11;
        private RadDropDownList cmbCustomer;
        private RadButton btnSaveAsTemplate;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private RadButton btnClose;
    }
}
