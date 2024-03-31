using System;
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
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser(dbContext);
            frmUser.MdiParent = this;
            frmUser.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier frmUser = new frmSupplier(dbContext);
            frmUser.MdiParent = this;
            frmUser.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
