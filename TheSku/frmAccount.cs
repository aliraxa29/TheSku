using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmAccount : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;

        string[] RootAccounts = { "Application of Funds (Assets)", "Source of Funds (Liabilities)", "Equity", "Income", "Expenses" };

        public frmAccount(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtAccountNumber;
            this.BindCombo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtAccountName.Text))
            {
                MessageBox.Show("Account Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAccountName.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                if (this.cmbParentAccount.SelectedIndex == -1)
                {
                    MessageBox.Show("Parent account is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbParentAccount.Focus();
                    return;
                }
                string account_name = !string.IsNullOrWhiteSpace(this.txtAccountNumber.Text) ? string.Concat(this.txtAccountNumber.Text.Trim(), " - ", this.txtAccountName.Text) : this.txtAccountName.Text;
                var supplier = dbContext.Account.Where(x => x.Name.Equals(account_name)).FirstOrDefault();
                if (supplier is not null)
                {
                    MessageBox.Show("Account with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtAccountName.Focus();
                    return;
                }
                Account account = new Account()
                {
                    Name = account_name,
                    Creation = DateTime.Now,
                    Owner = Global.UserName,
                    Disabled = this.chkDisabled.Checked,
                    AccountName = this.txtAccountName.Text.Trim(),
                    AccountNumber = this.txtAccountNumber.Text.Trim(),
                    IsGroup = this.chkIsGroup.Checked,
                    Company = dbContext.Company.FirstOrDefault(),
                    RootType = this.cmbRootType.SelectedItem.ToString(),
                    ReportType = this.cmbReportType.SelectedItem.ToString(),
                    Currency = dbContext.Currency.FirstOrDefault(),
                    ParentAccount = this.cmbParentAccount.SelectedValue?.ToString(),
                    AccountType = this.cmbAccountType.SelectedItem.ToString(),
                    TaxRate = this.cmbAccountType.Text == "Tax" ? this.txtTaxRate.Value : 0,
                    FreezeAccount = this.chkFrozen.Checked,
                };
                dbContext.Account.Add(account);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                if (!this.RootAccounts.Contains(this.txtAccountName.Text) && this.cmbParentAccount.SelectedIndex == -1)
                {
                    MessageBox.Show("Parent account is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbParentAccount.Focus();
                    return;
                }
                var account = dbContext.Account.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (account is not null)
                {
                    account.Disabled = this.chkDisabled.Checked;
                    account.AccountName = this.txtAccountName.Text.Trim();
                    account.AccountNumber = this.txtAccountNumber.Text.Trim();
                    account.Company = dbContext.Company.Where(c => c.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault();
                    account.RootType = this.cmbRootType.SelectedItem.ToString();
                    account.ReportType = this.cmbReportType.SelectedItem.ToString();
                    account.Currency = dbContext.Currency.Where(c => c.Name.Equals(this.cmbCurrency.SelectedValue)).FirstOrDefault();
                    account.ParentAccount = this.cmbParentAccount.SelectedValue?.ToString();
                    account.AccountType = this.cmbAccountType.SelectedItem.ToString();
                    account.TaxRate = this.cmbAccountType.Text == "Tax" ? this.txtTaxRate.Value : 0;
                    account.FreezeAccount = this.chkFrozen.Checked;
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtAccountName.Clear();
            this.txtAccountNumber.Clear();
            this.txtTaxRate.Value = 0;
            this.cmbAccountType.SelectedIndex = 0;
            this.cmbBalanceMustBe.SelectedIndex = -1;
            this.cmbCompany.SelectedValue = Global.Company;
            this.cmbCurrency.SelectedValue = Global.Currency;
            this.cmbParentAccount.SelectedIndex = -1;
            this.cmbReportType.SelectedIndex = 0;
            this.cmbRootType.SelectedIndex = 0;
            this.tabControl1.SelectTab(0);
            this.txtAccountName.Focus();
            this.txtAccountName.ReadOnly = false;
            this.txtAccountNumber.ReadOnly = false;
            this.chkIsGroup.ReadOnly = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbAccountType.Text == "Tax")
            {
                this.lblTaxRate.Visible = true;
                this.txtTaxRate.Visible = true;
            }
            else
            {
                this.lblTaxRate.Visible = false;
                this.txtTaxRate.Visible = false;
            }
        }

        private void frmAccount_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtAccountName.Focus();
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
            var suppliers = dbContext.Account
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
                var account = dbContext.Account.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (account is not null)
                {
                    this.txtAccountName.Text = account.AccountName;
                    this.txtAccountNumber.Text = account.AccountNumber;
                    this.chkDisabled.Checked = account.Disabled;
                    this.chkFrozen.Checked = account.FreezeAccount;
                    this.chkIsGroup.Checked = account.IsGroup;
                    this.cmbAccountType.SelectedItem = account.AccountType;
                    this.txtTaxRate.Value = account.TaxRate;
                    this.cmbCompany.SelectedValue = account.Company.Name;
                    this.cmbRootType.SelectedItem = account.RootType;
                    this.cmbReportType.SelectedItem = account.ReportType;
                    this.cmbParentAccount.SelectedValue = account.ParentAccount;
                    this.cmbBalanceMustBe.SelectedItem = account.BalanceMustBe;
                    this.cmbCurrency.SelectedValue = account.Currency.Name;
                    this.txtAccountName.ReadOnly = true;
                    this.txtAccountNumber.ReadOnly = true;
                    this.chkIsGroup.ReadOnly = true;
                    this.tabControl1.SelectTab(0);
                    this.txtAccountName.Focus();
                    this.lblID.Visible = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lblID.Text != "0")
            {
                if (MessageBox.Show($"Are you sure you want to delete {this.lblID.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var account = dbContext.Account.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (account is not null)
                    {
                        dbContext.Account.Remove(account);
                        dbContext.SaveChanges();
                        MessageBox.Show($"{this.lblID.Text} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnNew.PerformClick();
                    }
                }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to close {this.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.Close();
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

        private void BindCombo()
        {
            this.cmbCompany.DataSource = dbContext.Company.ToList();
            this.cmbCompany.SelectedValue = Global.Company.Name;
            this.cmbCurrency.DataSource = dbContext.Currency.Where(c => c.Enabled).ToList();
            this.cmbCurrency.SelectedValue = Global.Currency.Name;
            this.cmbParentAccount.DataSource = dbContext.Account.Where(c => c.IsGroup && c.Company == dbContext.Company.Where(c => c.Name == this.cmbCompany.SelectedValue.ToString()).FirstOrDefault()).ToList();
        }

        private void brnRefreshFields_Click(object sender, EventArgs e)
        {
            this.BindCombo();
        }

        private void gvList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "status")
            {
                if (Convert.ToBoolean(e.CellElement.Value) == false)
                {
                    e.CellElement.Text = "Enabled";
                }
                else
                {
                    e.CellElement.Text = "Disabled";
                }
            }
        }
    }
}
