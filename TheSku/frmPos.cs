using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Linq;
using TheSku.Data;
using Microsoft.EntityFrameworkCore;

namespace TheSku
{
    public partial class frmPos : Form
    {
        SellingSettings sellingSettings = new SellingSettings();
        AppDbContext dbContext;
        UserPermissions user;
        DbUser objUser;
        TransactionService transactionService;
        List<object> transactionEntities = new List<object>();
        string previousText = "";
        bool Validation = true;
        bool IsPosPayment = false;
        string SalesID = "0";
        decimal TotalQty;
        decimal Total;
        decimal NetTotal;
        decimal BaseTotal;
        decimal BaseNetTotal;
        decimal TaxesChargesAdded;
        decimal TaxesChargesDeducted;
        decimal BaseTaxesChargesAdded;
        decimal BaseTaxesChargesDeducted;
        decimal TotalTaxesCharges;
        decimal BaseTotalTaxesCharges;
        decimal LoyaltyAmount;
        decimal DiscountAmount;
        decimal BaseDiscountAmount;
        decimal AdditionalDiscountAmount;
        decimal RoundingAdjustment;
        decimal BaseRoundingAdjustment;
        decimal GrandTotal;
        decimal BaseGrandTotal;
        decimal RoundedTotal;
        decimal BaseRoundedTotal;
        decimal TotalCommission;
        decimal AmountEligibleForCommission;

        public static string DocType { get; set; }
        public static string InvoiceToLoad { get; set; }
        public static string QuoteToLoad { get; set; }

        public frmPos(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.transactionService = new TransactionService(dbContext);
            this.objUser = new DbUser(dbContext);
            this.user = new UserPermissions(dbContext);
            this.InitializeComponent();
            this.cmbCustomer.Text = sellingSettings.DefaultCustomerInPOS;
            this.lblPosProfile.Text = PosProfileSetting.PosProfile?.Name ?? "";
            this.txtExtraDiscount.Maximum = PosProfileSetting.AdditionalDiscountLimit;
            this.BindItemGrid();
            this.ActiveControl = this.txtFilter;
            this.gvItemList.AutoGenerateColumns = false;
        }

        private bool ValidateMinimumMargin(GridViewRowInfo row)
        {
            decimal average_price = Global.GetAveragePrice(row.Cells["item_code"].Value, PosProfileSetting.Warehouse.Name);
            decimal Percentage = this.RoundDouble(row.Cells["price_list_rate"].Value) - average_price;
            Percentage = Percentage / average_price;
            Percentage = Percentage * 100;
            if (Percentage >= sellingSettings.MinimumMarginPercentage)
            {
                return true;
            }
            return false;
        }

        private void PrintThermalInvoice()
        {
            if (PosProfileSetting.PrintFormat == "Thermal")
            {
                PrintDocument printDocument = new PrintDocument();
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                printDocument.PrintPage += this.PrintDoc_PrintPage;
                printDocument.Print();
            }
        }

        private object AddSettlement(string SalesID)
        {
            //if (!this.IsPosPayment)
            //{
            //    var acc = Db.Con.Query("tabPOS Payment Method AS ppm")
            //    .Join("tabMode Of Payment AS mp", "ppm.mode_of_payment", "mp.mode_of_payment")
            //    .Join("tabMode Of Payment Account AS mpa", "mp.name", "mpa.parent")
            //    .Where("mpa.company", PosProfileSetting.Company)
            //    .Where("ppm.parent", PosProfileSetting.PosProfile)
            //    .Where("ppm.is_default", 1)
            //    .FirstOrDefault();
            //    if (acc != null)
            //    {
            //        return new
            //        {
            //            modified_by = CompanySession.CurrentLoggedInUser,
            //            owner = CompanySession.CurrentLoggedInUser,
            //            docstatus = 1,
            //            parent = SalesID,
            //            parentfield = "name",
            //            parenttype = "POS Sales Invoice",
            //            idx = 0,
            //            is_default = Db.Con.Query("tabPOS Payment Method").Select("is_default").Where("parent", PosProfileSetting.PosProfile).FirstOrDefault().is_default,
            //            mode_of_payment = acc.mode_of_payment,
            //            amount = this.RoundedTotal,
            //            account = acc.default_account,
            //            type = acc.type,
            //            base_amount = this.BaseRoundedTotal
            //        };
            //    }
            //}
            return null;
        }

        private void AddStockLedger(GridViewRowInfo row)
        {
            //this.sql.Add(this.objUser.GenerateInsertQuery("tabStock Ledger Entry", new StockModule().AddStockLedger(1, row.Cells["item_code"].Value.ToString(), PosProfileSetting.Warehouse, Utility.Now, Utility.Now.ToString("HH:mm:ss"), "POS Sales Invoice", this.SalesID, "",
            //    -this.RoundDouble(row.Cells["stock_qty"].Value), this.RoundDouble(row.Cells["buying_rate"].Value), this.RoundDouble(row.Cells["price_list_rate"].Value) / this.RoundDouble(row.Cells["conversion_factor"].Value),
            //    PosProfileSetting.Company, row.Cells["stock_uom"].Value.ToString(), Global.GetFiscalYear(PosProfileSetting.Company))));
        }

