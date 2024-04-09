using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmCompany : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;

        public frmCompany(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.cmbCoaBasedOn.SelectedIndex = 0;
            this.ActiveControl = this.txtCompanyName;
            this.BindCombo();
            this.dtpEstablishment.NullableValue = null;
            this.dtpIncorporation.NullableValue = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCompanyName.Text))
            {
                MessageBox.Show("Company Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCompanyName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtAbbrivation.Text))
            {
                MessageBox.Show("Company Abbrivation is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAbbrivation.Focus();
                return;
            }
            if (this.cmbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Country is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbCountry.Focus();
                return;
            }
            if (this.cmbCurrency.SelectedIndex == -1)
            {
                MessageBox.Show("Currency is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbCurrency.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                if (dbContext.Company.Count(c => c.Abbrivation == this.txtAbbrivation.Text.Trim()) > 0)
                {
                    MessageBox.Show("This abbrivation is already used by another company", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtAbbrivation.Focus();
                    return;
                }
                string company = string.Concat(this.txtCompanyName.Text.Trim(), " - ", this.txtAbbrivation.Text.Trim());
                var company1 = dbContext.Company.Where(x => x.Name.Equals(company)).FirstOrDefault();
                if (company1 is not null)
                {
                    MessageBox.Show($"Company `{company1.Name}` with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCompanyName.Focus();
                    return;
                }
                if (this.cmbCoaBasedOn.Text == "Existing Company" && this.cmbExistingCompany.SelectedIndex <= -1)
                {
                    MessageBox.Show("Please select company from the list", "Company Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbExistingCompany.Focus();
                    return;
                }
                var country = dbContext.Country.FirstOrDefault(c => c.Name == this.cmbCountry.SelectedValue.ToString());
                var currency = dbContext.Currency.FirstOrDefault(c => c.Name == this.cmbCurrency.SelectedValue.ToString());
                Company company2 = new Company()
                {
                    Name = company,
                    Creation = DateTime.Now,
                    Owner = Global.UserName,
                    CompanyName = this.txtCompanyName.Text.Trim(),
                    Abbrivation = this.txtAbbrivation.Text.Trim(),
                    Country = country,
                    TaxID = this.txtTaxId.Text,
                    DateOfEstablishment = this.dtpEstablishment.NullableValue,
                    DateOfIncorporation = this.dtpIncorporation.NullableValue,
                    Fax = this.txtFax.Text,
                    PhoneNo = this.txtPhoneNo.Text,
                    EmailAddress = this.txtEmailAddress.Text,
                    Website = this.txtWebsite.Text,
                    CompanyDescription = this.txtCompanyDescription.Text,
                    CoaBasedOn = this.cmbCoaBasedOn.SelectedItem?.ToString(),
                    CoaTemplate = this.cmbCoaTemplate.SelectedItem?.ToString(),
                    ExistingCompany = this.cmbCoaBasedOn.SelectedItem?.ToString() == "Existing Company" ? this.cmbExistingCompany.SelectedValue?.ToString() : null,
                    Currency = currency,
                };
                dbContext.Company.Add(company2);
                dbContext.SaveChanges();
                this.CreateChartOfAccounts(company2, currency);
                this.AddCostCenters(company2);
                this.ResetForm();
            }
            else
            {
                var company = dbContext.Company.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (company is not null)
                {
                    company.CompanyDescription = this.txtCompanyDescription.Text;
                    company.DateOfEstablishment = this.dtpEstablishment.NullableValue;
                    company.DateOfIncorporation = this.dtpIncorporation.NullableValue;
                    company.EmailAddress = this.txtEmailAddress.Text;
                    company.Fax = this.txtFax.Text;
                    company.TaxID = this.txtTaxId.Text;
                    company.PhoneNo = this.txtPhoneNo.Text;
                    company.Website = this.txtWebsite.Text;
                    dbContext.Company.Update(company);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void AddCostCenters(Company company)
        {
            dbContext.CostCenter.AddRange(DefaultData.CostCenters(company, Global.UserName));
            dbContext.SaveChanges();
        }

        private void CreateChartOfAccounts(Company company, Currency currency)
        {
            if (this.cmbCoaBasedOn.Text == "Standard Template")
            {
                if (this.cmbCoaTemplate.Text == "Standard Chart Of Accounts")
                {
                    dbContext.Account.AddRange(ChartOfAccounts.GetStandardAccounts(company, currency, this.txtAbbrivation.Text, Global.UserName));
                    dbContext.SaveChanges();
                }
                else if (this.cmbCoaTemplate.Text == "Chart Of Accounts With Numbers")
                {
                    dbContext.Account.AddRange(ChartOfAccounts.GetAccountsWithNumbers(company, currency, this.txtAbbrivation.Text, Global.UserName));
                    dbContext.SaveChanges();
                }
            }
            else if (this.cmbCoaBasedOn.Text == "Existing Company")
            {
                Company c = new Company();
                c.Name = this.cmbExistingCompany.SelectedValue.ToString();
                var accounts = dbContext.Account.Where(a => a.Company == c).ToList();
                foreach (Account account in accounts)
                {
                    account.Name = account.Name.Replace(account.Company.Abbrivation, company.Abbrivation);
                    account.Company = company;
                    account.Creation = DateTime.Now;
                    account.Modified = DateTime.Now;
                    if (account.ParentAccount != null)
                    {
                        account.ParentAccount = account.ParentAccount.Replace(account.Company.Abbrivation, company.Abbrivation);
                    }
                }
                dbContext.Account.AddRange(accounts);
                dbContext.SaveChanges();
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtAbbrivation.Clear();
            this.txtCompanyDescription.Clear();
            this.txtCompanyName.Clear();
            this.txtEmailAddress.Clear();
            this.txtFax.Clear();
            this.txtPhoneNo.Clear();
            this.txtTaxId.Clear();
            this.txtWebsite.Clear();
            this.cmbCoaBasedOn.SelectedIndex = 0;
            this.cmbCountry.SelectedIndex = -1;
            this.tabControl1.SelectTab(0);
            this.txtCompanyName.Focus();
            this.cmbCoaBasedOn.Enabled = true;
            this.cmbCoaTemplate.Enabled = true;
            this.cmbExistingCompany.Enabled = true;
            this.txtCompanyName.ReadOnly = false;
            this.txtAbbrivation.ReadOnly = false;
            this.cmbCurrency.Enabled = true;
        }

        private void frmCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnSave.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.btnClose.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                this.btnNew.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                this.btnDelete.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    tabControl1.SelectTab(1);
                    this.txtNameFilter.Focus();
                }
                else
                {
                    tabControl1.SelectTab(0);
                    this.txtCompanyName.Focus();
                }
            }
        }

        private void gvList_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (this.gvList.RowCount > 0 && e.RowIndex >= 0)
            {
                var cell = this.gvList.Rows[e.RowIndex].Cells["name"].Value;
                if (cell != null)
                {
                    this.lblID.Text = cell.ToString();
                    this.LoadData();
                }
            }
        }

        private void BindGrid()
        {
            var suppliers = dbContext.Company
                            .OrderByDescending(x => x.Modified)
                            .Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text))
                            .Take((int)this.txtLimit.Value)
                            .ToList();
            this.gvList.DataSource = suppliers;
        }

        private void LoadData()
        {
            if (this.lblID.Text != "0")
            {
                if (!this.IsBinded)
                {
                    this.brnRefreshFields.PerformClick();
                    this.IsBinded = true;
                }
                var company = dbContext.Company.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (company is not null)
                {
                    this.txtCompanyName.Text = company.CompanyName;
                    this.txtAbbrivation.Text = company.Abbrivation;
                    this.cmbCountry.SelectedValue = company.Country.Name;
                    this.txtTaxId.Text = company.TaxID;
                    this.dtpEstablishment.NullableValue = company.DateOfEstablishment;
                    this.dtpIncorporation.NullableValue = company.DateOfIncorporation;
                    this.txtFax.Text = company.Fax;
                    this.txtPhoneNo.Text = company.PhoneNo;
                    this.txtEmailAddress.Text = company.EmailAddress;
                    this.txtWebsite.Text = company.Website;
                    this.txtCompanyDescription.Text = company.CompanyDescription;
                    this.cmbCoaBasedOn.Text = company.CoaBasedOn;
                    this.cmbCoaTemplate.Text = company.CoaTemplate;
                    this.cmbExistingCompany.SelectedValue = company.ExistingCompany;
                    this.cmbCurrency.SelectedValue = company.Currency.Name;
                    this.cmbCoaBasedOn.Enabled = false;
                    this.cmbCoaTemplate.Enabled = false;
                    this.cmbExistingCompany.Enabled = false;
                    this.cmbCurrency.Enabled = false;
                    this.txtCompanyName.ReadOnly = true;
                    this.txtAbbrivation.ReadOnly = true;
                    this.tabControl1.SelectTab(0);
                    this.txtCompanyName.Focus();
                    this.lblID.Visible = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lblID.Text != "0")
            {
                if (MessageBox.Show($"Are you sure you want to delete {this.lblID.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var company = dbContext.Company.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (company is not null)
                    {
                        dbContext.Company.Remove(company);
                        dbContext.SaveChanges();
                        MessageBox.Show($"{this.lblID.Text} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnNew.PerformClick();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to close {this.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.Close();
            }
        }

        private void txtNameFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnDisplay.PerformClick();
            }
            if (this.gvList.RowCount > 0)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    this.gvList.Focus();
                }
            }
        }

        private void gvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.gvList.RowCount > 0)
            {
                GridCellElement cell = this.gvList.CurrentCell;
                this.gvList_CellDoubleClick(sender, new GridViewCellEventArgs(cell.RowInfo, cell.ColumnInfo, this.gvList.ActiveEditor));
            }
        }

        private void btnCopyNameToClipboard_Click(object sender, EventArgs e)
        {
            if (this.lblID.Text != "0")
            {
                Clipboard.SetText(this.lblID.Text);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void brnRefreshFields_Click(object sender, EventArgs e)
        {
            this.BindCombo();
        }

        private void BindCombo()
        {
            this.cmbCountry.DataSource = dbContext.Country.ToList();
            this.cmbCurrency.DataSource = dbContext.Currency.Where(c => c.Enabled == 1).ToList();
            this.cmbCountry.SelectedValue = Global.Country;
            this.cmbCurrency.SelectedValue = Global.Currency;
        }

        private void cmbCoaBasedOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCoaBasedOn.SelectedIndex == 0)
            {
                this.label17.Visible = false;
                this.cmbExistingCompany.Visible = false;
                this.label16.Visible = true;
                this.cmbCoaTemplate.Visible = true;
                this.cmbCoaTemplate.SelectedIndex = 0;
            }
            else if (this.cmbCoaBasedOn.SelectedIndex == 1)
            {
                this.label17.Visible = true;
                this.cmbExistingCompany.Visible = true;
                this.label16.Visible = false;
                this.cmbCoaTemplate.Visible = false;
                this.cmbExistingCompany.DataSource = dbContext.Company.Where(c => c.Name != this.lblID.Text).ToList();
            }
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            this.txtAbbrivation.Text = GetInitials(this.txtCompanyName.Text.Trim());
        }

        static string GetInitials(string input)
        {
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string initials = string.Concat(words.Select(word => word[0]));
            return initials;
        }
    }
}
