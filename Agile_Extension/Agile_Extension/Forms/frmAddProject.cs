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
            lblProjFName.Text = "Project: " +  txtProjName.Text;
        }
        private void txtSprintName_TextChanged(object sender)
        {
            lblSprintF.Text = "1st Sprint: " + txtSprintName.Text;
        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            
            if (MetroSetMessageBox.Show(this, "Add Project to Database?", "Add Project", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {            
                JObject obj_proj = new clsRestAPIHandler().create_project(txtProjName.Text, listbox_toList(),sprint_list(txtSprintName.Text));
                update_user_projects();     
                get_updated_project_file();
                if(obj_proj != null)
                {
                    new clsRestAPIHandler().create_sprint(txtSprintName.Text, txtProjName.Text);
                    lblOutput.Text = obj_proj["message"].ToString();
                }
                resetControls();
            }
            
        }

        private void frmAddProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            populateComboBox();
           
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
            //Adds project to each user in the listbox to DB.
            for(int i = 0; i < listMembers.Items.Count; i++)
            {
                JObject obj = new clsRestAPIHandler().get_user_info(listMembers.Items[i].ToString());
                string projects = obj["user"][0]["projects"].ToString();
                string trimmed_proj = projects.Trim(new char[] { '[', ']' });
                string payload = update_user_projects(trimmed_proj, txtProjName.Text);
                payload =payload.Replace("\r\n", string.Empty);
                new clsRestAPIHandler().update_user(listMembers.Items[i].ToString(), payload);
            }

            //Adds project to the current user in DB.
            string current_user = new clsFileHandler().readFromFile(new clsFileHandler().get_user_file());
            JObject obj_current_user = new clsRestAPIHandler().get_user_info(current_user);
            string projects_current_user = obj_current_user["user"][0]["projects"].ToString();
            string trimmed_proj_current_user = projects_current_user.Trim(new char[] { '[', ']' });
            string payload_current_user = update_user_projects(trimmed_proj_current_user, txtProjName.Text);
            payload_current_user = payload_current_user.Replace("\r\n", string.Empty);
            new clsRestAPIHandler().update_user(current_user, payload_current_user);
            
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
            //Code below: adds user that is logged in to the project
            output.Add(new clsFileHandler().readFromFile(new clsFileHandler().get_user_file()));
            for(int i = 0; i < listMembers.Items.Count;i++)
            {
                output.Add(listMembers.Items[i].ToString());
            }
            return output;
        }

        private void populateComboBox()
        {
            JObject obj = new clsRestAPIHandler().get_all_users();
            int user_count = int.Parse(obj.GetValue("count").ToString());
            string current_user = new clsFileHandler().readFromFile(new clsFileHandler().get_user_file());
  
            for (int i = 0; i < user_count; i++)
            {         
                string users = obj["users"][i]["username"].ToString();     
                cmbMembers.Items.Add(users);                   
            }
            cmbMembers.Items.Remove(current_user);
        }

        private List<string> sprint_list(string sprint)
        {
            List<string> list = new List<string>();
            list.Add(sprint);
            return list;
        }
      
        #endregion

        #region UPDATE_CACHE_FILES_METHODS
        private void get_updated_project_file()
        {
            new clsFileHandler().deleteFile(new clsFileHandler().get_project_file());
            string current_user = new clsFileHandler().readFromFile(new clsFileHandler().get_user_file());
            JObject obj = new clsRestAPIHandler().get_user_info(current_user);
            string username = obj["user"][0]["username"].ToString();
            string projects = obj["user"][0]["projects"].ToString();
            string trimmed_proj = projects.Trim(new char[] { '[', ']' });
            List<string> user_projects = trimmed_proj.Split(',').ToList();
            new clsFileHandler().writeMutlipleLines(user_projects, new clsFileHandler().get_project_file());
        }
        #endregion

        #region GENERIC_METHODS
        private void resetControls()
        {
            txtProjName.Text = "";
            lblProjFName.Text = "";
            cmbMembers.Items.Clear();
            listMembers.Items.Clear();
            lblOutput.Text = "";
            populateComboBox();
        }
        #endregion
    }
}
