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
            if(validateProjAdd(txtProjName.Text,txtSprintName.Text,listMembers))
            {
                if (MetroSetMessageBox.Show(this, "Add Project to Database?", "Add Project", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    JObject obj_proj = new clsRestAPIHandler().create_project(txtProjName.Text, listbox_toList(), sprint_list(txtSprintName.Text));
                    update_user_projects();
                    get_updated_project_file();
                    if (obj_proj != null)
                    {
                        new clsRestAPIHandler().create_sprint(txtSprintName.Text, txtProjName.Text, dStart.Value, dEnd.Value);
                        MessageBox.Show("" + dStart.Value + dEnd.Value);
                        lblOutput.Text = obj_proj["message"].ToString();
                    }
                    lblOutput.Text = obj_proj["message"].ToString();
                    AddTabPageResetControls();
                }
            } 
        }

        private void frmAddProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            populateMembersComboBox();
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
                JArray user_projects = JArray.Parse(projects);
                user_projects.Add(txtProjName.Text);
                string json_payload = new clsRestAPIHandler().prepareJsonPayload("projects",user_projects);
                new clsRestAPIHandler().update_user(listMembers.Items[i].ToString(), json_payload);
            }

            //Adds project to the current user in DB.
            string current_user = new clsFileHandler().readFromFile(new clsFileHandler().get_user_file());
            JObject obj_current_user = new clsRestAPIHandler().get_user_info(current_user);
            string projects_current_user = obj_current_user["user"][0]["projects"].ToString();
            JArray projects_current_user_array = JArray.Parse(projects_current_user);
            projects_current_user_array.Add(txtProjName.Text);
            string current_payload = new clsRestAPIHandler().prepareJsonPayload("projects", projects_current_user_array);
            new clsRestAPIHandler().update_user(current_user,current_payload);
        }
        

        //Generates the JSON string that updates a user's projects
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

        private void populateMembersComboBox()
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
            string projects = obj["user"][0]["projects"].ToString();
            JArray user_projects = JArray.Parse(projects);
            new clsFileHandler().writeMutlipleLines(user_projects, new clsFileHandler().get_project_file());
        }
        #endregion

        #region GENERIC_METHODS
        private void AddTabPageResetControls()
        {
            txtProjName.Text = "";
            lblProjFName.Text = "";
            cmbMembers.Items.Clear();
            listMembers.Items.Clear();
            txtSprintName.Text = "";
            populateMembersComboBox();
        }
        #endregion

        #region DELETE_PROJECTS_REGION
        private void populateDelProjComboBox()
        {
            cmbDeleteProj.Items.Clear();
            string current_user = new clsFileHandler().readFromFile(new clsFileHandler().get_user_file());
            JObject obj_current_user = new clsRestAPIHandler().get_user_info(current_user);
            string projects_current_user = obj_current_user["user"][0]["projects"].ToString();
            JArray projects_current_user_array = JArray.Parse(projects_current_user);
            for(int i = 0; i <projects_current_user_array.Count;i++)
            {
                cmbDeleteProj.Items.Add(projects_current_user_array[i]);
            }
        }

        #endregion

        private bool validateProjAdd(string proj_name, string sprint_name, MetroSet_UI.Controls.MetroSetListBox list)
        {
            if(proj_name.Length<=0 || proj_name.Contains(" "))
            {
                lblOutput.Text = "Please enter a valid project name eg: proj_name";
                txtProjName.Focus();
                return false;
            }

            if(sprint_name.Length <=0 || sprint_name.Contains(" "))
            {
                lblOutput.Text = "Please enter a valid sprint name eg: sprint_1";
                txtSprintName.Focus();
                return false;
            }

            if(list.Items.Count <= 0)
            {
                lblOutput.Text = "No members added to project";
                list.Focus();
                return false;
            }

            lblOutput.Text = "";
            return true;
        }

        private void tpAddProj_Enter(object sender, EventArgs e)
        {
            AddTabPageResetControls();
            
        }

        private void tpDeleteProj_Enter(object sender, EventArgs e)
        {
            
            populateDelProjComboBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cmbDeleteProj.SelectedIndex != -1)
            {
                string del_project = cmbDeleteProj.SelectedItem.ToString();
                if (MetroSetMessageBox.Show(this, "Delete"+ del_project +"Database?", "Delete Project", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {  
                    removeProjFromUsers(del_project);
                    JObject obj = new clsRestAPIHandler().delete_project(del_project);
                    int selected_index = cmbDeleteProj.SelectedIndex;
                    cmbDeleteProj.Items.RemoveAt(selected_index);
                    if (obj["message"].ToString().Contains("deleted"))
                    {
                        lblDelResult.Text = obj["message"].ToString();
                    }
                    get_updated_project_file();
                }  
            }
            else
            {
                cmbDeleteProj.Focus();
            }
        }

        private void removeProjFromUsers(string project)
        {
            JObject obj = new clsRestAPIHandler().get_all_users();
            int user_count = int.Parse(obj.GetValue("count").ToString());
            for(int i = 0; i<user_count;i++)
            {
                string projects = obj["users"][i]["projects"].ToString();
                string u_name = obj["users"][i]["username"].ToString();
                JArray proj_array = JArray.Parse(projects);
                JArray new_proj_array = RemoveValueFromJArray(proj_array, project);
                string json_payload = new clsRestAPIHandler().prepareJsonPayload("projects", new_proj_array);
                new clsRestAPIHandler().update_user(u_name, json_payload);
            }
        }

        private static JArray RemoveValueFromJArray(JArray oldArray, dynamic obj)
        {
            List<string> newArray = oldArray.ToObject<List<string>>();
            newArray.Remove(obj);
            return JArray.FromObject(newArray);
        }
    }
}
