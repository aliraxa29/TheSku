using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmItem : Form
    {
        AppDbContext dbContext;

        public frmItem(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
        }
    }
}
