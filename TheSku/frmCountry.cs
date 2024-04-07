using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmCountry : Form
    {
        AppDbContext dbContext;

        public frmCountry(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtCountryName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCountryName.Text))
            {
                MessageBox.Show("Country Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCountryName.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                var supplier = dbContext.Country.Where(x => x.Name.Equals(this.txtCountryName.Text.Trim())).FirstOrDefault();
                if (supplier is not null)
                {
                    MessageBox.Show("Country with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCountryName.Focus();
                    return;
                }
                Country supplier1 = new Country()
                {
                    Name = this.txtCountryName.Text.Trim(),
                    Creation = DateTime.Now,
                    ModifiedBy = Global.UserName,
                    Owner = Global.UserName,
                    CountryName = this.txtCountryName.Text.Trim(),
                    DateFormat = this.txtDateFormat.Text.Trim(),
                    TimeFormat = this.txtTimeFormat.Text.Trim(),
                    TimeZones = this.txtTimeZones.Text,
                    Code = this.txtCode.Text.Trim(),
                };
                dbContext.Country.Add(supplier1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                var supplier1 = dbContext.Country.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier1 is not null)
                {
                    supplier1.CountryName = this.txtCountryName.Text.Trim().Trim();
                    supplier1.Modified = DateTime.Now;
                    supplier1.ModifiedBy = Global.UserName;
                    supplier1.DateFormat = this.txtDateFormat.Text.Trim();
                    supplier1.TimeFormat = this.txtTimeFormat.Text.Trim();
                    supplier1.TimeZones = this.txtTimeZones.Text;
                    supplier1.Code = this.txtCode.Text;
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtCountryName.Clear();
            this.txtCode.Clear();
            this.txtDateFormat.Clear();
            this.txtTimeFormat.Clear();
            this.txtTimeZones.Clear();
        }

        private void frmCountry_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtCountryName.Focus();
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
            var suppliers = dbContext.Country
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
                var supplier = dbContext.Country.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier is not null)
                {
                    this.txtCountryName.Text = supplier.CountryName;
                    this.txtCode.Text = supplier.Code;
                    this.txtDateFormat.Text = supplier.DateFormat;
                    this.txtTimeFormat.Text = supplier.TimeFormat;
                    this.txtTimeZones.Text = supplier.TimeZones;
                    this.tabControl1.SelectTab(0);
                    this.txtCountryName.Focus();
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
                    var supplier = dbContext.Country.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (supplier is not null)
                    {
                        dbContext.Country.Remove(supplier);
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
    }
}
