using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSku
{
    public partial class frmCustomer : Form
    {
        public frmCustomer(Data.AppDbContext dbContext)
        {
            InitializeComponent();
        }
    }
}
