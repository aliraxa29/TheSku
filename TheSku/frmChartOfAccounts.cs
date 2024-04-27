using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TheSku.Data;

namespace TheSku
{
    public partial class frmChartOfAccounts : Form
    {
        AppDbContext dbContext;
        List<Account> accounts = new List<Account>();

        public frmChartOfAccounts(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.cmbCompany.DataSource = dbContext.Company.ToList();
            this.cmbCompany.SelectedValue = dbContext.Singles.Where(s => s.Field == "default_company").Select(s => s.Value).FirstOrDefault()?.ToString();
            if (!bwAccounts.IsBusy)
            {
                this.bwAccounts.RunWorkerAsync();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to close {this.Text}?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.Close();
            }
        }

        private void BindAccounts()
        {
            this.tvAccounts.DisplayMember = "Name";
            this.tvAccounts.ParentMember = "ParentAccount";
            this.tvAccounts.ChildMember = "Name";
            accounts = dbContext.Account.Where(a => a.Company.Equals(dbContext.Company.Where(c => c.Name.Equals(this.cmbCompany.SelectedValue)).FirstOrDefault())).ToList();
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            if (this.btnExpandAll.Text == "Expand All")
            {
                this.tvAccounts.ExpandAll();
                this.btnExpandAll.Text = "Collapse All";
            }
            else
            {
                this.tvAccounts.CollapseAll();
                this.btnExpandAll.Text = "Expand All";
            }
        }

        private void frmAccountTreeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.btnClose.PerformClick();
            }
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            if (!bwAccounts.IsBusy)
            {
                bwAccounts.RunWorkerAsync();
            }
        }

        private void bwAccounts_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BindAccounts();
        }

        private void tvAccounts_SelectedNodesChanged(object sender, RadTreeViewEventArgs e)
        {
            if (this.tvAccounts.SelectedNode != null)
            {
                //if (Convert.ToBoolean(Convert.ToInt16(this.objUser.QueryScaler(string.Concat("SELECT COUNT(*) FROM tabAccount WHERE name = '", e.Node.Text, "' and is_group = 1")))))
                //{
                //    this.tvAccounts.SelectedNode.ContextMenu = this.cMenu;
                //}
                //else
                //{
                //    this.tvAccounts.SelectedNode.ContextMenu = null;
                //}
            }
        }

        private void bwAccounts_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.tvAccounts.DataSource = accounts;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmAccount(this.dbContext).ShowDialog();
        }

        private void cmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.cmbCompany.SelectedIndex != -1)
            {
                if (!bwAccounts.IsBusy)
                {
                    bwAccounts.RunWorkerAsync();
                }
            }
        }

        private void btnAddChildAccount_Click(object sender, EventArgs e)
        {
            frmAccount frmAccount = new frmAccount(this.dbContext);
            frmAccount.ShowDialog();
        }

        private void tvAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Apps)
            {
                this.tvAccounts.SelectedNode.ContextMenu = null;
            }
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {

        }
    }
}
