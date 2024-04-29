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
            stepProgressItem1 = new Telerik.WinControls.UI.StepProgressItem();
            radPanel1 = new Telerik.WinControls.UI.RadPanel();
            pCompanyInfo = new System.Windows.Forms.Panel();
            cmbLanguage = new Telerik.WinControls.UI.RadDropDownList();
            cmbCountry = new Telerik.WinControls.UI.RadDropDownList();
            cmbCurrency = new Telerik.WinControls.UI.RadDropDownList();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pTheBrand = new System.Windows.Forms.Panel();
            txtAbbrivation = new Telerik.WinControls.UI.RadTextBox();
            txtCompanyName = new Telerik.WinControls.UI.RadTextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            pUser = new System.Windows.Forms.Panel();
            txtPassword = new Telerik.WinControls.UI.RadTextBox();
            txtUsername = new Telerik.WinControls.UI.RadTextBox();
            txtFullName = new Telerik.WinControls.UI.RadTextBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pYourOrganization = new System.Windows.Forms.Panel();
            cmbCoaTemplate = new System.Windows.Forms.ComboBox();
            txtBank = new Telerik.WinControls.UI.RadTextBox();
            txtWhatItDo = new Telerik.WinControls.UI.RadTextBox();
            label15 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            btnNext = new Telerik.WinControls.UI.RadButton();
            btnBack = new Telerik.WinControls.UI.RadButton();
            btnCancel = new Telerik.WinControls.UI.RadButton();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)spStep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPanel1).BeginInit();
            radPanel1.SuspendLayout();
            pCompanyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCurrency).BeginInit();
            pTheBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAbbrivation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCompanyName).BeginInit();
            pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName).BeginInit();
            pYourOrganization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtWhatItDo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // spStep
            // 
            spStep.Dock = System.Windows.Forms.DockStyle.Fill;
            spStep.Location = new System.Drawing.Point(0, 0);
            spStep.Name = "spStep";
            spStep.Size = new System.Drawing.Size(594, 52);
            spStep.Steps.AddRange(new Telerik.WinControls.UI.StepProgressItem[] { spHello, spUser, spBrand, stepProgressItem1 });
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
            // stepProgressItem1
            // 
            stepProgressItem1.Name = "stepProgressItem1";
            stepProgressItem1.Text = "stepProgressItem1";
            // 
            // radPanel1
            // 
            radPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            radPanel1.Controls.Add(pYourOrganization);
            radPanel1.Controls.Add(pCompanyInfo);
            radPanel1.Controls.Add(pTheBrand);
            radPanel1.Controls.Add(pUser);
            radPanel1.Location = new System.Drawing.Point(152, 58);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new System.Drawing.Size(576, 301);
            radPanel1.TabIndex = 1;
            radPanel1.ThemeName = "Fluent";
            // 
            // pCompanyInfo
            // 
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
            pCompanyInfo.Size = new System.Drawing.Size(576, 301);
            pCompanyInfo.TabIndex = 0;
            pCompanyInfo.Visible = false;
            // 
            // cmbLanguage
            // 
            cmbLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbLanguage.DisplayMember = "LanguageName";
            cmbLanguage.DropDownAnimationEnabled = true;
            cmbLanguage.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbLanguage.Location = new System.Drawing.Point(162, 91);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new System.Drawing.Size(316, 27);
            cmbLanguage.TabIndex = 3;
            cmbLanguage.ThemeName = "Windows8";
            cmbLanguage.ValueMember = "Name";
            cmbLanguage.Enter += cmbLanguage_Enter;
            // 
            // cmbCountry
            // 
            cmbCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.DropDownAnimationEnabled = true;
            cmbCountry.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbCountry.Location = new System.Drawing.Point(162, 124);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new System.Drawing.Size(316, 27);
            cmbCountry.TabIndex = 3;
            cmbCountry.ThemeName = "Windows8";
            cmbCountry.ValueMember = "Name";
            cmbCountry.Enter += cmbCountry_Enter;
            // 
            // cmbCurrency
            // 
            cmbCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbCurrency.DisplayMember = "CurrencyName";
            cmbCurrency.DropDownAnimationEnabled = true;
            cmbCurrency.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbCurrency.Location = new System.Drawing.Point(162, 157);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new System.Drawing.Size(316, 27);
            cmbCurrency.TabIndex = 3;
            cmbCurrency.ThemeName = "Windows8";
            cmbCurrency.ValueMember = "Name";
            cmbCurrency.Enter += cmbCurrency_Enter;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(74, 163);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 15);
            label4.TabIndex = 2;
            label4.Text = "Your Currency";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(79, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Your Country";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(70, 97);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Your Language";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(265, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 32);
            label1.TabIndex = 1;
            label1.Text = "Hello!";
            // 
            // pTheBrand
            // 
            pTheBrand.Controls.Add(txtAbbrivation);
            pTheBrand.Controls.Add(txtCompanyName);
            pTheBrand.Controls.Add(label6);
            pTheBrand.Controls.Add(label7);
            pTheBrand.Controls.Add(label12);
            pTheBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            pTheBrand.Location = new System.Drawing.Point(0, 0);
            pTheBrand.Name = "pTheBrand";
            pTheBrand.Size = new System.Drawing.Size(576, 301);
            pTheBrand.TabIndex = 8;
            pTheBrand.Visible = false;
            // 
            // txtAbbrivation
            // 
            txtAbbrivation.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtAbbrivation.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtAbbrivation.Location = new System.Drawing.Point(144, 124);
            txtAbbrivation.Name = "txtAbbrivation";
            txtAbbrivation.Size = new System.Drawing.Size(316, 27);
            txtAbbrivation.TabIndex = 5;
            txtAbbrivation.ThemeName = "Windows8";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtCompanyName.Location = new System.Drawing.Point(144, 91);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new System.Drawing.Size(316, 27);
            txtCompanyName.TabIndex = 4;
            txtCompanyName.ThemeName = "Windows8";
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(69, 128);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 15);
            label6.TabIndex = 2;
            label6.Text = "Abbrivation";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(44, 98);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 15);
            label7.TabIndex = 2;
            label7.Text = "Company Name";
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(242, 10);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(130, 32);
            label12.TabIndex = 1;
            label12.Text = "The Brand";
            // 
            // pUser
            // 
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
            pUser.Size = new System.Drawing.Size(576, 301);
            pUser.TabIndex = 9;
            pUser.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtPassword.Location = new System.Drawing.Point(147, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(316, 27);
            txtPassword.TabIndex = 6;
            txtPassword.ThemeName = "Windows8";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtUsername.Location = new System.Drawing.Point(147, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(316, 27);
            txtUsername.TabIndex = 5;
            txtUsername.ThemeName = "Windows8";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtFullName.Location = new System.Drawing.Point(147, 102);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(316, 27);
            txtFullName.TabIndex = 4;
            txtFullName.ThemeName = "Windows8";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(84, 175);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(57, 15);
            label11.TabIndex = 2;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(81, 142);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(60, 15);
            label10.TabIndex = 2;
            label10.Text = "Username";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(80, 109);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(61, 15);
            label9.TabIndex = 2;
            label9.Text = "Full Name";
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(191, 10);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(227, 32);
            label8.TabIndex = 1;
            label8.Text = "The First User: You";
            // 
            // pYourOrganization
            // 
            pYourOrganization.Controls.Add(cmbCoaTemplate);
            pYourOrganization.Controls.Add(txtBank);
            pYourOrganization.Controls.Add(txtWhatItDo);
            pYourOrganization.Controls.Add(label15);
            pYourOrganization.Controls.Add(label5);
            pYourOrganization.Controls.Add(label13);
            pYourOrganization.Controls.Add(label14);
            pYourOrganization.Dock = System.Windows.Forms.DockStyle.Fill;
            pYourOrganization.Location = new System.Drawing.Point(0, 0);
            pYourOrganization.Name = "pYourOrganization";
            pYourOrganization.Size = new System.Drawing.Size(576, 301);
            pYourOrganization.TabIndex = 7;
            pYourOrganization.Visible = false;
            // 
            // cmbCoaTemplate
            // 
            cmbCoaTemplate.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbCoaTemplate.DisplayMember = "SupplierGroupName";
            cmbCoaTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCoaTemplate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            radListDataItem1.Selected = true;
            radListDataItem1.Text = "Standard Chart Of Accounts";
            radListDataItem2.Text = "Chart Of Accounts With Numbers";
            cmbCoaTemplate.Items.AddRange(new object[] { radListDataItem1, radListDataItem2 });
            cmbCoaTemplate.Location = new System.Drawing.Point(162, 157);
            cmbCoaTemplate.Name = "cmbCoaTemplate";
            cmbCoaTemplate.Size = new System.Drawing.Size(316, 25);
            cmbCoaTemplate.TabIndex = 2;
            cmbCoaTemplate.ValueMember = "Name";
            // 
            // txtBank
            // 
            txtBank.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtBank.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBank.Location = new System.Drawing.Point(162, 124);
            txtBank.Name = "txtBank";
            txtBank.Size = new System.Drawing.Size(316, 27);
            txtBank.TabIndex = 1;
            txtBank.ThemeName = "Windows8";
            // 
            // txtWhatItDo
            // 
            txtWhatItDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtWhatItDo.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtWhatItDo.Location = new System.Drawing.Point(162, 91);
            txtWhatItDo.Name = "txtWhatItDo";
            txtWhatItDo.Size = new System.Drawing.Size(316, 27);
            txtWhatItDo.TabIndex = 0;
            txtWhatItDo.ThemeName = "Windows8";
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(4, 162);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(151, 15);
            label15.TabIndex = 2;
            label15.Text = "Chart Of Account Template";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(87, 128);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 15);
            label5.TabIndex = 2;
            label5.Text = "Bank Name";
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(62, 98);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(95, 15);
            label13.TabIndex = 2;
            label13.Text = "What does it do?";
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(191, 10);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(223, 32);
            label14.TabIndex = 1;
            label14.Text = "Your Organization";
            // 
            // btnNext
            // 
            btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnNext.Location = new System.Drawing.Point(618, 365);
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
            btnBack.Location = new System.Drawing.Point(502, 365);
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
            btnCancel.Location = new System.Drawing.Point(152, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(78, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.ThemeName = "Windows8";
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(146, 422);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(spStep);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(146, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(594, 52);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.user_logo;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(146, 422);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmCompanySetup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(740, 422);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(radPanel1);
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
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCurrency).EndInit();
            pTheBrand.ResumeLayout(false);
            pTheBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAbbrivation).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCompanyName).EndInit();
            pUser.ResumeLayout(false);
            pUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName).EndInit();
            pYourOrganization.ResumeLayout(false);
            pYourOrganization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBank).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtWhatItDo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Telerik.WinControls.UI.StepProgressItem spBrand;
        private System.Windows.Forms.Panel pUser;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtUsername;
        private Telerik.WinControls.UI.RadTextBox txtFullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pTheBrand;
        private Telerik.WinControls.UI.RadTextBox txtAbbrivation;
        private Telerik.WinControls.UI.RadTextBox txtCompanyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pYourOrganization;
        private System.Windows.Forms.ComboBox cmbCoaTemplate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Telerik.WinControls.UI.RadTextBox txtBank;
        private Telerik.WinControls.UI.RadTextBox txtWhatItDo;
        private Telerik.WinControls.UI.StepProgressItem stepProgressItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}