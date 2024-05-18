namespace TheSku
{
    partial class frmTerritory
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            txtLimit = new Telerik.WinControls.UI.RadSpinEditor();
            txtNameFilter = new Telerik.WinControls.UI.RadTextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnDisplay = new Telerik.WinControls.UI.RadButton();
            gvList = new Telerik.WinControls.UI.RadGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tpList = new System.Windows.Forms.TabPage();
            txtSupplierName = new Telerik.WinControls.UI.RadTextBox();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cmbSupplierGroup = new Telerik.WinControls.UI.RadDropDownList();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)txtSupplierName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbSupplierGroup).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            txtLimit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtLimit.Location = new System.Drawing.Point(165, 60);
            txtLimit.Maximum = new decimal(new int[] { -915455471, -439557943, 2, 0 });
            txtLimit.Name = "txtLimit";
            txtLimit.NullableValue = new decimal(new int[] { 100, 0, 0, 0 });
            txtLimit.Size = new System.Drawing.Size(90, 23);
            txtLimit.TabIndex = 4;
            txtLimit.ThemeName = "Windows8";
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
            label3.Location = new System.Drawing.Point(165, 40);
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
            groupBox1.Size = new System.Drawing.Size(1090, 89);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // btnDisplay
            // 
            btnDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
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
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "TerritoryName";
            gridViewTextBoxColumn4.HeaderText = "Territory Name";
            gridViewTextBoxColumn4.Name = "territory_name";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 471;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "TerritoryManager.Name";
            gridViewTextBoxColumn5.HeaderText = "Territory Manager";
            gridViewTextBoxColumn5.Name = "territory_manager";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 330;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Name";
            gridViewTextBoxColumn6.HeaderText = "Name";
            gridViewTextBoxColumn6.Name = "name";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 264;
            gvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] { gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6 });
            gvList.MasterTemplate.EnableFiltering = true;
            gvList.MasterTemplate.EnableGrouping = false;
            gvList.MasterTemplate.EnablePaging = true;
            gvList.MasterTemplate.ViewDefinition = tableViewDefinition2;
            gvList.Name = "gvList";
            gvList.ReadOnly = true;
            gvList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            gvList.Size = new System.Drawing.Size(1084, 372);
            gvList.TabIndex = 0;
            gvList.ThemeName = "Windows8";
            gvList.CellDoubleClick += gvList_CellDoubleClick;
            gvList.KeyDown += gvList_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvList);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(3, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1090, 396);
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
            tpList.Size = new System.Drawing.Size(1096, 491);
            tpList.TabIndex = 1;
            tpList.Text = "List";
            tpList.UseVisualStyleBackColor = true;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSupplierName.Location = new System.Drawing.Point(274, 11);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new System.Drawing.Size(265, 23);
            txtSupplierName.TabIndex = 1;
            txtSupplierName.ThemeName = "Windows8";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(166, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 17);
            label2.TabIndex = 0;
            label2.Text = "Territory Name";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(690, 14);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 17);
            label5.TabIndex = 0;
            label5.Text = "Territory Manager";
            // 
            // cmbSupplierGroup
            // 
            cmbSupplierGroup.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbSupplierGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbSupplierGroup.DisplayMember = "SupplierGroupName";
            cmbSupplierGroup.DropDownAnimationEnabled = true;
            cmbSupplierGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbSupplierGroup.Location = new System.Drawing.Point(816, 11);
            cmbSupplierGroup.Name = "cmbSupplierGroup";
            cmbSupplierGroup.Size = new System.Drawing.Size(265, 23);
            cmbSupplierGroup.TabIndex = 2;
            cmbSupplierGroup.ThemeName = "Windows8";
            cmbSupplierGroup.ValueMember = "Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(txtSupplierName, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(cmbSupplierGroup, 3, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1084, 45);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(1090, 69);
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
            tabControl1.Size = new System.Drawing.Size(1104, 521);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1096, 491);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Territory";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(200, 71);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1104, 521);
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
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
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
            label1.Size = new System.Drawing.Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Territory";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1304, 71);
            panel1.TabIndex = 2;
            // 
            // frmTerritory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1304, 592);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmTerritory";
            Text = "Territory";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            KeyDown += frmTerritory_KeyDown;
            ((System.ComponentModel.ISupportInitialize)txtLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNameFilter).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList).EndInit();
            groupBox2.ResumeLayout(false);
            tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSupplierName).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbSupplierGroup).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Telerik.WinControls.UI.RadSpinEditor txtLimit;
        private Telerik.WinControls.UI.RadTextBox txtNameFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnDisplay;
        private Telerik.WinControls.UI.RadGridView gvList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tpList;
        private Telerik.WinControls.UI.RadTextBox txtSupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadDropDownList cmbSupplierGroup;
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
    }
}