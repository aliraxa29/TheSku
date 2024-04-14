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

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCountry"] != null)
            {
                Application.OpenForms["frmCountry"].BringToFront();
            }
            else
            {
                new frmCountry(dbContext) { MdiParent = this }.Show();
            }
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCurrency"] != null)
            {
                Application.OpenForms["frmCurrency"].BringToFront();
            }
            else
            {
                new frmCurrency(dbContext) { MdiParent = this }.Show();
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAccount"] != null)
            {
                Application.OpenForms["frmAccount"].BringToFront();
            }
            else
            {
                new frmAccount(dbContext) { MdiParent = this }.Show();
            }
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCompany"] != null)
            {
                Application.OpenForms["frmCompany"].BringToFront();
            }
            else
            {
                new frmCompany(dbContext) { MdiParent = this }.Show();
            }
        }

        private void sessionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSystemSettings"] != null)
            {
                Application.OpenForms["frmSystemSettings"].BringToFront();
            }
            else
            {
                new frmSystemSettings(dbContext) { MdiParent = this }.Show();
            }
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmChartOfAccounts"] != null)
            {
                Application.OpenForms["frmChartOfAccounts"].BringToFront();
            }
            else
            {
                new frmChartOfAccounts(dbContext) { MdiParent = this }.Show();
            }
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPos() { MdiParent = this }.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBrand"] != null)
            {
                Application.OpenForms["frmBrand"].BringToFront();
            }
            else
            {
                new frmBrand() { MdiParent = this }.Show();
            }
        }
    }
}
