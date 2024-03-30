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
            panel1 = new System.Windows.Forms.Panel();
            lblID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnClose = new Telerik.WinControls.UI.RadButton();
            btnDelete = new Telerik.WinControls.UI.RadButton();
            btnNew = new Telerik.WinControls.UI.RadButton();
            btnSave = new Telerik.WinControls.UI.RadButton();
            panel3 = new System.Windows.Forms.Panel();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtSupplierName = new Telerik.WinControls.UI.RadTextBox();
            label2 = new System.Windows.Forms.Label();
            tpList = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            gvList = new System.Windows.Forms.DataGridView();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtLimit = new System.Windows.Forms.NumericUpDown();
            txtNameFilter = new Telerik.WinControls.UI.RadTextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnDisplay = new Telerik.WinControls.UI.RadButton();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSupplierName).BeginInit();
            tpList.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvList).BeginInit();
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
            panel1.Size = new System.Drawing.Size(849, 71);
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
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnSave);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(200, 414);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.ForeColor = System.Drawing.Color.Black;
            btnClose.Location = new System.Drawing.Point(3, 132);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(194, 36);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.ThemeName = "Windows8";
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Location = new System.Drawing.Point(3, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(194, 36);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.ThemeName = "Windows8";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(3, 48);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(194, 36);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.ThemeName = "Windows8";
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(3, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(194, 36);
            btnSave.TabIndex = 1;
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
            panel3.Size = new System.Drawing.Size(649, 414);
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
            tabControl1.Size = new System.Drawing.Size(649, 414);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(641, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Supplier";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSupplierName);
            groupBox3.Controls.Add(label2);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(635, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Details";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSupplierName.Location = new System.Drawing.Point(123, 40);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new System.Drawing.Size(232, 23);
            txtSupplierName.TabIndex = 1;
            txtSupplierName.ThemeName = "Windows8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 17);
            label2.TabIndex = 0;
            label2.Text = "Supplier Name";
            // 
            // tpList
            // 
            tpList.Controls.Add(groupBox2);
            tpList.Controls.Add(groupBox1);
            tpList.Location = new System.Drawing.Point(4, 26);
            tpList.Name = "tpList";
            tpList.Padding = new System.Windows.Forms.Padding(3);
            tpList.Size = new System.Drawing.Size(641, 384);
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
            groupBox2.Size = new System.Drawing.Size(635, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "List";
            // 
            // gvList
            // 
            gvList.AllowUserToAddRows = false;
            gvList.AllowUserToDeleteRows = false;
            gvList.AllowUserToOrderColumns = true;
            gvList.AllowUserToResizeRows = false;
            gvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            gvList.BackgroundColor = System.Drawing.SystemColors.Control;
            gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { name, supplier_name });
            gvList.Dock = System.Windows.Forms.DockStyle.Fill;
            gvList.Location = new System.Drawing.Point(3, 21);
            gvList.MultiSelect = false;
            gvList.Name = "gvList";
            gvList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            gvList.Size = new System.Drawing.Size(629, 265);
            gvList.TabIndex = 0;
            gvList.CellDoubleClick += gvList_CellDoubleClick;
            gvList.KeyDown += gvList_KeyDown;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // supplier_name
            // 
            supplier_name.DataPropertyName = "SupplierName";
            supplier_name.HeaderText = "Supplier Name";
            supplier_name.Name = "supplier_name";
            supplier_name.ReadOnly = true;
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
            groupBox1.Size = new System.Drawing.Size(635, 89);
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
            btnDisplay.Location = new System.Drawing.Point(540, 47);
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
            ClientSize = new System.Drawing.Size(849, 485);
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
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSupplierName).EndInit();
            tpList.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView gvList;
        private System.Windows.Forms.GroupBox groupBox3;
        private Telerik.WinControls.UI.RadTextBox txtSupplierName;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadButton btnDisplay;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnClose;
        private System.Windows.Forms.NumericUpDown txtLimit;
        private Telerik.WinControls.UI.RadTextBox txtNameFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}