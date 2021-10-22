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

                JObject obj_proj = new clsRestAPIHandler().create_project(txtProjName.Text, listbox_toList());
                update_user_projects();
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

        #region SEND_INFO_TO_API_METHODS
        public void update_user_projects()
        {
            for(int i = 0; i < listMembers.Items.Count; i++)
            {
                JObject obj = new clsRestAPIHandler().get_user_info(listMembers.Items[i].ToString());
                string projects = obj["user"][0]["projects"].ToString();
                string trimmed_proj = projects.Trim(new char[] { '[', ']' });
                string payload = update_user_projects(trimmed_proj, txtProjName.Text);
                payload =payload.Replace("\r\n", string.Empty);
                new clsRestAPIHandler().update_user(listMembers.Items[i].ToString(), payload);
            }
            
        }
        
        public string update_user_projects(string projects,string new_project)
        {
            string json_payload = "[{" + (char)34 + "propName" + (char)34 + ":" + (char)34 + "projects" + (char)34 + "," + (char)34 + "value" + (char)34 + ":[";

            if(projects.Length > 0)
            {
                List<string> user_projects = projects.Split(',').ToList();
                for (int i = 0; i < user_projects.Count; i++)
                {
                    json_payload += user_projects[i] + ",";

                }
            }
            
            json_payload += ((char)34 + new_project + (char)34) + "]}]";
            return json_payload;
        }

        private List<string> listbox_toList()
        {
            List<string> output = new List<string>();
            for(int i = 0; i < listMembers.Items.Count;i++)
            {
                output.Add(listMembers.Items[i].ToString());
            }
            return output;
        }
        #endregion
       
    }
}
