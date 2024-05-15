using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmPosProfile : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;
        Company company;

        public frmPosProfile(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtPosProfileName;
            this.BindCombo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPosProfileName.Text))
            {
                MessageBox.Show("Pos Profile Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPosProfileName.Focus();
                return;
            }
            if (this.cmbCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Company is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbCompany.Focus();
                return;
            }
            if (this.cmbWarehouse.SelectedIndex == -1)
            {
                MessageBox.Show("Warehouse is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbWarehouse.Focus();
                return;
            }
            if (this.cmbCurrency.SelectedIndex == -1)
            {
                MessageBox.Show("Currency is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbCurrency.Focus();
                return;
            }
            if (this.cmbWriteOffAccount.SelectedIndex == -1)
            {
                MessageBox.Show("Write Off Account is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbWriteOffAccount.Focus();
                return;
            }
            if (this.cmbWriteOffCostCenter.SelectedIndex == -1)
            {
                MessageBox.Show("Write Off Cost Center is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbWriteOffCostCenter.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                var pos_profile = dbContext.PosProfile.Where(x => x.Name.Equals(this.txtPosProfileName.Text.Trim())).FirstOrDefault();
                if (pos_profile is not null)
                {
                    MessageBox.Show("Pos Profile with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPosProfileName.Focus();
                    return;
                }
                PosProfile posProfile = new PosProfile()
                {
                    Name = this.txtPosProfileName.Text.Trim(),
                    Creation = DateTime.Now,
                    ModifiedBy = Global.UserName,
                    Owner = Global.UserName,
                    PosProfileName = this.txtPosProfileName.Text.Trim(),
                    Warehouse = dbContext.Warehouse.Where(w => w.Name.Equals(this.cmbWarehouse.SelectedValue)).FirstOrDefault(),
                    CompanyAddress = this.txtCompanyAddress.Text,
                    PrintFormat = this.cmbPrintFormat.Text,
                    PriceList = dbContext.PriceList.Where(w => w.Name.Equals(this.cmbSellingPriceList.SelectedValue)).FirstOrDefault(),
                    Currency = dbContext.Currency.Where(w => w.Name.Equals(this.cmbCurrency.SelectedValue)).FirstOrDefault(),
                    WriteOffAccount = dbContext.Account.Where(w => w.Name.Equals(this.cmbWriteOffAccount.SelectedValue)).FirstOrDefault(),
                    WriteOffCostCenter = dbContext.CostCenter.Where(w => w.Name.Equals(this.cmbWriteOffCostCenter.SelectedValue)).FirstOrDefault(),
                    WriteOffLimit = this.txtWriteOffLimit.Value,
                    AccountForChangeAmount = dbContext.Account.Where(w => w.Name.Equals(this.cmbAccForChangeAmount.SelectedValue)).FirstOrDefault(),
                    IncomeAccount = dbContext.Account.Where(w => w.Name.Equals(this.cmbIncomeAccount.SelectedValue)).FirstOrDefault(),
                    ExpenseAccount = dbContext.Account.Where(w => w.Name.Equals(this.cmbExpenseAccount.SelectedValue)).FirstOrDefault(),
                    Company = dbContext.Company.Where(w => w.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault(),
                    Customer = dbContext.Customer.Where(w => w.Name.Equals(this.cmbCustomer.SelectedValue)).FirstOrDefault(),
                    Country = dbContext.Country.Where(w => w.Name.Equals(this.cmbCountry.SelectedValue)).FirstOrDefault(),
                    IgnorePricingRule = this.chkIgnorePricingRule.Checked,
                    AllowChangeRate = this.chkAllowChangeRate.Checked,
                    AllowChangeDiscount = this.chkAllowChangeDiscount.Checked,
                    ValidateStockOnSave = this.chkValidateStock.Checked,
                    UpdateStock = this.chkUpdateStock.Checked,
                    Disabled = this.chkDisabled.Checked,
                    DisableRoundedTotal = this.chkDisableRoundedTotal.Checked,
                    AdditionalDiscountLimit = this.txtAdditionalDiscLimit.Value,
                    CostCenter = dbContext.CostCenter.Where(w => w.Name.Equals(this.cmbCostCenter.SelectedValue)).FirstOrDefault(),
                    ReceiptFooter = this.txtFooter.Text,
                    ReceiptHeader = this.txtHeader.Text
                };
                dbContext.PosProfile.Add(posProfile);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                var posProfile = dbContext.PosProfile.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (posProfile is not null)
                {
                    posProfile.ModifiedBy = Global.UserName;
                    posProfile.PosProfileName = this.txtPosProfileName.Text.Trim();
                    posProfile.Warehouse = dbContext.Warehouse.Where(w => w.Name.Equals(this.cmbWarehouse.SelectedValue)).FirstOrDefault();
                    posProfile.CompanyAddress = this.txtCompanyAddress.Text;
                    posProfile.PrintFormat = this.cmbPrintFormat.Text;
                    posProfile.PriceList = dbContext.PriceList.Where(w => w.Name.Equals(this.cmbSellingPriceList.SelectedValue)).FirstOrDefault();
                    posProfile.Currency = dbContext.Currency.Where(w => w.Name.Equals(this.cmbCurrency.SelectedValue)).FirstOrDefault();
                    posProfile.WriteOffAccount = dbContext.Account.Where(w => w.Name.Equals(this.cmbWriteOffAccount.SelectedValue)).FirstOrDefault();
                    posProfile.WriteOffCostCenter = dbContext.CostCenter.Where(w => w.Name.Equals(this.cmbWriteOffCostCenter.SelectedValue)).FirstOrDefault();
                    posProfile.WriteOffLimit = this.txtWriteOffLimit.Value;
                    posProfile.AccountForChangeAmount = dbContext.Account.Where(w => w.Name.Equals(this.cmbAccForChangeAmount.SelectedValue)).FirstOrDefault();
                    posProfile.IncomeAccount = dbContext.Account.Where(w => w.Name.Equals(this.cmbIncomeAccount.SelectedValue)).FirstOrDefault();
                    posProfile.ExpenseAccount = dbContext.Account.Where(w => w.Name.Equals(this.cmbExpenseAccount.SelectedValue)).FirstOrDefault();
                    posProfile.Company = dbContext.Company.Where(w => w.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault();
                    posProfile.Customer = dbContext.Customer.Where(w => w.Name.Equals(this.cmbCustomer.SelectedValue)).FirstOrDefault();
                    posProfile.IgnorePricingRule = this.chkIgnorePricingRule.Checked;
                    posProfile.AllowChangeRate = this.chkAllowChangeRate.Checked;
                    posProfile.AllowChangeDiscount = this.chkAllowChangeDiscount.Checked;
                    posProfile.ValidateStockOnSave = this.chkValidateStock.Checked;
                    posProfile.UpdateStock = this.chkUpdateStock.Checked;
                    posProfile.Disabled = this.chkDisabled.Checked;
                    posProfile.DisableRoundedTotal = this.chkDisableRoundedTotal.Checked;
                    posProfile.AdditionalDiscountLimit = this.txtAdditionalDiscLimit.Value;
                    posProfile.CostCenter = dbContext.CostCenter.Where(w => w.Name.Equals(this.cmbCostCenter.SelectedValue)).FirstOrDefault();
                    posProfile.ReceiptFooter = this.txtFooter.Text;
                    posProfile.ReceiptHeader = this.txtHeader.Text;
                    dbContext.PosProfile.Update(posProfile);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtPosProfileName.Clear();
            this.cmbWarehouse.SelectedIndex = -1;
            this.txtCompanyAddress.Clear();
            this.cmbPrintFormat.SelectedIndex = -1;
            this.cmbSellingPriceList.SelectedIndex = -1;
            this.cmbCurrency.SelectedIndex = -1;
            this.cmbWriteOffAccount.SelectedIndex = -1;
            this.cmbWriteOffCostCenter.SelectedIndex = -1;
            this.txtWriteOffLimit.Value = 1;
            this.cmbAccForChangeAmount.SelectedIndex = -1;
            this.cmbIncomeAccount.SelectedIndex = -1;
            this.cmbExpenseAccount.SelectedIndex = -1;
            this.cmbCompany.SelectedValue = Global.Company.Name;
            this.cmbCustomer.SelectedIndex = -1;
            this.cmbCountry.SelectedValue = Global.Country.Name;
            this.chkAllowChangeDiscount.Checked = false;
            this.chkAllowChangeRate.Checked = false;
            this.chkDisabled.Checked = false;
            this.chkDisableRoundedTotal.Checked = false;
            this.chkIgnorePricingRule.Checked = false;
            this.chkUpdateStock.Checked = false;
            this.chkValidateStock.Checked = false;
            this.txtAdditionalDiscLimit.Value = 0;
            this.tabControl1.SelectTab(0);
            this.txtPosProfileName.Focus();
            this.cmbCostCenter.SelectedIndex = -1;
            this.txtFooter.Clear();
            this.txtHeader.Clear();
        }

        private void frmPosProfile_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtPosProfileName.Focus();
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
            var posProfiles = dbContext.PosProfile
                            .OrderByDescending(x => x.Modified)
                            .Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text))
                            .Take((int)this.txtLimit.Value)
                            .ToList();
            this.gvList.DataSource = posProfiles;
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
                var posProfile = dbContext.PosProfile.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (posProfile is not null)
                {
                    this.txtPosProfileName.Text = posProfile.PosProfileName;
                    this.cmbWarehouse.SelectedValue = posProfile.Warehouse?.Name ?? null;
                    this.txtCompanyAddress.Text = posProfile.CompanyAddress;
                    this.cmbPrintFormat.Text = posProfile.PrintFormat;
                    this.cmbSellingPriceList.SelectedValue = posProfile.PriceList?.Name ?? null;
                    this.cmbCurrency.SelectedValue = posProfile.Currency?.Name ?? null;
                    this.cmbWriteOffAccount.SelectedValue = posProfile.WriteOffAccount?.Name ?? null;
                    this.cmbWriteOffCostCenter.SelectedValue = posProfile.WriteOffCostCenter?.Name ?? null;
                    this.txtWriteOffLimit.Value = posProfile.WriteOffLimit;
                    this.cmbAccForChangeAmount.SelectedValue = posProfile.AccountForChangeAmount?.Name ?? null;
                    this.cmbIncomeAccount.SelectedValue = posProfile.IncomeAccount?.Name ?? null;
                    this.cmbExpenseAccount.SelectedValue = posProfile.ExpenseAccount?.Name ?? null;
                    this.cmbCompany.SelectedValue = posProfile.Company?.Name ?? null;
                    this.cmbCustomer.SelectedValue = posProfile.Customer?.Name ?? null;
                    this.chkIgnorePricingRule.Checked = posProfile.IgnorePricingRule;
                    this.chkAllowChangeRate.Checked = posProfile.AllowChangeRate;
                    this.chkAllowChangeDiscount.Checked = posProfile.AllowChangeDiscount;
                    this.chkValidateStock.Checked = posProfile.ValidateStockOnSave;
                    this.chkUpdateStock.Checked = posProfile.UpdateStock;
                    this.chkDisabled.Checked = posProfile.Disabled;
                    this.chkDisableRoundedTotal.Checked = posProfile.DisableRoundedTotal;
                    this.txtAdditionalDiscLimit.Value = posProfile.AdditionalDiscountLimit;
                    this.cmbCostCenter.SelectedValue = posProfile.CostCenter?.Name ?? null;
                    this.txtFooter.Text = posProfile.ReceiptFooter;
                    this.txtHeader.Text = posProfile.ReceiptHeader;
                    this.tabControl1.SelectTab(0);
                    this.txtPosProfileName.Focus();
                    this.lblID.Visible = true;
                }
            }
        }

        private void brnRefreshFields_Click(object sender, EventArgs e)
        {
            this.BindCombo();
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
                    var posProfile = dbContext.PosProfile.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (posProfile is not null)
                    {
                        dbContext.PosProfile.Remove(posProfile);
                        dbContext.SaveChanges();
                        MessageBox.Show($"{this.lblID.Text} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnNew.PerformClick();
                    }
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.BindGrid();
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

        private void BindCombo()
        {
            this.cmbCompany.DataSource = dbContext.Company.ToList();
            this.cmbCompany.SelectedValue = Global.Company.Name ?? null;
            this.cmbWarehouse.DataSource = dbContext.Warehouse.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company)).ToList();
            this.cmbSellingPriceList.DataSource = dbContext.PriceList.Where(w => w.Selling).ToList();
            this.cmbCurrency.DataSource = dbContext.Currency.Where(w => w.Enabled).ToList();
            this.cmbCurrency.SelectedValue = Global.Currency.Name;
            this.cmbWriteOffAccount.DataSource = dbContext.Account.Where(w => !w.Disabled && !w.IsGroup && w.ReportType.Equals("Profit and Loss") && w.Company.Equals(company)).ToList();
            this.cmbWriteOffCostCenter.DataSource = dbContext.CostCenter.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company)).ToList();
            this.cmbAccForChangeAmount.DataSource = dbContext.Account.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company) && new List<string>() { "Cash", "Bank" }.Contains(w.AccountType)).ToList();
            this.cmbIncomeAccount.DataSource = dbContext.Account.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company) && w.AccountType.Equals("Income Account")).ToList();
            this.cmbExpenseAccount.DataSource = dbContext.Account.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company) && w.ReportType.Equals("Profit and Loss")).ToList();
            this.cmbCountry.DataSource = dbContext.Country.ToList();
            this.cmbCountry.SelectedValue = Global.Country.Name;
            this.cmbCostCenter.DataSource = dbContext.CostCenter.Where(w => !w.Disabled && !w.IsGroup).ToList();
        }

        private void cmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            company = dbContext.Company.Where(c => c.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault();
        }

        private void cmbWarehouse_Enter(object sender, EventArgs e)
        {
            this.cmbWarehouse.DataSource = dbContext.Warehouse.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company)).ToList();
        }

        private void cmbWriteOffAccount_Enter(object sender, EventArgs e)
        {
            this.cmbWriteOffAccount.DataSource = dbContext.Account.Where(w => !w.Disabled && !w.IsGroup && w.ReportType.Equals("Profit and Loss") && w.Company.Equals(company)).ToList();
        }

        private void cmbWriteOffCostCenter_Enter(object sender, EventArgs e)
        {
            this.cmbWriteOffCostCenter.DataSource = dbContext.CostCenter.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company)).ToList();
        }

        private void cmbAccForChangeAmount_Enter(object sender, EventArgs e)
        {
            this.cmbAccForChangeAmount.DataSource = dbContext.Account.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company) && new List<string>() { "Cash", "Bank" }.Contains(w.AccountType)).ToList();
        }

        private void cmbIncomeAccount_Enter(object sender, EventArgs e)
        {
            this.cmbIncomeAccount.DataSource = dbContext.Account.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company) && w.AccountType.Equals("Income Account")).ToList();
        }

        private void cmbExpenseAccount_Enter(object sender, EventArgs e)
        {
            this.cmbExpenseAccount.DataSource = dbContext.Account.Where(w => !w.Disabled && !w.IsGroup && w.Company.Equals(company) && w.ReportType.Equals("Profit and Loss")).ToList();
        }
    }
}
