using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using TheSku.Data;

namespace TheSku
{
    public partial class frmSystemSettings : Form
    {
        AppDbContext dbContext;

        public frmSystemSettings(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.btnReload.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.BindCombo();
            this.BindData();
        }

        private void BindData()
        {
            var data = dbContext.Singles.Where(s => s.Doctype == "System Settings").ToList();
            if (data is not null && data.Count > 0)
            {
                this.cmbDefaultCompany.SelectedValue = data.Where(s => s.Field == "default_company").Select(s => s.Value).FirstOrDefault()?.ToString();
                this.cmbDefaultCurrency.SelectedValue = data.Where(s => s.Field == "default_currency").Select(s => s.Value).FirstOrDefault()?.ToString();
                this.cmbDefaultCountry.SelectedValue = data.Where(s => s.Field == "default_country").Select(s => s.Value).FirstOrDefault()?.ToString();
                this.cmbWarehouse.SelectedValue = data.Where(s => s.Field == "default_warehouse").Select(s => s.Value).FirstOrDefault()?.ToString();
                this.cmbLanguage.SelectedValue = data.Where(s => s.Field == "default_language").Select(s => s.Value).FirstOrDefault()?.ToString();
            }
        }

        private void BindCombo()
        {
            this.cmbDefaultCompany.DataSource = dbContext.Company.ToList();
            this.cmbDefaultCountry.DataSource = dbContext.Country.ToList();
            this.cmbDefaultCurrency.DataSource = dbContext.Currency.Where(c => c.Enabled).ToList();
            this.cmbWarehouse.DataSource = dbContext.Warehouse.Where(w => !w.IsGroup && w.Enabled).ToList();
            this.cmbLanguage.DataSource = dbContext.Languages.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var data = dbContext.Singles.Where(s => s.Doctype == "System Settings").ToList();
            if (data is not null && data.Count > 0)
            {
                foreach (Singles singles in data)
                {
                    if (singles.Field == "default_company")
                    {
                        singles.Value = this.cmbDefaultCompany.SelectedValue?.ToString();
                    }
                    if (singles.Field == "default_currency")
                    {
                        singles.Value = this.cmbDefaultCurrency.SelectedValue?.ToString();
                    }
                    if (singles.Field == "default_country")
                    {
                        singles.Value = this.cmbDefaultCountry.SelectedValue?.ToString();
                    }
                    if (singles.Field == "default_warehouse")
                    {
                        singles.Value = this.cmbWarehouse.SelectedValue?.ToString();
                    }
                    if (singles.Field == "default_language")
                    {
                        singles.Value = this.cmbLanguage.SelectedValue?.ToString();
                    }
                    singles.Modified = DateTime.Now;
                    singles.ModifiedBy = Global.UserName;
                }
                dbContext.Singles.UpdateRange(data);
                dbContext.SaveChanges();
                MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.BindData();
        }

        private void brnRefreshFields_Click(object sender, EventArgs e)
        {
            this.BindCombo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to close {this.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.Close();
            }
        }

        private void frmSystemSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnSave.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.btnClose.PerformClick();
            }
        }

        private void cmbWarehouse_Enter(object sender, EventArgs e)
        {
            this.cmbWarehouse.DataSource = dbContext.Warehouse.Where(w => !w.IsGroup && w.Enabled && w.Company.Equals(dbContext.Company.Where(c => c.Name.Equals(this.cmbDefaultCompany.SelectedValue)).FirstOrDefault())).ToList();
        }
    }
}
