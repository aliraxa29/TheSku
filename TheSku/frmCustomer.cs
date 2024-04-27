﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmCustomer : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;

        public frmCustomer(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtCustomerName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCustomerName.Text))
            {
                MessageBox.Show("Customer Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCustomerName.Focus();
                return;
            }
            if (this.cmbCustomerGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Customer Group is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbCustomerGroup.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                var supplier = dbContext.Customer.Where(x => x.Name.Equals(this.txtCustomerName.Text.Trim())).FirstOrDefault();
                if (supplier is not null)
                {
                    MessageBox.Show("Customer with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCustomerName.Focus();
                    return;
                }
                Customer supplier1 = new Customer()
                {
                    Name = this.txtCustomerName.Text.Trim(),
                    Creation = DateTime.Now,
                    ModifiedBy = Global.UserName,
                    Owner = Global.UserName,
                    CustomerName = this.txtCustomerName.Text.Trim(),
                    CustomerGroup = this.cmbCustomerGroup.SelectedValue?.ToString(),
                    CustomerType = this.cmbCustomerType.SelectedItem.ToString(),
                    TaxID = this.txtTaxID.Text,
                    PrimaryAddress = this.txtCustomerPrimaryAddress.Text,
                    PrimaryContact = this.txtCustomerPrimaryContact.Text,
                    Disabled = false,
                    PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                };
                foreach (GridViewRowInfo row in this.gvCreditLimit.Rows)
                {
                    supplier1.CreditLimits.Add(new()
                    {
                        Creation = DateTime.Now,
                        Owner = Global.UserName,
                        Comapny = row.Cells["company"].Value?.ToString(),
                        CreditLimit = Convert.ToDecimal(row.Cells["credit_limit"].Value),
                        BypassCreditCheck = Convert.ToInt16(row.Cells["bypass_credit_check"].Value)
                    });
                }
                foreach (GridViewRowInfo row in this.gvReceivableAccount.Rows)
                {
                    supplier1.PartyAccounts.Add(new()
                    {
                        Creation = DateTime.Now,
                        Owner = Global.UserName,
                        Comapny = row.Cells["company"].Value?.ToString(),
                        Account = row.Cells["account"].Value.ToString(),
                    });
                }
                dbContext.Customer.Add(supplier1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                var supplier1 = dbContext.Customer.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier1 is not null)
                {
                    supplier1.CustomerName = this.txtCustomerName.Text.Trim();
                    supplier1.Modified = DateTime.Now;
                    supplier1.ModifiedBy = Global.UserName;
                    supplier1.CustomerGroup = this.cmbCustomerGroup.SelectedValue?.ToString();
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtCustomerName.Clear();
            this.cmbCustomerGroup.SelectedIndex = -1;
        }

        private void frmCustomer_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtCustomerName.Focus();
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
            var suppliers = dbContext.Customer
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
                var supplier = dbContext.Customer.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier is not null)
                {
                    this.txtCustomerName.Text = supplier.CustomerName;
                    this.cmbCustomerGroup.SelectedValue = supplier.CustomerGroup;
                    this.tabControl1.SelectTab(0);
                    this.txtCustomerName.Focus();
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
                    var supplier = dbContext.Customer.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (supplier is not null)
                    {
                        dbContext.Customer.Remove(supplier);
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

        private void cmbCustomerGroup_Enter(object sender, EventArgs e)
        {
            if (this.cmbCustomerGroup.DataSource == null)
            {
                this.cmbCustomerGroup.DataSource = dbContext.CustomerGroup.ToList();
            }
        }

        private void brnRefreshFields_Click(object sender, EventArgs e)
        {
            this.cmbCustomerGroup.DataSource = dbContext.CustomerGroup.ToList();
        }
    }
}
