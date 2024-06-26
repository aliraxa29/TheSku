﻿using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmUser : Form
    {
        AppDbContext dbContext;
        public frmUser(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.btnDelete.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));
            this.btnCopyNameToClipboard.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.C));
            this.gvList.AutoGenerateColumns = false;
            this.ActiveControl = this.txtFirstName;
            this.brnRefreshFields.PerformClick();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            this.txtFullName.Text = string.Join(" ", this.txtFirstName.Text.Trim(), this.txtLastName.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("User Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
                return;
            }
            var user1 = dbContext.Users.Where(x => x.Name.Equals(this.txtUsername.Text.Trim())).FirstOrDefault();
            if (user1 is not null)
            {
                MessageBox.Show($"{this.Text} with this Name is already exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
                return;
            }
            else
            {
                if (this.lblID.Text == "0")
                {
                    User user = new User()
                    {
                        Name = this.txtUsername.Text.Trim(),
                        ModifiedBy = Global.UserName,
                        Owner = Global.UserName,
                        FirstName = this.txtFirstName.Text.Trim(),
                        LastName = this.txtLastName.Text.Trim(),
                        FullName = this.txtFullName.Text.Trim(),
                        UserName = this.txtUsername.Text.Trim(),
                        Password = Security.EncryptString(this.txtPassword.Text),
                        Role = dbContext.Roles.Where(r => r.Name.Equals(this.cmbRole.SelectedValue)).FirstOrDefault()
                    };
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                    this.ResetForm();
                }
                else
                {
                    var user = dbContext.Users.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                    if (user is not null)
                    {
                        user.FirstName = this.txtFirstName.Text.Trim();
                        user.LastName = this.txtLastName.Text.Trim();
                        user.FullName = this.txtFullName.Text.Trim();
                        user.Password = Security.EncryptString(this.txtPassword.Text);
                        user.Modified = DateTime.Now;
                        user.ModifiedBy = Global.UserName;
                        user.Role = dbContext.Roles.Where(r => r.Name.Equals(this.cmbRole.SelectedValue)).FirstOrDefault();
                        dbContext.SaveChanges();
                        this.ResetForm();
                    }
                }
            }
        }
        private void ResetForm()
        {
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtFullName.Clear();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.txtUsername.ReadOnly = false;
            this.tabControl1.SelectTab(0);
            this.txtFirstName.Focus();
            this.cmbRole.SelectedIndex = -1;
        }

        private void frmUser_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtFirstName.Focus();
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
            var users = dbContext.Users.
                Where(s => string.IsNullOrEmpty(this.txtNameFilter.Text) || s.Name.Contains(this.txtNameFilter.Text)).
                Take((int)this.txtLimit.Value).
                OrderByDescending(x => x.Modified).
                ToList();
            this.gvList.DataSource = users;
        }

        private void LoadData()
        {
            if (this.lblID.Text != "0")
            {
                var supplier = dbContext.Users.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                if (supplier is not null)
                {
                    this.txtFirstName.Text = supplier.FirstName;
                    this.txtLastName.Text = supplier.LastName;
                    this.txtFullName.Text = supplier.FullName;
                    this.txtUsername.Text = supplier.UserName;
                    this.txtPassword.Text = Security.DecryptString(supplier.Password);
                    this.cmbRole.SelectedValue = supplier.Role.Name;
                    this.tabControl1.SelectTab(0);
                    this.txtFirstName.Focus();
                    this.txtUsername.ReadOnly = true;
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
                if (this.lblID.Text != Global.UserName)
                {
                    if (MessageBox.Show($"Are you sure you want to delete {this.lblID.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var supplier = dbContext.Users.Where(x => x.Name.Equals(this.lblID.Text)).FirstOrDefault();
                        if (supplier is not null)
                        {
                            dbContext.Users.Remove(supplier);
                            dbContext.SaveChanges();
                            MessageBox.Show($"{this.lblID.Text} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btnNew.PerformClick();
                        }
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnCopyNameToClipboard_Click(object sender, EventArgs e)
        {
            if (this.lblID.Text != "0")
            {
                Clipboard.SetText(this.lblID.Text);
            }
        }

        private void brnRefreshFields_Click(object sender, EventArgs e)
        {
            this.cmbRole.DataSource = dbContext.Roles.ToList();
        }
    }
}
