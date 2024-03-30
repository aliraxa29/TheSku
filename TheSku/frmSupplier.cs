using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmSupplier : Form
    {
        AppDbContext AppDbContext;
        public frmSupplier(AppDbContext dbContext)
        {
            AppDbContext = dbContext;
            InitializeComponent();
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
            var supplier = AppDbContext.Suppliers.Where(x => x.Name.Equals(this.txtSupplierName.Text.Trim())).FirstOrDefault();
            if (supplier is not null)
            {
                MessageBox.Show("Supplier with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplierName.Focus();
                return;
            }
            else
            {
                if (this.lblID.Text == "0")
                {
                    Supplier supplier1 = new Supplier()
                    {
                        Name = this.txtSupplierName.Text.Trim(),
                        ModifiedBy = Global.UserName,
                        Owner = Global.UserName,
                        SupplierName = this.txtSupplierName.Text.Trim(),
                    };
                    AppDbContext.Suppliers.Add(supplier1);
                    AppDbContext.SaveChanges();
                    this.ResetForm();
                }
                else
                {
                    var supplier1 = AppDbContext.Suppliers.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (supplier1 is not null)
                    {
                        supplier1.SupplierName = this.txtSupplierName.Text.Trim();
                        supplier1.Modified = DateTime.Now;
                        supplier1.ModifiedBy = Global.UserName;
                        AppDbContext.SaveChanges();
                        this.ResetForm();
                    }
                }
            }
        }

        private void ResetForm()
        {
            this.txtSupplierName.Clear();
        }

        private void frmSupplier_KeyDown(object sender, KeyEventArgs e)
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

        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            var suppliers = AppDbContext.Suppliers.
                Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text)).
                Take((int)this.txtLimit.Value).
                OrderByDescending(x => x.Modified).
                ToList();
            this.gvList.DataSource = suppliers;
        }

        private void LoadData()
        {
            if (this.lblID.Text != "0")
            {
                var supplier = AppDbContext.Suppliers.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier is not null)
                {
                    this.txtSupplierName.Text = supplier.SupplierName;
                    this.tabControl1.SelectTab(0);
                    this.txtSupplierName.Focus();
                    this.lblID.Visible = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtSupplierName.Clear();
            this.tabControl1.SelectTab(0);
            this.txtSupplierName.Focus();
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
                    var supplier = AppDbContext.Suppliers.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (supplier is not null)
                    {
                        AppDbContext.Suppliers.Remove(supplier);
                        AppDbContext.SaveChanges();
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
                gvList_CellDoubleClick(sender, new DataGridViewCellEventArgs(this.gvList.CurrentCell.ColumnIndex, this.gvList.CurrentCell.RowIndex));
            }
        }
    }
}