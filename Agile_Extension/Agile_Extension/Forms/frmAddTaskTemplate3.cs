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
    public partial class frmAddTaskTemplate3 : MetroSetForm
    {
        public frmAddTaskTemplate3()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            frmKanbanTemplate3._Temp3.AddItem(tbTaskName.Text);
            ResetControls();
        }

        private void ResetControls()
        {
            tbTaskName.Text = "";
        }
    }
}
