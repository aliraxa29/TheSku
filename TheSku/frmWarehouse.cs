using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmWarehouse : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;

        public frmWarehouse(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtWarehouseName;
            this.brnRefreshFields.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtWarehouseName.Text))
            {
                MessageBox.Show("Warehouse Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWarehouseName.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                Warehouse warehouse = dbContext.Warehouse.Where(x => x.Name.Equals(this.txtWarehouseName.Text.Trim())).FirstOrDefault();
                if (warehouse is not null)
                {
                    MessageBox.Show("Warehouse with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtWarehouseName.Focus();
                    return;
                }
                Warehouse warehouse1 = new Warehouse()
                {
                    Name = this.txtWarehouseName.Text.Trim(),
                    Creation = DateTime.Now,
                    Owner = Global.UserName,
                    WarehouseName = this.txtWarehouseName.Text.Trim(),
                    ParentWarehouse = this.cmbParentWarehouse.SelectedValue?.ToString(),
                    Account = dbContext.Account.Where(a => a.Name.Equals(this.cmbAccount.SelectedValue)).FirstOrDefault(),
                    AddressLine1 = this.txtAddressLine1.Text,
                    AddressLine2 = this.txtAddressLine2.Text,
                    City = this.txtCity.Text,
                    Company = dbContext.Company.Where(a => a.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault(),
                    Enabled = this.chkEnable.Checked,
                    IsFranchise = this.chkIsFranchise.Checked,
                    IsGroup = this.chkIsGroupWarehouse.Checked,
                    MobileNo = this.txtMobileNo.Text,
                    PhoneNo = this.txtPhoneNo.Text,
                    State = this.txtState.Text
                };
                dbContext.Warehouse.Add(warehouse1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                if (dbContext.Warehouse.Where(w => w.ParentWarehouse.Equals(this.lblID.Text)).ToList().Count > 0 && !this.chkEnable.Checked)
                {
                    MessageBox.Show($"You cannot disable {this.lblID.Text} untill child warehouses are present.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Warehouse warehouse = dbContext.Warehouse.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (warehouse is not null)
                {
                    warehouse.WarehouseName = this.txtWarehouseName.Text.Trim();
                    warehouse.ParentWarehouse = this.cmbParentWarehouse.SelectedValue?.ToString();
                    warehouse.Account = dbContext.Account.Where(a => a.Name.Equals(this.cmbAccount.SelectedValue)).FirstOrDefault();
                    warehouse.AddressLine1 = this.txtAddressLine1.Text;
                    warehouse.AddressLine2 = this.txtAddressLine2.Text;
                    warehouse.City = this.txtCity.Text;
                    warehouse.Company = dbContext.Company.Where(a => a.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault();
                    warehouse.Enabled = this.chkEnable.Checked;
                    warehouse.IsFranchise = this.chkIsFranchise.Checked;
                    warehouse.IsGroup = this.chkIsGroupWarehouse.Checked;
                    warehouse.MobileNo = this.txtMobileNo.Text;
                    warehouse.PhoneNo = this.txtPhoneNo.Text;
                    warehouse.State = this.txtState.Text;
                    dbContext.Warehouse.Update(warehouse);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtWarehouseName.Clear();
            this.cmbParentWarehouse.SelectedIndex = -1;
            this.cmbAccount.SelectedIndex = -1;
            this.txtAddressLine1.Clear();
            this.txtAddressLine2.Clear();
            this.txtCity.Clear();
            this.cmbCompany.SelectedIndex = -1;
            this.chkEnable.Checked = true;
            this.chkIsFranchise.Checked = false;
            this.chkIsGroupWarehouse.Checked = false;
            this.txtMobileNo.Clear();
            this.txtPhoneNo.Clear();
            this.txtState.Clear();
            this.tabControl1.SelectTab(0);
            this.txtWarehouseName.Focus();
            this.chkIsGroupWarehouse.ReadOnly = false;
        }

        private void frmWarehouse_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtWarehouseName.Focus();
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
            var warehouses = dbContext.Warehouse
                            .OrderByDescending(x => x.Modified)
                            .Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text))
                            .Take((int)this.txtLimit.Value)
                            .ToList();
            this.gvList.DataSource = warehouses;
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
                var warehouse = dbContext.Warehouse.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (warehouse is not null)
                {
                    this.txtWarehouseName.Text = warehouse.WarehouseName;
                    this.cmbParentWarehouse.SelectedValue = warehouse.ParentWarehouse;
                    this.cmbAccount.SelectedValue = warehouse.Account?.Name ?? "";
                    this.txtAddressLine1.Text = warehouse.AddressLine1;
                    this.txtAddressLine2.Text = warehouse.AddressLine2;
                    this.txtCity.Text = warehouse.City;
                    this.cmbCompany.SelectedValue = warehouse.Company?.Name ?? null;
                    this.chkEnable.Checked = warehouse.Enabled;
                    this.chkIsFranchise.Checked = warehouse.IsFranchise;
                    this.chkIsGroupWarehouse.Checked = warehouse.IsGroup;
                    this.txtMobileNo.Text = warehouse.MobileNo;
                    this.txtPhoneNo.Text = warehouse.PhoneNo;
                    this.txtState.Text = warehouse.State;
                    this.tabControl1.SelectTab(0);
                    this.txtWarehouseName.Focus();
                    this.lblID.Visible = true;
                    this.chkIsGroupWarehouse.ReadOnly = true;
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.BindGrid();
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
                    Warehouse warehouse = dbContext.Warehouse.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (warehouse is not null)
                    {
                        dbContext.Warehouse.Remove(warehouse);
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
            this.cmbCompany.DataSource = dbContext.Company.ToList();
            this.cmbCompany.SelectedValue = Global.Company?.Name ?? null;
            this.cmbAccount.DataSource = dbContext.Account.Where(a => !a.IsGroup && !a.Disabled && a.AccountType.Equals("Stock") && a.Company.Equals(dbContext.Company.Where(c => c.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault())).ToList();
            this.cmbParentWarehouse.DataSource = dbContext.Warehouse.Where(w => w.IsGroup && w.Enabled).ToList();
            this.cmbParentWarehouse.SelectedIndex = -1;
        }

        private void cmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.cmbAccount.DataSource = dbContext.Account.Where(a => !a.IsGroup && !a.Disabled && a.AccountType.Equals("Stock") && a.Company.Equals(dbContext.Company.Where(c => c.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault())).ToList();
        }
    }
}
