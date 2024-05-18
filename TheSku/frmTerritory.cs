using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmTerritory : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;

        public frmTerritory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtSupplierName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtSupplierName.Text))
            {
                MessageBox.Show("Supplier Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplierName.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                Territory territory = dbContext.Territory.Where(x => x.Name.Equals(this.txtSupplierName.Text.Trim())).FirstOrDefault();
                if (territory is not null)
                {
                    MessageBox.Show($"{this.Text} with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtSupplierName.Focus();
                    return;
                }
                Territory territory1 = new Territory()
                {
                    Name = this.txtSupplierName.Text.Trim(),
                    Creation = DateTime.Now,
                    Owner = Global.UserName,
                    TerritoryName = this.txtSupplierName.Text.Trim(),
                    TerritoryManager = dbContext.Users.Where(u => u.Name.Equals(this.cmbSupplierGroup.SelectedValue)).FirstOrDefault()
                };
                dbContext.Territory.Add(territory1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                Territory territory = dbContext.Territory.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (territory is not null)
                {
                    territory.TerritoryName = this.txtSupplierName.Text.Trim();
                    territory.Modified = DateTime.Now;
                    territory.ModifiedBy = Global.UserName;
                    territory.TerritoryManager = dbContext.Users.Where(u => u.Name.Equals(this.cmbSupplierGroup.SelectedValue)).FirstOrDefault();
                    dbContext.Territory.Update(territory);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtSupplierName.Clear();
            this.cmbSupplierGroup.SelectedIndex = -1;
            this.tabControl1.SelectTab(0);
            this.txtSupplierName.Focus();
        }

        private void frmTerritory_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtSupplierName.Focus();
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
            var territories = dbContext.Territory
                            .OrderByDescending(x => x.Modified)
                            .Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text))
                            .Take((int)this.txtLimit.Value)
                            .ToList();
            this.gvList.DataSource = territories;
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
                var territory = dbContext.Territory.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (territory is not null)
                {
                    this.txtSupplierName.Text = territory.TerritoryName;
                    this.cmbSupplierGroup.SelectedValue = territory.TerritoryManager?.Name ?? null;
                    this.tabControl1.SelectTab(0);
                    this.txtSupplierName.Focus();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to close {this.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lblID.Text != "0")
            {
                if (MessageBox.Show($"Are you sure you want to delete {this.lblID.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Territory territory = dbContext.Territory.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (territory is not null)
                    {
                        dbContext.Territory.Remove(territory);
                        dbContext.SaveChanges();
                        MessageBox.Show($"{this.lblID.Text} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnNew.PerformClick();
                    }
                }
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
