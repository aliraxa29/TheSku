namespace TheSku
{
    partial class frmCompanySetup
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            spStep = new Telerik.WinControls.UI.RadStepProgressBar();
            spHello = new Telerik.WinControls.UI.StepProgressItem();
            spUser = new Telerik.WinControls.UI.StepProgressItem();
            spBrand = new Telerik.WinControls.UI.StepProgressItem();
            spYourOrganization = new Telerik.WinControls.UI.StepProgressItem();
            radPanel1 = new Telerik.WinControls.UI.RadPanel();
            pCompanyInfo = new System.Windows.Forms.Panel();
            pUser = new System.Windows.Forms.Panel();
            pTheBrand = new System.Windows.Forms.Panel();
            pYourOrganization = new System.Windows.Forms.Panel();
            cmbCoaTemplate = new System.Windows.Forms.ComboBox();
            radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            label15 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            txtAbbrivation = new Telerik.WinControls.UI.RadTextBox();
            txtCompanyName = new Telerik.WinControls.UI.RadTextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            txtPassword = new Telerik.WinControls.UI.RadTextBox();
            txtUsername = new Telerik.WinControls.UI.RadTextBox();
            txtFullName = new Telerik.WinControls.UI.RadTextBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            cmbLanguage = new Telerik.WinControls.UI.RadDropDownList();
            cmbCountry = new Telerik.WinControls.UI.RadDropDownList();
            cmbCurrency = new Telerik.WinControls.UI.RadDropDownList();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnNext = new Telerik.WinControls.UI.RadButton();
            btnBack = new Telerik.WinControls.UI.RadButton();
            btnCancel = new Telerik.WinControls.UI.RadButton();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            ((System.ComponentModel.ISupportInitialize)spStep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPanel1).BeginInit();
            radPanel1.SuspendLayout();
            pCompanyInfo.SuspendLayout();
            pUser.SuspendLayout();
            pTheBrand.SuspendLayout();
            pYourOrganization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radTextBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAbbrivation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCompanyName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            SuspendLayout();
            // 
            // spStep
            // 
            spStep.Dock = System.Windows.Forms.DockStyle.Top;
            spStep.Location = new System.Drawing.Point(0, 0);
            spStep.Name = "spStep";
            spStep.Size = new System.Drawing.Size(740, 52);
            spStep.Steps.AddRange(new Telerik.WinControls.UI.StepProgressItem[] { spHello, spUser, spBrand, spYourOrganization });
            spStep.TabIndex = 0;
            spStep.Text = "radStepProgressBar1";
            spStep.ThemeName = "Windows8";
            // 
            // spHello
            // 
            spHello.Name = "spHello";
            spHello.Text = "Hello";
            // 
            // spUser
            // 
            spUser.Name = "spUser";
            spUser.Text = "User";
            // 
            // spBrand
            // 
            spBrand.Name = "spBrand";
            spBrand.Text = "The Brand";
            // 
            // spYourOrganization
            // 
            spYourOrganization.Name = "spYourOrganization";
            spYourOrganization.Text = "Your Organization";
            // 
            // radPanel1
            // 
            radPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            radPanel1.Controls.Add(pCompanyInfo);
            radPanel1.Location = new System.Drawing.Point(12, 58);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new System.Drawing.Size(716, 266);
            radPanel1.TabIndex = 1;
            radPanel1.ThemeName = "Fluent";
            // 
            // pCompanyInfo
            // 
            pCompanyInfo.Controls.Add(pUser);
            pCompanyInfo.Controls.Add(cmbLanguage);
            pCompanyInfo.Controls.Add(cmbCountry);
            pCompanyInfo.Controls.Add(cmbCurrency);
            pCompanyInfo.Controls.Add(label4);
            pCompanyInfo.Controls.Add(label3);
            pCompanyInfo.Controls.Add(label2);
            pCompanyInfo.Controls.Add(label1);
            pCompanyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            pCompanyInfo.Location = new System.Drawing.Point(0, 0);
            pCompanyInfo.Name = "pCompanyInfo";
            pCompanyInfo.Size = new System.Drawing.Size(716, 266);
            pCompanyInfo.TabIndex = 0;
            pCompanyInfo.Visible = false;
            // 
            // pUser
            // 
            pUser.Controls.Add(pTheBrand);
            pUser.Controls.Add(txtPassword);
            pUser.Controls.Add(txtUsername);
            pUser.Controls.Add(txtFullName);
            pUser.Controls.Add(label11);
            pUser.Controls.Add(label10);
            pUser.Controls.Add(label9);
            pUser.Controls.Add(label8);
            pUser.Dock = System.Windows.Forms.DockStyle.Fill;
            pUser.Location = new System.Drawing.Point(0, 0);
            pUser.Name = "pUser";
            pUser.Size = new System.Drawing.Size(716, 266);
            pUser.TabIndex = 4;
            pUser.Visible = false;
            // 
            // pTheBrand
            // 
            pTheBrand.Controls.Add(pYourOrganization);
            pTheBrand.Controls.Add(txtAbbrivation);
            pTheBrand.Controls.Add(txtCompanyName);
            pTheBrand.Controls.Add(label6);
            pTheBrand.Controls.Add(label7);
            pTheBrand.Controls.Add(label12);
            pTheBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            pTheBrand.Location = new System.Drawing.Point(0, 0);
            pTheBrand.Name = "pTheBrand";
            pTheBrand.Size = new System.Drawing.Size(716, 266);
            pTheBrand.TabIndex = 5;
            pTheBrand.Visible = false;
            // 
            // pYourOrganization
            // 
            pYourOrganization.Controls.Add(cmbCoaTemplate);
            pYourOrganization.Controls.Add(radTextBox1);
            pYourOrganization.Controls.Add(radTextBox2);
            pYourOrganization.Controls.Add(label15);
            pYourOrganization.Controls.Add(label5);
            pYourOrganization.Controls.Add(label13);
            pYourOrganization.Controls.Add(label14);
            pYourOrganization.Dock = System.Windows.Forms.DockStyle.Fill;
            pYourOrganization.Location = new System.Drawing.Point(0, 0);
            pYourOrganization.Name = "pYourOrganization";
            pYourOrganization.Size = new System.Drawing.Size(716, 266);
            pYourOrganization.TabIndex = 6;
            pYourOrganization.Visible = false;
            // 
            // cmbCoaTemplate
            // 
            cmbCoaTemplate.DisplayMember = "SupplierGroupName";
            cmbCoaTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCoaTemplate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            radListDataItem1.Selected = true;
            radListDataItem1.Text = "Standard Chart Of Accounts";
            radListDataItem2.Text = "Chart Of Accounts With Numbers";
            cmbCoaTemplate.Items.AddRange(new object[] { radListDataItem1, radListDataItem2 });
            cmbCoaTemplate.Location = new System.Drawing.Point(207, 143);
            cmbCoaTemplate.Name = "cmbCoaTemplate";
            cmbCoaTemplate.Size = new System.Drawing.Size(316, 25);
            cmbCoaTemplate.TabIndex = 2;
            cmbCoaTemplate.ValueMember = "Name";
            // 
            // radTextBox1
            // 
            radTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            radTextBox1.Location = new System.Drawing.Point(207, 110);
            radTextBox1.Name = "radTextBox1";
            radTextBox1.Size = new System.Drawing.Size(316, 27);
            radTextBox1.TabIndex = 1;
            radTextBox1.ThemeName = "Windows8";
            // 
            // radTextBox2
            // 
            radTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            radTextBox2.Location = new System.Drawing.Point(207, 77);
            radTextBox2.Name = "radTextBox2";
            radTextBox2.Size = new System.Drawing.Size(316, 27);
            radTextBox2.TabIndex = 0;
            radTextBox2.ThemeName = "Windows8";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(49, 148);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(151, 15);
            label15.TabIndex = 2;
            label15.Text = "Chart Of Account Template";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(132, 114);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 15);
            label5.TabIndex = 2;
            label5.Text = "Bank Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(107, 84);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(95, 15);
            label13.TabIndex = 2;
            label13.Text = "What does it do?";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(248, 20);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(223, 32);
            label14.TabIndex = 1;
            label14.Text = "Your Organization";
            // 
            // txtAbbrivation
            // 
            txtAbbrivation.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtAbbrivation.Location = new System.Drawing.Point(207, 110);
            txtAbbrivation.Name = "txtAbbrivation";
            txtAbbrivation.Size = new System.Drawing.Size(316, 27);
            txtAbbrivation.TabIndex = 4;
            txtAbbrivation.ThemeName = "Windows8";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtCompanyName.Location = new System.Drawing.Point(207, 77);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new System.Drawing.Size(316, 27);
            txtCompanyName.TabIndex = 4;
            txtCompanyName.ThemeName = "Windows8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(132, 114);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 15);
            label6.TabIndex = 2;
            label6.Text = "Abbrivation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(107, 84);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 15);
            label7.TabIndex = 2;
            label7.Text = "Company Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(293, 20);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(130, 32);
            label12.TabIndex = 1;
            label12.Text = "The Brand";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtPassword.Location = new System.Drawing.Point(207, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(316, 27);
            txtPassword.TabIndex = 4;
            txtPassword.ThemeName = "Windows8";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtUsername.Location = new System.Drawing.Point(207, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(316, 27);
            txtUsername.TabIndex = 4;
            txtUsername.ThemeName = "Windows8";
            // 
            // txtFullName
            // 
            txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtFullName.Location = new System.Drawing.Point(207, 77);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(316, 27);
            txtFullName.TabIndex = 4;
            txtFullName.ThemeName = "Windows8";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(144, 150);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(57, 15);
            label11.TabIndex = 2;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(141, 117);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(60, 15);
            label10.TabIndex = 2;
            label10.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(140, 84);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(61, 15);
            label9.TabIndex = 2;
            label9.Text = "Full Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(248, 20);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(227, 32);
            label8.TabIndex = 1;
            label8.Text = "The First User: You";
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownAnimationEnabled = true;
            cmbLanguage.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbLanguage.Location = new System.Drawing.Point(207, 74);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new System.Drawing.Size(316, 27);
            cmbLanguage.TabIndex = 3;
            cmbLanguage.ThemeName = "Windows8";
            // 
            // cmbCountry
            // 
            cmbCountry.DropDownAnimationEnabled = true;
            cmbCountry.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbCountry.Location = new System.Drawing.Point(207, 107);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new System.Drawing.Size(316, 27);
            cmbCountry.TabIndex = 3;
            cmbCountry.ThemeName = "Windows8";
            // 
            // cmbCurrency
            // 
            cmbCurrency.DropDownAnimationEnabled = true;
            cmbCurrency.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbCurrency.Location = new System.Drawing.Point(207, 140);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new System.Drawing.Size(316, 27);
            cmbCurrency.TabIndex = 3;
            cmbCurrency.ThemeName = "Windows8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(146, 146);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 2;
            label4.Text = "Currency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(124, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Your Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(115, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Your Language";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(321, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 32);
            label1.TabIndex = 1;
            label1.Text = "Hello!";
            // 
            // btnNext
            // 
            btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnNext.Location = new System.Drawing.Point(618, 330);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(110, 45);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.ThemeName = "Windows8";
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnBack.Location = new System.Drawing.Point(502, 330);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(110, 45);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.ThemeName = "Windows8";
            btnBack.Click += btnBack_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancel.Location = new System.Drawing.Point(12, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(110, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.ThemeName = "Windows8";
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCompanySetup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(740, 387);
            Controls.Add(btnCancel);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(radPanel1);
            Controls.Add(spStep);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCompanySetup";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Setup Company";
            ((System.ComponentModel.ISupportInitialize)spStep).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPanel1).EndInit();
            radPanel1.ResumeLayout(false);
            pCompanyInfo.ResumeLayout(false);
            pCompanyInfo.PerformLayout();
            pUser.ResumeLayout(false);
            pUser.PerformLayout();
            pTheBrand.ResumeLayout(false);
            pTheBrand.PerformLayout();
            pYourOrganization.ResumeLayout(false);
            pYourOrganization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radTextBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAbbrivation).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCompanyName).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadStepProgressBar spStep;
        private Telerik.WinControls.UI.StepProgressItem spHello;
        private Telerik.WinControls.UI.StepProgressItem spUser;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnNext;
        private Telerik.WinControls.UI.RadButton btnBack;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private System.Windows.Forms.Panel pCompanyInfo;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList cmbCurrency;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList cmbLanguage;
        private Telerik.WinControls.UI.RadDropDownList cmbCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pUser;
        private Telerik.WinControls.UI.RadTextBox txtFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Telerik.WinControls.UI.StepProgressItem spBrand;
        private Telerik.WinControls.UI.StepProgressItem spYourOrganization;
        private System.Windows.Forms.Panel pTheBrand;
        private Telerik.WinControls.UI.RadTextBox txtAbbrivation;
        private Telerik.WinControls.UI.RadTextBox txtCompanyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pYourOrganization;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCoaTemplate;
        private System.Windows.Forms.Label label15;
    }
}