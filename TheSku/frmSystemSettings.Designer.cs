namespace TheSku
{
    partial class frmSystemSettings
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
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cmbDefaultCompany = new Telerik.WinControls.UI.RadDropDownList();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            cmbDefaultCountry = new Telerik.WinControls.UI.RadDropDownList();
            label3 = new System.Windows.Forms.Label();
            cmbDefaultCurrency = new Telerik.WinControls.UI.RadDropDownList();
            label4 = new System.Windows.Forms.Label();
            cmbWarehouse = new Telerik.WinControls.UI.RadDropDownList();
            cmbLanguage = new Telerik.WinControls.UI.RadDropDownList();
            label6 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            panel3 = new System.Windows.Forms.Panel();
            btnClose = new Telerik.WinControls.UI.RadButton();
            brnRefreshFields = new Telerik.WinControls.UI.RadButton();
            btnSave = new Telerik.WinControls.UI.RadButton();
            btnReload = new Telerik.WinControls.UI.RadMenuItem();
            radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)cmbDefaultCompany).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbDefaultCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbDefaultCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbWarehouse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).BeginInit();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brnRefreshFields).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radDropDownButton1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(159, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 17);
            label2.TabIndex = 0;
            label2.Text = "Default Country";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(691, 8);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 17);
            label5.TabIndex = 0;
            label5.Text = "Default Company";
            // 
            // cmbDefaultCompany
            // 
            cmbDefaultCompany.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbDefaultCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbDefaultCompany.DisplayMember = "CompanyName";
            cmbDefaultCompany.DropDownAnimationEnabled = true;
            cmbDefaultCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbDefaultCompany.Location = new System.Drawing.Point(813, 5);
            cmbDefaultCompany.Name = "cmbDefaultCompany";
            cmbDefaultCompany.Size = new System.Drawing.Size(265, 23);
            cmbDefaultCompany.TabIndex = 2;
            cmbDefaultCompany.ThemeName = "Windows8";
            cmbDefaultCompany.ValueMember = "Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(cmbDefaultCompany, 3, 0);
            tableLayoutPanel1.Controls.Add(cmbDefaultCountry, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbDefaultCurrency, 3, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbWarehouse, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbLanguage, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1081, 100);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // cmbDefaultCountry
            // 
            cmbDefaultCountry.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbDefaultCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbDefaultCountry.DisplayMember = "CountryName";
            cmbDefaultCountry.DropDownAnimationEnabled = true;
            cmbDefaultCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbDefaultCountry.Location = new System.Drawing.Point(273, 5);
            cmbDefaultCountry.Name = "cmbDefaultCountry";
            cmbDefaultCountry.Size = new System.Drawing.Size(264, 23);
            cmbDefaultCountry.TabIndex = 2;
            cmbDefaultCountry.ThemeName = "Windows8";
            cmbDefaultCountry.ValueMember = "Name";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(695, 41);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 17);
            label3.TabIndex = 0;
            label3.Text = "Default Currency";
            // 
            // cmbDefaultCurrency
            // 
            cmbDefaultCurrency.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbDefaultCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbDefaultCurrency.DisplayMember = "CurrencyName";
            cmbDefaultCurrency.DropDownAnimationEnabled = true;
            cmbDefaultCurrency.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbDefaultCurrency.Location = new System.Drawing.Point(813, 38);
            cmbDefaultCurrency.Name = "cmbDefaultCurrency";
            cmbDefaultCurrency.Size = new System.Drawing.Size(265, 23);
            cmbDefaultCurrency.TabIndex = 2;
            cmbDefaultCurrency.ThemeName = "Windows8";
            cmbDefaultCurrency.ValueMember = "Name";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(191, 41);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 17);
            label4.TabIndex = 0;
            label4.Text = "Warehouse";
            // 
            // cmbWarehouse
            // 
            cmbWarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbWarehouse.DisplayMember = "WarehouseName";
            cmbWarehouse.DropDownAnimationEnabled = true;
            cmbWarehouse.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbWarehouse.Location = new System.Drawing.Point(273, 38);
            cmbWarehouse.Name = "cmbWarehouse";
            cmbWarehouse.Size = new System.Drawing.Size(264, 23);
            cmbWarehouse.TabIndex = 2;
            cmbWarehouse.ThemeName = "Windows8";
            cmbWarehouse.ValueMember = "Name";
            cmbWarehouse.Enter += cmbWarehouse_Enter;
            // 
            // cmbLanguage
            // 
            cmbLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbLanguage.DisplayMember = "LanguageName";
            cmbLanguage.DropDownAnimationEnabled = true;
            cmbLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            cmbLanguage.Location = new System.Drawing.Point(273, 71);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new System.Drawing.Size(264, 23);
            cmbLanguage.TabIndex = 2;
            cmbLanguage.ThemeName = "Windows8";
            cmbLanguage.ValueMember = "Name";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(149, 74);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(118, 17);
            label6.TabIndex = 0;
            label6.Text = "Default Language";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(1087, 126);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Details";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1093, 491);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "System Settings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(200, 71);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1101, 521);
            panel3.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.ForeColor = System.Drawing.Color.Black;
            btnClose.Image = Properties.Resources.Delete_24;
            btnClose.Location = new System.Drawing.Point(3, 132);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(194, 36);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.ThemeName = "Windows8";
            btnClose.Click += btnClose_Click;
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
            radDropDownButton1.Items.AddRange(new Telerik.WinControls.RadItem[] { btnReload });
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
            panel2.Controls.Add(brnRefreshFields);
            panel2.Controls.Add(btnSave);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(200, 521);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(213, 37);
            label1.TabIndex = 0;
            label1.Text = "System Settings";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1301, 71);
            panel1.TabIndex = 2;
            // 
            // frmSystemSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1301, 592);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmSystemSettings";
            Text = "Session Settings";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            KeyDown += frmSystemSettings_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cmbDefaultCompany).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbDefaultCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbDefaultCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbWarehouse).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).EndInit();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadDropDownList cmbDefaultCompany;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton brnRefreshFields;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadMenuItem btnReload;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadDropDownList cmbDefaultCountry;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDropDownList cmbDefaultCurrency;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList cmbWarehouse;
        private Telerik.WinControls.UI.RadDropDownList cmbLanguage;
        private System.Windows.Forms.Label label6;
    }
}