using System;
using System.Linq;
using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmCompanySetup : Form
    {
        AppDbContext dbContext;
        int Current = 0;

        public frmCompanySetup(AppDbContext dbContext)
        {
            InitializeComponent();
            this.spStep.CompleteNext();
            if (Current == 0)
            {
                this.btnBack.Enabled = false;
            }
            else
            {
                this.btnBack.Enabled = true;
            }
            this.pCompanyInfo.Visible = true;
            this.dbContext = dbContext;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are going to close company setup.\nThis will not initialize your application if you have not setup your company.\nWould you like to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Back();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Current == 0)
            {
                if (this.cmbLanguage.SelectedIndex == -1)
                {
                    MessageBox.Show("Language is Required. Please select from the list", "Select Language", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbLanguage.Focus();
                    return;
                }
                if (this.cmbCountry.SelectedIndex == -1)
                {
                    MessageBox.Show("Country is Required. Please select from the list", "Select Country", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbCountry.Focus();
                    return;
                }
                if (this.cmbCurrency.SelectedIndex == -1)
                {
                    MessageBox.Show("Currency is Required. Please select from the list", "Select Currency", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbCurrency.Focus();
                    return;
                }
            }
            if (Current == 1)
            {
                if (string.IsNullOrWhiteSpace(this.txtCompanyName.Text))
                {
                    MessageBox.Show("Company name is required", "Company", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCompanyName.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.txtAbbrivation.Text))
                {
                    MessageBox.Show("Abbrivation is Required.", "Abbrivation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtAbbrivation.Focus();
                    return;
                }
            }
            if (Current == 2)
            {
                if (string.IsNullOrWhiteSpace(this.txtFullName.Text))
                {
                    MessageBox.Show("Please enter your full name", "Full Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtFullName.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.txtUsername.Text))
                {
                    MessageBox.Show("Username is Required for creation first user.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsername.Focus();
                    return;
                }
            }
            if (Current == 3)
            {
                if (string.IsNullOrWhiteSpace(this.txtWhatItDo.Text))
                {
                    MessageBox.Show("Please write what this company do", "What Does it Do", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtWhatItDo.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.txtBank.Text))
                {
                    MessageBox.Show("Bank name is Required.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtBank.Focus();
                    return;
                }
                if (this.cmbCoaTemplate.SelectedIndex == -1)
                {
                    MessageBox.Show("Chart of Account Template is required", "COA Template", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbCoaTemplate.Focus();
                    return;
                }
            }
            if (this.btnNext.Text == "Complete")
            {
                Company company = dbContext.Company.Where(c => c.CompanyName.Equals(this.txtCompanyName.Text.Trim())).FirstOrDefault();
                if (company == null)
                {
                    company = dbContext.Company.Where(c => c.Abbrivation.Equals(this.txtAbbrivation.Text.Trim())).FirstOrDefault();
                    if (company == null)
                    {
                        var country = dbContext.Country.Where(c => c.Name.Equals(this.cmbCountry.SelectedValue)).FirstOrDefault();
                        var currency = dbContext.Currency.Where(c => c.Name.Equals(this.cmbCurrency.SelectedValue)).FirstOrDefault();
                        string[] name = this.txtFullName.Text.Split(' ');
                        Company c = new Company();
                        c.Name = string.Concat(this.txtCompanyName.Text.Trim(), " - ", this.txtAbbrivation.Text.Trim());
                        c.Creation = DateTime.Now;
                        c.ModifiedBy = "Administrator";
                        c.Owner = "Administrator";
                        c.CompanyName = this.txtCompanyName.Text.Trim();
                        c.Abbrivation = this.txtAbbrivation.Text.Trim();
                        c.Country = country;
                        c.CompanyDescription = this.txtBank.Text;
                        c.CoaBasedOn = "Standard Template";
                        c.CoaTemplate = this.cmbCoaTemplate.SelectedItem.ToString();
                        c.Currency = currency;
                        dbContext.Company.Add(c);
                        dbContext.Users.Add(new() { Creation = DateTime.Now, FullName = this.txtFullName.Text, Name = this.txtUsername.Text.Trim(), UserName = this.txtUsername.Text, Password = Security.EncryptString(this.txtPassword.Text), ModifiedBy = "Administrator", FirstName = name[0], LastName = name.Length > 1 ? name[1] : "", Role = dbContext.Roles.Where(r => r.Name.Equals("System Manager")).FirstOrDefault() });
                        dbContext.SaveChanges();
                        this.CreateChartOfAccounts(c, currency);
                        this.AddCostCenters(c);
                        this.AddWarehouses(c);
                        MessageBox.Show("Company Setup Completed.\nNow application will be closed. You can restart the application to start.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show($"Abbrivation {this.txtAbbrivation.Text} is already been used by another company", "Abbr Already Used", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Company {this.txtCompanyName.Text} is already exists.", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Next();
        }

        public void AddWarehouses(Company company)
        {
            dbContext.Warehouse.AddRange(DefaultData.Warehouses(company, "Administrator"));
            dbContext.SaveChanges();
        }

        public void AddCostCenters(Company company)
        {
            dbContext.CostCenter.AddRange(DefaultData.CostCenters(company, "Administrator"));
            dbContext.SaveChanges();
        }

        public void CreateChartOfAccounts(Company company, Currency currency)
        {
            if (this.cmbCoaTemplate.Text == "Standard Chart Of Accounts")
            {
                Account account = new()
                {
                    Name = string.Concat(this.txtBank.Text.Trim(), " - ", company.Abbrivation),
                    Creation = DateTime.Now,
                    Modified = DateTime.Now,
                    ModifiedBy = "Administrator",
                    Owner = "Administrator",
                    Disabled = false,
                    AccountName = this.txtBank.Text.Trim(),
                    IsGroup = false,
                    Company = company,
                    RootType = "Asset",
                    ReportType = "Balance Sheet",
                    Currency = currency,
                    ParentAccount = $"Bank Accounts - {company.Abbrivation}",
                    AccountType = "Bank"
                };
                dbContext.Account.Add(account);
                dbContext.Account.AddRange(ChartOfAccounts.GetStandardAccounts(company, currency, this.txtAbbrivation.Text.Trim(), "Administrator"));
                dbContext.SaveChanges();
            }
            else if (this.cmbCoaTemplate.Text == "Chart Of Accounts With Numbers")
            {
                Account account = new()
                {
                    Name = string.Concat("1200 - ", this.txtBank.Text.Trim(), " - ", company.Abbrivation),
                    Creation = DateTime.Now,
                    Modified = DateTime.Now,
                    ModifiedBy = "Administrator",
                    Owner = "Administrator",
                    Disabled = false,
                    AccountName = this.txtBank.Text.Trim(),
                    IsGroup = false,
                    Company = company,
                    RootType = "Asset",
                    ReportType = "Balance Sheet",
                    Currency = currency,
                    ParentAccount = $"Bank Accounts - {company.Abbrivation}",
                    AccountType = "Bank"
                };
                dbContext.Account.Add(account);
                dbContext.Account.AddRange(ChartOfAccounts.GetAccountsWithNumbers(company, currency, this.txtAbbrivation.Text.Trim(), "Administrator"));
                dbContext.SaveChanges();
            }
        }

        private void Back()
        {
            this.spStep.CompletePrevious();
            if (Current > 0)
            {
                this.Current--;
                if (Current < 3)
                {
                    this.btnNext.Text = "Next";
                }
            }
            if (this.Current == 0)
            {
                this.btnBack.Enabled = false;
            }
            else
            {
                this.btnBack.Enabled = true;
            }
            if (Current == 0)
            {
                this.pCompanyInfo.Visible = true;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 1)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = true;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 2)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = true;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 3)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = true;
            }
        }

        private void Next()
        {
            this.spStep.CompleteNext();
            if (Current < 3)
            {
                this.Current++;
                if (Current > 0 && !this.btnBack.Enabled)
                {
                    this.btnBack.Enabled = true;
                }
            }
            if (this.Current == 3)
            {
                this.btnNext.Text = "Complete";
            }
            else
            {
                this.btnNext.Text = "Next";
            }
            if (this.Current == 0)
            {
                this.btnBack.Enabled = false;
            }
            else
            {
                this.btnBack.Enabled = true;
            }
            if (Current == 0)
            {
                this.pCompanyInfo.Visible = true;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 1)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = true;
                this.txtCompanyName.Focus();
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 2)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = true;
                this.txtFullName.Focus();
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 3)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = true;
                this.txtWhatItDo.Focus();
            }
        }

        private void cmbLanguage_Enter(object sender, EventArgs e)
        {
            if (this.cmbLanguage.DataSource == null)
            {
                this.cmbLanguage.DataSource = dbContext.Languages.OrderBy(l => l.Name).ToList();
            }
        }

        private void cmbCountry_Enter(object sender, EventArgs e)
        {
            if (this.cmbCountry.DataSource == null)
            {
                this.cmbCountry.DataSource = dbContext.Country.OrderBy(l => l.Name).ToList();
            }
        }

        private void cmbCurrency_Enter(object sender, EventArgs e)
        {
            if (this.cmbCurrency.DataSource == null)
            {
                this.cmbCurrency.DataSource = dbContext.Currency.OrderBy(l => l.Name).ToList();
            }
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            this.txtAbbrivation.Text = frmCompany.GetInitials(this.txtCompanyName.Text.Trim());
        }
    }
}
