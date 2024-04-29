using Telerik.WinControls.UI;

namespace TheSku
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
            GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn5 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn6 = new GridViewCheckBoxColumn();
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();
            panel1 = new System.Windows.Forms.Panel();
            btnHelp = new RadButton();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnAddPermission = new RadButton();
            gvList = new RadGridView();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cmbRole = new RadDropDownList();
            cmbDocument = new RadDropDownList();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHelp).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddPermission).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbRole).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbDocument).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(btnHelp);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1148, 100);
            panel1.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.Location = new System.Drawing.Point(1006, 66);
            btnHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(128, 28);
            btnHelp.TabIndex = 2;
            btnHelp.Text = "Help";
            btnHelp.ThemeName = "Windows8";
            btnHelp.Click += btnHelp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(14, 28);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(380, 40);
            label1.TabIndex = 1;
            label1.Text = "Role Permissions Manager";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(btnAddPermission);
            panel2.Controls.Add(gvList);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbRole);
            panel2.Controls.Add(cmbDocument);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 100);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1148, 506);
            panel2.TabIndex = 2;
            // 
            // btnAddPermission
            // 
            btnAddPermission.Location = new System.Drawing.Point(1006, 34);
            btnAddPermission.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddPermission.Name = "btnAddPermission";
            btnAddPermission.Size = new System.Drawing.Size(128, 33);
            btnAddPermission.TabIndex = 2;
            btnAddPermission.Text = "Add Permission";
            btnAddPermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAddPermission.ThemeName = "Windows8";
            btnAddPermission.Click += btnAddPermission_Click;
            // 
            // gvList
            // 
            gvList.BackColor = System.Drawing.Color.White;
            gvList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            gvList.ForeColor = System.Drawing.Color.Black;
            gvList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            gvList.Location = new System.Drawing.Point(14, 78);
            gvList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            // 
            // 
            // 
            gvList.MasterTemplate.AllowAddNewRow = false;
            gvList.MasterTemplate.AllowColumnChooser = false;
            gvList.MasterTemplate.AllowDragToGroup = false;
            gvList.MasterTemplate.AllowRowResize = false;
            gvList.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "name";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 46;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Role";
            gridViewTextBoxColumn2.HeaderText = "Role";
            gridViewTextBoxColumn2.Name = "role";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 274;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "DocumentType";
            gridViewTextBoxColumn3.HeaderText = "Document";
            gridViewTextBoxColumn3.Name = "document";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 400;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "Read";
            gridViewCheckBoxColumn1.HeaderText = "Read";
            gridViewCheckBoxColumn1.MinWidth = 23;
            gridViewCheckBoxColumn1.Name = "read";
            gridViewCheckBoxColumn1.Width = 80;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "Write";
            gridViewCheckBoxColumn2.HeaderText = "Write";
            gridViewCheckBoxColumn2.MinWidth = 23;
            gridViewCheckBoxColumn2.Name = "write";
            gridViewCheckBoxColumn2.Width = 69;
            gridViewCheckBoxColumn3.EnableExpressionEditor = false;
            gridViewCheckBoxColumn3.FieldName = "Create";
            gridViewCheckBoxColumn3.HeaderText = "Create";
            gridViewCheckBoxColumn3.MinWidth = 23;
            gridViewCheckBoxColumn3.Name = "create";
            gridViewCheckBoxColumn3.Width = 74;
            gridViewCheckBoxColumn4.EnableExpressionEditor = false;
            gridViewCheckBoxColumn4.FieldName = "Delete";
            gridViewCheckBoxColumn4.HeaderText = "Delete";
            gridViewCheckBoxColumn4.MinWidth = 23;
            gridViewCheckBoxColumn4.Name = "delete";
            gridViewCheckBoxColumn4.Width = 69;
            gridViewCheckBoxColumn5.EnableExpressionEditor = false;
            gridViewCheckBoxColumn5.FieldName = "Submit";
            gridViewCheckBoxColumn5.HeaderText = "Submit";
            gridViewCheckBoxColumn5.MinWidth = 23;
            gridViewCheckBoxColumn5.Name = "submit";
            gridViewCheckBoxColumn5.Width = 76;
            gridViewCheckBoxColumn6.EnableExpressionEditor = false;
            gridViewCheckBoxColumn6.FieldName = "Cancel";
            gridViewCheckBoxColumn6.HeaderText = "Cancel";
            gridViewCheckBoxColumn6.MinWidth = 23;
            gridViewCheckBoxColumn6.Name = "cancel";
            gridViewCheckBoxColumn6.Width = 64;
            gvList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewCheckBoxColumn1, gridViewCheckBoxColumn2, gridViewCheckBoxColumn3, gridViewCheckBoxColumn4, gridViewCheckBoxColumn5, gridViewCheckBoxColumn6 });
            gvList.MasterTemplate.EnableGrouping = false;
            gvList.MasterTemplate.EnableSorting = false;
            gvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gvList.Name = "gvList";
            gvList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            gvList.Size = new System.Drawing.Size(1120, 413);
            gvList.TabIndex = 2;
            gvList.ThemeName = "Windows8";
            gvList.CellValueChanged += gvList_CellValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(533, 15);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 17);
            label3.TabIndex = 1;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(10, 15);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "Document";
            // 
            // cmbRole
            // 
            cmbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cmbRole.DisplayMember = "Name";
            cmbRole.DropDownAnimationEnabled = true;
            cmbRole.DropDownHeight = 130;
            cmbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cmbRole.ItemHeight = 21;
            cmbRole.Location = new System.Drawing.Point(537, 38);
            cmbRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbRole.MaxDropDownItems = 20;
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new System.Drawing.Size(461, 27);
            cmbRole.TabIndex = 0;
            cmbRole.ThemeName = "Windows8";
            cmbRole.ValueMember = "name";
            cmbRole.SelectedIndexChanged += cmbDocument_SelectedIndexChanged;
            // 
            // cmbDocument
            // 
            cmbDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cmbDocument.DisplayMember = "Name";
            cmbDocument.DropDownAnimationEnabled = true;
            cmbDocument.DropDownHeight = 130;
            cmbDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cmbDocument.ItemHeight = 21;
            cmbDocument.Location = new System.Drawing.Point(14, 38);
            cmbDocument.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbDocument.MaxDropDownItems = 20;
            cmbDocument.Name = "cmbDocument";
            cmbDocument.Size = new System.Drawing.Size(515, 27);
            cmbDocument.TabIndex = 0;
            cmbDocument.ThemeName = "Windows8";
            cmbDocument.ValueMember = "name";
            cmbDocument.SelectedIndexChanged += cmbDocument_SelectedIndexChanged;
            // 
            // frmRolePermissionManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1148, 606);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRolePermissionManager";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Role Permission Manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHelp).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddPermission).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbRole).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbDocument).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnHelp;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadDropDownList cmbDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList cmbRole;
        private Telerik.WinControls.UI.RadGridView gvList;
        private Telerik.WinControls.UI.RadButton btnAddPermission;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}