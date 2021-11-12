using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace Agile_Extension.Forms
{
    public partial class frmAddTaskTemplate5Hons : MetroSetForm
    {
        public frmAddTaskTemplate5Hons()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            frmKanbanTemplate5Hons._Temp5Hons.AddItem(tbTaskName.Text);
            ResetControls();
        }

        private void ResetControls()
        {
            tbTaskName.Text = "";
        }
    }
}
