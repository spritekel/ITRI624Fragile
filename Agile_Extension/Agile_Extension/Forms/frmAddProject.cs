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
    public partial class frmAddProject : MetroSetForm
    {
        #region FORM_METHODS
        public frmAddProject()
        {
            InitializeComponent();
        }

        private void txtProjName_TextChanged(object sender)
        {
            //Changes text of Summary label as text is entered
            lblProjFName.Text = txtProjName.Text;
        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            
            //if (MetroSetMessageBox.Show(this, "Add Project to Database?", "Add Project", MessageBoxButtons.OKCancel) == DialogResult.Yes)
            //{

                JObject obj_proj = new clsRestAPIHandler().create_project(txtProjName.Text, project_users_list());
            //update_users_to_projects(txtProjName.Text);
            JObject user_proj = new clsRestAPIHandler().update_user(listMembers.Items[0].ToString(),txtProjName.Text);
                //frmDashboard dashboard = new frmDashboard();
                //dashboard.ShowDialog();
           //}

        }

        private void frmAddProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            JObject obj = new clsRestAPIHandler().get_all_users();
            int user_count = int.Parse(obj.GetValue("count").ToString());

            for (int i = 0; i < user_count; i++)
            {
                string users = obj["users"][i]["username"].ToString();
                cmbMembers.Items.Add(users);
            }
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
        #endregion

        public void update_users_to_projects(string new_project)
        {   
            for(int i = 0; i < listMembers.Items.Count; i++)
            {
                //JObject current_user = new clsRestAPIHandler().get_user_info(listMembers.Items[i].ToString());
                //string projects = current_user["user"][0]["projects"].ToString();
                //projects += ","+ new_project;
                JObject users_update = new clsRestAPIHandler().update_user(listMembers.Items[i].ToString(), new_project);
            }
        }

        public string project_users_list()
        {
            string output = "";
            for(int i = 0; i < listMembers.Items.Count; i++)
            {
                output += listMembers.Items[i];
                if(i < listMembers.Items.Count-1)
                {
                    output += ",";
                }
            }
            return output;
        }

 

    }
}
