namespace TheSku
{
    partial class frmSupplier
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            panel1 = new System.Windows.Forms.Panel();
            lblID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            btnReload = new Telerik.WinControls.UI.RadMenuItem();
            btnDelete = new Telerik.WinControls.UI.RadMenuItem();
            btnCopyNameToClipboard = new Telerik.WinControls.UI.RadMenuItem();
            btnClose = new Telerik.WinControls.UI.RadButton();
            btnNew = new Telerik.WinControls.UI.RadButton();
            brnRefreshFields = new Telerik.WinControls.UI.RadButton();
            btnSave = new Telerik.WinControls.UI.RadButton();
            panel3 = new System.Windows.Forms.Panel();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            txtSupplierName = new Telerik.WinControls.UI.RadTextBox();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cmbSupplierGroup = new Telerik.WinControls.UI.RadDropDownList();
            tpList = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            gvList = new Telerik.WinControls.UI.RadGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtLimit = new System.Windows.Forms.NumericUpDown();
            txtNameFilter = new Telerik.WinControls.UI.RadTextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnDisplay = new Telerik.WinControls.UI.RadButton();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brnRefreshFields).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSupplierName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbSupplierGroup).BeginInit();
            tpList.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNameFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(988, 71);
            panel1.TabIndex = 0;
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
            label1.Size = new System.Drawing.Size(118, 37);
            label1.TabIndex = 0;
            label1.Text = "Supplier";
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
            panel2.Size = new System.Drawing.Size(200, 414);
            panel2.TabIndex = 1;
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
            // btnReload
            // 
            btnReload.Image = Properties.Resources.Refresh_24;
            btnReload.Name = "btnReload";
            btnReload.Text = "Reload";
            btnReload.UseCompatibleTextRendering = false;
            btnReload.Click += btnReload_Click;
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
            // btnCopyNameToClipboard
            // 
            btnCopyNameToClipboard.Image = Properties.Resources.Copy__2__24;
            btnCopyNameToClipboard.Name = "btnCopyNameToClipboard";
            btnCopyNameToClipboard.Text = "Copy To Clipboard";
            btnCopyNameToClipboard.UseCompatibleTextRendering = false;
            btnCopyNameToClipboard.Click += btnCopyNameToClipboard_Click;
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
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(200, 71);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(788, 414);
            panel3.TabIndex = 1;
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
            tabControl1.Size = new System.Drawing.Size(788, 414);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(780, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Supplier";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(774, 126);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Details";
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
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new System.Drawing.Size(768, 100);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSupplierName.Location = new System.Drawing.Point(195, 5);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new System.Drawing.Size(186, 23);
            txtSupplierName.TabIndex = 1;
            txtSupplierName.ThemeName = "Windows8";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(90, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 17);
            label2.TabIndex = 0;
            label2.Text = "Supplier Name";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(472, 8);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 17);
            label5.TabIndex = 0;
            label5.Text = "Supplier Group";
            // 
            // cmbSupplierGroup
            // 
            cmbSupplierGroup.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbSupplierGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbSupplierGroup.DisplayMember = "SupplierGroupName";
            cmbSupplierGroup.DropDownAnimationEnabled = true;
            cmbSupplierGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbSupplierGroup.Location = new System.Drawing.Point(579, 5);
            cmbSupplierGroup.Name = "cmbSupplierGroup";
            cmbSupplierGroup.Size = new System.Drawing.Size(186, 23);
            cmbSupplierGroup.TabIndex = 2;
            cmbSupplierGroup.ThemeName = "Windows8";
            cmbSupplierGroup.ValueMember = "Name";
            cmbSupplierGroup.Enter += cmbSupplierGroup_Enter;
            // 
            // tpList
            // 
            tpList.Controls.Add(groupBox2);
            tpList.Controls.Add(groupBox1);
            tpList.Location = new System.Drawing.Point(4, 26);
            tpList.Name = "tpList";
            tpList.Padding = new System.Windows.Forms.Padding(3);
            tpList.Size = new System.Drawing.Size(780, 384);
            tpList.TabIndex = 1;
            tpList.Text = "List";
            tpList.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvList);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(3, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(774, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "List";
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
            gridViewTextBoxColumn1.FieldName = "SupplierName";
            gridViewTextBoxColumn1.HeaderText = "Supplier Name";
            gridViewTextBoxColumn1.Name = "supplier_name";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 331;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "SupplierGroup";
            gridViewTextBoxColumn2.HeaderText = "Supplier Group";
            gridViewTextBoxColumn2.Name = "suppiler_group";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 232;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.HeaderText = "Name";
            gridViewTextBoxColumn3.Name = "name";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 186;
            gvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3 });
            gvList.MasterTemplate.EnableFiltering = true;
            gvList.MasterTemplate.EnableGrouping = false;
            gvList.MasterTemplate.EnablePaging = true;
            gvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gvList.Name = "gvList";
            gvList.ReadOnly = true;
            gvList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            gvList.Size = new System.Drawing.Size(768, 265);
            gvList.TabIndex = 0;
            gvList.ThemeName = "Windows8";
            gvList.CellDoubleClick += gvList_CellDoubleClick;
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
            groupBox1.Size = new System.Drawing.Size(774, 89);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
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
            // btnDisplay
            // 
            btnDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDisplay.Location = new System.Drawing.Point(679, 47);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new System.Drawing.Size(90, 36);
            btnDisplay.TabIndex = 1;
            btnDisplay.Text = "Display";
            btnDisplay.ThemeName = "Windows8";
            btnDisplay.Click += btnDisplay_Click;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(988, 485);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmSupplier";
            Text = "Supplier";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            KeyDown += frmSupplier_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radDropDownButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)brnRefreshFields).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSupplierName).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbSupplierGroup).EndInit();
            tpList.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNameFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Telerik.WinControls.UI.RadTextBox txtSupplierName;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadButton btnDisplay;
        private System.Windows.Forms.NumericUpDown txtLimit;
        private Telerik.WinControls.UI.RadTextBox txtNameFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton1;
        private Telerik.WinControls.UI.RadMenuItem btnReload;
        private Telerik.WinControls.UI.RadMenuItem btnDelete;
        private Telerik.WinControls.UI.RadMenuItem btnCopyNameToClipboard;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadDropDownList cmbSupplierGroup;
        private Telerik.WinControls.UI.RadGridView gvList;
        private Telerik.WinControls.UI.RadButton brnRefreshFields;
    }
}