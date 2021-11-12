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
    public partial class frmAddTaskTemplate9 : MetroSetForm
    {
        public frmAddTaskTemplate9()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            frmKanbanTemplate9._Temp9.AddItem(tbTaskName.Text);
        }
    }
}
