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
            //dateTimePicker1.Value = DateTime.Now;
            //DateTime proposedEnddate = DateTime.Now;
            //proposedEnddate.AddDays(14);
            //dateTimePicker2.Value = proposedEnddate;
        }

        private void btnCreateSprint_Click_1(object sender, EventArgs e)
        {
            if (validate(tbSprintName.Text))
            {
                string current_project = new clsFileHandler().readFromFile(new clsFileHandler().get_current_project());
                JObject current_proj = new clsRestAPIHandler().get_single_project(current_project);
                MessageBox.Show(current_proj.ToString());
                string sprints = current_proj["project"][0]["sprints"].ToString();
                JArray sprints_array = JArray.Parse(sprints);
                JObject obj_sprint = new clsRestAPIHandler().create_sprint(tbSprintName.Text, current_project, dateTimePicker1.Value, dateTimePicker2.Value);
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

            if (DateTime.Compare(dateTimePicker2.Value, dateTimePicker1.Value) < 0)
            {
                lblOutput.Text = "Sprint end date is before the start date.";
                dateTimePicker1.Focus();
                return false;
            }

            if (DateTime.Compare(dateTimePicker2.Value, dateTimePicker1.Value) == 0)
            {
                lblOutput.Text = "Sprint start and date are on the same day!";
                dateTimePicker2.Focus();
                return false;
            }

            lblOutput.Text = "";
            return true;
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void addSprintForm_Load(object sender, EventArgs e)
        {

        }

        private void addSprintForm_Shown(object sender, EventArgs e)
        {

        }
    }
}
