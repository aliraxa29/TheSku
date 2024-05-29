using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmItem : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;

        public frmItem(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtItemCode;
            this.brnRefreshFields.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtItemName.Text))
            {
                MessageBox.Show("Item Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtItemName.Focus();
                return;
            }
            if (this.cmbStockUom.SelectedIndex == -1)
            {
                MessageBox.Show("Stock UOM is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbStockUom.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                string name = "";
                if (!string.IsNullOrWhiteSpace(this.txtItemCode.Text))
                {
                    name = this.txtItemCode.Text.Trim();
                }
                else
                {
                    name = Series.GetNextSeriesNumber(this.dbContext, "Item").ToString();
                }
                if (string.IsNullOrWhiteSpace(this.txtDescription.Text))
                {
                    this.txtDescription.Text = this.txtItemName.Text;
                }
                Item item = dbContext.Item.Where(x => x.Name.Equals(name)).FirstOrDefault();
                if (item is not null)
                {
                    MessageBox.Show("Item with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtItemName.Focus();
                    return;
                }
                Item item1 = new Item()
                {
                    Name = name,
                    Creation = DateTime.Now,
                    Owner = Global.UserName,
                    ItemCode = name,
                    ItemGroup = dbContext.ItemGroup.Where(i => i.Name.Equals(this.cmbItemGroup.SelectedValue)).FirstOrDefault(),
                    ItemName = this.txtItemName.Text.Trim(),
                    IsFridgeItem = this.chkIsFridgeItem.Checked,
                    IsNarcoticItem = this.chkIsNarcotic.Checked,
                    IsNearExpiryItem = this.chkIsNearExpiry.Checked,
                    IsNonReturnableItem = this.chkIsNonReturnable.Checked,
                    IsPurchaseItem = this.chkIsPurchaseItem.Checked,
                    IsSaleItem = this.chkIsSaleItem.Checked,
                    IsShortItem = this.chkIsShort.Checked,
                    IsStockItem = this.chkIsStockItem.Checked,
                    AllowNegativeStock = this.chkAllowNegativeStock.Checked,
                    Brand = dbContext.Brand.Where(b => b.Name.Equals(this.cmbBrand.SelectedValue)).FirstOrDefault(),
                    Description = this.txtDescription.Text,
                    Disabled = this.chkDisabled.Checked,
                    GenericName = this.txtGenericName.Text,
                    OpeningStock = this.txtOpeningStock.Value,
                    ValuationRate = this.txtValuationRate.Value,
                    PackingType = dbContext.PackingType.Where(p => p.Name.Equals(this.cmbPackingType.SelectedValue)).FirstOrDefault(),
                    Packing = this.txtPacking.Text,
                    RackLocation = this.txtRackLocation.Text,
                    StandardRate = this.txtStandardRate.Value,
                    StockUom = dbContext.Uom.Where(u => u.Name.Equals(this.cmbStockUom.SelectedValue)).FirstOrDefault()
                };
                foreach (GridViewRowInfo row in this.gvUom.Rows)
                {
                    UomConversionDetail uc = new UomConversionDetail()
                    {
                        Creation = DateTime.Now,
                        Owner = Global.UserName,
                        ItemCode = item,
                        Uom = dbContext.Uom.Where(u => u.Name.Equals(row.Cells["uom"].Value)).FirstOrDefault()
                    };
                    dbContext.UomConversionDetail.Add(uc);
                }
                foreach (GridViewRowInfo row in this.gvSupplier.Rows)
                {
                    ItemSupplier iSupplier = new ItemSupplier()
                    {
                        Creation = DateTime.Now,
                        Owner = Global.UserName,
                        ItemCode = item,
                        Supplier = dbContext.Suppliers.Where(u => u.Name.Equals(row.Cells["supplier"].Value)).FirstOrDefault()
                    };
                    dbContext.ItemSupplier.Add(iSupplier);
                }
                dbContext.Item.Add(item1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                Item item = dbContext.Item.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (item is not null)
                {
                    item.ItemGroup = dbContext.ItemGroup.Where(i => i.Name.Equals(this.cmbItemGroup.SelectedValue)).FirstOrDefault();
                    item.ItemName = this.txtItemName.Text.Trim();
                    item.IsFridgeItem = this.chkIsFridgeItem.Checked;
                    item.IsNarcoticItem = this.chkIsNarcotic.Checked;
                    item.IsNearExpiryItem = this.chkIsNearExpiry.Checked;
                    item.IsNonReturnableItem = this.chkIsNonReturnable.Checked;
                    item.IsPurchaseItem = this.chkIsPurchaseItem.Checked;
                    item.IsSaleItem = this.chkIsSaleItem.Checked;
                    item.IsShortItem = this.chkIsShort.Checked;
                    item.IsStockItem = this.chkIsStockItem.Checked;
                    item.AllowNegativeStock = this.chkAllowNegativeStock.Checked;
                    item.Brand = dbContext.Brand.Where(b => b.Name.Equals(this.cmbBrand.SelectedValue)).FirstOrDefault();
                    item.Description = this.txtDescription.Text;
                    item.Disabled = this.chkDisabled.Checked;
                    item.GenericName = this.txtGenericName.Text;
                    item.OpeningStock = this.txtOpeningStock.Value;
                    item.ValuationRate = this.txtValuationRate.Value;
                    item.PackingType = dbContext.PackingType.Where(p => p.Name.Equals(this.cmbPackingType.SelectedValue)).FirstOrDefault();
                    item.Packing = this.txtPacking.Text;
                    item.RackLocation = this.txtRackLocation.Text;
                    item.StandardRate = this.txtStandardRate.Value;
                    item.StockUom = dbContext.Uom.Where(u => u.Name.Equals(this.cmbStockUom.SelectedValue)).FirstOrDefault();
                    dbContext.Item.Update(item);
                    foreach (GridViewRowInfo row in this.gvUom.Rows)
                    {
                        if (row.Cells["name"].Value is null)
                        {
                            UomConversionDetail uc = new UomConversionDetail()
                            {
                                Creation = DateTime.Now,
                                Owner = Global.UserName,
                                ItemCode = item,
                                Uom = dbContext.Uom.Where(u => u.Name.Equals(row.Cells["uom"].Value)).FirstOrDefault(),
                                ConversionFactor = Convert.ToDecimal(row.Cells["conversion_factor"].Value),
                            };
                            dbContext.UomConversionDetail.Add(uc);
                        }
                        else
                        {
                            UomConversionDetail uc = dbContext.UomConversionDetail.Where(u => u.Name.Equals(row.Cells["name"].Value)).FirstOrDefault();
                            uc.Uom = dbContext.Uom.Where(u => u.Name.Equals(row.Cells["uom"].Value)).FirstOrDefault();
                            uc.ConversionFactor = Convert.ToDecimal(row.Cells["conversion_factor"].Value);
                            dbContext.UomConversionDetail.Update(uc);
                        }
                    }
                    foreach (GridViewRowInfo row in this.gvSupplier.Rows)
                    {
                        if (row.Cells["name"].Value is null)
                        {
                            ItemSupplier iSupplier = new ItemSupplier()
                            {
                                Creation = DateTime.Now,
                                Owner = Global.UserName,
                                ItemCode = item,
                                Supplier = dbContext.Suppliers.Where(u => u.Name.Equals(row.Cells["supplier"].Value)).FirstOrDefault()
                            };
                            dbContext.ItemSupplier.Add(iSupplier);
                        }
                        else
                        {
                            ItemSupplier iSupplier = dbContext.ItemSupplier.Where(u => u.Name.Equals(row.Cells["name"].Value)).FirstOrDefault();
                            iSupplier.Supplier = dbContext.Suppliers.Where(u => u.Name.Equals(row.Cells["supplier"].Value)).FirstOrDefault();
                            dbContext.ItemSupplier.Update(iSupplier);
                        }
                    }
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtItemCode.Clear();
            this.cmbItemGroup.SelectedIndex = -1;
            this.txtItemName.Clear();
            this.chkIsFridgeItem.Checked = false;
            this.chkIsNarcotic.Checked = false;
            this.chkIsNearExpiry.Checked = false;
            this.chkIsNonReturnable.Checked = false;
            this.chkIsPurchaseItem.Checked = true;
            this.chkIsSaleItem.Checked = true;
            this.chkIsStockItem.Checked = true;
            this.chkIsShort.Checked = false;
            this.chkAllowNegativeStock.Checked = false;
            this.cmbBrand.SelectedIndex = -1;
            this.txtDescription.Clear();
            this.chkDisabled.Checked = false;
            this.txtGenericName.Clear();
            this.txtOpeningStock.Value = 0;
            this.txtValuationRate.Value = 0;
            this.cmbPackingType.SelectedIndex = -1;
            this.txtPacking.Clear();
            this.txtRackLocation.Clear();
            this.txtStandardRate.Value = 0;
            this.cmbStockUom.SelectedIndex = -1;
            this.tabControl1.SelectTab(0);
            this.txtItemName.Focus();
        }

        private void frmItem_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtItemName.Focus();
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
            var items = dbContext.Item
                            .OrderByDescending(x => x.Modified)
                            .Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text))
                            .Take((int)this.txtLimit.Value)
                            .ToList();
            this.gvList.DataSource = items;
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
                Item item = dbContext.Item.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (item is not null)
                {
                    this.txtItemCode.Text = item.ItemCode;
                    this.cmbItemGroup.SelectedValue = item.ItemGroup?.Name ?? null;
                    this.txtItemName.Text = item.ItemName;
                    this.chkIsFridgeItem.Checked = item.IsFridgeItem;
                    this.chkIsNarcotic.Checked = item.IsNarcoticItem;
                    this.chkIsNearExpiry.Checked = item.IsNearExpiryItem;
                    this.chkIsNonReturnable.Checked = item.IsNonReturnableItem;
                    this.chkIsPurchaseItem.Checked = item.IsPurchaseItem;
                    this.chkIsSaleItem.Checked = item.IsSaleItem;
                    this.chkIsShort.Checked = item.IsShortItem;
                    this.chkIsStockItem.Checked = item.IsStockItem;
                    this.chkAllowNegativeStock.Checked = item.AllowNegativeStock;
                    this.cmbBrand.SelectedValue = item.Brand?.Name ?? null;
                    this.txtDescription.Text = item.Description;
                    this.chkDisabled.Checked = item.Disabled;
                    this.txtGenericName.Text = item.GenericName;
                    this.txtOpeningStock.Value = item.OpeningStock;
                    this.txtValuationRate.Value = item.ValuationRate;
                    this.cmbPackingType.SelectedValue = item.PackingType?.Name ?? null;
                    this.txtPacking.Text = item.Packing;
                    this.txtRackLocation.Text = item.RackLocation;
                    this.txtStandardRate.Value = item.StandardRate;
                    this.cmbStockUom.SelectedValue = item.StockUom?.Name ?? null;
                    this.gvSupplier.Rows.Clear();
                    this.gvUom.Rows.Clear();
                    foreach (UomConversionDetail uom in dbContext.UomConversionDetail.Where(u => u.ItemCode.Equals(item)).ToList())
                    {
                        GridViewDataRowInfo row = new GridViewDataRowInfo(this.gvUom.MasterView);
                        row.Cells["name"].Value = uom.Name;
                        row.Cells["uom"].Value = uom.Uom?.Name ?? null;
                        row.Cells["conversion_factor"].Value = uom.ConversionFactor;
                        this.gvUom.Rows.Add(row);
                    }
                    foreach (ItemSupplier supplier in dbContext.ItemSupplier.Where(u => u.ItemCode.Equals(item)).ToList())
                    {
                        GridViewDataRowInfo row = new GridViewDataRowInfo(this.gvSupplier.MasterView);
                        row.Cells["name"].Value = supplier.Name;
                        row.Cells["supplier"].Value = supplier.Supplier?.Name ?? null;
                        this.gvSupplier.Rows.Add(row);
                    }
                    this.tabControl1.SelectTab(0);
                    this.txtItemName.Focus();
                    this.lblID.Visible = true;
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
                    Item item = dbContext.Item.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (item is not null)
                    {
                        dbContext.Item.Remove(item);
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
            this.cmbBrand.DataSource = dbContext.Brand.ToList();
            this.cmbItemGroup.DataSource = dbContext.ItemGroup.ToList();
            this.cmbPackingType.DataSource = dbContext.PackingType.ToList();
            this.cmbStockUom.DataSource = dbContext.Uom.ToList();
            ((GridViewComboBoxColumn)this.gvUom.Columns["uom"]).DataSource = dbContext.Uom.ToList();
            ((GridViewComboBoxColumn)this.gvSupplier.Columns["supplier"]).DataSource = dbContext.Suppliers.ToList();
        }
    }
}
