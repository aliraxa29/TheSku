using System.Linq;
using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmLogin : Form
    {
        readonly AppDbContext dbContext1;

        public frmLogin(AppDbContext dbContext)
        {
            this.dbContext1 = dbContext;
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUserName.Text))
            {
                MessageBox.Show("User Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Password is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
                return;
            }
            var user = dbContext1.Users
                     .Where(x => x.UserName == this.txtUserName.Text.Trim() && x.Password == Security.EncryptString(this.txtPassword.Text))
                     .FirstOrDefault();
            if (user is not null)
            {
                Global.UserName = user.UserName;
                base.Hide();
                new frmMain(dbContext1).Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
