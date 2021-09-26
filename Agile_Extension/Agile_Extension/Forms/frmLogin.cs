using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile_Extension.Forms
{
    public partial class frmLogin : MetroSetForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
