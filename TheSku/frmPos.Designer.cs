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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            GridViewTextBoxColumn gridViewTextBoxColumn19 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn20 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn21 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn22 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn23 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn24 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn25 = new GridViewTextBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn24 = new GridViewDecimalColumn();
            GridViewComboBoxColumn gridViewComboBoxColumn3 = new GridViewComboBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn25 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn26 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn27 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn28 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn29 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn30 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn31 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn32 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn33 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn34 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn35 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn36 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn37 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn38 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn39 = new GridViewDecimalColumn();
            GridViewComboBoxColumn gridViewComboBoxColumn4 = new GridViewComboBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn40 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn41 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn42 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn43 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn44 = new GridViewDecimalColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn26 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn27 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn28 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn29 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn30 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn31 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn32 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn33 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn34 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn35 = new GridViewTextBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn45 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn46 = new GridViewDecimalColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn36 = new GridViewTextBoxColumn();
            GridViewSummaryItem gridViewSummaryItem12 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem13 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem14 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem15 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem16 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem17 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem18 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem19 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem20 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem21 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem22 = new GridViewSummaryItem();
            TableViewDefinition tableViewDefinition2 = new TableViewDefinition();
            gvItemList = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
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
            radGroupBox1 = new RadGroupBox();
            btnClose = new RadButton();
            label11 = new Label();
            label2 = new Label();
            txtExtraDiscount = new RadSpinEditor();
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
            ((ISupportInitialize)btnClose).BeginInit();
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
            gvItemList.Columns.AddRange(new DataGridViewColumn[] { name, item_name, description });
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
            // name
            // 
            name.DataPropertyName = "Name";
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Visible = false;
            // 
            // item_name
            // 
            item_name.DataPropertyName = "ItemName";
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            item_name.DefaultCellStyle = dataGridViewCellStyle3;
            item_name.HeaderText = "Item Name";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            item_name.Width = 300;
            // 
            // description
            // 
            description.DataPropertyName = "Description";
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.DefaultCellStyle = dataGridViewCellStyle4;
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 150;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(95, 113);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(304, 23);
            txtFilter.TabIndex = 0;
            txtFilter.ThemeName = "Windows8";
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyDown += txtFilter_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 117);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
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
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.HeaderText = "Sr. No.";
            gridViewTextBoxColumn19.Name = "srno";
            gridViewTextBoxColumn19.ReadOnly = true;
            gridViewTextBoxColumn19.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn19.Width = 48;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.HeaderText = "Item Code";
            gridViewTextBoxColumn20.IsVisible = false;
            gridViewTextBoxColumn20.Name = "item_code";
            gridViewTextBoxColumn20.ReadOnly = true;
            gridViewTextBoxColumn20.Width = 87;
            gridViewTextBoxColumn21.EnableExpressionEditor = false;
            gridViewTextBoxColumn21.HeaderText = "Barcode";
            gridViewTextBoxColumn21.IsVisible = false;
            gridViewTextBoxColumn21.Name = "barcode";
            gridViewTextBoxColumn21.ReadOnly = true;
            gridViewTextBoxColumn21.Width = 46;
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.HeaderText = "Item Name";
            gridViewTextBoxColumn22.Name = "item_name";
            gridViewTextBoxColumn22.ReadOnly = true;
            gridViewTextBoxColumn22.Width = 188;
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.HeaderText = "Description";
            gridViewTextBoxColumn23.IsVisible = false;
            gridViewTextBoxColumn23.Name = "description";
            gridViewTextBoxColumn23.ReadOnly = true;
            gridViewTextBoxColumn23.Width = 88;
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.HeaderText = "Packing Type";
            gridViewTextBoxColumn24.IsVisible = false;
            gridViewTextBoxColumn24.Name = "packing_type";
            gridViewTextBoxColumn24.ReadOnly = true;
            gridViewTextBoxColumn24.Width = 100;
            gridViewTextBoxColumn25.EnableExpressionEditor = false;
            gridViewTextBoxColumn25.HeaderText = "Packing";
            gridViewTextBoxColumn25.IsVisible = false;
            gridViewTextBoxColumn25.Name = "packing";
            gridViewTextBoxColumn25.ReadOnly = true;
            gridViewTextBoxColumn25.Width = 61;
            gridViewDecimalColumn24.DecimalPlaces = 0;
            gridViewDecimalColumn24.EnableExpressionEditor = false;
            gridViewDecimalColumn24.HeaderText = "Qty";
            gridViewDecimalColumn24.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn24.Name = "qty";
            gridViewDecimalColumn24.ShowUpDownButtons = false;
            gridViewDecimalColumn24.Step = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn24.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewComboBoxColumn3.DisplayMember = "uom";
            gridViewComboBoxColumn3.EnableExpressionEditor = false;
            gridViewComboBoxColumn3.HeaderText = "UOM";
            gridViewComboBoxColumn3.Name = "uom";
            gridViewComboBoxColumn3.ValueMember = "uom";
            gridViewComboBoxColumn3.VisibleInColumnChooser = false;
            gridViewComboBoxColumn3.Width = 77;
            gridViewDecimalColumn25.EnableExpressionEditor = false;
            gridViewDecimalColumn25.HeaderText = "Conv. Factor";
            gridViewDecimalColumn25.Name = "conversion_factor";
            gridViewDecimalColumn25.ReadOnly = true;
            gridViewDecimalColumn25.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn25.Width = 85;
            gridViewDecimalColumn26.EnableExpressionEditor = false;
            gridViewDecimalColumn26.HeaderText = "Buying Rate";
            gridViewDecimalColumn26.Name = "buying_rate";
            gridViewDecimalColumn26.ReadOnly = true;
            gridViewDecimalColumn26.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn26.Width = 86;
            gridViewDecimalColumn27.EnableExpressionEditor = false;
            gridViewDecimalColumn27.FormatString = "{0:0.00}";
            gridViewDecimalColumn27.HeaderText = "Price";
            gridViewDecimalColumn27.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn27.Name = "price_list_rate";
            gridViewDecimalColumn27.ShowUpDownButtons = false;
            gridViewDecimalColumn27.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewDecimalColumn27.Width = 83;
            gridViewDecimalColumn28.EnableExpressionEditor = false;
            gridViewDecimalColumn28.FormatString = "{0:0.00}";
            gridViewDecimalColumn28.HeaderText = "Base Price";
            gridViewDecimalColumn28.IsVisible = false;
            gridViewDecimalColumn28.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn28.Name = "base_price_list_rate";
            gridViewDecimalColumn28.ReadOnly = true;
            gridViewDecimalColumn28.Width = 49;
            gridViewDecimalColumn29.EnableExpressionEditor = false;
            gridViewDecimalColumn29.HeaderText = "Qty As Per Stock UOM";
            gridViewDecimalColumn29.IsVisible = false;
            gridViewDecimalColumn29.Name = "stock_qty";
            gridViewDecimalColumn29.ReadOnly = true;
            gridViewDecimalColumn30.EnableExpressionEditor = false;
            gridViewDecimalColumn30.HeaderText = "Total";
            gridViewDecimalColumn30.Name = "total";
            gridViewDecimalColumn30.ReadOnly = true;
            gridViewDecimalColumn30.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn30.Width = 77;
            gridViewDecimalColumn31.EnableExpressionEditor = false;
            gridViewDecimalColumn31.HeaderText = "Base Total";
            gridViewDecimalColumn31.IsVisible = false;
            gridViewDecimalColumn31.Name = "base_total";
            gridViewDecimalColumn31.ReadOnly = true;
            gridViewDecimalColumn31.VisibleInColumnChooser = false;
            gridViewDecimalColumn32.EnableExpressionEditor = false;
            gridViewDecimalColumn32.HeaderText = "Disc %";
            gridViewDecimalColumn32.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn32.Name = "discount_percentage";
            gridViewDecimalColumn32.ShowUpDownButtons = false;
            gridViewDecimalColumn32.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewDecimalColumn32.Width = 55;
            gridViewDecimalColumn33.EnableExpressionEditor = false;
            gridViewDecimalColumn33.FormatString = "{0:0.00}";
            gridViewDecimalColumn33.HeaderText = "Disc Amount";
            gridViewDecimalColumn33.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn33.Name = "discount_amount";
            gridViewDecimalColumn33.ReadOnly = true;
            gridViewDecimalColumn33.ShowUpDownButtons = false;
            gridViewDecimalColumn33.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn33.Width = 94;
            gridViewDecimalColumn34.EnableExpressionEditor = false;
            gridViewDecimalColumn34.HeaderText = "Base Discount Percentage";
            gridViewDecimalColumn34.IsVisible = false;
            gridViewDecimalColumn34.Name = "base_discount_percentage";
            gridViewDecimalColumn34.ReadOnly = true;
            gridViewDecimalColumn34.VisibleInColumnChooser = false;
            gridViewDecimalColumn34.Width = 40;
            gridViewDecimalColumn35.EnableExpressionEditor = false;
            gridViewDecimalColumn35.FormatString = "{0:0.00}";
            gridViewDecimalColumn35.HeaderText = "Rate";
            gridViewDecimalColumn35.Name = "rate";
            gridViewDecimalColumn35.ReadOnly = true;
            gridViewDecimalColumn35.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn35.Width = 72;
            gridViewDecimalColumn36.EnableExpressionEditor = false;
            gridViewDecimalColumn36.FormatString = "{0:0.00}";
            gridViewDecimalColumn36.HeaderText = "Amount";
            gridViewDecimalColumn36.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn36.Name = "amount";
            gridViewDecimalColumn36.ReadOnly = true;
            gridViewDecimalColumn36.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn36.Width = 89;
            gridViewDecimalColumn37.EnableExpressionEditor = false;
            gridViewDecimalColumn37.HeaderText = "Base Rate";
            gridViewDecimalColumn37.IsVisible = false;
            gridViewDecimalColumn37.Name = "base_rate";
            gridViewDecimalColumn37.ReadOnly = true;
            gridViewDecimalColumn37.VisibleInColumnChooser = false;
            gridViewDecimalColumn37.Width = 42;
            gridViewDecimalColumn38.EnableExpressionEditor = false;
            gridViewDecimalColumn38.HeaderText = "Base Amount";
            gridViewDecimalColumn38.IsVisible = false;
            gridViewDecimalColumn38.Name = "base_amount";
            gridViewDecimalColumn38.ReadOnly = true;
            gridViewDecimalColumn38.VisibleInColumnChooser = false;
            gridViewDecimalColumn38.Width = 49;
            gridViewDecimalColumn39.EnableExpressionEditor = false;
            gridViewDecimalColumn39.HeaderText = "Stock UOM Rate";
            gridViewDecimalColumn39.IsVisible = false;
            gridViewDecimalColumn39.Name = "stock_uom_rate";
            gridViewDecimalColumn39.ReadOnly = true;
            gridViewComboBoxColumn4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gridViewComboBoxColumn4.DisplayMember = "title";
            gridViewComboBoxColumn4.DropDownStyle = RadDropDownStyle.DropDown;
            gridViewComboBoxColumn4.EnableExpressionEditor = false;
            gridViewComboBoxColumn4.HeaderText = "Item Tax Template";
            gridViewComboBoxColumn4.Name = "item_tax_template";
            gridViewComboBoxColumn4.ValueMember = "name";
            gridViewComboBoxColumn4.Width = 137;
            gridViewDecimalColumn40.EnableExpressionEditor = false;
            gridViewDecimalColumn40.FormatString = "{0:0.00}";
            gridViewDecimalColumn40.HeaderText = "Tax Amount";
            gridViewDecimalColumn40.Name = "tax_amount";
            gridViewDecimalColumn40.ReadOnly = true;
            gridViewDecimalColumn40.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn40.Width = 84;
            gridViewDecimalColumn41.EnableExpressionEditor = false;
            gridViewDecimalColumn41.FormatString = "{0:0.00}";
            gridViewDecimalColumn41.HeaderText = "Net Rate";
            gridViewDecimalColumn41.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn41.Name = "net_rate";
            gridViewDecimalColumn41.ReadOnly = true;
            gridViewDecimalColumn41.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn41.Width = 90;
            gridViewDecimalColumn42.EnableExpressionEditor = false;
            gridViewDecimalColumn42.FormatString = "{0:0.0000}";
            gridViewDecimalColumn42.HeaderText = "Net Amount";
            gridViewDecimalColumn42.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn42.Name = "net_amount";
            gridViewDecimalColumn42.ReadOnly = true;
            gridViewDecimalColumn42.Width = 111;
            gridViewDecimalColumn43.EnableExpressionEditor = false;
            gridViewDecimalColumn43.HeaderText = "Base Net Rate";
            gridViewDecimalColumn43.IsVisible = false;
            gridViewDecimalColumn43.Name = "base_net_rate";
            gridViewDecimalColumn43.ReadOnly = true;
            gridViewDecimalColumn43.VisibleInColumnChooser = false;
            gridViewDecimalColumn43.Width = 45;
            gridViewDecimalColumn44.EnableExpressionEditor = false;
            gridViewDecimalColumn44.HeaderText = "Base Net Amount";
            gridViewDecimalColumn44.IsVisible = false;
            gridViewDecimalColumn44.Name = "base_net_amount";
            gridViewDecimalColumn44.ReadOnly = true;
            gridViewDecimalColumn44.VisibleInColumnChooser = false;
            gridViewTextBoxColumn26.EnableExpressionEditor = false;
            gridViewTextBoxColumn26.HeaderText = "Rack Location";
            gridViewTextBoxColumn26.IsVisible = false;
            gridViewTextBoxColumn26.Name = "rack_location";
            gridViewTextBoxColumn26.ReadOnly = true;
            gridViewTextBoxColumn26.VisibleInColumnChooser = false;
            gridViewTextBoxColumn27.EnableExpressionEditor = false;
            gridViewTextBoxColumn27.HeaderText = "Doctor Name";
            gridViewTextBoxColumn27.IsVisible = false;
            gridViewTextBoxColumn27.Name = "doctor_name";
            gridViewTextBoxColumn27.ReadOnly = true;
            gridViewTextBoxColumn27.VisibleInColumnChooser = false;
            gridViewTextBoxColumn28.EnableExpressionEditor = false;
            gridViewTextBoxColumn28.HeaderText = "Is Non Returnable";
            gridViewTextBoxColumn28.IsVisible = false;
            gridViewTextBoxColumn28.Name = "is_non_returnable";
            gridViewTextBoxColumn28.ReadOnly = true;
            gridViewTextBoxColumn28.VisibleInColumnChooser = false;
            gridViewTextBoxColumn29.EnableExpressionEditor = false;
            gridViewTextBoxColumn29.HeaderText = "Is Fridge";
            gridViewTextBoxColumn29.IsVisible = false;
            gridViewTextBoxColumn29.Name = "is_fridge_item";
            gridViewTextBoxColumn29.ReadOnly = true;
            gridViewTextBoxColumn30.EnableExpressionEditor = false;
            gridViewTextBoxColumn30.HeaderText = "Disabled";
            gridViewTextBoxColumn30.IsVisible = false;
            gridViewTextBoxColumn30.Name = "disabled";
            gridViewTextBoxColumn30.ReadOnly = true;
            gridViewTextBoxColumn30.VisibleInColumnChooser = false;
            gridViewTextBoxColumn31.EnableExpressionEditor = false;
            gridViewTextBoxColumn31.HeaderText = "Is Narcotic";
            gridViewTextBoxColumn31.IsVisible = false;
            gridViewTextBoxColumn31.Name = "is_narcotic";
            gridViewTextBoxColumn31.ReadOnly = true;
            gridViewTextBoxColumn31.VisibleInColumnChooser = false;
            gridViewTextBoxColumn32.EnableExpressionEditor = false;
            gridViewTextBoxColumn32.HeaderText = "Is Expiry";
            gridViewTextBoxColumn32.IsVisible = false;
            gridViewTextBoxColumn32.Name = "is_expiry_item";
            gridViewTextBoxColumn32.ReadOnly = true;
            gridViewTextBoxColumn32.VisibleInColumnChooser = false;
            gridViewTextBoxColumn33.EnableExpressionEditor = false;
            gridViewTextBoxColumn33.HeaderText = "Brand";
            gridViewTextBoxColumn33.IsVisible = false;
            gridViewTextBoxColumn33.Name = "brand";
            gridViewTextBoxColumn33.ReadOnly = true;
            gridViewTextBoxColumn33.VisibleInColumnChooser = false;
            gridViewTextBoxColumn34.EnableExpressionEditor = false;
            gridViewTextBoxColumn34.HeaderText = "Item Group";
            gridViewTextBoxColumn34.IsVisible = false;
            gridViewTextBoxColumn34.Name = "item_group";
            gridViewTextBoxColumn34.ReadOnly = true;
            gridViewTextBoxColumn34.VisibleInColumnChooser = false;
            gridViewTextBoxColumn35.EnableExpressionEditor = false;
            gridViewTextBoxColumn35.HeaderText = "Is Lock Disc";
            gridViewTextBoxColumn35.IsVisible = false;
            gridViewTextBoxColumn35.Name = "is_lock_discount";
            gridViewTextBoxColumn35.ReadOnly = true;
            gridViewTextBoxColumn35.VisibleInColumnChooser = false;
            gridViewDecimalColumn45.EnableExpressionEditor = false;
            gridViewDecimalColumn45.HeaderText = "Unit Price List Rate";
            gridViewDecimalColumn45.IsVisible = false;
            gridViewDecimalColumn45.Name = "unit_price_list_rate";
            gridViewDecimalColumn45.ReadOnly = true;
            gridViewDecimalColumn45.VisibleInColumnChooser = false;
            gridViewDecimalColumn46.EnableExpressionEditor = false;
            gridViewDecimalColumn46.HeaderText = "Base Unit Price List Rate";
            gridViewDecimalColumn46.IsVisible = false;
            gridViewDecimalColumn46.Name = "base_unit_price_list_rate";
            gridViewDecimalColumn46.VisibleInColumnChooser = false;
            gridViewTextBoxColumn36.EnableExpressionEditor = false;
            gridViewTextBoxColumn36.HeaderText = "Stock UOM";
            gridViewTextBoxColumn36.IsVisible = false;
            gridViewTextBoxColumn36.Name = "stock_uom";
            gridViewTextBoxColumn36.ReadOnly = true;
            gvSalesList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn19, gridViewTextBoxColumn20, gridViewTextBoxColumn21, gridViewTextBoxColumn22, gridViewTextBoxColumn23, gridViewTextBoxColumn24, gridViewTextBoxColumn25, gridViewDecimalColumn24, gridViewComboBoxColumn3, gridViewDecimalColumn25, gridViewDecimalColumn26, gridViewDecimalColumn27, gridViewDecimalColumn28, gridViewDecimalColumn29, gridViewDecimalColumn30, gridViewDecimalColumn31, gridViewDecimalColumn32, gridViewDecimalColumn33, gridViewDecimalColumn34, gridViewDecimalColumn35, gridViewDecimalColumn36, gridViewDecimalColumn37, gridViewDecimalColumn38, gridViewDecimalColumn39, gridViewComboBoxColumn4, gridViewDecimalColumn40, gridViewDecimalColumn41, gridViewDecimalColumn42, gridViewDecimalColumn43, gridViewDecimalColumn44, gridViewTextBoxColumn26, gridViewTextBoxColumn27, gridViewTextBoxColumn28, gridViewTextBoxColumn29, gridViewTextBoxColumn30, gridViewTextBoxColumn31, gridViewTextBoxColumn32, gridViewTextBoxColumn33, gridViewTextBoxColumn34, gridViewTextBoxColumn35, gridViewDecimalColumn45, gridViewDecimalColumn46, gridViewTextBoxColumn36 });
            gvSalesList.MasterTemplate.EnableAlternatingRowColor = true;
            gvSalesList.MasterTemplate.EnableGrouping = false;
            gvSalesList.MasterTemplate.EnableSorting = false;
            gridViewSummaryItem12.Aggregate = GridAggregateFunction.Count;
            gridViewSummaryItem12.AggregateExpression = null;
            gridViewSummaryItem12.FormatString = "Total Items = {0}";
            gridViewSummaryItem12.Name = "item_name";
            gridViewSummaryItem13.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem13.AggregateExpression = null;
            gridViewSummaryItem13.FormatString = "{0}";
            gridViewSummaryItem13.Name = "qty";
            gridViewSummaryItem14.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem14.AggregateExpression = null;
            gridViewSummaryItem14.FormatString = "{0:0.00}";
            gridViewSummaryItem14.Name = "price_list_rate";
            gridViewSummaryItem15.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem15.AggregateExpression = null;
            gridViewSummaryItem15.FormatString = "{0:0.00}";
            gridViewSummaryItem15.Name = "discount_amount";
            gridViewSummaryItem16.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem16.AggregateExpression = null;
            gridViewSummaryItem16.FormatString = "{0:0.00}";
            gridViewSummaryItem16.Name = "rate";
            gridViewSummaryItem17.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem17.AggregateExpression = null;
            gridViewSummaryItem17.FormatString = "{0:0.00}";
            gridViewSummaryItem17.Name = "amount";
            gridViewSummaryItem18.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem18.AggregateExpression = null;
            gridViewSummaryItem18.FormatString = "{0:0.00}";
            gridViewSummaryItem18.Name = "net_rate";
            gridViewSummaryItem19.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem19.AggregateExpression = null;
            gridViewSummaryItem19.FormatString = "{0:0.00}";
            gridViewSummaryItem19.Name = "net_amount";
            gridViewSummaryItem20.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem20.AggregateExpression = null;
            gridViewSummaryItem20.FormatString = "{0:0.00}";
            gridViewSummaryItem20.Name = "total";
            gridViewSummaryItem21.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem21.AggregateExpression = null;
            gridViewSummaryItem21.FormatString = "{0:0.00}";
            gridViewSummaryItem21.Name = "buying_rate";
            gridViewSummaryItem22.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem22.AggregateExpression = null;
            gridViewSummaryItem22.FormatString = "{0:0.00}";
            gridViewSummaryItem22.Name = "tax_amount";
            gvSalesList.MasterTemplate.SummaryRowsTop.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { gridViewSummaryItem12, gridViewSummaryItem13, gridViewSummaryItem14, gridViewSummaryItem15, gridViewSummaryItem16, gridViewSummaryItem17, gridViewSummaryItem18, gridViewSummaryItem19, gridViewSummaryItem20, gridViewSummaryItem21, gridViewSummaryItem22 }));
            gvSalesList.MasterTemplate.ViewDefinition = tableViewDefinition2;
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
            chkStandardDiscount.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkStandardDiscount.Location = new Point(4, 66);
            chkStandardDiscount.Name = "chkStandardDiscount";
            chkStandardDiscount.Size = new Size(173, 19);
            chkStandardDiscount.TabIndex = 3;
            chkStandardDiscount.Text = "Apply Standard Discount";
            chkStandardDiscount.ThemeName = "Windows8";
            chkStandardDiscount.ToggleState = ToggleState.On;
            chkStandardDiscount.ToggleStateChanged += chkStandardDiscount_ToggleStateChanged;
            // 
            // PrintDoc
            // 
            PrintDoc.PrintPage += PrintDoc_PrintPage;
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radGroupBox1.Controls.Add(btnClose);
            radGroupBox1.Controls.Add(label11);
            radGroupBox1.Controls.Add(label2);
            radGroupBox1.Controls.Add(txtExtraDiscount);
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
            txtExtraDiscount.Size = new Size(131, 23);
            txtExtraDiscount.TabIndex = 11;
            txtExtraDiscount.ThemeName = "Windows8";
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
            cmbCustomer.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCustomer.Location = new Point(7, 36);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(278, 28);
            cmbCustomer.TabIndex = 1;
            cmbCustomer.ThemeName = "Windows8";
            cmbCustomer.TextChanged += cmbCustomer_TextChanged;
            cmbCustomer.KeyDown += cmbCustomer_KeyDown;
            cmbCustomer.Enter += cmbCustomer_Enter;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCustomer.Location = new Point(290, 34);
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
            btnSubmit.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            ((ISupportInitialize)btnClose).EndInit();
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
        private RadGroupBox radGroupBox1;
        private RadTextBox txtGrossTotal;
        private RadTextBox txtGrandTotal;
        private RadTextBox txtDiscount;
        private RadGroupBox radGroupBox2;
        private Label label2;
        private RadSpinEditor txtExtraDiscount;
        private Label lblPosProfile;
        private RadGroupBox radGroupBox3;
        private RadGroupBox radGroupBox4;
        private Label label7;
        private RadTextBox txtTotalTaxesAdded;
        private Label label6;
        private RadTextBox txtAdditionalDiscountAmount;
        private Label label11;
        private RadDropDownList cmbCustomer;
        private RadButton btnSaveAsTemplate;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private RadButton btnClose;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn description;
    }
}
