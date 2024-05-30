using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmPosQty : Form
    {
        DbUser objUser;
        UserPermissions UserPermissions;
        AppDbContext dbContext;

        bool IsStockItem;
        bool IsFridgeItem;
        bool IsNonReturnable;
        bool IsNarcotic;
        bool IsShort;
        bool IsLockDiscount;
        bool IsExpiryItem;

        public GridViewDataRowInfo GetgvRowInfo
        {
            get;
            set;
        }

        public int Qty
        {
            get;
            set;
        }

        public string Frm { get; set; }

        public frmPosQty(string itemcode, GridViewDataRowInfo gridViewRowInfo, string form, AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.UserPermissions = new UserPermissions(dbContext);
            this.InitializeComponent();
            Frm = form;
            this.lblItemCode.Text = itemcode;
            this.GetgvRowInfo = gridViewRowInfo;
            this.LoadItemData();
            this.lblPP.Visible = UserPermissions.HasReadPermission("POS Sales Invoice Buying Rate");
            this.lblPurchaseRate.Visible = UserPermissions.HasReadPermission("POS Sales Invoice Buying Rate");
            this.ActiveControl = this.txtQty;
        }

        private void Calculate()
        {
            if (this.txtQty.Value > 0)
            {
                this.GetgvRowInfo.Cells["barcode"].Value = string.Empty;
                this.GetgvRowInfo.Cells["item_code"].Value = this.lblItemCode.Text;
                this.GetgvRowInfo.Cells["item_name"].Value = this.lblItemName.Text;
                this.GetgvRowInfo.Cells["description"].Value = this.txtDescription.Text;
                this.GetgvRowInfo.Cells["item_group"].Value = this.lblItemGroup.Text;
                this.GetgvRowInfo.Cells["brand"].Value = this.lblBrand.Text;
                this.GetgvRowInfo.Cells["packing_type"].Value = this.lblPackingType.Text;
                this.GetgvRowInfo.Cells["packing"].Value = this.lblPacking.Text;
                this.GetgvRowInfo.Cells["qty"].Value = this.txtQty.Value;
                this.GetgvRowInfo.Cells["stock_uom"].Value = "Nos";
                this.GetgvRowInfo.Cells["unit_price_list_rate"].Value = this.RoundDouble(this.lblPrice.Text);
                this.GetgvRowInfo.Cells["base_unit_price_list_rate"].Value = this.RoundDouble(this.lblPrice.Text);
                this.GetgvRowInfo.Cells["uom"].Value = this.cmbUOM.SelectedValue;
                this.GetgvRowInfo.Cells["conversion_factor"].Value = dbContext.UomConversionDetail.Where(u => u.ItemCode.Equals(dbContext.Item.Where(i => i.ItemCode.Equals(this.lblItemCode.Text)).FirstOrDefault())).FirstOrDefault();
                this.GetgvRowInfo.Cells["stock_qty"].Value = this.RoundDouble(this.GetgvRowInfo.Cells["qty"].Value) * this.RoundDouble(this.GetgvRowInfo.Cells["conversion_factor"].Value);
                this.GetgvRowInfo.Cells["price_list_rate"].Value = string.Format("{0:0.00}", this.lblPrice.Text);
                this.GetgvRowInfo.Cells["base_price_list_rate"].Value = this.lblPrice.Text;
                this.GetgvRowInfo.Cells["stock_uom_rate"].Value = 0;
                this.GetgvRowInfo.Cells["discount_percentage"].Value = 0;
                this.GetgvRowInfo.Cells["base_discount_percentage"].Value = 0;
                this.GetgvRowInfo.Cells["item_tax_template"].Value = string.Empty;
                this.GetgvRowInfo.Cells["rack_location"].Value = this.lblRackLocation.Text;
                this.GetgvRowInfo.Cells["doctor_name"].Value = this.txtDrname.Text;
                this.GetgvRowInfo.Cells["is_non_returnable"].Value = Convert.ToInt16(this.IsNonReturnable);
                this.GetgvRowInfo.Cells["is_fridge_item"].Value = Convert.ToInt16(this.IsFridgeItem);
                this.GetgvRowInfo.Cells["disabled"].Value = Convert.ToInt16(this.IsStockItem);
                this.GetgvRowInfo.Cells["is_narcotic"].Value = Convert.ToInt16(this.IsNarcotic);
                this.GetgvRowInfo.Cells["is_expiry_item"].Value = Convert.ToInt16(this.IsExpiryItem);
                this.GetgvRowInfo.Cells["is_lock_discount"].Value = Convert.ToInt16(this.IsLockDiscount);
                this.GetgvRowInfo.Cells["buying_rate"].Value = this.lblPurchaseRate.Text;
            }
            else
            {
                this.Qty = -1;
                this.txtQty.Value = -1;
            }
        }

        private void frmQtyItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PosProfileSetting.ValidateStock && Frm != "Quotation")
            {
                if (this.txtQty.Value > 0 && this.txtQty.Value > Convert.ToDecimal(this.lblStock.Text))
                {
                    MessageBox.Show("Qty cannot be grater than Available Stock", "Low Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void LoadItemData()
        {
            //this.lblInTransitStock.Text = Item.GetInTransitStock(this.lblItemCode.Text, PosProfileSetting.Warehouse).ToString("#0.00");
            Item item = dbContext.Item.Where(i => i.Name.Equals(this.lblItemCode.Text)).FirstOrDefault();
            if (item is not null)
            {
                this.lblPackingType.Text = item.PackingType?.Name ?? "";
                this.lblPacking.Text = item.Packing;
                this.IsExpiryItem = item.IsNearExpiryItem;
                this.lblItemName.Text = item.ItemName;
                this.txtDescription.Text = item.Description;
                this.lblRackLocation.Text = item.RackLocation;
                this.lblBrand.Text = item.Brand?.Name ?? "";
                this.lblGeneric.Text = item.GenericName;
                this.IsNonReturnable = item.IsNonReturnableItem;
                this.IsFridgeItem = item.IsFridgeItem;
                this.IsNarcotic = item.IsNarcoticItem;
                this.IsShort = item.IsShortItem;
                this.lblItemGroup.Text = item.ItemGroup?.Name ?? "";
                var itemprice = dbContext.ItemPrice.Where(i => i.ItemCode.Equals(item)).ToList();
                DateTime? modified = itemprice.Where(i => i.Selling).FirstOrDefault()?.Modified;
                this.lblPriceChanged.Text = string.Concat(modified.ToString(), " - ", Utility.TimeSpan(modified.ToString()));
                if (this.IsNarcotic)
                {
                    this.lblDrname.Visible = true;
                    this.txtDrname.Visible = true;
                }
                if (!this.IsShort)
                {
                    this.lblShort.Text = "No";
                    this.lblShort.ForeColor = Color.Blue;
                }
                else
                {
                    this.lblShort.Text = "This Item Is Short In Market";
                    this.lblShort.ForeColor = Color.Red;
                }
                this.lblPrice.Text = itemprice.Where(i => i.Selling).FirstOrDefault()?.PriceListRate.ToString("#0.00");
                var s = dbContext.UomConversionDetail.Where(u => u.ItemCode.Equals(item)).ToList();
                if (s != null)
                {
                    this.cmbUOM.DataSource = s;
                }
                this.lblPurchaseRate.Text = itemprice.Where(i => i.Buying).FirstOrDefault()?.PriceListRate.ToString("#0.00");
                this.lblRetailPrice.Text = (this.RoundDouble(this.RoundDouble(this.lblPrice.Text) * this.RoundDouble(this.lblConversionFactor.Text))).ToString();
                this.lblStock.Text = dbContext.Bin.Where(b => b.ItemCode.Equals(item) && b.Warehouse.Equals(Global.Warehouse)).Sum(s => s.ActualQty).ToString("#0.00");
            }
            else
            {
                this.txtQty.Text = "-1";
                this.txtQty.Enabled = false;
            }
        }

        private double RoundDouble(object dvalue)
        {
            if (double.TryParse(dvalue.ToString(), out double Num))
            {
                return Math.Round(Num, 2);
            }
            return 0;
        }

        private void txtDrname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' ? false : e.KeyChar != ' ');
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.cmbUOM.SelectedIndex == -1)
            {
                MessageBox.Show("Please select UOM from the list", "UOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.IsNarcotic && string.IsNullOrWhiteSpace(this.txtDrname.Text))
            {
                MessageBox.Show("Please type Doctor Name for this Item", "Dr Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDrname.Focus();
                base.DialogResult = DialogResult.None;
            }
            else
            {
                this.Qty = Convert.ToInt16(this.txtQty.Value);
                this.Calculate();
                base.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Qty = -1;
            this.txtQty.Value = -1;
            base.Close();
        }

        private void cmbUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbUOM.SelectedIndex >= 0)
            {
                UomConversionDetail ud = dbContext.UomConversionDetail.Where(u => u.ItemCode.Equals(dbContext.Item.Where(i => i.Name.Equals(this.lblItemCode.Text)).FirstOrDefault()) && u.Uom.Equals(dbContext.Uom.Where(x => x.Name.Equals(this.cmbUOM.SelectedValue)).FirstOrDefault())).FirstOrDefault();
                if (ud != null)
                {
                    this.lblConversionFactor.Text = ud.ConversionFactor.ToString("#0.00");
                }
            }
            else
            {
                this.lblConversionFactor.Text = "1";
            }
            this.lblRetailPrice.Text = Math.Round(this.RoundDouble(this.lblPrice.Text) * this.RoundDouble(this.lblConversionFactor.Text), 3).ToString();
        }
    }
}
