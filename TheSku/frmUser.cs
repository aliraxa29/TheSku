using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    public partial class frmUser : Form
    {
        public frmUser(AppDbContext dbContext)
        {
            InitializeComponent();
        }
    }
}
