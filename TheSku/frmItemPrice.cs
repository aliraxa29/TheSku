using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmItemPrice : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;
        string ItemCodePreviousText = "";
        string previousText = "";

        public frmItemPrice(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtItemName;
            this.dtpValidFrom.Value = DateTime.Now;
            this.brnRefreshFields.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.cmbItemCode.SelectedIndex == -1)
            {
                MessageBox.Show("Item Code is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbItemCode.Focus();
                return;
            }
            if (this.cmbPriceList.SelectedIndex == -1)
            {
                MessageBox.Show("Price List is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbPriceList.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                ItemPrice itemPrice = new ItemPrice()
                {
                    Creation = DateTime.Now,
                    Owner = Global.UserName,
                    ItemCode = this.cmbItemCode.SelectedValue?.ToString(),
                    ItemName = this.txtItemName.Text,
                    Brand = dbContext.Brand.Where(i => i.Name.Equals(this.txtBrand.Text)).FirstOrDefault(),
                    Description = this.txtDescription.Text,
                    PriceList = dbContext.PriceList.Where(i => i.Name.Equals(this.cmbPriceList.SelectedValue)).FirstOrDefault(),
                    Currency = dbContext.Currency.Where(i => i.Name.Equals(this.cmbCurrency.SelectedValue)).FirstOrDefault(),
                    PriceListRate = this.txtPriceListRate.Value,
                    Uom = dbContext.Uom.Where(i => i.Name.Equals(this.cmbUom.SelectedValue)).FirstOrDefault(),
                    Customer = dbContext.Customer.Where(i => i.Name.Equals(this.cmbCustomer.SelectedValue)).FirstOrDefault(),
                    Supplier = dbContext.Suppliers.Where(i => i.Name.Equals(this.cmbSupplier.SelectedValue)).FirstOrDefault(),
                    Selling = this.chkSelling.Checked,
                    Buying = this.chkBuying.Checked,
                    LockDiscount = this.chkLockDiscount.Checked,
                    ValidFrom = DateOnly.FromDateTime(this.dtpValidFrom.Value),
                };
                dbContext.ItemPrice.Add(itemPrice);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                ItemPrice itemPrice = dbContext.ItemPrice.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (itemPrice is not null)
                {
                    itemPrice.ItemCode = this.cmbItemCode.SelectedValue?.ToString();
                    itemPrice.ItemName = this.txtItemName.Text;
                    itemPrice.Brand = dbContext.Brand.Where(i => i.Name.Equals(this.txtBrand.Text)).FirstOrDefault();
                    itemPrice.Description = this.txtDescription.Text;
                    itemPrice.PriceList = dbContext.PriceList.Where(i => i.Name.Equals(this.cmbPriceList.SelectedValue)).FirstOrDefault();
                    itemPrice.Currency = dbContext.Currency.Where(i => i.Name.Equals(this.cmbCurrency.SelectedValue)).FirstOrDefault();
                    itemPrice.PriceListRate = this.txtPriceListRate.Value;
                    itemPrice.Uom = dbContext.Uom.Where(i => i.Name.Equals(this.cmbUom.SelectedValue)).FirstOrDefault();
                    itemPrice.Customer = dbContext.Customer.Where(i => i.Name.Equals(this.cmbCustomer.SelectedValue)).FirstOrDefault();
                    itemPrice.Supplier = dbContext.Suppliers.Where(i => i.Name.Equals(this.cmbSupplier.SelectedValue)).FirstOrDefault();
                    itemPrice.Selling = this.chkSelling.Checked;
                    itemPrice.Buying = this.chkBuying.Checked;
                    itemPrice.LockDiscount = this.chkLockDiscount.Checked;
                    itemPrice.ValidFrom = DateOnly.FromDateTime(this.dtpValidFrom.Value);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtBrand.Clear();
            this.txtDescription.Clear();
            this.txtItemName.Clear();
            this.txtPriceListRate.Value = 0;
            this.cmbCurrency.SelectedIndex = -1;
            this.cmbCustomer.SelectedIndex = -1;
            this.cmbItemCode.SelectedIndex = -1;
            this.cmbPriceList.SelectedIndex = -1;
            this.cmbSupplier.SelectedIndex = -1;
            this.cmbUom.SelectedIndex = -1;
            this.chkBuying.Checked = false;
            this.chkLockDiscount.Checked = false;
            this.chkSelling.Checked = false;
            this.dtpValidFrom.Value = DateTime.Now;
            this.tabControl1.SelectTab(0);
            this.cmbItemCode.SelectedIndex = -1;
        }

        private void frmItemPrice_KeyDown(object sender, KeyEventArgs e)
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
                    this.cmbItemCode.Focus();
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
            var itemPrices = dbContext.ItemPrice
                            .OrderByDescending(x => x.Modified)
                            .Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.ItemCode.Contains(this.txtNameFilter.Text))
                            .Take((int)this.txtLimit.Value)
                            .ToList();
            this.gvList.DataSource = itemPrices;
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
                var itemPrice = dbContext.ItemPrice.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (itemPrice is not null)
                {
                    this.cmbItemCode.SelectedValue = itemPrice.ItemCode;
                    this.txtItemName.Text = itemPrice.ItemName;
                    this.txtBrand.Text = itemPrice.Brand?.Name ?? "";
                    this.txtDescription.Text = itemPrice.Description;
                    this.cmbPriceList.SelectedValue = itemPrice.PriceList?.Name ?? null;
                    this.cmbCurrency.SelectedValue = itemPrice.Currency?.Name ?? null;
                    this.txtPriceListRate.Value = itemPrice.PriceListRate;
                    this.cmbUom.SelectedValue = itemPrice.Uom?.Name ?? null;
                    this.cmbCustomer.SelectedValue = itemPrice.Customer?.Name ?? null;
                    this.cmbSupplier.SelectedValue = itemPrice.Supplier?.Name ?? null;
                    this.chkSelling.Checked = itemPrice.Selling;
                    this.chkBuying.Checked = itemPrice.Buying;
                    this.chkLockDiscount.Checked = itemPrice.LockDiscount;
                    this.dtpValidFrom.Value = Convert.ToDateTime(itemPrice.ValidFrom);
                    this.tabControl1.SelectTab(0);
                    this.cmbItemCode.Focus();
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
                    ItemPrice itemPrice = dbContext.ItemPrice.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (itemPrice is not null)
                    {
                        dbContext.ItemPrice.Remove(itemPrice);
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
            this.cmbPriceList.DataSource = dbContext.PriceList.Where(pl => pl.Enabled).ToList();
            this.cmbSupplier.DataSource = dbContext.Suppliers.Where(s => !s.Disabled).ToList();
            this.cmbUom.DataSource = dbContext.Uom.Where(u => u.Enabled).ToList();
        }

        private void cmbItemCode_TextChanged(object sender, EventArgs e)
        {
            ItemCodePreviousText = this.cmbItemCode.Text;
            this.BindItemCode();
        }

        private void BindItemCode()
        {
            this.cmbItemCode.TextChanged -= cmbItemCode_TextChanged;
            this.cmbItemCode.DataSource = dbContext.Item.Where(c => !c.Disabled).Where(c => c.Name.Contains(this.cmbCustomer.Text) || c.ItemName.Contains(this.cmbCustomer.Text)).Select(c => new { c.Name, c.ItemName }).OrderBy(c => c.ItemName).Take(50).ToList();
            this.cmbItemCode.ValueMember = "Name";
            this.cmbItemCode.DisplayMember = "ItemName";
            this.cmbItemCode.Text = ItemCodePreviousText;
            this.cmbItemCode.TextChanged += cmbItemCode_TextChanged;
            this.cmbItemCode.SelectText(cmbItemCode.Text.Length, 0);
        }

        private void cmbCustomer_TextChanged(object sender, EventArgs e)
        {
            previousText = this.cmbCustomer.Text;
            this.BindCustomers();
        }

        private void BindCustomers()
        {
            this.cmbCustomer.TextChanged -= cmbCustomer_TextChanged;
            this.cmbCustomer.DataSource = dbContext.Customer.Where(c => !c.Disabled).Where(c => c.Name.Contains(this.cmbCustomer.Text) || c.CustomerName.Contains(this.cmbCustomer.Text) || c.PhoneNumber.Contains(this.cmbCustomer.Text)).Select(c => new { c.Name, c.CustomerName }).OrderBy(c => c.CustomerName).Take(50).ToList();
            this.cmbCustomer.ValueMember = "Name";
            this.cmbCustomer.DisplayMember = "CustomerName";
            this.cmbCustomer.Text = previousText;
            this.cmbCustomer.TextChanged += cmbCustomer_TextChanged;
            this.cmbCustomer.SelectText(cmbCustomer.Text.Length, 0);
        }

        private void cmbItemCode_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Item item = dbContext.Item.Where(i => i.Name.Equals(this.cmbItemCode.SelectedValue)).FirstOrDefault();
            if (item is not null)
            {
                this.txtItemName.Text = item.ItemName;
                this.txtBrand.Text = item.Brand?.Name ?? "";
                this.txtDescription.Text = item.Description;
            }
        }
    }
}
