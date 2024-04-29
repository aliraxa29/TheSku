using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmRolePermissionManager : Form
    {
        AppDbContext dbContext;
        UserPermissions userPermissions;

        public frmRolePermissionManager(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            userPermissions = new UserPermissions(dbContext);
            InitializeComponent();
            if (!userPermissions.HasWritePermission("Role Permission Manager"))
            {
                this.gvList.ReadOnly = true;
            }
            this.gvList.AutoGenerateColumns = false;
            this.cmbRole.DataSource = dbContext.Roles.Where(r => !r.Disabled).Select(r => r.Name).ToList();
            this.cmbDocument.DataSource = dbContext.Documents.Select(r => r.Name).ToList();
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            if (!userPermissions.HasCreatePermission("Role Permission Manager"))
            {
                return;
            }
            if (this.cmbDocument.SelectedIndex == -1 || this.cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select either role or the document from the list", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbDocument.Focus();
                return;
            }
            var p = dbContext.UserPermissions.Where(p => p.Role.Equals(this.cmbRole.SelectedValue) && p.DocumentType.Equals(this.cmbDocument.SelectedValue)).ToList();
            if (p.Count > 0)
            {
                MessageBox.Show("Permission is already exists.", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbContext.UserPermissions.Add(new()
            {
                Creation = Utility.Now,
                ModifiedBy = Global.UserName,
                DocumentType = this.cmbDocument.SelectedValue?.ToString(),
                Role = dbContext.Roles.Where(r => r.Name.Equals(this.cmbRole.SelectedValue)).FirstOrDefault()
            });
            dbContext.SaveChanges();
            MessageBox.Show("Permission added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BindGrid();
        }

        private void cmbDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRole.SelectedIndex >= 0 && this.cmbDocument.SelectedIndex >= 0)
            {
                this.gvList.DataSource = dbContext.UserPermissions.Where(p => p.Role.Equals(this.cmbRole.SelectedValue)).OrderBy(p => p.DocumentType).ToList();
            }
            else if (this.cmbRole.SelectedIndex >= 0)
            {
                this.gvList.DataSource = dbContext.UserPermissions.Where(p => p.Role.Equals(this.cmbRole.SelectedValue)).OrderBy(p => p.DocumentType).ToList();
            }
            else if (this.cmbDocument.SelectedIndex >= 0)
            {
                this.gvList.DataSource = dbContext.UserPermissions.Where(p => p.DocumentType.Equals(this.cmbDocument.SelectedValue)).OrderBy(p => p.DocumentType).ToList();
            }
        }

        private void BindGrid()
        {
            this.gvList.DataSource = dbContext.UserPermissions.Where(p => p.Role.Equals(this.cmbRole.SelectedValue) && p.DocumentType.Equals(this.cmbDocument.SelectedValue)).ToList();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmRolePermissionManagerHelp().ShowDialog();
        }

        private void gvList_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.ActiveEditor is RadCheckBoxEditor)
            {
                var permission = dbContext.UserPermissions.Where(p => p.Name.Equals(e.Row.Cells["name"].Value)).FirstOrDefault();
                if (permission != null)
                {
                    permission.Read = Convert.ToBoolean(e.Row.Cells["read"].Value);
                    permission.Write = Convert.ToBoolean(e.Row.Cells["write"].Value);
                    permission.Create = Convert.ToBoolean(e.Row.Cells["create"].Value);
                    permission.Submit = Convert.ToBoolean(e.Row.Cells["submit"].Value);
                    permission.Cancel = Convert.ToBoolean(e.Row.Cells["cancel"].Value);
                    permission.Delete = Convert.ToBoolean(e.Row.Cells["delete"].Value);
                    dbContext.UserPermissions.Update(permission);
                }
            }
        }
    }
}
