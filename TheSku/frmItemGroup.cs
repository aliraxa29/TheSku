using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmItemGroup : Form
    {
        AppDbContext dbContext;

        public frmItemGroup(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtItemGroup;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtItemGroup.Text))
            {
                MessageBox.Show("Item Group Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtItemGroup.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                ItemGroup itemGroup = dbContext.ItemGroup.Where(x => x.Name.Equals(this.txtItemGroup.Text.Trim())).FirstOrDefault();
                if (itemGroup is not null)
                {
                    MessageBox.Show("Item Group with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtItemGroup.Focus();
                    return;
                }
                ItemGroup itemGroup1 = new ItemGroup()
                {
                    Name = this.txtItemGroup.Text.Trim(),
                    Creation = DateTime.Now,
                    Owner = Global.UserName,
                    ItemGroupName = this.txtItemGroup.Text.Trim(),
                };
                dbContext.ItemGroup.Add(itemGroup1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                ItemGroup itemGroup = dbContext.ItemGroup.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (itemGroup is not null)
                {
                    itemGroup.ItemGroupName = this.txtItemGroup.Text.Trim();
                    dbContext.ItemGroup.Update(itemGroup);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtItemGroup.Clear();
            this.tabControl1.SelectTab(0);
            this.txtItemGroup.Focus();
        }

        private void frmItemGroup_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtItemGroup.Focus();
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
            var itemGroups = dbContext.ItemGroup
                            .OrderByDescending(x => x.Modified)
                            .Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text))
                            .Take((int)this.txtLimit.Value)
                            .ToList();
            this.gvList.DataSource = itemGroups;
        }

        private void LoadData()
        {
            if (this.lblID.Text != "0")
            {
                ItemGroup itemGroup = dbContext.ItemGroup.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (itemGroup is not null)
                {
                    this.txtItemGroup.Text = itemGroup.ItemGroupName;
                    this.tabControl1.SelectTab(0);
                    this.txtItemGroup.Focus();
                    this.lblID.Visible = true;
                }
            }
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
                    ItemGroup itemGroup = dbContext.ItemGroup.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (itemGroup is not null)
                    {
                        dbContext.ItemGroup.Remove(itemGroup);
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

        private void txtLimit_KeyDown(object sender, KeyEventArgs e)
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }
    }
}
