using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmCostCenter : Form
    {
        AppDbContext dbContext = new AppDbContext(DbContextOptionsProvider.Options);
        bool IsBinded = false;

        public frmCostCenter()
        {
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtCostCenterName;
            this.BindCombo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCostCenterName.Text))
            {
                MessageBox.Show("Cost Center Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCostCenterName.Focus();
                return;
            }
            if (this.cmbCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Company is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbCompany.Focus();
                return;
            }
            Company company = dbContext.Company.Where(c => c.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault();
            if (this.lblID.Text == "0")
            {
                string costcenter = string.Concat(this.txtCostCenterName.Text.Trim(), " - ", company.Abbrivation);
                int costcenter1 = dbContext.CostCenter.Where(x => x.Name.Equals(costcenter)).Count();
                if (costcenter1 > 0)
                {
                    MessageBox.Show("Cost Center with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCostCenterName.Focus();
                    return;
                }
                CostCenter costCenter = new CostCenter()
                {
                    Name = costcenter,
                    Creation = DateTime.Now,
                    ModifiedBy = Global.UserName,
                    Owner = Global.UserName,
                    CostCenterName = this.txtCostCenterName.Text.Trim(),
                    ParentCostCenter = this.cmbParentCostCenter.SelectedValue?.ToString(),
                    Company = company,
                    Disabled = this.chkDisabled.Checked,
                    IsGroup = this.chkIsGroup.Checked,
                };
                dbContext.CostCenter.Add(costCenter);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                var supplier1 = dbContext.CostCenter.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier1 is not null)
                {
                    supplier1.CostCenterName = this.txtCostCenterName.Text.Trim();
                    supplier1.Modified = DateTime.Now;
                    supplier1.ModifiedBy = Global.UserName;
                    supplier1.ParentCostCenter = this.cmbParentCostCenter.SelectedValue?.ToString();
                    supplier1.Company = company;
                    supplier1.Disabled = this.chkDisabled.Checked;
                    supplier1.IsGroup = this.chkIsGroup.Checked;
                    dbContext.CostCenter.Update(supplier1);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtCostCenterName.Clear();
            this.cmbCompany.SelectedValue = Global.Company.Name;
            this.chkDisabled.Checked = false;
            this.chkIsGroup.Checked = false;
            this.cmbParentCostCenter.SelectedIndex = -1;
            this.tabControl1.SelectTab(0);
            this.txtCostCenterName.Focus();
        }

        private void frmCostCenter_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtCostCenterName.Focus();
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
            var suppliers = dbContext.CostCenter
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
                var supplier = dbContext.CostCenter.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier is not null)
                {
                    this.txtCostCenterName.Text = supplier.CostCenterName;
                    this.cmbCompany.SelectedValue = supplier.Company.Name;
                    this.cmbParentCostCenter.SelectedValue = supplier.ParentCostCenter;
                    this.chkDisabled.Checked = supplier.Disabled;
                    this.chkIsGroup.Checked = supplier.IsGroup;
                    this.tabControl1.SelectTab(0);
                    this.txtCostCenterName.Focus();
                    this.lblID.Visible = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to close {this.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.Close();
            }
        }

        private void btnCopyNameToClipboard_Click(object sender, EventArgs e)
        {
            if (this.lblID.Text != "0")
            {
                Clipboard.SetText(this.lblID.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lblID.Text != "0")
            {
                if (MessageBox.Show($"Are you sure you want to delete {this.lblID.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var supplier = dbContext.CostCenter.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (supplier is not null)
                    {
                        dbContext.CostCenter.Remove(supplier);
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadData();
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

        private void brnRefreshFields_Click(object sender, EventArgs e)
        {
            this.BindCombo();
        }

        private void BindCombo()
        {
            this.cmbCompany.DataSource = dbContext.Company.ToList();
            this.cmbParentCostCenter.DataSource = dbContext.CostCenter.Where(c => !c.Disabled && c.IsGroup && c.Company.Equals(dbContext.Company.Where(c => c.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault())).ToList();
        }

        private void cmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.cmbParentCostCenter.DataSource = dbContext.CostCenter.Where(c => !c.Disabled && c.IsGroup && c.Company.Equals(dbContext.Company.Where(c => c.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault())).ToList();
        }
    }
}
