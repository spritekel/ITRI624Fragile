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
            if(validate(tbTaskName.Text))
            { 
                frmKanbanTemplate3._Temp3.AddItem(tbTaskName.Text); 
            }
            
            ResetControls();
        }

        private void ResetControls()
        {
            tbTaskName.Text = "";
        }

        private bool validate(string task_name)
        {
            if (task_name.Length <= 0 || task_name.Contains(" "))
            {
                lblOutput.Text = "Please enter a valid task name eg: task_name";
                tbTaskName.Focus();
                return false;
            }


            lblOutput.Text = "";
            return true;
        }
        /*
        private bool validate(string task_name, MetroSet_UI.Controls.MetroSetListBox list)
        {
            if (task_name.Length <= 0 || task_name.Contains(" "))
            {
                lblOutput.Text = "Please enter a valid task name eg: task_name";
                tbTaskName.Focus();
                return false;
            }

            if (list.Items.Count <= 0)
            {
                lblOutput.Text = "No members added to task";
                list.Focus();
                return false;
            }

            lblOutput.Text = "";
            return true;
        }*/
    }
}
