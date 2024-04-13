using System;
using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmNameEditor : Form
    {
        AppDbContext dbContext;

        public frmNameEditor(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtNewName.Text))
            {
                MessageBox.Show("New Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNewName.Focus();
                return;
            }
            var d = dbContext.
        }
    }
}
