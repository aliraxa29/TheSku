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
            GridViewTextBoxColumn gridViewTextBoxColumn115 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn116 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn117 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn118 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn119 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn120 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn121 = new GridViewTextBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn139 = new GridViewDecimalColumn();
            GridViewComboBoxColumn gridViewComboBoxColumn13 = new GridViewComboBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn140 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn141 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn142 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn143 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn144 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn145 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn146 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn147 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn148 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn149 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn150 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn151 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn152 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn153 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn154 = new GridViewDecimalColumn();
            GridViewComboBoxColumn gridViewComboBoxColumn14 = new GridViewComboBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn155 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn156 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn157 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn158 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn159 = new GridViewDecimalColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn122 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn123 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn124 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn125 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn126 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn127 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn128 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn129 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn130 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn131 = new GridViewTextBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn160 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn161 = new GridViewDecimalColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn132 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn7 = new GridViewCheckBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn133 = new GridViewTextBoxColumn();
            GridViewSummaryItem gridViewSummaryItem67 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem68 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem69 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem70 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem71 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem72 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem73 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem74 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem75 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem76 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem77 = new GridViewSummaryItem();
            TableViewDefinition tableViewDefinition7 = new TableViewDefinition();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            gvItemList = new DataGridView();
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
            btnClose = new RadButton();
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
            name = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
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
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(95, 116);
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
            label1.Location = new Point(10, 120);
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
            gridViewTextBoxColumn115.EnableExpressionEditor = false;
            gridViewTextBoxColumn115.HeaderText = "Sr. No.";
            gridViewTextBoxColumn115.Name = "srno";
            gridViewTextBoxColumn115.ReadOnly = true;
            gridViewTextBoxColumn115.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn115.Width = 48;
            gridViewTextBoxColumn116.EnableExpressionEditor = false;
            gridViewTextBoxColumn116.HeaderText = "Item Code";
            gridViewTextBoxColumn116.IsVisible = false;
            gridViewTextBoxColumn116.Name = "item_code";
            gridViewTextBoxColumn116.ReadOnly = true;
            gridViewTextBoxColumn116.Width = 87;
            gridViewTextBoxColumn117.EnableExpressionEditor = false;
            gridViewTextBoxColumn117.HeaderText = "Barcode";
            gridViewTextBoxColumn117.IsVisible = false;
            gridViewTextBoxColumn117.Name = "barcode";
            gridViewTextBoxColumn117.ReadOnly = true;
            gridViewTextBoxColumn117.Width = 46;
            gridViewTextBoxColumn118.EnableExpressionEditor = false;
            gridViewTextBoxColumn118.HeaderText = "Item Name";
            gridViewTextBoxColumn118.Name = "item_name";
            gridViewTextBoxColumn118.ReadOnly = true;
            gridViewTextBoxColumn118.Width = 188;
            gridViewTextBoxColumn119.EnableExpressionEditor = false;
            gridViewTextBoxColumn119.HeaderText = "Description";
            gridViewTextBoxColumn119.IsVisible = false;
            gridViewTextBoxColumn119.Name = "description";
            gridViewTextBoxColumn119.ReadOnly = true;
            gridViewTextBoxColumn119.Width = 88;
            gridViewTextBoxColumn120.EnableExpressionEditor = false;
            gridViewTextBoxColumn120.HeaderText = "Packing Type";
            gridViewTextBoxColumn120.IsVisible = false;
            gridViewTextBoxColumn120.Name = "packing_type";
            gridViewTextBoxColumn120.ReadOnly = true;
            gridViewTextBoxColumn120.Width = 100;
            gridViewTextBoxColumn121.EnableExpressionEditor = false;
            gridViewTextBoxColumn121.HeaderText = "Packing";
            gridViewTextBoxColumn121.IsVisible = false;
            gridViewTextBoxColumn121.Name = "packing";
            gridViewTextBoxColumn121.ReadOnly = true;
            gridViewTextBoxColumn121.Width = 61;
            gridViewDecimalColumn139.DecimalPlaces = 0;
            gridViewDecimalColumn139.EnableExpressionEditor = false;
            gridViewDecimalColumn139.HeaderText = "Qty";
            gridViewDecimalColumn139.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn139.Name = "qty";
            gridViewDecimalColumn139.ShowUpDownButtons = false;
            gridViewDecimalColumn139.Step = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn139.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewComboBoxColumn13.DisplayMember = "uom";
            gridViewComboBoxColumn13.EnableExpressionEditor = false;
            gridViewComboBoxColumn13.HeaderText = "UOM";
            gridViewComboBoxColumn13.Name = "uom";
            gridViewComboBoxColumn13.ValueMember = "uom";
            gridViewComboBoxColumn13.VisibleInColumnChooser = false;
            gridViewComboBoxColumn13.Width = 77;
            gridViewDecimalColumn140.EnableExpressionEditor = false;
            gridViewDecimalColumn140.HeaderText = "Conv. Factor";
            gridViewDecimalColumn140.Name = "conversion_factor";
            gridViewDecimalColumn140.ReadOnly = true;
            gridViewDecimalColumn140.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn140.Width = 85;
            gridViewDecimalColumn141.EnableExpressionEditor = false;
            gridViewDecimalColumn141.HeaderText = "Buying Rate";
            gridViewDecimalColumn141.Name = "buying_rate";
            gridViewDecimalColumn141.ReadOnly = true;
            gridViewDecimalColumn141.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn141.Width = 86;
            gridViewDecimalColumn142.EnableExpressionEditor = false;
            gridViewDecimalColumn142.FormatString = "{0:0.00}";
            gridViewDecimalColumn142.HeaderText = "Price";
            gridViewDecimalColumn142.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn142.Name = "price_list_rate";
            gridViewDecimalColumn142.ShowUpDownButtons = false;
            gridViewDecimalColumn142.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewDecimalColumn142.Width = 83;
            gridViewDecimalColumn143.EnableExpressionEditor = false;
            gridViewDecimalColumn143.FormatString = "{0:0.00}";
            gridViewDecimalColumn143.HeaderText = "Base Price";
            gridViewDecimalColumn143.IsVisible = false;
            gridViewDecimalColumn143.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn143.Name = "base_price_list_rate";
            gridViewDecimalColumn143.ReadOnly = true;
            gridViewDecimalColumn143.Width = 49;
            gridViewDecimalColumn144.EnableExpressionEditor = false;
            gridViewDecimalColumn144.HeaderText = "Qty As Per Stock UOM";
            gridViewDecimalColumn144.IsVisible = false;
            gridViewDecimalColumn144.Name = "stock_qty";
            gridViewDecimalColumn144.ReadOnly = true;
            gridViewDecimalColumn145.EnableExpressionEditor = false;
            gridViewDecimalColumn145.HeaderText = "Total";
            gridViewDecimalColumn145.Name = "total";
            gridViewDecimalColumn145.ReadOnly = true;
            gridViewDecimalColumn145.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn145.Width = 77;
            gridViewDecimalColumn146.EnableExpressionEditor = false;
            gridViewDecimalColumn146.HeaderText = "Base Total";
            gridViewDecimalColumn146.IsVisible = false;
            gridViewDecimalColumn146.Name = "base_total";
            gridViewDecimalColumn146.ReadOnly = true;
            gridViewDecimalColumn146.VisibleInColumnChooser = false;
            gridViewDecimalColumn147.EnableExpressionEditor = false;
            gridViewDecimalColumn147.HeaderText = "Disc %";
            gridViewDecimalColumn147.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn147.Name = "discount_percentage";
            gridViewDecimalColumn147.ShowUpDownButtons = false;
            gridViewDecimalColumn147.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewDecimalColumn147.Width = 55;
            gridViewDecimalColumn148.EnableExpressionEditor = false;
            gridViewDecimalColumn148.FormatString = "{0:0.00}";
            gridViewDecimalColumn148.HeaderText = "Disc Amount";
            gridViewDecimalColumn148.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn148.Name = "discount_amount";
            gridViewDecimalColumn148.ReadOnly = true;
            gridViewDecimalColumn148.ShowUpDownButtons = false;
            gridViewDecimalColumn148.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn148.Width = 94;
            gridViewDecimalColumn149.EnableExpressionEditor = false;
            gridViewDecimalColumn149.HeaderText = "Base Discount Percentage";
            gridViewDecimalColumn149.IsVisible = false;
            gridViewDecimalColumn149.Name = "base_discount_percentage";
            gridViewDecimalColumn149.ReadOnly = true;
            gridViewDecimalColumn149.VisibleInColumnChooser = false;
            gridViewDecimalColumn149.Width = 40;
            gridViewDecimalColumn150.EnableExpressionEditor = false;
            gridViewDecimalColumn150.FormatString = "{0:0.00}";
            gridViewDecimalColumn150.HeaderText = "Rate";
            gridViewDecimalColumn150.Name = "rate";
            gridViewDecimalColumn150.ReadOnly = true;
            gridViewDecimalColumn150.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn150.Width = 72;
            gridViewDecimalColumn151.EnableExpressionEditor = false;
            gridViewDecimalColumn151.FormatString = "{0:0.00}";
            gridViewDecimalColumn151.HeaderText = "Amount";
            gridViewDecimalColumn151.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn151.Name = "amount";
            gridViewDecimalColumn151.ReadOnly = true;
            gridViewDecimalColumn151.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn151.Width = 89;
            gridViewDecimalColumn152.EnableExpressionEditor = false;
            gridViewDecimalColumn152.HeaderText = "Base Rate";
            gridViewDecimalColumn152.IsVisible = false;
            gridViewDecimalColumn152.Name = "base_rate";
            gridViewDecimalColumn152.ReadOnly = true;
            gridViewDecimalColumn152.VisibleInColumnChooser = false;
            gridViewDecimalColumn152.Width = 42;
            gridViewDecimalColumn153.EnableExpressionEditor = false;
            gridViewDecimalColumn153.HeaderText = "Base Amount";
            gridViewDecimalColumn153.IsVisible = false;
            gridViewDecimalColumn153.Name = "base_amount";
            gridViewDecimalColumn153.ReadOnly = true;
            gridViewDecimalColumn153.VisibleInColumnChooser = false;
            gridViewDecimalColumn153.Width = 49;
            gridViewDecimalColumn154.EnableExpressionEditor = false;
            gridViewDecimalColumn154.HeaderText = "Stock UOM Rate";
            gridViewDecimalColumn154.IsVisible = false;
            gridViewDecimalColumn154.Name = "stock_uom_rate";
            gridViewDecimalColumn154.ReadOnly = true;
            gridViewComboBoxColumn14.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gridViewComboBoxColumn14.DisplayMember = "title";
            gridViewComboBoxColumn14.DropDownStyle = RadDropDownStyle.DropDown;
            gridViewComboBoxColumn14.EnableExpressionEditor = false;
            gridViewComboBoxColumn14.HeaderText = "Item Tax Template";
            gridViewComboBoxColumn14.Name = "item_tax_template";
            gridViewComboBoxColumn14.ValueMember = "name";
            gridViewComboBoxColumn14.Width = 137;
            gridViewDecimalColumn155.EnableExpressionEditor = false;
            gridViewDecimalColumn155.FormatString = "{0:0.00}";
            gridViewDecimalColumn155.HeaderText = "Tax Amount";
            gridViewDecimalColumn155.Name = "tax_amount";
            gridViewDecimalColumn155.ReadOnly = true;
            gridViewDecimalColumn155.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn155.Width = 84;
            gridViewDecimalColumn156.EnableExpressionEditor = false;
            gridViewDecimalColumn156.FormatString = "{0:0.00}";
            gridViewDecimalColumn156.HeaderText = "Net Rate";
            gridViewDecimalColumn156.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn156.Name = "net_rate";
            gridViewDecimalColumn156.ReadOnly = true;
            gridViewDecimalColumn156.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn156.Width = 90;
            gridViewDecimalColumn157.EnableExpressionEditor = false;
            gridViewDecimalColumn157.FormatString = "{0:0.0000}";
            gridViewDecimalColumn157.HeaderText = "Net Amount";
            gridViewDecimalColumn157.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn157.Name = "net_amount";
            gridViewDecimalColumn157.ReadOnly = true;
            gridViewDecimalColumn157.Width = 111;
            gridViewDecimalColumn158.EnableExpressionEditor = false;
            gridViewDecimalColumn158.HeaderText = "Base Net Rate";
            gridViewDecimalColumn158.IsVisible = false;
            gridViewDecimalColumn158.Name = "base_net_rate";
            gridViewDecimalColumn158.ReadOnly = true;
            gridViewDecimalColumn158.VisibleInColumnChooser = false;
            gridViewDecimalColumn158.Width = 45;
            gridViewDecimalColumn159.EnableExpressionEditor = false;
            gridViewDecimalColumn159.HeaderText = "Base Net Amount";
            gridViewDecimalColumn159.IsVisible = false;
            gridViewDecimalColumn159.Name = "base_net_amount";
            gridViewDecimalColumn159.ReadOnly = true;
            gridViewDecimalColumn159.VisibleInColumnChooser = false;
            gridViewTextBoxColumn122.EnableExpressionEditor = false;
            gridViewTextBoxColumn122.HeaderText = "Rack Location";
            gridViewTextBoxColumn122.IsVisible = false;
            gridViewTextBoxColumn122.Name = "rack_location";
            gridViewTextBoxColumn122.ReadOnly = true;
            gridViewTextBoxColumn122.VisibleInColumnChooser = false;
            gridViewTextBoxColumn123.EnableExpressionEditor = false;
            gridViewTextBoxColumn123.HeaderText = "Doctor Name";
            gridViewTextBoxColumn123.IsVisible = false;
            gridViewTextBoxColumn123.Name = "doctor_name";
            gridViewTextBoxColumn123.ReadOnly = true;
            gridViewTextBoxColumn123.VisibleInColumnChooser = false;
            gridViewTextBoxColumn124.EnableExpressionEditor = false;
            gridViewTextBoxColumn124.HeaderText = "Is Non Returnable";
            gridViewTextBoxColumn124.IsVisible = false;
            gridViewTextBoxColumn124.Name = "is_non_returnable";
            gridViewTextBoxColumn124.ReadOnly = true;
            gridViewTextBoxColumn124.VisibleInColumnChooser = false;
            gridViewTextBoxColumn125.EnableExpressionEditor = false;
            gridViewTextBoxColumn125.HeaderText = "Is Fridge";
            gridViewTextBoxColumn125.IsVisible = false;
            gridViewTextBoxColumn125.Name = "is_fridge_item";
            gridViewTextBoxColumn125.ReadOnly = true;
            gridViewTextBoxColumn126.EnableExpressionEditor = false;
            gridViewTextBoxColumn126.HeaderText = "Disabled";
            gridViewTextBoxColumn126.IsVisible = false;
            gridViewTextBoxColumn126.Name = "disabled";
            gridViewTextBoxColumn126.ReadOnly = true;
            gridViewTextBoxColumn126.VisibleInColumnChooser = false;
            gridViewTextBoxColumn127.EnableExpressionEditor = false;
            gridViewTextBoxColumn127.HeaderText = "Is Narcotic";
            gridViewTextBoxColumn127.IsVisible = false;
            gridViewTextBoxColumn127.Name = "is_narcotic";
            gridViewTextBoxColumn127.ReadOnly = true;
            gridViewTextBoxColumn127.VisibleInColumnChooser = false;
            gridViewTextBoxColumn128.EnableExpressionEditor = false;
            gridViewTextBoxColumn128.HeaderText = "column1";
            gridViewTextBoxColumn128.IsVisible = false;
            gridViewTextBoxColumn128.Name = "is_expiry_item";
            gridViewTextBoxColumn128.ReadOnly = true;
            gridViewTextBoxColumn128.VisibleInColumnChooser = false;
            gridViewTextBoxColumn129.EnableExpressionEditor = false;
            gridViewTextBoxColumn129.HeaderText = "Brand";
            gridViewTextBoxColumn129.IsVisible = false;
            gridViewTextBoxColumn129.Name = "brand";
            gridViewTextBoxColumn129.ReadOnly = true;
            gridViewTextBoxColumn129.VisibleInColumnChooser = false;
            gridViewTextBoxColumn130.EnableExpressionEditor = false;
            gridViewTextBoxColumn130.HeaderText = "Item Group";
            gridViewTextBoxColumn130.IsVisible = false;
            gridViewTextBoxColumn130.Name = "item_group";
            gridViewTextBoxColumn130.ReadOnly = true;
            gridViewTextBoxColumn130.VisibleInColumnChooser = false;
            gridViewTextBoxColumn131.EnableExpressionEditor = false;
            gridViewTextBoxColumn131.HeaderText = "Is Lock Disc";
            gridViewTextBoxColumn131.IsVisible = false;
            gridViewTextBoxColumn131.Name = "is_lock_discount";
            gridViewTextBoxColumn131.ReadOnly = true;
            gridViewTextBoxColumn131.VisibleInColumnChooser = false;
            gridViewDecimalColumn160.EnableExpressionEditor = false;
            gridViewDecimalColumn160.HeaderText = "Unit Price List Rate";
            gridViewDecimalColumn160.IsVisible = false;
            gridViewDecimalColumn160.Name = "unit_price_list_rate";
            gridViewDecimalColumn160.ReadOnly = true;
            gridViewDecimalColumn161.EnableExpressionEditor = false;
            gridViewDecimalColumn161.HeaderText = "Base Unit Price List Rate";
            gridViewDecimalColumn161.IsVisible = false;
            gridViewDecimalColumn161.Name = "base_unit_price_list_rate";
            gridViewTextBoxColumn132.EnableExpressionEditor = false;
            gridViewTextBoxColumn132.HeaderText = "Stock UOM";
            gridViewTextBoxColumn132.IsVisible = false;
            gridViewTextBoxColumn132.Name = "stock_uom";
            gridViewTextBoxColumn132.ReadOnly = true;
            gridViewCheckBoxColumn7.EnableExpressionEditor = false;
            gridViewCheckBoxColumn7.HeaderText = "Is Rule Applied";
            gridViewCheckBoxColumn7.IsVisible = false;
            gridViewCheckBoxColumn7.MinWidth = 20;
            gridViewCheckBoxColumn7.Name = "is_pricing_rule_applied";
            gridViewCheckBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn133.EnableExpressionEditor = false;
            gridViewTextBoxColumn133.HeaderText = "Rule Name";
            gridViewTextBoxColumn133.IsVisible = false;
            gridViewTextBoxColumn133.Name = "pricing_rule_name";
            gridViewTextBoxColumn133.ReadOnly = true;
            gvSalesList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn115, gridViewTextBoxColumn116, gridViewTextBoxColumn117, gridViewTextBoxColumn118, gridViewTextBoxColumn119, gridViewTextBoxColumn120, gridViewTextBoxColumn121, gridViewDecimalColumn139, gridViewComboBoxColumn13, gridViewDecimalColumn140, gridViewDecimalColumn141, gridViewDecimalColumn142, gridViewDecimalColumn143, gridViewDecimalColumn144, gridViewDecimalColumn145, gridViewDecimalColumn146, gridViewDecimalColumn147, gridViewDecimalColumn148, gridViewDecimalColumn149, gridViewDecimalColumn150, gridViewDecimalColumn151, gridViewDecimalColumn152, gridViewDecimalColumn153, gridViewDecimalColumn154, gridViewComboBoxColumn14, gridViewDecimalColumn155, gridViewDecimalColumn156, gridViewDecimalColumn157, gridViewDecimalColumn158, gridViewDecimalColumn159, gridViewTextBoxColumn122, gridViewTextBoxColumn123, gridViewTextBoxColumn124, gridViewTextBoxColumn125, gridViewTextBoxColumn126, gridViewTextBoxColumn127, gridViewTextBoxColumn128, gridViewTextBoxColumn129, gridViewTextBoxColumn130, gridViewTextBoxColumn131, gridViewDecimalColumn160, gridViewDecimalColumn161, gridViewTextBoxColumn132, gridViewCheckBoxColumn7, gridViewTextBoxColumn133 });
            gvSalesList.MasterTemplate.EnableAlternatingRowColor = true;
            gvSalesList.MasterTemplate.EnableGrouping = false;
            gvSalesList.MasterTemplate.EnableSorting = false;
            gridViewSummaryItem67.Aggregate = GridAggregateFunction.Count;
            gridViewSummaryItem67.AggregateExpression = null;
            gridViewSummaryItem67.FormatString = "Total Items = {0}";
            gridViewSummaryItem67.Name = "item_name";
            gridViewSummaryItem68.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem68.AggregateExpression = null;
            gridViewSummaryItem68.FormatString = "{0}";
            gridViewSummaryItem68.Name = "qty";
            gridViewSummaryItem69.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem69.AggregateExpression = null;
            gridViewSummaryItem69.FormatString = "{0:0.00}";
            gridViewSummaryItem69.Name = "price_list_rate";
            gridViewSummaryItem70.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem70.AggregateExpression = null;
            gridViewSummaryItem70.FormatString = "{0:0.00}";
            gridViewSummaryItem70.Name = "discount_amount";
            gridViewSummaryItem71.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem71.AggregateExpression = null;
            gridViewSummaryItem71.FormatString = "{0:0.00}";
            gridViewSummaryItem71.Name = "rate";
            gridViewSummaryItem72.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem72.AggregateExpression = null;
            gridViewSummaryItem72.FormatString = "{0:0.00}";
            gridViewSummaryItem72.Name = "amount";
            gridViewSummaryItem73.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem73.AggregateExpression = null;
            gridViewSummaryItem73.FormatString = "{0:0.00}";
            gridViewSummaryItem73.Name = "net_rate";
            gridViewSummaryItem74.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem74.AggregateExpression = null;
            gridViewSummaryItem74.FormatString = "{0:0.00}";
            gridViewSummaryItem74.Name = "net_amount";
            gridViewSummaryItem75.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem75.AggregateExpression = null;
            gridViewSummaryItem75.FormatString = "{0:0.00}";
            gridViewSummaryItem75.Name = "total";
            gridViewSummaryItem76.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem76.AggregateExpression = null;
            gridViewSummaryItem76.FormatString = "{0:0.00}";
            gridViewSummaryItem76.Name = "buying_rate";
            gridViewSummaryItem77.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem77.AggregateExpression = null;
            gridViewSummaryItem77.FormatString = "{0:0.00}";
            gridViewSummaryItem77.Name = "tax_amount";
            gvSalesList.MasterTemplate.SummaryRowsTop.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { gridViewSummaryItem67, gridViewSummaryItem68, gridViewSummaryItem69, gridViewSummaryItem70, gridViewSummaryItem71, gridViewSummaryItem72, gridViewSummaryItem73, gridViewSummaryItem74, gridViewSummaryItem75, gridViewSummaryItem76, gridViewSummaryItem77 }));
            gvSalesList.MasterTemplate.ViewDefinition = tableViewDefinition7;
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
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Visible = false;
            // 
            // item_name
            // 
            item_name.DataPropertyName = "item_name";
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            item_name.DefaultCellStyle = dataGridViewCellStyle13;
            item_name.HeaderText = "Item Name";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            item_name.Width = 300;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.DefaultCellStyle = dataGridViewCellStyle14;
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 150;
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
