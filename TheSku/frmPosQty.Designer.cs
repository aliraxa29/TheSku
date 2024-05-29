using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace TheSku
{
    partial class frmPosQty
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
            lblPurchaseRate = new Label();
            lblPriceChanged = new Label();
            lblRetailPrice = new Label();
            lblConversionFactor = new Label();
            lblStock = new Label();
            lblDrname = new Label();
            label25 = new Label();
            label23 = new Label();
            lblItemCode = new Label();
            lblDiscPercent = new Label();
            txtDrname = new RadTextBox();
            lblPrice = new Label();
            groupBox1 = new GroupBox();
            lblShort = new Label();
            cmbUOM = new ComboBox();
            label28 = new Label();
            lblRackLocation = new Label();
            lblItemGroup = new Label();
            txtDescription = new RichTextBox();
            label5 = new Label();
            lblPacking = new Label();
            lblPackingType = new Label();
            label17 = new Label();
            lblBrand = new Label();
            label26 = new Label();
            lblItemName = new Label();
            label12 = new Label();
            label3 = new Label();
            label10 = new Label();
            label14 = new Label();
            label6 = new Label();
            label8 = new Label();
            lblPP = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblGeneric = new TextBox();
            label21 = new Label();
            txtQty = new RadSpinEditor();
            btnCancel = new RadButton();
            btnOk = new RadButton();
            groupBox3 = new GroupBox();
            lblInTransitStock = new Label();
            lblReturnToHO = new Label();
            label13 = new Label();
            label9 = new Label();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtDrname).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOk).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblPurchaseRate
            // 
            lblPurchaseRate.AutoSize = true;
            lblPurchaseRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPurchaseRate.Location = new System.Drawing.Point(167, 121);
            lblPurchaseRate.Margin = new Padding(4, 0, 4, 0);
            lblPurchaseRate.Name = "lblPurchaseRate";
            lblPurchaseRate.Size = new System.Drawing.Size(15, 17);
            lblPurchaseRate.TabIndex = 24;
            lblPurchaseRate.Text = "0";
            // 
            // lblPriceChanged
            // 
            lblPriceChanged.AutoSize = true;
            lblPriceChanged.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPriceChanged.Location = new System.Drawing.Point(167, 504);
            lblPriceChanged.Margin = new Padding(4, 0, 4, 0);
            lblPriceChanged.Name = "lblPriceChanged";
            lblPriceChanged.Size = new System.Drawing.Size(15, 17);
            lblPriceChanged.TabIndex = 1;
            lblPriceChanged.Text = "0";
            // 
            // lblRetailPrice
            // 
            lblRetailPrice.AutoSize = true;
            lblRetailPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRetailPrice.Location = new System.Drawing.Point(167, 228);
            lblRetailPrice.Margin = new Padding(4, 0, 4, 0);
            lblRetailPrice.Name = "lblRetailPrice";
            lblRetailPrice.Size = new System.Drawing.Size(15, 17);
            lblRetailPrice.TabIndex = 3;
            lblRetailPrice.Text = "0";
            // 
            // lblConversionFactor
            // 
            lblConversionFactor.AutoSize = true;
            lblConversionFactor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblConversionFactor.Location = new System.Drawing.Point(167, 193);
            lblConversionFactor.Margin = new Padding(4, 0, 4, 0);
            lblConversionFactor.Name = "lblConversionFactor";
            lblConversionFactor.Size = new System.Drawing.Size(15, 17);
            lblConversionFactor.TabIndex = 4;
            lblConversionFactor.Text = "0";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblStock.Location = new System.Drawing.Point(119, 33);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(55, 30);
            lblStock.TabIndex = 32;
            lblStock.Text = "0.00";
            // 
            // lblDrname
            // 
            lblDrname.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDrname.AutoSize = true;
            lblDrname.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDrname.Location = new System.Drawing.Point(887, 524);
            lblDrname.Margin = new Padding(4, 0, 4, 0);
            lblDrname.Name = "lblDrname";
            lblDrname.Size = new System.Drawing.Size(89, 16);
            lblDrname.TabIndex = 33;
            lblDrname.Text = "Doctor Name";
            lblDrname.Visible = false;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label25.Location = new System.Drawing.Point(679, 548);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(69, 16);
            label25.TabIndex = 34;
            label25.Text = "Quantity :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label23.Location = new System.Drawing.Point(7, 33);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(67, 30);
            label23.TabIndex = 35;
            label23.Text = "Stock";
            // 
            // lblItemCode
            // 
            lblItemCode.AutoSize = true;
            lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblItemCode.Location = new System.Drawing.Point(167, 31);
            lblItemCode.Margin = new Padding(4, 0, 4, 0);
            lblItemCode.Name = "lblItemCode";
            lblItemCode.Size = new System.Drawing.Size(15, 17);
            lblItemCode.TabIndex = 36;
            lblItemCode.Text = "0";
            // 
            // lblDiscPercent
            // 
            lblDiscPercent.AutoSize = true;
            lblDiscPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDiscPercent.Location = new System.Drawing.Point(350, 571);
            lblDiscPercent.Margin = new Padding(4, 0, 4, 0);
            lblDiscPercent.Name = "lblDiscPercent";
            lblDiscPercent.Size = new System.Drawing.Size(116, 13);
            lblDiscPercent.TabIndex = 38;
            lblDiscPercent.Text = "lblItemDiscountPercent";
            lblDiscPercent.Visible = false;
            // 
            // txtDrname
            // 
            txtDrname.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtDrname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtDrname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            txtDrname.Location = new System.Drawing.Point(890, 544);
            txtDrname.Margin = new Padding(4, 3, 4, 3);
            txtDrname.Name = "txtDrname";
            txtDrname.Size = new System.Drawing.Size(206, 25);
            txtDrname.TabIndex = 41;
            txtDrname.ThemeName = "Windows8";
            txtDrname.Visible = false;
            txtDrname.KeyPress += txtDrname_KeyPress;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPrice.Location = new System.Drawing.Point(167, 91);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(15, 17);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblShort);
            groupBox1.Controls.Add(lblPriceChanged);
            groupBox1.Controls.Add(cmbUOM);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(lblPurchaseRate);
            groupBox1.Controls.Add(lblDiscPercent);
            groupBox1.Controls.Add(lblRackLocation);
            groupBox1.Controls.Add(lblItemGroup);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(lblItemCode);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblPacking);
            groupBox1.Controls.Add(lblPackingType);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(lblBrand);
            groupBox1.Controls.Add(lblRetailPrice);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(lblConversionFactor);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(lblItemName);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblPP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(492, 613);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // lblShort
            // 
            lblShort.AutoSize = true;
            lblShort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblShort.Location = new System.Drawing.Point(167, 541);
            lblShort.Margin = new Padding(4, 0, 4, 0);
            lblShort.Name = "lblShort";
            lblShort.Size = new System.Drawing.Size(13, 13);
            lblShort.TabIndex = 5;
            lblShort.Text = "0";
            // 
            // cmbUOM
            // 
            cmbUOM.DisplayMember = "uom";
            cmbUOM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUOM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbUOM.FormattingEnabled = true;
            cmbUOM.Location = new System.Drawing.Point(167, 154);
            cmbUOM.Margin = new Padding(4, 3, 4, 3);
            cmbUOM.Name = "cmbUOM";
            cmbUOM.Size = new System.Drawing.Size(312, 29);
            cmbUOM.TabIndex = 25;
            cmbUOM.ValueMember = "uom";
            cmbUOM.SelectedIndexChanged += cmbUOM_SelectedIndexChanged;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label28.Location = new System.Drawing.Point(8, 539);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(59, 17);
            label28.TabIndex = 13;
            label28.Text = "Is Short :";
            // 
            // lblRackLocation
            // 
            lblRackLocation.AutoSize = true;
            lblRackLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRackLocation.Location = new System.Drawing.Point(167, 473);
            lblRackLocation.Margin = new Padding(4, 0, 4, 0);
            lblRackLocation.Name = "lblRackLocation";
            lblRackLocation.Size = new System.Drawing.Size(13, 13);
            lblRackLocation.TabIndex = 6;
            lblRackLocation.Text = "0";
            // 
            // lblItemGroup
            // 
            lblItemGroup.AutoSize = true;
            lblItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblItemGroup.Location = new System.Drawing.Point(350, 586);
            lblItemGroup.Margin = new Padding(4, 0, 4, 0);
            lblItemGroup.Name = "lblItemGroup";
            lblItemGroup.Size = new System.Drawing.Size(64, 13);
            lblItemGroup.TabIndex = 37;
            lblItemGroup.Text = "lblItemgroup";
            lblItemGroup.Visible = false;
            // 
            // txtDescription
            // 
            txtDescription.AutoSize = true;
            txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtDescription.Location = new System.Drawing.Point(171, 259);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new System.Drawing.Size(312, 101);
            txtDescription.TabIndex = 8;
            txtDescription.TabStop = false;
            txtDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(8, 504);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 17);
            label5.TabIndex = 9;
            label5.Text = "Price Changed On:";
            // 
            // lblPacking
            // 
            lblPacking.AutoSize = true;
            lblPacking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPacking.Location = new System.Drawing.Point(167, 406);
            lblPacking.Margin = new Padding(4, 0, 4, 0);
            lblPacking.Name = "lblPacking";
            lblPacking.Size = new System.Drawing.Size(15, 17);
            lblPacking.TabIndex = 3;
            lblPacking.Text = "0";
            // 
            // lblPackingType
            // 
            lblPackingType.AutoSize = true;
            lblPackingType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPackingType.Location = new System.Drawing.Point(167, 375);
            lblPackingType.Margin = new Padding(4, 0, 4, 0);
            lblPackingType.Name = "lblPackingType";
            lblPackingType.Size = new System.Drawing.Size(15, 17);
            lblPackingType.TabIndex = 3;
            lblPackingType.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label17.Location = new System.Drawing.Point(8, 438);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(49, 17);
            label17.TabIndex = 9;
            label17.Text = "Brand :";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBrand.Location = new System.Drawing.Point(167, 438);
            lblBrand.Margin = new Padding(4, 0, 4, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new System.Drawing.Size(15, 17);
            lblBrand.TabIndex = 10;
            lblBrand.Text = "0";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label26.Location = new System.Drawing.Point(8, 471);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(95, 17);
            label26.TabIndex = 14;
            label26.Text = "Rack Location :";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblItemName.Location = new System.Drawing.Point(167, 60);
            lblItemName.Margin = new Padding(4, 0, 4, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new System.Drawing.Size(15, 17);
            lblItemName.TabIndex = 7;
            lblItemName.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(8, 406);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(52, 17);
            label12.TabIndex = 8;
            label12.Text = "Packing";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(8, 375);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 17);
            label3.TabIndex = 8;
            label3.Text = "Packing Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(8, 228);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(79, 17);
            label10.TabIndex = 8;
            label10.Text = "Retail Price :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(8, 259);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(74, 17);
            label14.TabIndex = 9;
            label14.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(8, 160);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 17);
            label6.TabIndex = 12;
            label6.Text = "UOM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(8, 193);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(119, 17);
            label8.TabIndex = 12;
            label8.Text = "Conversion Factor";
            // 
            // lblPP
            // 
            lblPP.AutoSize = true;
            lblPP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPP.Location = new System.Drawing.Point(8, 121);
            lblPP.Margin = new Padding(4, 0, 4, 0);
            lblPP.Name = "lblPP";
            lblPP.Size = new System.Drawing.Size(97, 17);
            lblPP.TabIndex = 13;
            lblPP.Text = "Purchase Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(8, 91);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 17);
            label4.TabIndex = 13;
            label4.Text = "Unit Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(8, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 17);
            label1.TabIndex = 14;
            label1.Text = "Item Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblGeneric);
            groupBox2.Controls.Add(label21);
            groupBox2.Location = new System.Drawing.Point(513, 14);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(583, 403);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Details";
            // 
            // lblGeneric
            // 
            lblGeneric.Location = new System.Drawing.Point(124, 31);
            lblGeneric.Margin = new Padding(4, 3, 4, 3);
            lblGeneric.Name = "lblGeneric";
            lblGeneric.ReadOnly = true;
            lblGeneric.Size = new System.Drawing.Size(451, 23);
            lblGeneric.TabIndex = 18;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label21.Location = new System.Drawing.Point(6, 34);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(91, 17);
            label21.TabIndex = 16;
            label21.Text = "Generic Name";
            // 
            // txtQty
            // 
            txtQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtQty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtQty.Location = new System.Drawing.Point(766, 544);
            txtQty.Margin = new Padding(4, 3, 4, 3);
            txtQty.Maximum = new decimal(new int[] { -252715453, 1013359577, 0, 0 });
            txtQty.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            txtQty.Name = "txtQty";
            txtQty.NullableValue = new decimal(new int[] { 1, 0, 0, 0 });
            txtQty.Size = new System.Drawing.Size(117, 25);
            txtQty.TabIndex = 44;
            txtQty.ThemeName = "Windows8";
            txtQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(968, 599);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(128, 28);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.ThemeName = "Windows8";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new System.Drawing.Point(833, 599);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(128, 28);
            btnOk.TabIndex = 25;
            btnOk.Text = "OK";
            btnOk.ThemeName = "Windows8";
            btnOk.Click += btnOk_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(lblInTransitStock);
            groupBox3.Controls.Add(lblReturnToHO);
            groupBox3.Controls.Add(lblStock);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new System.Drawing.Point(513, 423);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(583, 92);
            groupBox3.TabIndex = 45;
            groupBox3.TabStop = false;
            groupBox3.Text = "Stock Information";
            // 
            // lblInTransitStock
            // 
            lblInTransitStock.AutoSize = true;
            lblInTransitStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblInTransitStock.Location = new System.Drawing.Point(434, 50);
            lblInTransitStock.Margin = new Padding(4, 0, 4, 0);
            lblInTransitStock.Name = "lblInTransitStock";
            lblInTransitStock.Size = new System.Drawing.Size(41, 21);
            lblInTransitStock.TabIndex = 32;
            lblInTransitStock.Text = "0.00";
            // 
            // lblReturnToHO
            // 
            lblReturnToHO.AutoSize = true;
            lblReturnToHO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblReturnToHO.Location = new System.Drawing.Point(434, 20);
            lblReturnToHO.Margin = new Padding(4, 0, 4, 0);
            lblReturnToHO.Name = "lblReturnToHO";
            lblReturnToHO.Size = new System.Drawing.Size(41, 21);
            lblReturnToHO.TabIndex = 32;
            lblReturnToHO.Text = "0.00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(298, 53);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(95, 17);
            label13.TabIndex = 9;
            label13.Text = "In Transit Stock";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(298, 23);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 17);
            label9.TabIndex = 9;
            label9.Text = "Return To HO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(8, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 17);
            label2.TabIndex = 14;
            label2.Text = "Item Code";
            // 
            // frmQtyItem
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(1111, 636);
            Controls.Add(groupBox3);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txtQty);
            Controls.Add(lblDrname);
            Controls.Add(label25);
            Controls.Add(txtDrname);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmQtyItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Details";
            FormClosing += frmQtyItem_FormClosing;
            ((System.ComponentModel.ISupportInitialize)txtDrname).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOk).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPurchaseRate;

        private Label lblPriceChanged;

        private Label lblRetailPrice;

        private Label lblConversionFactor;

        private Label lblStock;

        private Label lblDrname;

        private Label label25;

        private Label label23;

        private Label lblItemCode;

        private Label lblDiscPercent;

        private RadTextBox txtDrname;

        private Label lblPrice;

        private GroupBox groupBox1;

        private Label lblItemName;

        private Label label10;

        private Label label5;

        private Label label14;

        private Label label8;

        private Label lblPP;

        private Label label4;

        private Label label1;

        private GroupBox groupBox2;

        private Label lblShort;

        private Label lblRackLocation;

        private Label label17;

        private Label lblBrand;

        private Label label28;

        private Label label26;

        private Label label21;

        private Label lblItemGroup;
        private RadSpinEditor txtQty;
        private RadButton btnCancel;
        private RadButton btnOk;
        private Label label6;
        private ComboBox cmbUOM;
        private Label lblPackingType;
        private Label label3;
        private RichTextBox txtDescription;
        private GroupBox groupBox3;
        private Label lblPacking;
        private Label label12;
        private Label label9;
        private Label label13;
        private Label lblInTransitStock;
        private Label lblReturnToHO;
        private TextBox lblGeneric;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Label label2;
    }
}