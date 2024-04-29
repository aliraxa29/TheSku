namespace PharmacyManagementSystem.User
{
    partial class frmRolePermissionManager
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn7 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn8 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn9 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn10 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn11 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn12 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddPermission = new Telerik.WinControls.UI.RadButton();
            this.gvList = new Telerik.WinControls.UI.RadGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbDocument = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(862, 57);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(110, 24);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.ThemeName = "ControlDefault";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role Permissions Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddPermission);
            this.panel2.Controls.Add(this.gvList);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbRole);
            this.panel2.Controls.Add(this.cmbDocument);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 438);
            this.panel2.TabIndex = 2;
            // 
            // btnAddPermission
            // 
            this.btnAddPermission.Location = new System.Drawing.Point(862, 33);
            this.btnAddPermission.Name = "btnAddPermission";
            this.btnAddPermission.Size = new System.Drawing.Size(110, 29);
            this.btnAddPermission.TabIndex = 2;
            this.btnAddPermission.Text = "Add Permission";
            this.btnAddPermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPermission.ThemeName = "ControlDefault";
            this.btnAddPermission.Click += new System.EventHandler(this.btnAddPermission_Click);
            // 
            // gvList
            // 
            this.gvList.BackColor = System.Drawing.Color.White;
            this.gvList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvList.ForeColor = System.Drawing.Color.Black;
            this.gvList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvList.Location = new System.Drawing.Point(12, 68);
            // 
            // 
            // 
            this.gvList.MasterTemplate.AllowAddNewRow = false;
            this.gvList.MasterTemplate.AllowColumnChooser = false;
            this.gvList.MasterTemplate.AllowDragToGroup = false;
            this.gvList.MasterTemplate.AllowRowResize = false;
            this.gvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "role";
            gridViewTextBoxColumn3.HeaderText = "Role";
            gridViewTextBoxColumn3.Name = "role";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 234;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "document_type";
            gridViewTextBoxColumn4.HeaderText = "Document";
            gridViewTextBoxColumn4.Name = "document";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 342;
            gridViewCheckBoxColumn7.EnableExpressionEditor = false;
            gridViewCheckBoxColumn7.FieldName = "read";
            gridViewCheckBoxColumn7.HeaderText = "Read";
            gridViewCheckBoxColumn7.MinWidth = 20;
            gridViewCheckBoxColumn7.Name = "read";
            gridViewCheckBoxColumn7.Width = 69;
            gridViewCheckBoxColumn8.EnableExpressionEditor = false;
            gridViewCheckBoxColumn8.FieldName = "write";
            gridViewCheckBoxColumn8.HeaderText = "Write";
            gridViewCheckBoxColumn8.MinWidth = 20;
            gridViewCheckBoxColumn8.Name = "write";
            gridViewCheckBoxColumn8.Width = 59;
            gridViewCheckBoxColumn9.EnableExpressionEditor = false;
            gridViewCheckBoxColumn9.FieldName = "create";
            gridViewCheckBoxColumn9.HeaderText = "Create";
            gridViewCheckBoxColumn9.MinWidth = 20;
            gridViewCheckBoxColumn9.Name = "create";
            gridViewCheckBoxColumn9.Width = 64;
            gridViewCheckBoxColumn10.EnableExpressionEditor = false;
            gridViewCheckBoxColumn10.FieldName = "delete";
            gridViewCheckBoxColumn10.HeaderText = "Delete";
            gridViewCheckBoxColumn10.MinWidth = 20;
            gridViewCheckBoxColumn10.Name = "delete";
            gridViewCheckBoxColumn10.Width = 59;
            gridViewCheckBoxColumn11.EnableExpressionEditor = false;
            gridViewCheckBoxColumn11.FieldName = "submit";
            gridViewCheckBoxColumn11.HeaderText = "Submit";
            gridViewCheckBoxColumn11.MinWidth = 20;
            gridViewCheckBoxColumn11.Name = "submit";
            gridViewCheckBoxColumn11.Width = 66;
            gridViewCheckBoxColumn12.EnableExpressionEditor = false;
            gridViewCheckBoxColumn12.FieldName = "cancel";
            gridViewCheckBoxColumn12.HeaderText = "Cancel";
            gridViewCheckBoxColumn12.MinWidth = 20;
            gridViewCheckBoxColumn12.Name = "cancel";
            gridViewCheckBoxColumn12.Width = 53;
            this.gvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn7,
            gridViewCheckBoxColumn8,
            gridViewCheckBoxColumn9,
            gridViewCheckBoxColumn10,
            gridViewCheckBoxColumn11,
            gridViewCheckBoxColumn12});
            this.gvList.MasterTemplate.EnableGrouping = false;
            this.gvList.MasterTemplate.EnableSorting = false;
            this.gvList.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[0]));
            this.gvList.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gvList.Name = "gvList";
            this.gvList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvList.Size = new System.Drawing.Size(960, 358);
            this.gvList.TabIndex = 2;
            this.gvList.ThemeName = "ControlDefault";
            this.gvList.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvList_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Document";
            // 
            // cmbRole
            // 
            this.cmbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRole.DisplayMember = "name";
            this.cmbRole.DropDownHeight = 130;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.IntegralHeight = false;
            this.cmbRole.ItemHeight = 21;
            this.cmbRole.Location = new System.Drawing.Point(460, 33);
            this.cmbRole.MaxDropDownItems = 20;
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(396, 29);
            this.cmbRole.TabIndex = 0;
            this.cmbRole.ValueMember = "name";
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbDocument_SelectedIndexChanged);
            // 
            // cmbDocument
            // 
            this.cmbDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDocument.DisplayMember = "name";
            this.cmbDocument.DropDownHeight = 130;
            this.cmbDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocument.FormattingEnabled = true;
            this.cmbDocument.IntegralHeight = false;
            this.cmbDocument.ItemHeight = 21;
            this.cmbDocument.Location = new System.Drawing.Point(12, 33);
            this.cmbDocument.MaxDropDownItems = 20;
            this.cmbDocument.Name = "cmbDocument";
            this.cmbDocument.Size = new System.Drawing.Size(442, 29);
            this.cmbDocument.TabIndex = 0;
            this.cmbDocument.ValueMember = "name";
            this.cmbDocument.SelectedIndexChanged += new System.EventHandler(this.cmbDocument_SelectedIndexChanged);
            // 
            // frmRolePermissionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRolePermissionManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role Permission Manager";
            this.ThemeName = "ControlDefault";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnHelp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRole;
        private Telerik.WinControls.UI.RadGridView gvList;
        private Telerik.WinControls.UI.RadButton btnAddPermission;
    }
}