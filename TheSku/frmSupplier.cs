using System;
using System.Linq;
using System.Windows.Forms;
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

        private void tpList_Enter(object sender, EventArgs e)
        {
            var suppliers = AppDbContext.Suppliers.Take(100).OrderByDescending(x => x.Modified).ToList();
            this.gvList.DataSource = suppliers;
        }

        private void frmSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnSave.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    tabControl1.SelectTab(1);
                    this.gvList.Focus();
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
                }
            }
        }

    }
}
