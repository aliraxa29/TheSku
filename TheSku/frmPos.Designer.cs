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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn5 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn6 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn7 = new GridViewTextBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
            GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn4 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn5 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn6 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn7 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn8 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn9 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn10 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn11 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn12 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn13 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn14 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn15 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn16 = new GridViewDecimalColumn();
            GridViewComboBoxColumn gridViewComboBoxColumn2 = new GridViewComboBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn17 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn18 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn19 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn20 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn21 = new GridViewDecimalColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn8 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn9 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn10 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn11 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn12 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn13 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn14 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn15 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn16 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn17 = new GridViewTextBoxColumn();
            GridViewDecimalColumn gridViewDecimalColumn22 = new GridViewDecimalColumn();
            GridViewDecimalColumn gridViewDecimalColumn23 = new GridViewDecimalColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn18 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new GridViewCheckBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn19 = new GridViewTextBoxColumn();
            GridViewSummaryItem gridViewSummaryItem1 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem2 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem3 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem4 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem5 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem6 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem7 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem8 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem9 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem10 = new GridViewSummaryItem();
            GridViewSummaryItem gridViewSummaryItem11 = new GridViewSummaryItem();
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            item_name.DefaultCellStyle = dataGridViewCellStyle1;
            item_name.HeaderText = "Item Name";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            item_name.Width = 300;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.DefaultCellStyle = dataGridViewCellStyle2;
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
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Sr. No.";
            gridViewTextBoxColumn1.Name = "srno";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 48;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Item Code";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "item_code";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 87;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Barcode";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "barcode";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 46;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Item Name";
            gridViewTextBoxColumn4.Name = "item_name";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 188;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Description";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "description";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 88;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "Packing Type";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "packing_type";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "Packing";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "packing";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 61;
            gridViewDecimalColumn1.DecimalPlaces = 0;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.HeaderText = "Qty";
            gridViewDecimalColumn1.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn1.Name = "qty";
            gridViewDecimalColumn1.ShowUpDownButtons = false;
            gridViewDecimalColumn1.Step = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn1.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewComboBoxColumn1.DisplayMember = "uom";
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.HeaderText = "UOM";
            gridViewComboBoxColumn1.Name = "uom";
            gridViewComboBoxColumn1.ValueMember = "uom";
            gridViewComboBoxColumn1.VisibleInColumnChooser = false;
            gridViewComboBoxColumn1.Width = 77;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.HeaderText = "Conv. Factor";
            gridViewDecimalColumn2.Name = "conversion_factor";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn2.Width = 85;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.HeaderText = "Buying Rate";
            gridViewDecimalColumn3.Name = "buying_rate";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn3.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn3.Width = 86;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FormatString = "{0:0.00}";
            gridViewDecimalColumn4.HeaderText = "Price";
            gridViewDecimalColumn4.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn4.Name = "price_list_rate";
            gridViewDecimalColumn4.ShowUpDownButtons = false;
            gridViewDecimalColumn4.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewDecimalColumn4.Width = 83;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FormatString = "{0:0.00}";
            gridViewDecimalColumn5.HeaderText = "Base Price";
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn5.Name = "base_price_list_rate";
            gridViewDecimalColumn5.ReadOnly = true;
            gridViewDecimalColumn5.Width = 49;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.HeaderText = "Qty As Per Stock UOM";
            gridViewDecimalColumn6.IsVisible = false;
            gridViewDecimalColumn6.Name = "stock_qty";
            gridViewDecimalColumn6.ReadOnly = true;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.HeaderText = "Total";
            gridViewDecimalColumn7.Name = "total";
            gridViewDecimalColumn7.ReadOnly = true;
            gridViewDecimalColumn7.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn7.Width = 77;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.HeaderText = "Base Total";
            gridViewDecimalColumn8.IsVisible = false;
            gridViewDecimalColumn8.Name = "base_total";
            gridViewDecimalColumn8.ReadOnly = true;
            gridViewDecimalColumn8.VisibleInColumnChooser = false;
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.HeaderText = "Disc %";
            gridViewDecimalColumn9.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn9.Name = "discount_percentage";
            gridViewDecimalColumn9.ShowUpDownButtons = false;
            gridViewDecimalColumn9.TextAlignment = ContentAlignment.MiddleLeft;
            gridViewDecimalColumn9.Width = 55;
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.FormatString = "{0:0.00}";
            gridViewDecimalColumn10.HeaderText = "Disc Amount";
            gridViewDecimalColumn10.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn10.Name = "discount_amount";
            gridViewDecimalColumn10.ReadOnly = true;
            gridViewDecimalColumn10.ShowUpDownButtons = false;
            gridViewDecimalColumn10.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn10.Width = 94;
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.HeaderText = "Base Discount Percentage";
            gridViewDecimalColumn11.IsVisible = false;
            gridViewDecimalColumn11.Name = "base_discount_percentage";
            gridViewDecimalColumn11.ReadOnly = true;
            gridViewDecimalColumn11.VisibleInColumnChooser = false;
            gridViewDecimalColumn11.Width = 40;
            gridViewDecimalColumn12.EnableExpressionEditor = false;
            gridViewDecimalColumn12.FormatString = "{0:0.00}";
            gridViewDecimalColumn12.HeaderText = "Rate";
            gridViewDecimalColumn12.Name = "rate";
            gridViewDecimalColumn12.ReadOnly = true;
            gridViewDecimalColumn12.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn12.Width = 72;
            gridViewDecimalColumn13.EnableExpressionEditor = false;
            gridViewDecimalColumn13.FormatString = "{0:0.00}";
            gridViewDecimalColumn13.HeaderText = "Amount";
            gridViewDecimalColumn13.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn13.Name = "amount";
            gridViewDecimalColumn13.ReadOnly = true;
            gridViewDecimalColumn13.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn13.Width = 89;
            gridViewDecimalColumn14.EnableExpressionEditor = false;
            gridViewDecimalColumn14.HeaderText = "Base Rate";
            gridViewDecimalColumn14.IsVisible = false;
            gridViewDecimalColumn14.Name = "base_rate";
            gridViewDecimalColumn14.ReadOnly = true;
            gridViewDecimalColumn14.VisibleInColumnChooser = false;
            gridViewDecimalColumn14.Width = 42;
            gridViewDecimalColumn15.EnableExpressionEditor = false;
            gridViewDecimalColumn15.HeaderText = "Base Amount";
            gridViewDecimalColumn15.IsVisible = false;
            gridViewDecimalColumn15.Name = "base_amount";
            gridViewDecimalColumn15.ReadOnly = true;
            gridViewDecimalColumn15.VisibleInColumnChooser = false;
            gridViewDecimalColumn15.Width = 49;
            gridViewDecimalColumn16.EnableExpressionEditor = false;
            gridViewDecimalColumn16.HeaderText = "Stock UOM Rate";
            gridViewDecimalColumn16.IsVisible = false;
            gridViewDecimalColumn16.Name = "stock_uom_rate";
            gridViewDecimalColumn16.ReadOnly = true;
            gridViewComboBoxColumn2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gridViewComboBoxColumn2.DisplayMember = "title";
            gridViewComboBoxColumn2.DropDownStyle = RadDropDownStyle.DropDown;
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.HeaderText = "Item Tax Template";
            gridViewComboBoxColumn2.Name = "item_tax_template";
            gridViewComboBoxColumn2.ValueMember = "name";
            gridViewComboBoxColumn2.Width = 137;
            gridViewDecimalColumn17.EnableExpressionEditor = false;
            gridViewDecimalColumn17.FormatString = "{0:0.00}";
            gridViewDecimalColumn17.HeaderText = "Tax Amount";
            gridViewDecimalColumn17.Name = "tax_amount";
            gridViewDecimalColumn17.ReadOnly = true;
            gridViewDecimalColumn17.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn17.Width = 84;
            gridViewDecimalColumn18.EnableExpressionEditor = false;
            gridViewDecimalColumn18.FormatString = "{0:0.00}";
            gridViewDecimalColumn18.HeaderText = "Net Rate";
            gridViewDecimalColumn18.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn18.Name = "net_rate";
            gridViewDecimalColumn18.ReadOnly = true;
            gridViewDecimalColumn18.TextAlignment = ContentAlignment.MiddleCenter;
            gridViewDecimalColumn18.Width = 90;
            gridViewDecimalColumn19.EnableExpressionEditor = false;
            gridViewDecimalColumn19.FormatString = "{0:0.0000}";
            gridViewDecimalColumn19.HeaderText = "Net Amount";
            gridViewDecimalColumn19.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            gridViewDecimalColumn19.Name = "net_amount";
            gridViewDecimalColumn19.ReadOnly = true;
            gridViewDecimalColumn19.Width = 111;
            gridViewDecimalColumn20.EnableExpressionEditor = false;
            gridViewDecimalColumn20.HeaderText = "Base Net Rate";
            gridViewDecimalColumn20.IsVisible = false;
            gridViewDecimalColumn20.Name = "base_net_rate";
            gridViewDecimalColumn20.ReadOnly = true;
            gridViewDecimalColumn20.VisibleInColumnChooser = false;
            gridViewDecimalColumn20.Width = 45;
            gridViewDecimalColumn21.EnableExpressionEditor = false;
            gridViewDecimalColumn21.HeaderText = "Base Net Amount";
            gridViewDecimalColumn21.IsVisible = false;
            gridViewDecimalColumn21.Name = "base_net_amount";
            gridViewDecimalColumn21.ReadOnly = true;
            gridViewDecimalColumn21.VisibleInColumnChooser = false;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "Rack Location";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "rack_location";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.VisibleInColumnChooser = false;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.HeaderText = "Doctor Name";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "doctor_name";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.VisibleInColumnChooser = false;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.HeaderText = "Is Non Returnable";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "is_non_returnable";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.VisibleInColumnChooser = false;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.HeaderText = "Is Fridge";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "is_fridge_item";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.HeaderText = "Disabled";
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "disabled";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.VisibleInColumnChooser = false;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.HeaderText = "Is Narcotic";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "is_narcotic";
            gridViewTextBoxColumn13.ReadOnly = true;
            gridViewTextBoxColumn13.VisibleInColumnChooser = false;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.HeaderText = "column1";
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "is_expiry_item";
            gridViewTextBoxColumn14.ReadOnly = true;
            gridViewTextBoxColumn14.VisibleInColumnChooser = false;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.HeaderText = "Brand";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "brand";
            gridViewTextBoxColumn15.ReadOnly = true;
            gridViewTextBoxColumn15.VisibleInColumnChooser = false;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.HeaderText = "Item Group";
            gridViewTextBoxColumn16.IsVisible = false;
            gridViewTextBoxColumn16.Name = "item_group";
            gridViewTextBoxColumn16.ReadOnly = true;
            gridViewTextBoxColumn16.VisibleInColumnChooser = false;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.HeaderText = "Is Lock Disc";
            gridViewTextBoxColumn17.IsVisible = false;
            gridViewTextBoxColumn17.Name = "is_lock_discount";
            gridViewTextBoxColumn17.ReadOnly = true;
            gridViewTextBoxColumn17.VisibleInColumnChooser = false;
            gridViewDecimalColumn22.EnableExpressionEditor = false;
            gridViewDecimalColumn22.HeaderText = "Unit Price List Rate";
            gridViewDecimalColumn22.IsVisible = false;
            gridViewDecimalColumn22.Name = "unit_price_list_rate";
            gridViewDecimalColumn22.ReadOnly = true;
            gridViewDecimalColumn23.EnableExpressionEditor = false;
            gridViewDecimalColumn23.HeaderText = "Base Unit Price List Rate";
            gridViewDecimalColumn23.IsVisible = false;
            gridViewDecimalColumn23.Name = "base_unit_price_list_rate";
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.HeaderText = "Stock UOM";
            gridViewTextBoxColumn18.IsVisible = false;
            gridViewTextBoxColumn18.Name = "stock_uom";
            gridViewTextBoxColumn18.ReadOnly = true;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.HeaderText = "Is Rule Applied";
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "is_pricing_rule_applied";
            gridViewCheckBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.HeaderText = "Rule Name";
            gridViewTextBoxColumn19.IsVisible = false;
            gridViewTextBoxColumn19.Name = "pricing_rule_name";
            gridViewTextBoxColumn19.ReadOnly = true;
            gvSalesList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7, gridViewDecimalColumn1, gridViewComboBoxColumn1, gridViewDecimalColumn2, gridViewDecimalColumn3, gridViewDecimalColumn4, gridViewDecimalColumn5, gridViewDecimalColumn6, gridViewDecimalColumn7, gridViewDecimalColumn8, gridViewDecimalColumn9, gridViewDecimalColumn10, gridViewDecimalColumn11, gridViewDecimalColumn12, gridViewDecimalColumn13, gridViewDecimalColumn14, gridViewDecimalColumn15, gridViewDecimalColumn16, gridViewComboBoxColumn2, gridViewDecimalColumn17, gridViewDecimalColumn18, gridViewDecimalColumn19, gridViewDecimalColumn20, gridViewDecimalColumn21, gridViewTextBoxColumn8, gridViewTextBoxColumn9, gridViewTextBoxColumn10, gridViewTextBoxColumn11, gridViewTextBoxColumn12, gridViewTextBoxColumn13, gridViewTextBoxColumn14, gridViewTextBoxColumn15, gridViewTextBoxColumn16, gridViewTextBoxColumn17, gridViewDecimalColumn22, gridViewDecimalColumn23, gridViewTextBoxColumn18, gridViewCheckBoxColumn1, gridViewTextBoxColumn19 });
            gvSalesList.MasterTemplate.EnableAlternatingRowColor = true;
            gvSalesList.MasterTemplate.EnableGrouping = false;
            gvSalesList.MasterTemplate.EnableSorting = false;
            gridViewSummaryItem1.Aggregate = GridAggregateFunction.Count;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "Total Items = {0}";
            gridViewSummaryItem1.Name = "item_name";
            gridViewSummaryItem2.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem2.AggregateExpression = null;
            gridViewSummaryItem2.FormatString = "{0}";
            gridViewSummaryItem2.Name = "qty";
            gridViewSummaryItem3.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem3.AggregateExpression = null;
            gridViewSummaryItem3.FormatString = "{0:0.00}";
            gridViewSummaryItem3.Name = "price_list_rate";
            gridViewSummaryItem4.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem4.AggregateExpression = null;
            gridViewSummaryItem4.FormatString = "{0:0.00}";
            gridViewSummaryItem4.Name = "discount_amount";
            gridViewSummaryItem5.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem5.AggregateExpression = null;
            gridViewSummaryItem5.FormatString = "{0:0.00}";
            gridViewSummaryItem5.Name = "rate";
            gridViewSummaryItem6.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem6.AggregateExpression = null;
            gridViewSummaryItem6.FormatString = "{0:0.00}";
            gridViewSummaryItem6.Name = "amount";
            gridViewSummaryItem7.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem7.AggregateExpression = null;
            gridViewSummaryItem7.FormatString = "{0:0.00}";
            gridViewSummaryItem7.Name = "net_rate";
            gridViewSummaryItem8.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem8.AggregateExpression = null;
            gridViewSummaryItem8.FormatString = "{0:0.00}";
            gridViewSummaryItem8.Name = "net_amount";
            gridViewSummaryItem9.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem9.AggregateExpression = null;
            gridViewSummaryItem9.FormatString = "{0:0.00}";
            gridViewSummaryItem9.Name = "total";
            gridViewSummaryItem10.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem10.AggregateExpression = null;
            gridViewSummaryItem10.FormatString = "{0:0.00}";
            gridViewSummaryItem10.Name = "buying_rate";
            gridViewSummaryItem11.Aggregate = GridAggregateFunction.Sum;
            gridViewSummaryItem11.AggregateExpression = null;
            gridViewSummaryItem11.FormatString = "{0:0.00}";
            gridViewSummaryItem11.Name = "tax_amount";
            gvSalesList.MasterTemplate.SummaryRowsTop.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { gridViewSummaryItem1, gridViewSummaryItem2, gridViewSummaryItem3, gridViewSummaryItem4, gridViewSummaryItem5, gridViewSummaryItem6, gridViewSummaryItem7, gridViewSummaryItem8, gridViewSummaryItem9, gridViewSummaryItem10, gridViewSummaryItem11 }));
            gvSalesList.MasterTemplate.ViewDefinition = tableViewDefinition1;
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
            chkStandardDiscount.Size = new Size(181, 21);
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
