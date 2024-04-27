using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmCompanySetup : Form
    {
        AppDbContext dbContext;
        int Current = 0;

        public frmCompanySetup(AppDbContext dbContext)
        {
            InitializeComponent();
            this.spStep.CompleteNext();
            if (Current == 0)
            {
                this.btnBack.Enabled = false;
            }
            else
            {
                this.btnBack.Enabled = true;
            }
            this.pYourOrganization.Visible = true;
            this.dbContext = dbContext;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are going to close company setup.\nThis will not initialize your application if you have not setup your company.\nWould you like to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.Current == 0)
            {
                this.btnBack.Enabled = false;
            }
            else
            {
                this.btnBack.Enabled = true;
            }
            this.spStep.CompletePrevious();
            if (Current > 0)
            {
                this.Current--;
                if (Current < 2)
                {
                    this.btnNext.Text = "Next";
                }
            }
            if (Current == 0)
            {
                this.pCompanyInfo.Visible = true;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 1)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = true;
                this.pTheBrand.BringToFront();
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 2)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = true;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 3)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.spStep.CompleteNext();
            if (Current < 2)
            {
                this.Current++;
                if (Current > 0 && !this.btnBack.Enabled)
                {
                    this.btnBack.Enabled = true;
                }
            }
            else
            {
                if (this.Current == 2)
                {
                    this.btnNext.Text = "Complete";
                }
                else
                {
                    this.btnNext.Text = "Next";
                }
            }
            if (Current == 0)
            {
                this.pCompanyInfo.Visible = true;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 1)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = true;
                this.pTheBrand.BringToFront();
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 2)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = true;
                this.pYourOrganization.Visible = false;
            }
            else if (Current == 3)
            {
                this.pCompanyInfo.Visible = false;
                this.pTheBrand.Visible = false;
                this.pUser.Visible = false;
                this.pYourOrganization.Visible = true;
            }
        }
    }
}