        private void BindItemGrid()
        {
            this.gvItemList.AutoGenerateColumns = false;
            this.gvItemList.DataSource = this.objUser.GetItems(this.txtFilter.Text);
            this.txtFilter.Focus();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer frmAddCustomer = new frmAddCustomer(this.dbContext, this.cmbCustomer.Text);
            if (frmAddCustomer.ShowDialog() == DialogResult.OK)
            {
                this.cmbCustomer.SelectedValue = frmAddCustomer.Customer;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this POS Sale?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.SaveandPrint();
        }

        private void Calculate()
        {
            try
            {
                this.TotalQty = 0;
                this.BaseTotal = 0;
                this.BaseNetTotal = 0;
                this.Total = 0;
                this.NetTotal = 0;
                this.BaseTotalTaxesCharges = 0;
                this.TotalTaxesCharges = 0;
                this.AdditionalDiscountAmount = 0;
                this.DiscountAmount = 0;
                this.BaseGrandTotal = 0;
                this.BaseRoundingAdjustment = 0;
                this.BaseRoundedTotal = 0;
                this.GrandTotal = 0;
                this.RoundingAdjustment = 0;
                this.RoundedTotal = 0;
                decimal Discount = 0;
                foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                {
                    row.Cells["base_price_list_rate"].Value = this.RoundDouble(row.Cells["conversion_factor"].Value) * this.RoundDouble(row.Cells["base_unit_price_list_rate"].Value);
                    row.Cells["stock_qty"].Value = this.RoundDouble(row.Cells["qty"].Value) * this.RoundDouble(row.Cells["conversion_factor"].Value);
                    row.Cells["total"].Value = this.RoundDouble(row.Cells["qty"].Value) * this.RoundDouble(row.Cells["price_list_rate"].Value);
                    row.Cells["base_total"].Value = this.RoundDouble(row.Cells["qty"].Value) * this.RoundDouble(row.Cells["base_price_list_rate"].Value);
                    //if (PricingRule.Calculate)
                    //{
                    //    Discount = ((this.RoundDouble(row.Cells["discount_percentage"].Value) * this.RoundDouble(row.Cells["price_list_rate"].Value)) / 100);
                    //    row.Cells["discount_amount"].Value = Discount * this.RoundDouble(row.Cells["qty"].Value);
                    //}
                    row.Cells["rate"].Value = this.RoundDouble(row.Cells["price_list_rate"].Value) - Discount;
                    row.Cells["amount"].Value = this.RoundDouble(row.Cells["rate"].Value) * this.RoundDouble(row.Cells["qty"].Value);
                    row.Cells["base_rate"].Value = this.RoundDouble(row.Cells["base_price_list_rate"].Value) - Discount;
                    row.Cells["base_amount"].Value = this.RoundDouble(row.Cells["base_rate"].Value) * this.RoundDouble(row.Cells["qty"].Value);
                    this.CalculateTaxesGrid(row);
                    decimal taxes = this.RoundDouble(row.Cells["tax_amount"].Value);
                    row.Cells["tax_amount"].Value = this.RoundDouble(row.Cells["tax_amount"].Value) * this.RoundDouble(row.Cells["qty"].Value);
                    row.Cells["net_rate"].Value = this.RoundDouble(row.Cells["rate"].Value) + taxes;
                    row.Cells["net_amount"].Value = this.RoundDouble(row.Cells["net_rate"].Value) * this.RoundDouble(row.Cells["qty"].Value);
                    row.Cells["base_net_rate"].Value = this.RoundDouble(row.Cells["base_rate"].Value) + taxes;
                    row.Cells["base_net_amount"].Value = this.RoundDouble(row.Cells["base_net_rate"].Value) * this.RoundDouble(row.Cells["qty"].Value);
                    row.Cells["stock_uom_rate"].Value = this.RoundDouble(row.Cells["rate"].Value) / this.RoundDouble(row.Cells["conversion_factor"].Value);

                    this.TotalQty += this.RoundDouble(row.Cells["qty"].Value);
                    this.BaseTotal += this.RoundDouble(row.Cells["base_total"].Value);
                    this.BaseNetTotal += this.RoundDouble(row.Cells["base_net_amount"].Value);
                    this.Total += this.RoundDouble(row.Cells["total"].Value);
                    this.NetTotal += this.RoundDouble(row.Cells["net_amount"].Value);
                    this.DiscountAmount += this.RoundDouble(row.Cells["discount_amount"].Value);
                    this.TotalTaxesCharges += this.RoundDouble(row.Cells["tax_amount"].Value);
                }
                this.BaseGrandTotal = this.BaseNetTotal;
                this.GrandTotal = this.NetTotal;
                this.AdditionalDiscountAmount = this.GrandTotal * this.txtExtraDiscount.Value / 100;
                this.GrandTotal = this.GrandTotal - this.AdditionalDiscountAmount;
                if (PosProfileSetting.DisableRoundedTotal)
                {
                    this.RoundingAdjustment = 0;
                    this.RoundedTotal = this.GrandTotal;
                    this.BaseRoundingAdjustment = 0;
                    this.BaseRoundedTotal = this.BaseGrandTotal;
                }
                else
                {
                    this.BaseRoundingAdjustment = Math.Round(this.BaseNetTotal) - this.BaseNetTotal;
                    this.BaseRoundedTotal = Math.Round(this.BaseNetTotal);
                    this.RoundingAdjustment = Math.Round(this.GrandTotal) - this.GrandTotal;
                    this.RoundedTotal = Math.Round(this.GrandTotal);
                }

                this.txtDiscount.Text = this.DiscountAmount.ToString("#,#0.00");
                this.txtAdditionalDiscountAmount.Text = this.AdditionalDiscountAmount.ToString("#,#0.00");
                this.txtGrossTotal.Text = this.Total.ToString("#,#0.00");
                this.txtGrandTotal.Text = this.RoundedTotal.ToString("#,#0.00");
                this.txtTotalTaxesAdded.Text = this.TotalTaxesCharges.ToString("#,#0.00");
                //PricingRule.Calculate = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CalculateTaxes(DataRow row)
        {
            //DataTable dt = Database.GetAll("tabItem Tax Template Detail", new Dictionary<string, object> { { "parent", row["item_tax_template"] }, { "parenttype", "Item Tax Template" } }, null);
            //if (dt.Rows.Count > 0)
            //{
            //    decimal NetTaxes = 0;
            //    foreach (DataRow dataRow in dt.Rows)
            //    {
            //        NetTaxes += this.RoundDouble(dataRow["tax_rate"]) / 100 * this.RoundDouble(row["rate"]);
            //    }
            //    row["tax_amount"] = NetTaxes;
            //    return;
            //}
            //row["tax_amount"] = 0;
        }
        private void CalculateTaxesGrid(GridViewRowInfo row)
        {
            //DataTable dt = Database.GetAll("tabItem Tax Template Detail", new Dictionary<string, object> { { "parent", row.Cells["item_tax_template"].Value }, { "parenttype", "Item Tax Template" } }, null);
            //if (dt.Rows.Count > 0)
            //{
            //    decimal NetTaxes = 0;
            //    foreach (DataRow dataRow in dt.Rows)
            //    {
            //        NetTaxes += this.RoundDouble(dataRow["tax_rate"]) / 100 * this.RoundDouble(row.Cells["rate"].Value);
            //    }
            //    row.Cells["tax_amount"].Value = NetTaxes;
            //    return;
            //}
            //row.Cells["tax_amount"].Value = 0;
        }


        private void chkStandardDiscount_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (!this.chkStandardDiscount.Checked)
            {
                foreach (GridViewRowInfo value in this.gvSalesList.Rows)
                {
                    value.Cells["discount_percentage"].Value = 0;
                }
            }
            else
            {
                foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                {
                    row.Cells["discount_percentage"].Value = row.Cells["base_discount_percentage"].Value;
                }
            }
            this.Calculate();
        }

        private void frmSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.H)
            {
                //if (UserRights.purchases_stock_entry)
                //{
                //    frmPurchaseHistory frmPurchaseHistory = new frmPurchaseHistory(this.gvItemList.Rows[this.gvItemList.CurrentRow.Index].Cells["name"].Value.ToString());
                //    frmPurchaseHistory.ShowDialog();
                //    e.Handled = true;
                //    return;
                //}
            }
            if (e.Control && e.KeyCode == Keys.ShiftKey)
            {
                frmAddCustomer frmAddCustomer = new frmAddCustomer(this.dbContext, this.cmbCustomer.Text);
                if (frmAddCustomer.ShowDialog() == DialogResult.OK)
                {
                    this.cmbCustomer.SelectedValue = frmAddCustomer.Customer;
                }
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                this.txtExtraDiscount.Focus();
            }
            if (e.Control && e.KeyCode == Keys.H)
            {
                if (this.gvItemList.RowCount > 0)
                {
                    //frmSaleHistory frmItemSaleHistory = new frmSaleHistory(this.gvItemList.Rows[this.gvItemList.CurrentRow.Index].Cells["name"].Value.ToString());
                    //frmItemSaleHistory.ShowDialog();
                    //e.Handled = true;
                    //return;
                }
            }
            if (e.Control && e.KeyCode == Keys.I || e.KeyCode == Keys.F2)
            {
                this.txtFilter.Focus();
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                this.SaveandPrint();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.SaveOnly();
            }
            if (e.Control && e.KeyCode == Keys.L || e.KeyCode == Keys.F3)
            {
                this.gvSalesList.Focus();
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.btnClose.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                if (user.HasReadPermission("Pos Sales Invoice"))
                {
                    if (Application.OpenForms["frmListOfPosInvoices"] == null)
                    {
                        (new frmListOfPosInvoices()
                        {
                            MdiParent = this.MdiParent
                        }).Show();
                    }
                    else
                    {
                        Application.OpenForms["frmListOfPosInvoices"].BringToFront();
                    }
                }
            }
            if (e.Control && e.KeyCode == Keys.G)
            {
                //frmRepeatBill frmRepeatBill = new frmRepeatBill();
                //frmRepeatBill.ShowDialog();
                //if (frmRepeatBill.DialogResult == DialogResult.OK)
                //{
                //    this.LoadInvoice();
                //}
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                //frmGenericSearch frmGenericSearch = new frmGenericSearch();
                //frmGenericSearch.ShowDialog();
                //if (frmGenericSearch.ItemName != "")
                //{
                //    this.txtFilter.Text = frmGenericSearch.ItemName;
                //}
            }
            if (e.KeyCode == Keys.F7)
            {
                //frmExpiryItems frmGenericSearch = new frmExpiryItems();
                //frmGenericSearch.ShowDialog();
                //if (frmGenericSearch.ItemName != "")
                //{
                //    this.txtFilter.Text = frmGenericSearch.ItemName;
                //}
            }
            if (e.KeyCode == Keys.F8)
            {
                if (this.gvSalesList.RowCount > 0 && this.GrandTotal > 0 && this.cmbCustomer.SelectedIndex >= 0)
                {
                    if (MessageBox.Show("Are you sure you want to save the POS invoice and proceed to payment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.IsPosPayment = true;
                        this.SaveOnly();
                        //(new frmSalePayment(this.SalesID, true)).ShowDialog();
                        if (MessageBox.Show("Do you want to print the invoice?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.PrintReceipt();
                            if (this.IsPosPayment)
                            {
                                this.ResetForm();
                            }
                        }
                        else
                        {
                            if (this.IsPosPayment)
                            {
                                this.ResetForm();
                            }
                        }
                        this.IsPosPayment = false;
                    }
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                //if (UserRights.view_list_of_invoices)
                //{
                //    if (MessageBox.Show("Are you sure you want to close this Sale?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        if (Application.OpenForms["frmListOfInvoices"] == null)
                //        {
                //            (new frmListOfPOSInvoices()
                //            {
                //                MdiParent = base.ParentForm
                //            }).Show();
                //        }
                //        else
                //        {
                //            Application.OpenForms["frmListOfInvoices"].BringToFront();
                //        }
                //        base.Close();
                //    }
                //}
            }
            if (e.KeyCode == Keys.F11 && this.gvSalesList.RowCount > 0)
            {
                //frmSaveSaleTemplate frmSaveSaleTemplate = new frmSaveSaleTemplate();
                //frmSaveSaleTemplate.ShowDialog();
                //if (frmSaveSaleTemplate.TemplateCode != "0")
                //{
                //    foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                //    {
                //        string str = string.Concat(new string[] { "INSERT INTO `tab sale templates items` (`modifiedby`,`owner`,`item_code`,`item_name`,`customer_phone`,`qty`) VALUES ('", Global.UserName, "','", Global.UserName, "','", row.Cells["item_code"].Value.ToString(), "','", row.Cells["item_code"].Value.ToString(), "','", frmSaveSaleTemplate.PhoneNo, "','", row.Cells["qty"].Value.ToString(), "')" });
                //        this.objUser.ExecQuery(str);
                //    }
                //    MessageBox.Show("Template Saved Successfully..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //}
            }
        }

        private void gvItemList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gvItemList.Rows.Count > 0)
            {
                this.SalesAddItem();
            }
        }

        private void gvItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.gvSalesList.Focus();
            }
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                this.SalesAddItem();
            }
            if (e.KeyCode == Keys.Up && this.gvItemList.Rows.Count > 1 && this.gvItemList.CurrentRow.Index == 0)
            {
                this.gvItemList.CurrentCell = this.gvItemList.Rows[this.gvItemList.Rows.Count - 1].Cells[1];
            }
            if (e.KeyCode == Keys.Down && this.gvItemList.Rows.Count > 1 && this.gvItemList.CurrentRow.Index == this.gvItemList.Rows.Count - 1)
            {
                this.gvItemList.CurrentCell = this.gvItemList.Rows[0].Cells[1];
            }
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                this.txtFilter.Text = e.KeyCode.ToString();
                this.txtFilter.DeselectAll();
                this.txtFilter.SelectionStart = this.txtFilter.Text.Length;
            }
        }

        private void gvSalesList_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            this.Validation = false;
        }

        private void gvSalesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (this.gvSalesList.Columns["qty"].Name == "qty" && this.gvSalesList.RowCount > 0)
                {
                    //frmQtyCalculator frmQtyCalculator = new frmQtyCalculator(this.gvSalesList.Rows[this.gvSalesList.CurrentRow.Index].Cells["item_code"].Value.ToString());
                    //frmQtyCalculator.ShowDialog();
                    //if (frmQtyCalculator.Qty != 0)
                    //{
                    //    this.gvSalesList.Rows[this.gvSalesList.CurrentRow.Index].Cells["qty"].Value = frmQtyCalculator.Qty;
                    //    this.Calculate();
                    //}
                }
            }
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                this.gvSalesList.EndEdit();
            }
        }

        private void gvSalesList_UserDeletedRow(object sender, GridViewRowEventArgs e)
        {
            this.Calculate();
        }

        private void lblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //(new frmHelpProvider("Sale")).ShowDialog();
        }

        private void LoadInvoice()
        {
            //string str = "";
            //if (frmPOS.InvoiceToLoad != "" && frmPOS.DocType == "Cancelled Invoice")
            //{
            //    str = string.Concat("SELECT arsi.parent, ti.name, arsi.qty, arsi.doctor_name from `tabcancel invoice item` arsi INNER JOIN tabItem ti on arsi.item_code = ti.name WHERE ti.disabled = 0 and arsi.parent = ", frmPOS.InvoiceToLoad);
            //}
            //if (frmPOS.InvoiceToLoad != "" && frmPOS.DocType == "Sales Invoice")
            //{
            //    str = string.Concat("SELECT sii.parent, ti.item_code, SUM(sii.qty) qty, sii.doctor_name, sii.uom FROM `tabSales Invoice Item` sii INNER JOIN `tabItem` ti ON sii.item_code = ti.item_code WHERE ti.disabled = 0 AND sii.parent = '", Global.Replace(frmPOS.InvoiceToLoad), "' GROUP BY sii.item_code");
            //}
            //if (frmPOS.InvoiceToLoad != "" && frmPOS.DocType == "Quotation")
            //{
            //    str = string.Concat("SELECT arsi.parent, ti.item_code, arsi.uom, arsi.qty, arsi.doctor_name FROM `tabquotation item` arsi INNER JOIN tabItem ti on arsi.item_code = ti.name WHERE ti.disabled = 0 and arsi.parent = '", frmPOS.InvoiceToLoad, "'");
            //}
            //if (frmPOS.InvoiceToLoad != "" && frmPOS.DocType == "Saved Template")
            //{
            //    str = string.Concat("SELECT ti.item_code, '1' as qty,'n' as doctor_name from `tab sale templates items` ts INNER JOIN tabItem ti on ts.item_code = ti.name WHERE ti.disabled = 0 and ts.customer_phone = ", frmPOS.InvoiceToLoad);
            //}
            //if (frmPOS.InvoiceToLoad == "")
            //{
            //    MessageBox.Show("Wrong Input! Kindly Give a Valid Invoice No.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //DataTable item = this.objUser.FillDS(str).Tables[0];
            //if (item.Rows.Count > 0)
            //{
            //    foreach (DataRow row in item.Rows)
            //    {
            //        this.LoadInvoiceItems(row["item_code"].ToString(), this.RoundDouble(row["qty"].ToString()), row["doctor_name"].ToString(), row["uom"].ToString());
            //    }
            //    this.Calculate();
            //}
            //else
            //{
            //    MessageBox.Show("There is some issue with This invoice. Cannot Fetch Data", "Fetch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void LoadInvoiceItems(string item_code, decimal qty, string doctor_name, string uom)
        {
            foreach (GridViewDataRowInfo row in this.gvSalesList.Rows)
            {
                if (row.Cells["item_code"].Value.ToString() == item_code)
                {
                    return;
                }
            }
            //DataTable dt = Item.GetItemDetail(item_code);
            //if (dt.Rows.Count > 0)
            //{
            //    this.gvSalesList.CellValueChanged -= this.gvSalesList_CellValueChanged;
            //    GridViewDataRowInfo gridViewDataRowInfo = new GridViewDataRowInfo(this.gvSalesList.MasterView);
            //    gridViewDataRowInfo.Cells["item_code"].Value = item_code;
            //    gridViewDataRowInfo.Cells["barcode"].Value = "";
            //    gridViewDataRowInfo.Cells["item_name"].Value = dt.Rows[0]["item_name"];
            //    gridViewDataRowInfo.Cells["description"].Value = dt.Rows[0]["description"];
            //    gridViewDataRowInfo.Cells["packing_type"].Value = dt.Rows[0]["packing_type"];
            //    gridViewDataRowInfo.Cells["packing"].Value = dt.Rows[0]["packing"];
            //    gridViewDataRowInfo.Cells["qty"].Value = Math.Abs(Math.Round(qty));
            //    gridViewDataRowInfo.Cells["price_list_rate"].Value = this.RoundDouble(dt.Rows[0]["sale_price"]);
            //    gridViewDataRowInfo.Cells["base_price_list_rate"].Value = this.RoundDouble(dt.Rows[0]["sale_price"]);
            //    gridViewDataRowInfo.Cells["unit_price_list_rate"].Value = this.RoundDouble(dt.Rows[0]["sale_price"]);
            //    gridViewDataRowInfo.Cells["base_unit_price_list_rate"].Value = this.RoundDouble(dt.Rows[0]["sale_price"]);
            //    gridViewDataRowInfo.Cells["uom"].Value = uom;
            //    gridViewDataRowInfo.Cells["conversion_factor"].Value = Item.GetUomConversionFactor(item_code, uom);
            //    gridViewDataRowInfo.Cells["stock_qty"].Value = 0;
            //    gridViewDataRowInfo.Cells["stock_uom_rate"].Value = 0;
            //    gridViewDataRowInfo.Cells["stock_uom"].Value = "Nos";
            //    gridViewDataRowInfo.Cells["discount_percentage"].Value = 0;
            //    gridViewDataRowInfo.Cells["base_discount_percentage"].Value = 0;
            //    gridViewDataRowInfo.Cells["item_tax_template"].Value = string.Empty;
            //    gridViewDataRowInfo.Cells["rack_location"].Value = dt.Rows[0]["rack_location"];
            //    gridViewDataRowInfo.Cells["doctor_name"].Value = doctor_name;
            //    gridViewDataRowInfo.Cells["is_non_returnable"].Value = Convert.ToInt16(dt.Rows[0]["is_non_returnable"]);
            //    gridViewDataRowInfo.Cells["is_fridge_item"].Value = Convert.ToInt16(dt.Rows[0]["is_fridge_item"]);
            //    gridViewDataRowInfo.Cells["disabled"].Value = Convert.ToInt16(dt.Rows[0]["disabled"]);
            //    gridViewDataRowInfo.Cells["is_narcotic"].Value = Convert.ToInt16(dt.Rows[0]["is_narcotic_item"]);
            //    gridViewDataRowInfo.Cells["is_expiry_item"].Value = Convert.ToInt16(dt.Rows[0]["is_near_expiry"]);
            //    gridViewDataRowInfo.Cells["brand"].Value = dt.Rows[0]["brand"];
            //    gridViewDataRowInfo.Cells["item_group"].Value = dt.Rows[0]["item_group"];
            //    gridViewDataRowInfo.Cells["is_lock_discount"].Value = Convert.ToInt16(dt.Rows[0]["lock_discount"]);
            //    gridViewDataRowInfo.Cells["buying_rate"].Value = this.RoundDouble(dt.Rows[0]["purchase_price"]);
            //    this.gvSalesList.Rows.Add(gridViewDataRowInfo);
            //    this.gvSalesList.CellValueChanged += this.gvSalesList_CellValueChanged;
            //}
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //foreach (GridViewDataColumn column in this.gvSalesList.Columns)
            //{
            //    dataTable.Columns.Add(column.Name, column.DataType);
            //}
            //foreach (GridViewRowInfo row in this.gvSalesList.Rows)
            //{
            //    DataRow value = dataTable.NewRow();
            //    for (int i = 0; i < dataTable.Columns.Count; i++)
            //    {
            //        value[i] = row.Cells[i].Value;
            //    }
            //    dataTable.Rows.Add(value);
            //}
            //dataTable = (new DataView(dataTable)
            //{
            //    Sort = "item_name ASC"
            //}).ToTable();
            //Graphics graphics = e.Graphics;
            //Font font = new Font("Arial", 9f);
            //Font font1 = new Font("Arial", 8f);
            //Font font2 = new Font("Arial", 8f, FontStyle.Bold);
            //float height = font1.GetHeight();
            //Image image = (File.Exists("logo.jpg")) ? Image.FromFile("logo.jpg") : null;
            //Image image1 = (File.Exists("footerimg.png")) ? Image.FromFile("footerimg.png") : null;
            //Image image3 = (File.Exists("nonreturnable.jpg")) ? Image.FromFile("nonreturnable.jpg") : null;
            //Image image4 = (File.Exists("nonreturnablefridge.jpg")) ? Image.FromFile("nonreturnablefridge.jpg") : null;
            //Image FooterImage = (File.Exists("Footer.png")) ? Image.FromFile("Footer.png") : null;
            //Pen blackPen = new Pen(Color.Black, 2f);
            //PointF point1 = new PointF(5f, 140f);
            //PointF point2 = new PointF(840f, 140f);
            //string str = "__________________________________________";
            //int num = 5;
            //int num1 = 0;
            //int height1 = 55;
            //StringFormat stringFormat = new StringFormat()
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //};
            //if (image != null)
            //{
            //    graphics.DrawImage(image, num + 4, num1, 250, 80);
            //}
            //else
            //{
            //    graphics.DrawString(PosProfileSetting.Company.Trim(), new Font("Arial", 14f, FontStyle.Bold), new SolidBrush(Color.Black), 20, 10);
            //    height1 = 20;
            //}
            //float headerHeight = CalculateHeaderHeight(PosProfileSetting.ThermalReceiptHeader, font, 250f, graphics);
            //Rectangle headerRect = new Rectangle(num, num1 + height1 + (int)height, 280, Convert.ToInt32(headerHeight));
            //graphics.DrawString(PosProfileSetting.ThermalReceiptHeader.Trim(), font, new SolidBrush(Color.Black), headerRect, stringFormat);
            //height1 += (int)headerHeight;
            //height1 += (int)height;
            //SizeF sizeF = new SizeF();
            //graphics.DrawString(string.Concat("No: ", this.SalesID.PadLeft(3)), font, new SolidBrush(Color.Black), (float)num, (float)height1);
            //height1 += 20;
            //graphics.DrawString(string.Concat("Customer: ", string.Join(" ", this.cmbCustomer.SelectedValue?.ToString(), this.cmbCustomer.Text).PadRight(20)), font, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //height1 += 20;
            //if (this.txtPatient.Text.Trim() != "")
            //{
            //    graphics.DrawString(string.Concat("Patient: ", this.txtPatient.Text.ToUpper().PadRight(20)), font, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //    height1 += 20;
            //}
            //graphics.DrawString(string.Concat("Date: ", Utility.Now.ToString("dd-MM-yyyy hh:mm:ss tt").PadRight(20)), font, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //if (!string.IsNullOrWhiteSpace(this.txtAddress.Text.Trim()))
            //{
            //    height1 += 20;
            //    graphics.DrawString(string.Concat("Address: ", this.txtAddress.Text.PadRight(20)), font, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //}
            //height1 += 12;
            //graphics.DrawString(str, font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //height1 += 20;
            //graphics.DrawString("R#", font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //graphics.DrawString("Name".PadLeft(12), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //graphics.DrawString("Qty".PadLeft(25), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //graphics.DrawString("Price".PadLeft(41), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //decimal discount = 0;
            //foreach (GridViewRowInfo row in this.gvSalesList.Rows)
            //{
            //    if (this.RoundDouble(row.Cells["discount_amount"].Value) > 0)
            //    {
            //        discount += this.RoundDouble(row.Cells["discount_amount"].Value);
            //    }
            //}
            //if (discount > 0)
            //{
            //    graphics.DrawString("Discount".PadLeft(60), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //}
            //graphics.DrawString("Total".PadLeft(73), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //height1 += 8;
            //graphics.DrawString(str, font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //height1 += 15;
            //foreach (GridViewRowInfo row in this.gvSalesList.Rows)
            //{
            //    graphics.DrawString(DrawLimitedString(e.Graphics, row.Cells["rack_location"].Value.ToString(), font1, 25), font1, new SolidBrush(Color.Black), num, height1);
            //    StringFormat format = new StringFormat()
            //    {
            //        Alignment = StringAlignment.Near
            //    };
            //    RectangleF rect = new RectangleF((float)num + 27f, (float)height1, 300f, height);
            //    if (Convert.ToBoolean(Convert.ToInt16(row.Cells["is_expiry_item"].Value)))
            //    {
            //        graphics.DrawString(string.Concat("**", row.Cells["description"].Value.ToString()), font1, new SolidBrush(Color.Black), rect, format);
            //    }
            //    else
            //    {
            //        graphics.DrawString(row.Cells["description"].Value.ToString(), font1, new SolidBrush(Color.Black), rect, format);
            //    }
            //    graphics.DrawString(this.RoundDouble(row.Cells["qty"].Value).ToString().PadLeft(25), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1 + 14));
            //    graphics.DrawString(this.RoundDouble(row.Cells["price_list_rate"].Value).ToString().PadLeft(40), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1 + 14));
            //    if (discount > 0)
            //    {
            //        graphics.DrawString(this.RoundDouble(row.Cells["discount_amount"].Value).ToString().PadLeft(59), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1 + 14));
            //    }
            //    graphics.DrawString(this.RoundDouble(row.Cells["net_amount"].Value).ToString().PadLeft(73), font1, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1 + 14));
            //    height1 = height1 + (int)height + 15;
            //    if (Convert.ToBoolean(Convert.ToInt16(row.Cells["is_fridge_item"].Value)))
            //    {
            //        graphics.DrawImage(image4, num + 28, height1, 230, 28);
            //        height1 = height1 + (int)height + 13;
            //    }
            //    else if (Convert.ToBoolean(Convert.ToInt16(row.Cells["is_non_returnable"].Value)))
            //    {
            //        graphics.DrawImage(image3, num, num1 + height1, 108, 28);
            //        height1 = height1 + (int)height + 13;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //height1 -= 8;
            //graphics.DrawString(str, font1, new SolidBrush(Color.Black), (float)num, (float)height1);
            //height1 += 15;
            //graphics.DrawString(string.Concat("Total Items: ", this.gvSalesList.Rows.Count.ToString().PadLeft(3)), new Font("Times New Roman", 8f, FontStyle.Bold), new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //graphics.DrawString(string.Concat("Gross Total: ", this.txtGrossTotal.Text).PadLeft(12), new Font("Times New Roman", 8f, FontStyle.Bold), new SolidBrush(Color.Black), (float)num + 130f, (float)(num1 + height1));
            //height1 += 15;
            //graphics.DrawString(CompanySession.CurrentLoggedInUser, font, new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //if (discount + this.AdditionalDiscountAmount > 0)
            //{
            //    height1 += 5;
            //    graphics.DrawString(string.Concat("You Saved:   ", (this.DiscountAmount + this.AdditionalDiscountAmount).ToString()).PadLeft(60), new Font("Times New Roman", 8f, FontStyle.Regular), new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //}
            //height1 += 17;
            //graphics.DrawString(string.Concat("Grand Total:   ", this.RoundedTotal.ToString("#,#0.00")).PadLeft(50, ' '), new Font("Times New Roman", 10f, FontStyle.Bold), new SolidBrush(Color.Black), (float)num, (float)(num1 + height1));
            //height1 += 20;
            //if (image1 != null)
            //{
            //    graphics.DrawImage(image1, num, num1 + height1, 265, 31);
            //    height1 += 35;
            //}
            //if (!PosProfileSetting.PrintFooterImage)
            //{
            //    StringFormat stringFormat1 = new StringFormat()
            //    {
            //        Alignment = StringAlignment.Near,
            //        LineAlignment = StringAlignment.Near
            //    };
            //    stringFormat.Alignment = StringAlignment.Near;
            //    sizeF = e.Graphics.MeasureString(PosProfileSetting.ThermalReceiptFooter, font, 250);
            //    headerRect = new Rectangle(num, num1 + height1, 280, Convert.ToInt32(sizeF.Height));
            //    graphics.DrawString(PosProfileSetting.ThermalReceiptFooter, font, new SolidBrush(Color.Black), headerRect, stringFormat1);
            //}
            //else
            //{
            //    if (FooterImage != null)
            //    {
            //        graphics.DrawImage(FooterImage, num, num1 + height1, 265, 60);
            //        height1 += 55;
            //    }
            //    StringFormat format = new StringFormat()
            //    {
            //        Alignment = StringAlignment.Near,
            //        LineAlignment = StringAlignment.Near
            //    };
            //    stringFormat.Alignment = StringAlignment.Near;
            //    sizeF = e.Graphics.MeasureString(CompanySession.ArCompanyFooter, font, 250);
            //    headerRect = new Rectangle(num, num1 + height1, 280, Convert.ToInt32(sizeF.Height));
            //    graphics.DrawString(CompanySession.ArCompanyFooter, font, new SolidBrush(Color.Black), headerRect, format);
            //}
        }

        private void PrintFullPage()
        {
            //try
            //{
            //    StiReport report = StiReport.CreateNewReport();
            //    report.Load(Properties.Resources.sales_invoice_a5);
            //    var dbMySQL = (StiSqlDatabase)report.Dictionary.Databases["MySQL"];
            //    dbMySQL.ConnectionString = Global.ConnectionString;
            //    report.Dictionary.Variables["sales_invoice"].ValueObject = this.SalesID;
            //    report.Dictionary.Variables["InvoiceFooter"].ValueObject = PosProfileSetting.ThermalReceiptFooter;
            //    //report.Dictionary.Variables["MainLogo"].ValueObject = null;
            //    report.Dictionary.Variables["InvoiceHeader"].ValueObject = PosProfileSetting.ThermalReceiptHeader;
            //    report.Dictionary.Variables["PrintHeading"].ValueObject = "Sales Invoice";
            //    report.Dictionary.Variables["CompanyName"].ValueObject = Global.Company.Name;
            //    report.Render(false);
            //    report.Print(true);
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
        }

        private string DrawLimitedString(Graphics graphics, string originalString, Font font, int maxWidth)
        {
            SizeF stringSize = graphics.MeasureString(originalString, font);
            int maxCharacters = (int)(maxWidth / (stringSize.Width / originalString.Length));
            string limitedString = "";
            if (originalString.Length > 0)
            {
                limitedString = originalString.Substring(0, Math.Min(originalString.Length, maxCharacters));
            }
            return limitedString;
        }

        private float CalculateHeaderHeight(string text, Font font, float maxWidth, Graphics graphics)
        {
            SizeF textSize = graphics.MeasureString(text, font, (int)maxWidth);
            return textSize.Height + 15;
        }

        private void PrintReceipt()
        {
            if (PosProfileSetting.PrintFormat != "Thermal")
            {
                this.PrintFullPage();
                return;
            }
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(this.PrintDoc_PrintPage);
            printDocument.Print();
        }

        private void ResetForm()
        {
            this.gvSalesList.Rows.Clear();
            this.chkStandardDiscount.Checked = true;
            this.cmbCustomer.SelectedValue = sellingSettings.DefaultCustomerInPOS;
            this.txtFilter.Text = "";
            this.txtRemarks.Text = "";
            this.txtDiscount.Text = "0.00";
            this.txtGrossTotal.Text = "0.00";
            this.txtGrandTotal.Text = "0.00";
            this.txtTotalTaxesAdded.Text = "0.00";
            this.txtAdditionalDiscountAmount.Text = "0.00";
            this.txtPatient.Text = "";
            this.txtFilter.Focus();
            this.gvSalesList.MasterTemplate.EnableSorting = false;
            this.txtAddress.Clear();
            this.txtExtraDiscount.Value = 0;
        }

        private decimal RoundDouble(object Value)
        {
            if (decimal.TryParse(Value.ToString(), out decimal Num))
            {
                return Math.Round(Num, 2);
            }
            return 0;
        }

        private void SalesAddItem()
        {
            GridViewDataRowInfo gridViewDataRowInfo = new GridViewDataRowInfo(this.gvSalesList.MasterView);
            frmPosQty frmQtyItem = new frmPosQty(this.gvItemList.Rows[this.gvItemList.CurrentRow.Index].Cells["name"].Value.ToString(), gridViewDataRowInfo, "Sale", this.dbContext);
            frmQtyItem.ShowDialog();
            int Qty = frmQtyItem.Qty;
            if (Qty >= 0 && gridViewDataRowInfo.Cells["item_code"].Value != null)
            {
                foreach (GridViewDataRowInfo row in this.gvSalesList.Rows)
                {
                    if (row.Cells["item_code"].Value.ToString() == gridViewDataRowInfo.Cells["item_code"].Value.ToString())
                    {
                        MessageBox.Show("Duplicate Item, Please Select other item", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Qty = -1;
                    }
                }
                if (Qty >= 0)
                {
                    if (gridViewDataRowInfo.Cells["item_code"].Value != null && gridViewDataRowInfo.Cells["item_code"].Value != DBNull.Value)
                    {
                        this.gvSalesList.Rows.Add(gridViewDataRowInfo);
                    }
                    this.Calculate();
                    this.txtFilter.Clear();
                    this.txtFilter.Focus();
                }
            }
            else
            {
                this.txtFilter.Focus();
            }
        }

        private void SaveandPrint()
        {
            if (sellingSettings.IsCustomerRequiredInPos)
            {
                if (this.cmbCustomer.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Customer from the list.", "Select Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbCustomer.Focus();
                    return;
                }
            }
            foreach (GridViewRowInfo row in this.gvSalesList.Rows)
            {
                if (this.RoundDouble(row.Cells["stock_qty"].Value) <= 0)
                {
                    MessageBox.Show(string.Concat("The Qty for Item `", row.Cells["item_name"].Value.ToString(), "` is not correct. Please fix it or remove this item from sale"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    row.IsCurrent = true;
                    row.IsSelected = true;
                    return;
                }
            }
            try
            {
                if (this.gvSalesList.Rows.Count <= 0)
                {
                    MessageBox.Show("There is no item in your sales list.\nKindly add some items to proceed to save the sales invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtFilter.Focus();
                    return;
                }
                if (!this.Validation)
                {
                    this.gvSalesList.EndEdit();
                }
                if (this.gvSalesList.Rows.Count > 0)
                {
                    this.Calculate();
                    foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                    {
                        if (!this.ValidateMinimumMargin(row))
                        {
                            MessageBox.Show($"Margin of item `{row.Cells["item_name"].Value}` is less than Minimum Margin Set in Settings.\nIf you want to override this, you need to change the Minimum Margin Value in Selling Settings. Thanks", "Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row.IsCurrent = true;
                            row.IsSelected = true;
                            return;
                        }
                        if (this.RoundDouble(row.Cells["price_list_rate"].Value) > 0)
                        {
                            if (PosProfileSetting.ValidateStock)
                            {
                                decimal actual_qty = Global.GetActualQty(row.Cells["item_code"].Value, PosProfileSetting.Warehouse);
                                if (actual_qty < this.RoundDouble(row.Cells["stock_qty"].Value))
                                {
                                    MessageBox.Show(string.Concat("The qty for \"", row.Cells["item_name"].Value.ToString(), "\" has sold on other counter since you added it in sale list.\nAvailable Qty is : ", actual_qty), "Qty Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    row.Cells["qty"].Value = Math.Round(actual_qty, 0);
                                    return;
                                }
                            }
                            if (sellingSettings.ValidatePriceAgainstPurchaseRate)
                            {
                                if (this.RoundDouble(row.Cells["price_list_rate"].Value) <= Global.GetAveragePrice(row.Cells["item_code"].Value, PosProfileSetting.Warehouse))
                                {
                                    MessageBox.Show(string.Concat("Sale Price for item '", row.Cells["item_name"].Value.ToString(), "' is less than or equal to Purchase Price.\nKindly Set it in the settings or contact with administrator. Thanks"), "Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            if (this.RoundDouble(row.Cells["discount_percentage"].Value) > sellingSettings.MaximumDiscount)
                            {
                                MessageBox.Show(string.Concat("The Disc % for \"", row.Cells["item_name"].Value.ToString(), "\" is greater than your permission right. Kindly Set it.\nDiscount Permission is : ", sellingSettings.MaximumDiscount), "Discount Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                row.Cells["discount_percentage"].Value = sellingSettings.MaximumDiscount;
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(string.Concat("Sale Price for item '", row.Cells["item_name"].Value.ToString(), "' is less than or equal to zero.\nPlease Check."), "Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row.IsSelected = true;
                            row.IsCurrent = true;
                            return;
                        }
                    }
                    decimal QtyCount = 0;
                    foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                    {
                        QtyCount += this.RoundDouble(row.Cells["qty"].Value.ToString());
                    }
                    //this.SalesID = NamingSeries.GetSeries("POS-").ToString();
                    //NamingSeries.SetSeries("POS-");
                    //this.sql.Add(this.objUser.GenerateInsertQuery("tabSales Invoice", this.objUser.AddSalesInvoice(this.SalesID, (sellingSettings.EnableCashierTerminal) ? 0 : 1, this.cmbCustomer.Text, "POS-", "", "", this.cmbCustomer.SelectedValue?.ToString(),
                    //    this.cmbCustomer.Text, Customer.GetCustomerTaxID(this.cmbCustomer.SelectedValue?.ToString()), this.txtPatient.Text, PosProfileSetting.PosProfile, 1, 0, 0, 0, 0, PosProfileSetting.Company,
                    //    Company.GetCompanyTaxId(), Utility.Now, Utility.Now.ToString("HH:mm:ss"), 0, Utility.Now,
                    //    "", "", PosProfileSetting.CostCenter, "", "", Customer.GetCustomerAddress(this.cmbCustomer.SelectedValue?.ToString()), "", "", "", Customer.GetCustomerTerritory(this.cmbCustomer.SelectedValue?.ToString()), "",
                    //    "", "", "", "", PosProfileSetting.Currency, Utility.GetConversionRate(PosProfileSetting.Currency, ""), PosProfileSetting.PriceList, PriceList.GetPriceListCurrency(PosProfileSetting.PriceList),
                    //    1, Convert.ToInt16(PosProfileSetting.IgnorePricingRule), Convert.ToInt16(PosProfileSetting.UpdateStock), QtyCount, this.BaseTotal, this.BaseNetTotal, 0, this.Total, this.NetTotal, "",
                    //    "", PosProfileSetting.TaxCategory, this.BaseTotalTaxesCharges, this.TotalTaxesCharges, 0, 0, 0, "", "", "", PosProfileSetting.ApplyDiscountOn, this.BaseDiscountAmount, Company.DefaultDiscountAccount,
                    //    this.txtExtraDiscount.Value, this.AdditionalDiscountAmount + this.DiscountAmount, this.BaseGrandTotal, this.BaseRoundingAdjustment, this.BaseRoundedTotal, Currency.InWords(this.BaseRoundedTotal), this.GrandTotal,
                    //    this.RoundingAdjustment, this.RoundedTotal, Currency.InWords(this.RoundedTotal), 0, 0, Convert.ToInt16(PosProfileSetting.DisableRoundedTotal), 0, 0, 0, PosProfileSetting.WriteOffAccount, PosProfileSetting.WriteOffCostCenter,
                    //    0, 0, "", "", (sellingSettings.EnableCashierTerminal) ? 0 : this.BaseRoundedTotal, (sellingSettings.EnableCashierTerminal) ? 0 : this.RoundedTotal, 0, 0, PosProfileSetting.AccountForChangeAmount,
                    //    "", "", PosProfileSetting.LetterHead, PosProfileSetting.PrintHeading, "en-US", (sellingSettings.EnableCashierTerminal) ? "UnPaid" : "Paid", Customer.GetCustomerGroup(this.cmbCustomer.SelectedValue?.ToString()), PosProfileSetting.Campaign,
                    //    Convert.ToInt16(Customer.IsInternalCustomer(this.cmbCustomer.SelectedValue?.ToString())), 0, Company.DefaultReceivableAccount, CompanySession.Currency, 0, Company.UnrealizeProfitLossAccount, this.txtRemarks.Text, "",
                    //    this.RoundedTotal, 0, 0, "", "", PosProfileSetting.IncomeAccount, (sellingSettings.EnableCashierTerminal) ? 0 : 1, 0, this.gvSalesList.RowCount)));
                    //foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                    //{
                    //    if (PosProfileSetting.ValidateStock)
                    //    {
                    //        if (!sellingSettings.EnableCashierTerminal)
                    //        {
                    //            this.AddStockLedger(row);
                    //        }
                    //        this.AddSalesItemsBatchWise(row);
                    //    }
                    //    else
                    //    {
                    //        this.sql.Add(this.objUser.GenerateInsertQuery("tabSales Invoice Item", this.objUser.AddSalesInvoiceItem((sellingSettings.EnableCashierTerminal) ? 0 : 1, this.SalesID, row.Index, row.Cells["barcode"].Value?.ToString(), row.Cells["item_code"].Value?.ToString(),
                    //            row.Cells["item_name"].Value?.ToString(), "", row.Cells["description"].Value?.ToString(), row.Cells["item_group"].Value?.ToString(), row.Cells["brand"].Value?.ToString(), row.Cells["packing_type"].Value?.ToString(), row.Cells["packing"].Value?.ToString(), this.RoundDouble(row.Cells["qty"].Value?.ToString()),
                    //            StockSettings.DefaultStockUom, row.Cells["uom"].Value?.ToString(), this.RoundDouble(row.Cells["conversion_factor"].Value?.ToString()), this.RoundDouble(row.Cells["stock_qty"].Value?.ToString()), this.RoundDouble(row.Cells["price_list_rate"].Value?.ToString()),
                    //            this.RoundDouble(row.Cells["base_price_list_rate"].Value?.ToString()), this.RoundDouble(row.Cells["total"].Value), this.RoundDouble(row.Cells["discount_percentage"].Value?.ToString()), this.RoundDouble(row.Cells["discount_amount"].Value?.ToString()), this.RoundDouble(row.Cells["rate"].Value?.ToString()), this.RoundDouble(row.Cells["amount"].Value?.ToString()),
                    //            row.Cells["item_tax_template"].Value?.ToString(), this.RoundDouble(row.Cells["tax_amount"].Value?.ToString()), this.RoundDouble(row.Cells["base_rate"].Value?.ToString()), this.RoundDouble(row.Cells["base_amount"].Value?.ToString()), this.RoundDouble(row.Cells["stock_uom_rate"].Value?.ToString()), 0, 1, this.RoundDouble(row.Cells["net_rate"].Value?.ToString()),
                    //            this.RoundDouble(row.Cells["net_amount"].Value?.ToString()), this.RoundDouble(row.Cells["base_net_rate"].Value?.ToString()), this.RoundDouble(row.Cells["base_net_amount"].Value?.ToString()), PosProfileSetting.IncomeAccount, 0, "", Company.DefaultFinanceBook,
                    //            PosProfileSetting.ExpenseAccount, "", Company.DefaultDeferredRevenueAccount, "", 0, "", "", 0, 0, "", PosProfileSetting.Warehouse, "", "", "", ItemPrice.GetPrice(row.Cells["item_code"].Value.ToString(), false), 0, "", "", "", "", "", 0, PosProfileSetting.CostCenter, "", (sellingSettings.EnableCashierTerminal) ? 0 : 1, row.Cells["doctor_name"].Value?.ToString(), "", row.Cells["rack_location"].Value?.ToString())));
                    //    }
                    //}
                    //if (!sellingSettings.EnableCashierTerminal)
                    //{
                    //    this.sql.Add(this.objUser.GenerateInsertQuery("tabSales Invoice Payment", this.AddSettlement(this.SalesID)));
                    //    this.sql.Add(new SqlStatement
                    //    {
                    //        Sql = $"UPDATE `tabSales Invoice` SET posting_date = @posting_date, posting_time = @posting_time WHERE name = '{this.SalesID}'",
                    //        Parameters = new Dictionary<string, object>
                    //        {
                    //            { "posting_date", Utility.Now },
                    //            { "posting_time", Utility.Now.ToString("HH:mm:ss") }
                    //        },
                    //    });
                    //    this.sql.Add(new SqlStatement
                    //    {
                    //        Sql = $"UPDATE `tabSales Invoice Item` SET posting_date = @posting_date, posting_time = @posting_time WHERE parent = '{this.SalesID}'",
                    //        Parameters = new Dictionary<string, object>
                    //        {
                    //            { "posting_date", Utility.Now },
                    //            { "posting_time", Utility.Now.ToString("HH:mm:ss") }
                    //        },
                    //    });
                    //    Database.ExecuteTransaction(null, sql, this.gvSalesList);
                    //    this.sql.Clear();
                    //    this.PerformGLEntry();
                    //    Database.ExecuteTransaction(null, this.sql);
                    //    this.sql.Clear();
                    //}
                    //Database.ExecuteTransaction(null, sql);
                    this.PrintThermalInvoice();
                    if (!this.IsPosPayment)
                    {
                        this.ResetForm();
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void SaveOnly()
        {
            if (sellingSettings.IsCustomerRequiredInPos)
            {
                if (this.cmbCustomer.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Customer from the list.", "Select Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbCustomer.Focus();
                    return;
                }
            }
            foreach (GridViewRowInfo row in this.gvSalesList.Rows)
            {
                if (this.RoundDouble(row.Cells["stock_qty"].Value) <= 0)
                {
                    MessageBox.Show(string.Concat("The Qty for Item `", row.Cells["item_name"].Value.ToString(), "` is not correct. Please fix it or remove this item from sale."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    row.IsCurrent = true;
                    row.IsSelected = true;
                    return;
                }
            }
            try
            {
                if (this.gvSalesList.Rows.Count <= 0)
                {
                    MessageBox.Show("There is no item in your sales list.\nKindly add some items to proceed to save the sales invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtFilter.Focus();
                    return;
                }
                if (!this.Validation)
                {
                    this.gvSalesList.EndEdit();
                }
                if (this.gvSalesList.Rows.Count > 0)
                {
                    this.Calculate();
                    foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                    {
                        if (!this.ValidateMinimumMargin(row))
                        {
                            MessageBox.Show($"Margin of item `{row.Cells["item_name"].Value}` is less than Minimum Margin Set in Settings.\nIf you want to override this, you need to change the Minimum Margin Value in Selling Settings. Thanks", "Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row.IsCurrent = true;
                            row.IsSelected = true;
                            return;
                        }
                        if (this.RoundDouble(row.Cells["price_list_rate"].Value) > 0)
                        {
                            if (PosProfileSetting.ValidateStock)
                            {
                                decimal actual_qty = Global.GetActualQty(row.Cells["item_code"].Value, PosProfileSetting.Warehouse);
                                if (actual_qty < this.RoundDouble(row.Cells["stock_qty"].Value))
                                {
                                    MessageBox.Show(string.Concat("The qty for \"", row.Cells["item_name"].Value.ToString(), "\" has sold on other counter since you added it in sale list.\nAvailable Qty is : ", actual_qty), "Qty Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    row.Cells["qty"].Value = Math.Round(actual_qty, 0);
                                    return;
                                }
                            }
                            if (sellingSettings.ValidatePriceAgainstPurchaseRate)
                            {
                                if (this.RoundDouble(row.Cells["price_list_rate"].Value) <= Global.GetAveragePrice(row.Cells["item_code"].Value, PosProfileSetting.Warehouse))
                                {
                                    MessageBox.Show(string.Concat("Sale Price for item '", row.Cells["item_name"].Value.ToString(), "' is less than or equal to Purchase Price.\nKindly Set it in the settings or contact with administrator. Thanks"), "Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            if (this.RoundDouble(row.Cells["discount_percentage"].Value) > sellingSettings.MaximumDiscount)
                            {
                                MessageBox.Show(string.Concat("The Disc % for \"", row.Cells["item_name"].Value.ToString(), "\" is greater than your permission right. Kindly Set it.\nDiscount Permission is : ", sellingSettings.MaximumDiscount), "Discount Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                row.Cells["discount_percentage"].Value = sellingSettings.MaximumDiscount;
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(string.Concat("Sale Price for item '", row.Cells["item_name"].Value.ToString(), "' is less than or equal to zero.\nPlease Check."), "Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row.IsSelected = true;
                            row.IsCurrent = true;
                            return;
                        }
                    }
                    decimal QtyCount = 0;
                    foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                    {
                        QtyCount += this.RoundDouble(row.Cells["qty"].Value);
                    }
                    //this.objUser.AddSalesInvoice(this.SalesID, (sellingSettings.EnableCashierTerminal) ? 0 : 1, this.cmbCustomer.Text, "POS-", "", "", this.cmbCustomer.SelectedValue?.ToString(),
                    //    this.cmbCustomer.Text, Customer.GetCustomerTaxID(this.cmbCustomer.SelectedValue?.ToString()), this.txtPatient.Text, PosProfileSetting.PosProfile, 1, 0, 0, 0, 0, PosProfileSetting.Company,
                    //    Company.GetCompanyTaxId(), Utility.Now, Utility.Now.ToString("HH:mm:ss"), 0, Utility.Now,
                    //    "", "", PosProfileSetting.CostCenter, "", "", Customer.GetCustomerAddress(this.cmbCustomer.SelectedValue?.ToString()), "", "", "", Customer.GetCustomerTerritory(this.cmbCustomer.SelectedValue?.ToString()), "",
                    //    "", "", "", "", PosProfileSetting.Currency, Utility.GetConversionRate(PosProfileSetting.Currency, ""), PosProfileSetting.PriceList, PriceList.GetPriceListCurrency(PosProfileSetting.PriceList),
                    //    1, Convert.ToInt16(PosProfileSetting.IgnorePricingRule), Convert.ToInt16(PosProfileSetting.UpdateStock), QtyCount, this.BaseTotal, this.BaseNetTotal, 0, this.Total, this.NetTotal, "",
                    //    "", PosProfileSetting.TaxCategory, this.BaseTotalTaxesCharges, this.TotalTaxesCharges, 0, 0, 0, "", "", "", PosProfileSetting.ApplyDiscountOn, this.BaseDiscountAmount, Company.DefaultDiscountAccount,
                    //    this.txtExtraDiscount.Value, this.AdditionalDiscountAmount + this.DiscountAmount, this.BaseGrandTotal, this.BaseRoundingAdjustment, this.BaseRoundedTotal, Currency.InWords(this.BaseRoundedTotal), this.GrandTotal,
                    //    this.RoundingAdjustment, this.RoundedTotal, Currency.InWords(this.RoundedTotal), 0, 0, Convert.ToInt16(PosProfileSetting.DisableRoundedTotal), 0, 0, 0, PosProfileSetting.WriteOffAccount, PosProfileSetting.WriteOffCostCenter,
                    //    0, 0, "", "", (sellingSettings.EnableCashierTerminal) ? 0 : this.BaseRoundedTotal, (sellingSettings.EnableCashierTerminal) ? 0 : this.RoundedTotal, 0, 0, PosProfileSetting.AccountForChangeAmount,
                    //    "", "", PosProfileSetting.LetterHead, PosProfileSetting.PrintHeading, "en-US", (sellingSettings.EnableCashierTerminal) ? "UnPaid" : "Paid", Customer.GetCustomerGroup(this.cmbCustomer.SelectedValue?.ToString()), PosProfileSetting.Campaign,
                    //    Convert.ToInt16(Customer.IsInternalCustomer(this.cmbCustomer.SelectedValue?.ToString())), 0, Company.DefaultReceivableAccount, CompanySession.Currency, 0, Company.UnrealizeProfitLossAccount, this.txtRemarks.Text, "",
                    //    this.RoundedTotal, 0, 0, "", "", PosProfileSetting.IncomeAccount, (sellingSettings.EnableCashierTerminal) ? 0 : 1, 0, this.gvSalesList.RowCount)));
                    foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                    {
                        if (PosProfileSetting.ValidateStock)
                        {
                            if (!sellingSettings.EnableCashierTerminal)
                            {
                                this.AddStockLedger(row);
                            }
                        }
                        else
                        {
                            //sql.Add(this.objUser.GenerateInsertQuery("tabSales Invoice Item", this.objUser.AddSalesInvoiceItem((sellingSettings.EnableCashierTerminal) ? 0 : 1, this.SalesID, row.Index, row.Cells["barcode"].Value?.ToString(), row.Cells["item_code"].Value?.ToString(),
                            //    row.Cells["item_name"].Value?.ToString(), "", row.Cells["description"].Value?.ToString(), row.Cells["item_group"].Value?.ToString(), row.Cells["brand"].Value?.ToString(), row.Cells["packing_type"].Value?.ToString(), row.Cells["packing"].Value?.ToString(), this.RoundDouble(row.Cells["qty"].Value?.ToString()),
                            //    StockSettings.DefaultStockUom, row.Cells["uom"].Value?.ToString(), this.RoundDouble(row.Cells["conversion_factor"].Value?.ToString()), this.RoundDouble(row.Cells["stock_qty"].Value?.ToString()), this.RoundDouble(row.Cells["price_list_rate"].Value?.ToString()),
                            //    this.RoundDouble(row.Cells["base_price_list_rate"].Value?.ToString()), this.RoundDouble(row.Cells["total"].Value), this.RoundDouble(row.Cells["discount_percentage"].Value?.ToString()), this.RoundDouble(row.Cells["discount_amount"].Value?.ToString()), this.RoundDouble(row.Cells["rate"].Value?.ToString()), this.RoundDouble(row.Cells["amount"].Value?.ToString()),
                            //    row.Cells["item_tax_template"].Value?.ToString(), this.RoundDouble(row.Cells["tax_amount"].Value?.ToString()), this.RoundDouble(row.Cells["base_rate"].Value?.ToString()), this.RoundDouble(row.Cells["base_amount"].Value?.ToString()), this.RoundDouble(row.Cells["stock_uom_rate"].Value?.ToString()), 0, 1, this.RoundDouble(row.Cells["net_rate"].Value?.ToString()),
                            //    this.RoundDouble(row.Cells["net_amount"].Value?.ToString()), this.RoundDouble(row.Cells["base_net_rate"].Value?.ToString()), this.RoundDouble(row.Cells["base_net_amount"].Value?.ToString()), PosProfileSetting.IncomeAccount, 0, "", Company.DefaultFinanceBook,
                            //    PosProfileSetting.ExpenseAccount, "", Company.DefaultDeferredRevenueAccount, "", 0, "", "", 0, 0, "", PosProfileSetting.Warehouse, "", "", "", ItemPrice.GetPrice(row.Cells["item_code"].Value.ToString(), false), 0, "", "", "", "", "", 0, PosProfileSetting.CostCenter, "", (sellingSettings.EnableCashierTerminal) ? 0 : 1, row.Cells["doctor_name"].Value?.ToString(), "", row.Cells["rack_location"].Value?.ToString())));
                        }
                    }
                    if (!sellingSettings.EnableCashierTerminal)
                    {
                        //sql.Add(this.objUser.GenerateInsertQuery("tabSales Invoice Payment", this.AddSettlement(this.SalesID)));
                        //sql.Add(new SqlStatement
                        //{
                        //    Sql = $"UPDATE `tabSales Invoice` SET posting_date = @posting_date, posting_time = @posting_time WHERE name = '{this.SalesID}'",
                        //    Parameters = new Dictionary<string, object>
                        //    {
                        //        { "posting_date", Utility.Now },
                        //        { "posting_time", Utility.Now.ToString("HH:mm:ss") }
                        //    },
                        //});
                        //sql.Add(new SqlStatement
                        //{
                        //    Sql = $"UPDATE `tabSales Invoice Item` SET posting_date = @posting_date, posting_time = @posting_time WHERE parent = '{this.SalesID}'",
                        //    Parameters = new Dictionary<string, object>
                        //    {
                        //        { "posting_date", Utility.Now },
                        //        { "posting_time", Utility.Now.ToString("HH:mm:ss") }
                        //    },
                        //});
                        //Database.ExecuteTransaction(null, sql, this.gvSalesList);
                        //this.sql.Clear();
                        //this.PerformGLEntry();
                        //Database.ExecuteTransaction(null, this.sql);
                        //this.sql.Clear();
                    }
                    //Database.ExecuteTransaction(null, sql);
                    MessageBox.Show($"Cheque `{this.SalesID}` Saved Sucessfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!this.IsPosPayment)
                    {
                        this.ResetForm();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                this.gvItemList.Focus();
                if (this.gvItemList.Rows.Count > 1)
                {
                    this.gvItemList.CurrentRow.Selected = true;
                    if (this.gvItemList.Rows.Count - 1 > this.gvItemList.CurrentRow.Index)
                    {
                        this.gvItemList.CurrentCell = this.gvItemList.Rows[this.gvItemList.CurrentRow.Index + 1].Cells[1];
                    }
                }
            }
            if (e.KeyCode == Keys.Return && this.gvItemList.Rows.Count > 0)
            {
                this.gvItemList_KeyDown(this.gvItemList, new KeyEventArgs(Keys.Return));
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            this.BindItemGrid();
        }

        private void gvSalesList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "srno")
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
            }
        }

        private void gvSalesList_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Column is GridViewDataColumn gridViewData)
            {
                if (gridViewData.DataType == typeof(decimal))
                {
                    if (e.ActiveEditor is GridSpinEditor editor)
                    {
                        RadSpinEditorElement element = editor.EditorElement as RadSpinEditorElement;
                        element.InterceptArrowKeys = false;
                        element.KeyDown -= new KeyEventHandler(element_KeyDown);
                        element.KeyDown += new KeyEventHandler(element_KeyDown);
                    }
                }
            }

            if (e.Column.Name == "uom")
            {
                if (this.gvSalesList.CurrentRow.Cells["uom"].Value != DBNull.Value)
                {
                    RadDropDownListEditor editor = (RadDropDownListEditor)this.gvSalesList.ActiveEditor;
                    RadDropDownListEditorElement editorElement = (RadDropDownListEditorElement)editor.EditorElement;
                    if (e.Row.Cells["uom"].Value != null)
                    {
                        editorElement.DataSource = dbContext.UomConversionDetail.Where(i => i.ItemCode.Equals(e.Row.Cells["item_code"].Value)).ToList();
                    }
                    else
                    {
                        e.Row.Cells["uom"].Value = "Nos";
                    }
                    editorElement.SelectedValue = null;
                    editorElement.SelectedValue = this.gvSalesList.CurrentCell.Value;
                }
            }
            if (e.Column.Name == "item_tax_template")
            {
                RadDropDownListEditor editor = (RadDropDownListEditor)this.gvSalesList.ActiveEditor;
                RadDropDownListEditorElement editorElement = (RadDropDownListEditorElement)editor.EditorElement;
                editorElement.DataSource = dbContext.ItemTaxTemplate.Where(i => !i.Disabled).Where(i => i.Company.Equals(PosProfileSetting.Company)).ToList();
                editorElement.SelectedValue = null;
                editorElement.SelectedValue = this.gvSalesList.CurrentCell.Value;
            }
        }

        private void element_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down || e.KeyData == Keys.Up)
            {
                if (sender is RadSpinEditorElement element)
                {
                    var gridView = element.ElementTree.Control as RadGridView;

                    if (e.KeyData == Keys.Down)
                    {
                        gridView.GridNavigator.SelectNextRow(1);
                    }
                    else if (e.KeyData == Keys.Up)
                    {
                        gridView.GridNavigator.SelectPreviousRow(1);
                    }
                }
            }
        }

        private void txtExtraDiscount_ValueChanged(object sender, EventArgs e)
        {
            this.Calculate();
        }

        private void gvSalesList_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            bool Check = false;
            if (e.Column is GridViewDataColumn col)
            {
                if (col.DataType == typeof(decimal))
                {
                    if (e.Value == null)
                    {
                        e.Row.Cells[e.Column.Index].Value = 1;
                    }
                    if (!e.Column.ReadOnly && e.Value != null && e.RowIndex != -1)
                    {
                        Check = true;
                        if (PosProfileSetting.ValidateStock)
                        {
                            e.Row.Cells["stock_qty"].Value = this.RoundDouble(e.Row.Cells["qty"].Value) * this.RoundDouble(e.Row.Cells["conversion_factor"].Value);
                            decimal actual_qty = Global.GetActualQty(e.Row.Cells["item_code"].Value, PosProfileSetting.Warehouse);
                            if (actual_qty >= this.RoundDouble(e.Row.Cells["stock_qty"].Value))
                            {
                                this.Validation = true;
                                this.Calculate();
                            }
                            else
                            {
                                MessageBox.Show(string.Concat("Qty is Grater than available Stock or it is adjusted to available stock.\nCurrent Qty is `", actual_qty, "`"), "Qty Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                e.Row.Cells["qty"].Value = actual_qty;
                                e.Row.Cells["uom"].Value = sellingSettings.DefaultSaleUOM;
                                this.Calculate();
                            }
                        }
                        else
                        {
                            this.Calculate();
                        }
                    }
                    else
                    {
                        Check = false;
                    }
                }
            }
            if (e.Row.Cells["qty"].Value == null)
            {
                e.Row.Cells["qty"].Value = 1;
            }
            if (e.Row.Cells["discount_percentage"].Value == null)
            {
                e.Row.Cells["discount_percentage"].Value = 0;
            }
            if (Check)
            {
                foreach (GridViewRowInfo row in this.gvSalesList.Rows)
                {
                    if (Convert.ToBoolean(Convert.ToInt16(row.Cells["is_lock_discount"].Value.ToString())) && this.RoundDouble(row.Cells["discount_percentage"].Value.ToString()) > 0)
                    {
                        MessageBox.Show(string.Concat("Discount for item '", row.Cells["item_name"].Value.ToString(), "' is Locked.\nYou Cannot Change Discount."), "Lock Discount", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        row.Cells["discount_percentage"].Value = 0;
                    }
                }
            }
            if (e.Column.Name == "uom")
            {
                e.Row.Cells["conversion_factor"].Value = Global.GetUomConversionFactor(e.Row.Cells["item_code"].Value, e.Row.Cells["uom"].Value?.ToString());
                e.Row.Cells["price_list_rate"].Value = this.RoundDouble(e.Row.Cells["conversion_factor"].Value) * this.RoundDouble(e.Row.Cells["unit_price_list_rate"].Value);
                e.Row.Cells["base_price_list_rate"].Value = this.RoundDouble(e.Row.Cells["conversion_factor"].Value) * this.RoundDouble(e.Row.Cells["base_unit_price_list_rate"].Value);
                this.gvSalesList.CellValueChanged -= gvSalesList_CellValueChanged;
                this.Calculate();
                this.gvSalesList.CellValueChanged += gvSalesList_CellValueChanged;
            }
            if (e.Column.Name == "item_tax_template")
            {
                this.gvSalesList.CellValueChanged -= gvSalesList_CellValueChanged;
                this.Calculate();
                this.gvSalesList.CellValueChanged += gvSalesList_CellValueChanged;
            }
        }

        private void PerformGLEntry()
        {
            Dictionary<object, decimal> taxes = new Dictionary<object, decimal>();
            foreach (GridViewRowInfo it in this.gvSalesList.Rows)
            {
                if (it.Cells["item_tax_template"].Value == null || it.Cells["item_tax_template"].Value == DBNull.Value)
                {
                    continue;
                }
                foreach (ItemTaxTemplateDetail row in Global.GetItemTaxTemplate(it.Cells["item_tax_template"].Value?.ToString()))
                {
                    if (taxes.ContainsKey(row.TaxType))
                    {
                        taxes[row.TaxType] += this.RoundDouble(row.TaxType) / 100 * this.RoundDouble(it.Cells["rate"].Value);
                    }
                    else
                    {
                        taxes.Add(row.TaxType, this.RoundDouble(row.TaxRate) / 100 * this.RoundDouble(it.Cells["rate"].Value));
                    }
                }
            }
            SalesInvoice items = dbContext.SalesInvoice.Where(si => si.Name.Equals(this.SalesID)).FirstOrDefault();
            foreach (SalesInvoiceItem row in items.SalesInvoiceItems)
            {
                this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, items.DebitTo, "Customer", this.cmbCustomer.SelectedValue?.ToString(), items.CostCenter, 0, items.RoundedTotal, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        row.IncomeAccount.Name, "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                if (this.RoundingAdjustment != 0)
                {
                    if (taxes.Count > 0 && taxes.FirstOrDefault().Value > 0)
                    {
                        this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, row.IncomeAccount, "", "", items.CostCenter, 0, items.Total, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        this.cmbCustomer.SelectedValue?.ToString(), "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                    }
                    else
                    {
                        this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, row.IncomeAccount, "", "", items.CostCenter, items.GrandTotal, 0, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        this.cmbCustomer.SelectedValue?.ToString(), "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                    }
                }
                else
                {
                    this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, row.IncomeAccount, "", "", items.CostCenter, 0, items.RoundedTotal, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        this.cmbCustomer.SelectedValue?.ToString(), "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                }
                if (taxes.Count > 0)
                {
                    foreach (var item in taxes)
                    {
                        if (item.Value <= 0)
                        {
                            continue;
                        }
                        this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, dbContext.Account.Where(a => a.Name.Equals(item.Key)).FirstOrDefault(), "", "", items.CostCenter, 0, item.Value, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        this.cmbCustomer.SelectedValue?.ToString(), "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                    }
                }
                var value = dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(stock_qty * incoming_rate), 0) AS cogs FROM `tabSales Invoice Item` WHERE parent = {1};", this.SalesID).FirstOrDefault();

                this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, Global.GetWarehouseStockAccount(PosProfileSetting.Warehouse), "", "", items.CostCenter, 0, value, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        row.ExpenseAccount.Name, "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, row.ExpenseAccount, "", "", items.CostCenter, value, 0, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        Global.GetWarehouseStockAccount(PosProfileSetting.Warehouse).Name, "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));

                List<SalesInvoicePayment> payments = dbContext.SalesInvoicePayment.Where(s => s.SalesInvoice.Equals(this.SalesID)).ToList();
                foreach (SalesInvoicePayment payment in payments)
                {
                    this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, payment.Account, "", "", items.CostCenter, payment.Amount, 0, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        this.cmbCustomer.SelectedValue?.ToString(), "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                    this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, items.DebitTo, "", "", items.CostCenter, 0, payment.Amount, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        payment.Account.Name, "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                }
                if (this.RoundingAdjustment != 0)
                {
                    if (this.RoundingAdjustment < 0)
                    {
                        this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, Global.GetRoundOffAccount(), "", "", null, 0, items.RoundingAdjustment, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        this.cmbCustomer.SelectedValue?.ToString(), "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                    }
                    else
                    {
                        this.dbContext.GLEntries.Add(Global.MakeGLEntry(1, Utility.Now, Utility.Now, Global.GetRoundOffAccount(), "", "", null, items.RoundingAdjustment, 0, Global.GetAccountCurreny(Global.GetDefaultPayableAccount()),
                        this.cmbCustomer.SelectedValue?.ToString(), "POS Sales Invoice", this.SalesID, "POS Sales Invoice", this.SalesID, "", false, false, Global.GetFiscalYear(Global.Company.Name), Global.Company, null, false));
                    }
                }
            }
        }

        private void cmbCustomer_TextChanged(object sender, EventArgs e)
        {
            previousText = this.cmbCustomer.Text;
            this.BindComboBox();
        }

        private void BindComboBox()
        {
            this.cmbCustomer.TextChanged -= cmbCustomer_TextChanged;
            this.cmbCustomer.DataSource = dbContext.Customer.Where(c => !c.Disabled).Where(c => c.Name.Contains(this.cmbCustomer.Text) || c.CustomerName.Contains(this.cmbCustomer.Text) || c.PhoneNumber.Contains(this.cmbCustomer.Text)).Select(c => new { c.Name, c.CustomerName }).OrderBy(c => c.CustomerName).Take(50).ToList();
            this.cmbCustomer.ValueMember = "name";
            this.cmbCustomer.DisplayMember = "customer_name";
            this.cmbCustomer.Text = previousText;
            this.cmbCustomer.TextChanged += cmbCustomer_TextChanged;
            this.cmbCustomer.SelectText(cmbCustomer.Text.Length, 0);
        }

        private void cmbCustomer_Enter(object sender, EventArgs e)
        {
            this.cmbCustomer.ShowDropDown();
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.cmbCustomer.Items.Count > 0)
                {
                    this.cmbCustomer.ShowDropDown();
                    this.cmbCustomer.Items[0].Selected = true;
                }
            }
        }
    }
}