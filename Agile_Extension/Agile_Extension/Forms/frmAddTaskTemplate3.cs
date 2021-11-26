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
using Agile_Extension.Classes;
using Newtonsoft.Json.Linq;

namespace Agile_Extension.Forms
{
    public partial class frmAddTaskTemplate3 : MetroSetForm
    {
        public frmAddTaskTemplate3()
        {
            InitializeComponent();
            populateComboBox();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if(validate(tbTaskName.Text,listMembers))
            { 
                frmKanbanTemplate3._Temp3.AddItem(tbTaskName.Text);

                string current_project = new clsFileHandler().readFromFile(new clsFileHandler().get_current_project());
                string current_sprint = new clsFileHandler().readFromFile(new clsFileHandler().get_current_sprint());

                string[] users = new string[listMembers.Items.Count];
                for (int i = 0; i < listMembers.Items.Count; i++)
                {
                    users[i] = listMembers.Items[i].ToString();
                }
                string allusers = String.Join(",", users);
                //MessageBox.Show(allusers);

                string content = "{listNumber: '1', " + "taskName: '" + tbTaskName.Text + "', taskUsers: '" + allusers + "'}";
                JObject obj = JObject.Parse(content);
                new clsRestAPIHandler().add_task(current_sprint, current_project, obj.ToString());
                //MessageBox.Show(obj.ToString());
            }



            ResetControls();
        }

        private void cmbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbMembers.SelectedIndex;

            listMembers.Items.Add(cmbMembers.Text);
            cmbMembers.Items.RemoveAt(index);
        }

        private void listMembers_SelectedIndexChanged(object sender)
        {
            int index = listMembers.SelectedIndex;
            cmbMembers.Items.Add(listMembers.Items[index]);
            listMembers.Items.RemoveAt(index);
        }
        private void populateComboBox()
        {
            string projectname = new clsFileHandler().readFromFile(new clsFileHandler().get_current_project());
            JObject obj = new clsRestAPIHandler().get_single_project(projectname);
            string current_user = new clsFileHandler().readFromFile(new clsFileHandler().get_user_file());
            JArray current_users = JArray.Parse(obj["project"][0]["projUsers"].ToString());

            foreach (string item in current_users)
            {
                cmbMembers.Items.Add(item);
            }
            cmbMembers.Items.Remove(current_user);
        }
        private void ResetControls()
        {
            tbTaskName.Text = "";
            lblMembersDets.Text = "";
            cmbMembers.Items.Clear();
            listMembers.Items.Clear();
            populateComboBox();
        }

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
        }
    }
}
