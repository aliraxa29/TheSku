namespace TheSku
{
    partial class frmChangePassword
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
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            txtConfirmPassword = new Telerik.WinControls.UI.RadTextBox();
            label4 = new System.Windows.Forms.Label();
            txtNewPassword = new Telerik.WinControls.UI.RadTextBox();
            label3 = new System.Windows.Forms.Label();
            txtOldPassword = new Telerik.WinControls.UI.RadTextBox();
            label2 = new System.Windows.Forms.Label();
            txtUsername = new Telerik.WinControls.UI.RadTextBox();
            label1 = new System.Windows.Forms.Label();
            btnSave = new Telerik.WinControls.UI.RadButton();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).BeginInit();
            radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOldPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            radLabel1.Location = new System.Drawing.Point(12, 12);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new System.Drawing.Size(171, 30);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Change Password";
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            radGroupBox1.Controls.Add(txtConfirmPassword);
            radGroupBox1.Controls.Add(label4);
            radGroupBox1.Controls.Add(txtNewPassword);
            radGroupBox1.Controls.Add(label3);
            radGroupBox1.Controls.Add(txtOldPassword);
            radGroupBox1.Controls.Add(label2);
            radGroupBox1.Controls.Add(txtUsername);
            radGroupBox1.Controls.Add(label1);
            radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
            radGroupBox1.HeaderText = "";
            radGroupBox1.Location = new System.Drawing.Point(12, 48);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new System.Drawing.Size(386, 130);
            radGroupBox1.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(103, 95);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new System.Drawing.Size(278, 20);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.ThemeName = "Windows8";
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 96);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 15);
            label4.TabIndex = 0;
            label4.Text = "Confirm Pass:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(103, 69);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new System.Drawing.Size(278, 20);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.ThemeName = "Windows8";
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 70);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 15);
            label3.TabIndex = 0;
            label3.Text = "New Password:";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new System.Drawing.Point(103, 43);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '●';
            txtOldPassword.Size = new System.Drawing.Size(278, 20);
            txtOldPassword.TabIndex = 0;
            txtOldPassword.ThemeName = "Windows8";
            txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Old Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(103, 17);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new System.Drawing.Size(278, 20);
            txtUsername.TabIndex = 0;
            txtUsername.TabStop = false;
            txtUsername.ThemeName = "Windows8";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Location = new System.Drawing.Point(191, 184);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(110, 24);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.ThemeName = "Windows8";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.Location = new System.Drawing.Point(307, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(91, 24);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.ThemeName = "Windows8";
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(410, 220);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(radGroupBox1);
            Controls.Add(radLabel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmChangePassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).EndInit();
            radGroupBox1.ResumeLayout(false);
            radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOldPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadTextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtNewPassword;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadTextBox txtOldPassword;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txtUsername;
        private System.Windows.Forms.Label label1;
    }
}