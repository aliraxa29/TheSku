using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmPriceList : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;

        public frmPriceList(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtPriceListName;
            this.brnRefreshFields.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPriceListName.Text))
            {
                MessageBox.Show("Price List Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPriceListName.Focus();
                return;
            }
            if (this.cmbCurrency.SelectedIndex == -1)
            {
                MessageBox.Show("Currency is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbCurrency.Focus();
                return;
            }
            if (!this.chkBuying.Checked && !this.chkSelling.Checked)
            {
                MessageBox.Show("Please check whether selling or buying.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.chkBuying.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                PriceList priceList = dbContext.PriceList.Where(x => x.Name.Equals(this.txtPriceListName.Text.Trim())).FirstOrDefault();
                if (priceList is not null)
                {
                    MessageBox.Show("Price List with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPriceListName.Focus();
                    return;
                }
                PriceList priceList1 = new PriceList()
                {
                    Name = this.txtPriceListName.Text.Trim(),
                    Creation = DateTime.Now,
                    Owner = Global.UserName,
                    PriceListName = this.txtPriceListName.Text.Trim(),
                    Currency = dbContext.Currency.Where(c => c.Name.Equals(this.cmbCurrency.SelectedValue)).FirstOrDefault(),
                    Buying = this.chkBuying.Checked,
                    PriceNotUomDependent = this.chkPriceNotUomDependent.Checked,
                    Enabled = this.chkEnabled.Checked,
                    Selling = this.chkSelling.Checked,
                };
                dbContext.PriceList.Add(priceList1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                PriceList priceList = dbContext.PriceList.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (priceList is not null)
                {
                    priceList.PriceListName = this.txtPriceListName.Text.Trim();
                    priceList.Currency = dbContext.Currency.Where(c => c.Name.Equals(this.cmbCurrency.SelectedValue)).FirstOrDefault();
                    priceList.Buying = this.chkBuying.Checked;
                    priceList.PriceNotUomDependent = this.chkPriceNotUomDependent.Checked;
                    priceList.Enabled = this.chkEnabled.Checked;
                    priceList.Selling = this.chkSelling.Checked;
                    dbContext.PriceList.Update(priceList);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtPriceListName.Clear();
            this.cmbCurrency.SelectedValue = Global.Currency?.Name ?? null;
            this.chkBuying.Checked = false;
            this.chkSelling.Checked = false;
            this.chkPriceNotUomDependent.Checked = false;
            this.chkEnabled.Checked = true;
            this.tabControl1.SelectTab(0);
            this.txtPriceListName.Focus();
        }

        private void frmPriceList_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtPriceListName.Focus();
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
            var priceLists = dbContext.PriceList
                            .OrderByDescending(x => x.Modified)
                            .Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text))
                            .Take((int)this.txtLimit.Value)
                            .ToList();
            this.gvList.DataSource = priceLists;
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
                PriceList priceList = dbContext.PriceList.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (priceList is not null)
                {
                    this.txtPriceListName.Text = priceList.PriceListName;
                    this.cmbCurrency.SelectedValue = priceList.Currency?.Name ?? null;
                    this.chkBuying.Checked = priceList.Buying;
                    this.chkEnabled.Checked = priceList.Enabled;
                    this.chkPriceNotUomDependent.Checked = priceList.PriceNotUomDependent;
                    this.chkSelling.Checked = priceList.Selling;
                    this.tabControl1.SelectTab(0);
                    this.txtPriceListName.Focus();
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
                    PriceList priceList = dbContext.PriceList.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (priceList is not null)
                    {
                        dbContext.PriceList.Remove(priceList);
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
            this.cmbCurrency.DataSource = dbContext.Currency.Where(c => c.Enabled).ToList();
            this.cmbCurrency.SelectedValue = Global.Currency?.Name ?? null;
        }
    }
}
