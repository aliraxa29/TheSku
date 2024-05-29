using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmAddCustomer : Form
    {
        AppDbContext dbContext;
        SellingSettings SellingSettings = new SellingSettings();
        public string Customer { get; set; }

        public frmAddCustomer(AppDbContext dbContext, string phoneNo)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.ActiveControl = this.txtPhoneNo;
            this.txtPhoneNo.Text = phoneNo;
            this.cmbCustomerGroup.DataSource = dbContext.CustomerGroup.ToList();
            this.cmbTerritory.DataSource = dbContext.Territory.ToList();
            this.cmbType.SelectedIndex = 0;
            this.cmbCustomerGroup.SelectedValue = SellingSettings.DefaultCustomerGroup ?? "";
            this.cmbTerritory.SelectedValue = SellingSettings.DefaultTerritory ?? "";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCustomerName.Text))
            {
                MessageBox.Show("Customer Name required to create New Customer", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                base.DialogResult = DialogResult.None;
                this.txtCustomerName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtPhoneNo.Text))
            {
                MessageBox.Show("Customer Mobile Phone Number required to create new Customer.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                base.DialogResult = DialogResult.None;
                this.txtPhoneNo.Focus();
                return;
            }
            if (this.txtPhoneNo.Text.Length <= 10)
            {
                MessageBox.Show("Customer Mobile No Should Be 10 Digits Long", "Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                base.DialogResult = DialogResult.None;
                this.txtPhoneNo.Focus();
                return;
            }
            if (this.cmbCustomerGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Select Customer Group", "Customer Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                base.DialogResult = DialogResult.None;
                this.cmbCustomerGroup.Focus();
                return;
            }
            Customer customer1 = dbContext.Customer.Where(c => c.Name.Equals(this.txtPhoneNo.Text.Trim())).FirstOrDefault();
            if (customer1 != null)
            {
                MessageBox.Show("Customer with this number is already exists.", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                base.DialogResult = DialogResult.None;
                this.txtPhoneNo.Focus();
                return;
            }
            Customer customer = new Customer()
            {
                Name = this.txtPhoneNo.Text.Trim(),
                Owner = Global.UserName,
                Creation = DateTime.Now,
                CustomerName = this.txtCustomerName.Text.Trim(),
                CustomerGroup = this.cmbCustomerGroup.SelectedValue?.ToString(),
                CustomerType = this.cmbType.SelectedItem.ToString(),
                PhoneNumber = this.txtPhoneNo.Text.Trim(),
            };
            dbContext.Customer.Add(customer);
            dbContext.SaveChanges();
            this.Customer = this.txtPhoneNo.Text;
            base.DialogResult = DialogResult.OK;
            return;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) ? false : e.KeyChar != Convert.ToChar(Keys.Return)))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }
    }
}
