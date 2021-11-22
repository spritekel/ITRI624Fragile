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
using Microsoft.VisualBasic;
using Agile_Extension.Classes;
using Newtonsoft.Json.Linq;

namespace Agile_Extension.Forms
{
    public partial class addSprintForm : MetroSetForm
    {
        public addSprintForm()
        {
            InitializeComponent();
        }

        private void addSprintForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateSprint_Click_1(object sender, EventArgs e)
        {
            if (validate(tbSprintName.Text))
            {
                DateTime startDate = startDatePick.Value.Date;
                DateTime endDate = endDatePick.Value.Date;

                string current_project = new clsFileHandler().readFromFile(new clsFileHandler().get_current_project());
                JObject current_proj = new clsRestAPIHandler().get_single_project(current_project);
                //MessageBox.Show(current_proj.ToString());
                string sprints = current_proj["project"][0]["sprints"].ToString();
                JArray sprints_array = JArray.Parse(sprints);
                JObject obj_sprint = new clsRestAPIHandler().create_sprint(tbSprintName.Text, current_project, startDate, endDate);
                Console.WriteLine(obj_sprint);
                sprints_array.Add(tbSprintName.Text);
                string current_payload = new clsRestAPIHandler().prepareJsonPayload("sprints", sprints_array);
                new clsRestAPIHandler().update_project(current_project, current_payload);

                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Hide();
            }

        }

        private void addSprintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Hide();
        }

        private bool validate(string sprint_name)
        {
            if (sprint_name.Length <= 0 || sprint_name.Contains(" "))
            {
                lblOutput.Text = "Please enter a valid sprint name eg: sprint_1";
                tbSprintName.Focus();
                return false;
            }

            lblOutput.Text = "";
            return true;
        }
    }
}
