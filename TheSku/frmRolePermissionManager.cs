using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PharmacyManagementSystem.User
{
    public partial class frmRolePermissionManager : Form
    {
        public frmRolePermissionManager()
        {
            InitializeComponent();
            if (!Users.HasWritePermission("Role Permission Manager"))
            {
                this.gvList.ReadOnly = true;
            }
            this.gvList.AutoGenerateColumns = false;
            this.cmbRole.DataSource = Db.Con.Query("tabRole").Select("name").Where("disabled", 0).Get();
            this.cmbDocument.DataSource = Db.Con.Query("tabDoctype").Select("name").Get();
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            if (!Users.HasCreatePermission("Role Permission Manager"))
            {
                return;
            }
            if (this.cmbDocument.SelectedIndex == -1 || this.cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select either role or the document from the list", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbDocument.Focus();
                return;
            }
            if (Db.Con.Query("tabUser Permission").Where(new { role = this.cmbRole.SelectedValue?.ToString(), document_type = this.cmbDocument.SelectedValue?.ToString() }).Count<int>() > 0)
            {
                MessageBox.Show("Permission is Already exists.", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Db.Con.Query("tabUser Permission").Insert(new
            {
                modified_by = CompanySession.CurrentLoggedInUser,
                owner = CompanySession.CurrentLoggedInUser,
                document_type = this.cmbDocument.SelectedValue?.ToString(),
                role = this.cmbRole.SelectedValue?.ToString()
            });
            MessageBox.Show("Permission added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BindGrid();
        }

        private void cmbDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRole.SelectedIndex >= 0 && this.cmbDocument.SelectedIndex >= 0)
            {
                this.gvList.DataSource = Db.Con.Query("tabUser Permission").Where(new { role = this.cmbRole.SelectedValue?.ToString(), document_type = this.cmbDocument.SelectedValue?.ToString() }).OrderBy("document_type").Get();
            }
            else if (this.cmbRole.SelectedIndex >= 0)
            {
                this.gvList.DataSource = Db.Con.Query("tabUser Permission").Where(new { role = this.cmbRole.SelectedValue?.ToString() }).OrderBy("document_type").Get();
            }
            else if (this.cmbDocument.SelectedIndex >= 0)
            {
                this.gvList.DataSource = Db.Con.Query("tabUser Permission").Where(new { document_type = this.cmbDocument.SelectedValue?.ToString() }).OrderBy("document_type").Get();
            }
        }

        private void BindGrid()
        {
            this.gvList.DataSource = Db.Con.Query("tabUser Permission").Where(new { role = this.cmbRole.SelectedValue?.ToString(), document_type = this.cmbDocument.SelectedValue?.ToString() }).Get();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmRolePermissionManagerHelp().ShowDialog();
        }

        private void gvList_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.ActiveEditor is RadCheckBoxEditor)
            {
                Db.Con.Query("tabUser Permission").Where(new { document_type = e.Row.Cells["document"].Value?.ToString(), role = e.Row.Cells["role"].Value?.ToString() }).Update(new
                {
                    read = Convert.ToInt16(e.Row.Cells["read"].Value),
                    write = Convert.ToInt16(e.Row.Cells["write"].Value),
                    create = Convert.ToInt16(e.Row.Cells["create"].Value),
                    submit = Convert.ToInt16(e.Row.Cells["submit"].Value),
                    cancel = Convert.ToInt16(e.Row.Cells["cancel"].Value),
                    delete = Convert.ToInt16(e.Row.Cells["delete"].Value),
                });
            }
        }
    }
}
