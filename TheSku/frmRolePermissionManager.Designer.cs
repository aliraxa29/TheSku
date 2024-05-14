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
            GridViewTextBoxColumn gridViewTextBoxColumn7 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn8 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn9 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn13 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn14 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn15 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn16 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn17 = new GridViewCheckBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn18 = new GridViewCheckBoxColumn();
            TableViewDefinition tableViewDefinition3 = new TableViewDefinition();
            panel1 = new System.Windows.Forms.Panel();
            btnHelp = new RadButton();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            cmbDocument = new RadDropDownList();
            cmbRole = new RadDropDownList();
            btnAddPermission = new RadButton();
            gvList = new RadGridView();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHelp).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbDocument).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbRole).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddPermission).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).BeginInit();
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
            panel2.Controls.Add(cmbDocument);
            panel2.Controls.Add(cmbRole);
            panel2.Controls.Add(btnAddPermission);
            panel2.Controls.Add(gvList);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 100);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1148, 506);
            panel2.TabIndex = 2;
            // 
            // cmbDocument
            // 
            cmbDocument.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbDocument.DisplayMember = "DocumentName";
            cmbDocument.DropDownAnimationEnabled = true;
            cmbDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            cmbDocument.Location = new System.Drawing.Point(14, 38);
            cmbDocument.Name = "cmbDocument";
            cmbDocument.Size = new System.Drawing.Size(463, 27);
            cmbDocument.TabIndex = 3;
            cmbDocument.ThemeName = "Windows8";
            cmbDocument.ValueMember = "Name";
            cmbDocument.SelectedIndexChanged += cmbDocument_SelectedIndexChanged;
            // 
            // cmbRole
            // 
            cmbRole.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbRole.DisplayMember = "RoleName";
            cmbRole.DropDownAnimationEnabled = true;
            cmbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            cmbRole.Location = new System.Drawing.Point(483, 38);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new System.Drawing.Size(463, 27);
            cmbRole.TabIndex = 3;
            cmbRole.ThemeName = "Windows8";
            cmbRole.ValueMember = "Name";
            cmbRole.SelectedIndexChanged += cmbDocument_SelectedIndexChanged;
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
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Name";
            gridViewTextBoxColumn7.HeaderText = "Name";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "name";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 46;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Role.Name";
            gridViewTextBoxColumn8.HeaderText = "Role";
            gridViewTextBoxColumn8.Name = "role";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 274;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "DocumentType";
            gridViewTextBoxColumn9.HeaderText = "Document";
            gridViewTextBoxColumn9.Name = "document";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 400;
            gridViewCheckBoxColumn13.EnableExpressionEditor = false;
            gridViewCheckBoxColumn13.FieldName = "Read";
            gridViewCheckBoxColumn13.HeaderText = "Read";
            gridViewCheckBoxColumn13.MinWidth = 23;
            gridViewCheckBoxColumn13.Name = "read";
            gridViewCheckBoxColumn13.Width = 80;
            gridViewCheckBoxColumn14.EnableExpressionEditor = false;
            gridViewCheckBoxColumn14.FieldName = "Write";
            gridViewCheckBoxColumn14.HeaderText = "Write";
            gridViewCheckBoxColumn14.MinWidth = 23;
            gridViewCheckBoxColumn14.Name = "write";
            gridViewCheckBoxColumn14.Width = 69;
            gridViewCheckBoxColumn15.EnableExpressionEditor = false;
            gridViewCheckBoxColumn15.FieldName = "Create";
            gridViewCheckBoxColumn15.HeaderText = "Create";
            gridViewCheckBoxColumn15.MinWidth = 23;
            gridViewCheckBoxColumn15.Name = "create";
            gridViewCheckBoxColumn15.Width = 74;
            gridViewCheckBoxColumn16.EnableExpressionEditor = false;
            gridViewCheckBoxColumn16.FieldName = "Delete";
            gridViewCheckBoxColumn16.HeaderText = "Delete";
            gridViewCheckBoxColumn16.MinWidth = 23;
            gridViewCheckBoxColumn16.Name = "delete";
            gridViewCheckBoxColumn16.Width = 69;
            gridViewCheckBoxColumn17.EnableExpressionEditor = false;
            gridViewCheckBoxColumn17.FieldName = "Submit";
            gridViewCheckBoxColumn17.HeaderText = "Submit";
            gridViewCheckBoxColumn17.MinWidth = 23;
            gridViewCheckBoxColumn17.Name = "submit";
            gridViewCheckBoxColumn17.Width = 76;
            gridViewCheckBoxColumn18.EnableExpressionEditor = false;
            gridViewCheckBoxColumn18.FieldName = "Cancel";
            gridViewCheckBoxColumn18.HeaderText = "Cancel";
            gridViewCheckBoxColumn18.MinWidth = 23;
            gridViewCheckBoxColumn18.Name = "cancel";
            gridViewCheckBoxColumn18.Width = 64;
            gvList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn7, gridViewTextBoxColumn8, gridViewTextBoxColumn9, gridViewCheckBoxColumn13, gridViewCheckBoxColumn14, gridViewCheckBoxColumn15, gridViewCheckBoxColumn16, gridViewCheckBoxColumn17, gridViewCheckBoxColumn18 });
            gvList.MasterTemplate.EnableGrouping = false;
            gvList.MasterTemplate.EnableSorting = false;
            gvList.MasterTemplate.ViewDefinition = tableViewDefinition3;
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
            label3.Location = new System.Drawing.Point(480, 15);
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
            ((System.ComponentModel.ISupportInitialize)cmbDocument).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbRole).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddPermission).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnHelp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView gvList;
        private Telerik.WinControls.UI.RadButton btnAddPermission;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private RadDropDownList cmbDocument;
        private RadDropDownList cmbRole;
    }
}