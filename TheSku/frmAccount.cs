using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using TheSku.Data;

namespace TheSku
{
    public partial class frmAccount : Form
    {
        AppDbContext dbContext;
        bool IsBinded = false;

        public frmAccount(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtAccountNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtAccountName.Text))
            {
                MessageBox.Show("Account Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAccountName.Focus();
                return;
            }
            if (this.cmbParentAccount.SelectedIndex == -1)
            {
                MessageBox.Show("Supplier Group is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbParentAccount.Focus();
                return;
            }
            if (this.lblID.Text == "0")
            {
                //string abbr = 
                string account_name = !string.IsNullOrWhiteSpace(this.txtAccountNumber.Text) ? string.Concat(this.txtAccountNumber.Text.Trim()," - ",this.txtAccountName.Text) : this.txtAccountName.Text;
                var supplier = dbContext.Account.Where(x => x.Name.Equals(account_name)).FirstOrDefault();
                if (supplier is not null)
                {
                    MessageBox.Show("Supplier with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtAccountName.Focus();
                    return;
                }
                Account supplier1 = new Account()
                {
                    Name = this.txtAccountName.Text.Trim(),
                    Creation = DateTime.Now,
                    ModifiedBy = Global.UserName,
                    Owner = Global.UserName,
                };
                dbContext.Account.Add(supplier1);
                dbContext.SaveChanges();
                this.ResetForm();
            }
            else
            {
                var supplier1 = dbContext.Account.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier1 is not null)
                {
                    supplier1.AccountName = this.txtAccountNumber.Text.Trim();
                    supplier1.Modified = DateTime.Now;
                    supplier1.ModifiedBy = Global.UserName;
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtAccountName.Clear();
            this.tabControl1.SelectTab(0);
            this.txtAccountName.Focus();
        }
    }
}
