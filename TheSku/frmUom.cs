using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmUom : Form
    {
        AppDbContext dbContext;

        public frmUom(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtUomName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUomName.Text))
            {
                MessageBox.Show("Uom Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUomName.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                Uom uom = dbContext.Uom.Where(x => x.Name.Equals(this.txtUomName.Text.Trim())).FirstOrDefault();
                if (uom is not null)
                {
                    MessageBox.Show("Uom with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUomName.Focus();
                    return;
                }
                Uom uom1 = new Uom()
                {
                    Name = this.txtUomName.Text.Trim(),
                    Creation = DateTime.Now,
                    ModifiedBy = Global.UserName,
                    Owner = Global.UserName,
                    UomName = this.txtUomName.Text.Trim(),
                    Enabled = this.chkEnabled.Checked,
                    MustBeWholeNumber = this.chkMustBeWholeNumber.Checked,
                };
                dbContext.Uom.Add(uom1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                Uom uom = dbContext.Uom.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (uom is not null)
                {
                    uom.UomName = this.txtUomName.Text.Trim();
                    uom.Modified = DateTime.Now;
                    uom.ModifiedBy = Global.UserName;
                    uom.Enabled = this.chkEnabled.Checked;
                    uom.MustBeWholeNumber = this.chkMustBeWholeNumber.Checked;
                    dbContext.Uom.Update(uom);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtUomName.Clear();
            this.chkEnabled.Checked = true;
            this.chkMustBeWholeNumber.Checked = false;
            this.tabControl1.SelectTab(0);
            this.txtUomName.Focus();
        }

        private void frmUom_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtUomName.Focus();
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
            var suppliers = dbContext.Uom
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
                Uom uom = dbContext.Uom.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (uom is not null)
                {
                    this.txtUomName.Text = uom.UomName;
                    this.chkEnabled.Checked = uom.Enabled;
                    this.chkMustBeWholeNumber.Checked = uom.MustBeWholeNumber;
                    this.tabControl1.SelectTab(0);
                    this.txtUomName.Focus();
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
                    Uom uom = dbContext.Uom.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (uom is not null)
                    {
                        dbContext.Uom.Remove(uom);
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
