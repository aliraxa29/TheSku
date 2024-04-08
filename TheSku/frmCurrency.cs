using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmCurrency : Form
    {
        AppDbContext dbContext;

        public frmCurrency(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtCurrencyName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCurrencyName.Text))
            {
                MessageBox.Show("Currency Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCurrencyName.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                var currency1 = dbContext.Currency.Where(x => x.Name.Equals(this.txtCurrencyName.Text.Trim())).FirstOrDefault();
                if (currency1 is not null)
                {
                    MessageBox.Show("Currency with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCurrencyName.Focus();
                    return;
                }
                Currency currency = new Currency()
                {
                    Name = this.txtCurrencyName.Text.Trim(),
                    Creation = DateTime.Now,
                    ModifiedBy = Global.UserName,
                    Owner = Global.UserName,
                    CurrencyName = this.txtCurrencyName.Text.Trim(),
                    Enabled = Convert.ToInt16(this.chkEnabled.Checked),
                    Symbol = this.txtSymbol.Text,
                    Fraction = this.txtFraction.Text,
                    FractionUnits = this.txtFractionUnits.Text,
                    SmallestCurrencyFractionValue = this.txtSmallestFractionValue.Value,
                };
                dbContext.Currency.Add(currency);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                var currency = dbContext.Currency.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (currency is not null)
                {
                    currency.CurrencyName = this.txtCurrencyName.Text.Trim();
                    currency.Enabled = Convert.ToInt16(this.chkEnabled.Checked);
                    currency.Symbol = this.txtSymbol.Text;
                    currency.Fraction = this.txtFraction.Text;
                    currency.FractionUnits = this.txtFractionUnits.Text;
                    currency.SmallestCurrencyFractionValue = this.txtSmallestFractionValue.Value;
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtCurrencyName.Clear();
            this.txtFraction.Clear();
            this.txtFractionUnits.Clear();
            this.txtSmallestFractionValue.Value = 0;
            this.txtSymbol.Clear();
            this.tabControl1.SelectTab(0);
            this.txtCurrencyName.Focus();
        }

        private void frmCurrency_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtCurrencyName.Focus();
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
            var suppliers = dbContext.Currency
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
                var currency = dbContext.Currency.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (currency is not null)
                {
                    this.txtCurrencyName.Text = currency.CurrencyName;
                    this.txtFraction.Text = currency.Fraction;
                    this.txtFractionUnits.Text = currency.FractionUnits;
                    this.txtSmallestFractionValue.Value = currency.SmallestCurrencyFractionValue;
                    this.txtSymbol.Text = currency.Symbol;
                    this.tabControl1.SelectTab(0);
                    this.txtCurrencyName.Focus();
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
                    var currency = dbContext.Currency.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (currency is not null)
                    {
                        dbContext.Currency.Remove(currency);
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

        private void gvList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "status")
            {
                if (e.CellElement.Value.ToString() == "1")
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
