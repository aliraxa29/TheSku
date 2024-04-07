﻿using System;
using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmMain : Form
    {
        readonly AppDbContext dbContext;

        public frmMain(AppDbContext dbContext1)
        {
            dbContext = dbContext1;
            InitializeComponent();
            this.lblUsername.Text = Global.UserName;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUser"] != null)
            {
                Application.OpenForms["frmUser"].BringToFront();
            }
            else
            {
                new frmUser(dbContext) { MdiParent = this }.Show();
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSupplier"] != null)
            {
                Application.OpenForms["frmSupplier"].BringToFront();
            }
            else
            {
                new frmSupplier(dbContext) { MdiParent = this }.Show();
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmChangePassword(dbContext).ShowDialog();
        }

        private void supplierGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SupplierGroup"] != null)
            {
                Application.OpenForms["SupplierGroup"].BringToFront();
            }
            else
            {
                new frmSupplierGroup(dbContext) { MdiParent = this }.Show();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCustomer(dbContext) { MdiParent = this }.Show();
        }
    }
}
