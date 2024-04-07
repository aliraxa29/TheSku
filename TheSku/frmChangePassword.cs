using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmChangePassword : Form
    {
        AppDbContext dbContext;

        public frmChangePassword(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.txtUsername.Text = Global.UserName;
            this.ActiveControl = this.txtOldPassword;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.TextLength <= 0)
            {
                MessageBox.Show("Username is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
                return;
            }
            if (this.txtOldPassword.TextLength <= 0)
            {
                MessageBox.Show("Old Password is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtOldPassword.Focus();
                return;
            }
            if (this.txtNewPassword.TextLength <= 0)
            {
                MessageBox.Show("New Password is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNewPassword.Focus();
                return;
            }
            if (this.txtConfirmPassword.TextLength <= 0)
            {
                MessageBox.Show("Confirm Password is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtConfirmPassword.Focus();
                return;
            }
            if (this.txtConfirmPassword.Text != this.txtNewPassword.Text)
            {
                MessageBox.Show("Confirm Password does not match with new password", "Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtConfirmPassword.Focus();
                return;
            }
            var user = dbContext.Users.Where(x => x.UserName == this.txtUsername.Text).FirstOrDefault();
            if (user is not null)
            {
                if (Security.EncryptString(this.txtOldPassword.Text) != user.Password)
                {
                    MessageBox.Show("Your old password does not match with current password.", "Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtOldPassword.Focus();
                    return;
                }
                user.Password = Security.EncryptString(this.txtNewPassword.Text);
                dbContext.Users.Update(user);
                dbContext.SaveChanges();
                MessageBox.Show("Password Changed Successfully.\nPlease remember your new password", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.DialogResult = DialogResult.OK;
            }
        }
    }
}
