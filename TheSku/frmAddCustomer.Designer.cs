using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace TheSku
{
    partial class frmAddCustomer
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
            btnCancel = new RadButton();
            btnOk = new RadButton();
            label3 = new Label();
            label2 = new Label();
            txtCustomerName = new RadTextBox();
            txtPhoneNo = new RadTextBox();
            label1 = new Label();
            cmbTerritory = new ComboBox();
            cmbCustomerGroup = new ComboBox();
            cmbType = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNo).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(358, 282);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(128, 28);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.ThemeName = "Windows8";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom;
            btnOk.Location = new System.Drawing.Point(223, 282);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(128, 28);
            btnOk.TabIndex = 5;
            btnOk.Text = "Ok";
            btnOk.ThemeName = "Windows8";
            btnOk.Click += OK_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(59, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 17);
            label3.TabIndex = 15;
            label3.Text = "First Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(64, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 17);
            label2.TabIndex = 16;
            label2.Text = "Phone No :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCustomerName.Location = new System.Drawing.Point(149, 120);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(428, 27);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.ThemeName = "Windows8";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPhoneNo.Location = new System.Drawing.Point(149, 84);
            txtPhoneNo.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new System.Drawing.Size(428, 27);
            txtPhoneNo.TabIndex = 0;
            txtPhoneNo.ThemeName = "Windows8";
            txtPhoneNo.KeyPress += txtPhone_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(220, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(266, 37);
            label1.TabIndex = 14;
            label1.Text = "Add New Customer";
            // 
            // cmbTerritory
            // 
            cmbTerritory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTerritory.DisplayMember = "territory_name";
            cmbTerritory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbTerritory.FormattingEnabled = true;
            cmbTerritory.Location = new System.Drawing.Point(149, 226);
            cmbTerritory.Margin = new Padding(4, 3, 4, 3);
            cmbTerritory.Name = "cmbTerritory";
            cmbTerritory.Size = new System.Drawing.Size(428, 29);
            cmbTerritory.TabIndex = 4;
            cmbTerritory.ValueMember = "territory_name";
            // 
            // cmbCustomerGroup
            // 
            cmbCustomerGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomerGroup.DisplayMember = "name";
            cmbCustomerGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbCustomerGroup.FormattingEnabled = true;
            cmbCustomerGroup.Location = new System.Drawing.Point(149, 191);
            cmbCustomerGroup.Margin = new Padding(4, 3, 4, 3);
            cmbCustomerGroup.Name = "cmbCustomerGroup";
            cmbCustomerGroup.Size = new System.Drawing.Size(428, 29);
            cmbCustomerGroup.TabIndex = 3;
            cmbCustomerGroup.ValueMember = "name";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Individual", "Company" });
            cmbType.Location = new System.Drawing.Point(149, 156);
            cmbType.Margin = new Padding(4, 3, 4, 3);
            cmbType.Name = "cmbType";
            cmbType.Size = new System.Drawing.Size(428, 29);
            cmbType.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(77, 231);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 17);
            label6.TabIndex = 18;
            label6.Text = "Territory:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(29, 196);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 17);
            label5.TabIndex = 19;
            label5.Text = "Customer Group:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(99, 161);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 17);
            label4.TabIndex = 20;
            label4.Text = "Type:";
            // 
            // frmAddCustomer
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(686, 337);
            Controls.Add(cmbTerritory);
            Controls.Add(cmbCustomerGroup);
            Controls.Add(cmbType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(txtPhoneNo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddCustomer";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOk).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerName).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadButton btnCancel;
        private RadButton btnOk;
        private Label label3;
        private Label label2;
        private RadTextBox txtCustomerName;
        private RadTextBox txtPhoneNo;
        private Label label1;
        private ComboBox cmbTerritory;
        private ComboBox cmbCustomerGroup;
        private ComboBox cmbType;
        private Label label6;
        private Label label5;
        private Label label4;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}
