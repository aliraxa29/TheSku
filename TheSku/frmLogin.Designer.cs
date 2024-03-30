namespace TheSku
{
    partial class frmLogin
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
            txtUserName = new Telerik.WinControls.UI.RadTextBox();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            btnSignIn = new Telerik.WinControls.UI.RadButton();
            txtPassword = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)txtUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSignIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtUserName.Location = new System.Drawing.Point(12, 204);
            txtUserName.Name = "txtUserName";
            txtUserName.NullText = "User Name";
            txtUserName.Size = new System.Drawing.Size(324, 27);
            txtUserName.TabIndex = 0;
            txtUserName.ThemeName = "Windows8";
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new System.Drawing.Point(12, 298);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new System.Drawing.Size(324, 40);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.ThemeName = "Windows8";
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtPassword.Location = new System.Drawing.Point(12, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.NullText = "Password";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(324, 27);
            txtPassword.TabIndex = 1;
            txtPassword.ThemeName = "Windows8";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            AcceptButton = btnSignIn;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(348, 450);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)txtUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSignIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadButton btnSignIn;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
    }
}