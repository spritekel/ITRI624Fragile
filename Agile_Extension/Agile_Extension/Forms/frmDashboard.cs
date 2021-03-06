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
using Newtonsoft.Json;


namespace Agile_Extension.Forms
{
    public partial class frmDashboard : MetroSetForm
    {

        #region FORM_METHODS
        public frmDashboard()
        {
            InitializeComponent();

        }


        private void frmDashboard_Load(object sender, EventArgs e)
        {
            List<string> projects = new clsFileHandler().readMultipleLinesFromFIle(new clsFileHandler().get_project_file());
            if (new clsFileHandler().readFromFile(new clsFileHandler().get_role_file()).Contains("admin"))
            {
                btnAddProj.Enabled = true;
            }
            generateTabPages(projects);
            ///testing
        }

        private void metroSetEllipse1_Click(object sender, EventArgs e)
        {
            frmChat chat = new frmChat();
            chat.Show();
        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            frmAddProject frmProjAdd = new frmAddProject();
            frmProjAdd.Show();
            this.Hide();

        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            new clsFileHandler().deleteFile(new clsFileHandler().get_role_file());
            new clsFileHandler().deleteFile(new clsFileHandler().get_project_file());
            new clsFileHandler().deleteFile(new clsFileHandler().get_user_file());
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
        #endregion

        #region DYNAMIC_FORM_CREATION

        private void generateTabPages(List<string> tabs)
        {
            //Add TabPages
            List<MetroSet_UI.Child.MetroSetTabPage> tap_page = new List<MetroSet_UI.Child.MetroSetTabPage>();
            for (int i = 0; i < tabs.Count; i++)
            {
                tap_page.Add(new MetroSet_UI.Child.MetroSetTabPage());
            }

            for (int i = 0; i < tap_page.Count; i++)
            {
                tap_page[i].AutoScroll = true;
                string project_name = tabs[i].ToString();
                tap_page[i].Name = project_name;
                tap_page[i].Text = project_name;
                metroSetTabControl1.Controls.Add(tap_page[i]);
                generateSprintTiles(project_name, tap_page[i]);
                generateProgressBar(project_name, tap_page[i]);
                MetroSet_UI.Controls.MetroSetPanel metrosetPanel = generatePanel(tap_page[i]);
                MetroSet_UI.Controls.MetroSetLabel metrosetLabel = generatePanelLabel(metrosetPanel);
                MetroSet_UI.Controls.MetroSetListBox metrosetListBox = generateListBox(metrosetPanel, project_name);
                generateSprintBtn(project_name, tap_page[i]);
            }
        }

        //Add Tiles
        private void generateSprintTiles(string project_name, Control parent)
        {
            List<MetroSet_UI.Controls.MetroSetTile> tiles = new List<MetroSet_UI.Controls.MetroSetTile>();
            JArray sprints = get_sprints(project_name);
            int first_c_local_one = 30;
            int first_c_local_two = 35;
            int tile_size = 75;
            for (int i = 0; i < sprints.Count; i++)
            {
                tiles.Add(new clsDynamicFormControls(sprints[i].ToString(), first_c_local_one, first_c_local_two, tile_size * 2, tile_size).createDynamicTile(parent));
                first_c_local_one += tile_size * 2 + 20;
                tiles[i].Click += tile_click_event;
                tiles[i].Name = sprints[i].ToString();
            }
        }

        private void generateSprintBtn(string project_name, Control parent)
        {
            int x_pos = 200;
            int y_pos = 200;
            int tile_size = 75;

            MetroSet_UI.Controls.MetroSetTile SprintBtn = new clsDynamicFormControls("New Sprint", x_pos, y_pos, tile_size, tile_size).createDynamicTile(parent);
            SprintBtn.Click += sprintbtn_click_event;
            SprintBtn.Name = "SprintBtn";
        }

        //Add ProgressBar
        private void generateProgressBar(string project, Control parent)
        {
            int progress_bar_local_one = 15;
            int progress_bar_local_two = 150;
            int progress_bar_size = 150;
            CircularProgressBar.CircularProgressBar progress = new clsDynamicFormControls("Progress", progress_bar_local_one, progress_bar_local_two, progress_bar_size, progress_bar_size).createDynamicProgressBar(parent);
            progress.Name = "pb" + project;
           
            double value = getProgress(project.ToString());
           
            int percent = ((int)(Math.Round(value)));
            progress.Value = percent;
            progress.SubscriptText = percent.ToString();
        }

        private double getProgress(string project)
        {
            double progressPercent = 0;
            int doing = 0;
            int done = 0;
            int todo = 0;

            string tabName = project;

            JObject allsprints = new clsRestAPIHandler().get_all_sprints();
            int count = int.Parse(allsprints["count"].ToString());
            List<string> taskList = new List<string>();

            JArray TaskArray = null;
            for (int i = 0; i <= count - 1; i++)
            {
                if (allsprints["sprints"][i]["sprint"]["project"].ToString() == tabName)
                {

                    if (allsprints["sprints"][i]["sprint"]["tasks"].ToString() != "[]")
                    {
                        TaskArray = JArray.Parse(allsprints["sprints"][i]["sprint"]["tasks"].ToString());


                        for (int k = 0; k <= TaskArray.Count() - 1; k++)
                        {
                            //To-do task count
                            if (TaskArray[k]["listNumber"].ToString() == "1")
                            {
                                todo += 1;
                            }
                            //Doing task count
                            if (TaskArray[k]["listNumber"].ToString() == "2")
                            {
                                doing += 1;
                            }
                            //Done task count
                            if (TaskArray[k]["listNumber"].ToString() == "3")
                            {
                                done += 1;
                            }
                        }
                    }
                }
            }
            double div = doing + todo + done;
            
            progressPercent = done / div;
            if (double.IsInfinity(progressPercent))
            {
                progressPercent = 1;
            }
            if (progressPercent.ToString() == "NaN") {
                progressPercent = 0;
            }
            return progressPercent * 100;

        }

        //Add Panel
        private MetroSet_UI.Controls.MetroSetPanel generatePanel(Control parent)
        {
            int panel_local_one = 700; //X-pos
            int panel_local_two = 125; //Y-pos
            int panel_size_one = 250;  //X-size
            int panel_size_two = 200;  //Y-size
            MetroSet_UI.Controls.MetroSetPanel panel = new clsDynamicFormControls(panel_local_one, panel_local_two, panel_size_one, panel_size_two).createDynamicPanel(parent);
            return panel;
        }

        //Adds Label on Panel
        private MetroSet_UI.Controls.MetroSetLabel generatePanelLabel(Control parent)
        {
            int lbl_local_one = 9;
            int lbl_local_two = 9;
            int lbl_size_one = 240;
            int lbl_size_two = 23;
            MetroSet_UI.Controls.MetroSetLabel label = new clsDynamicFormControls("AGENDA", lbl_local_one, lbl_local_two, lbl_size_one, lbl_size_two).createDynamicLabel(parent);
            return label;
        }

        //Adds Listbox on Panel
        private MetroSet_UI.Controls.MetroSetListBox generateListBox(Control parent, string project)
        {

            int list_local_one = 8;
            int list_local_two = 47;
            int list_size = 199;
            MetroSet_UI.Controls.MetroSetListBox list = new clsDynamicFormControls(list_local_one, list_local_two, list_size, list_size - 100).createDynamicListBox(parent);
           
            List<string> taskList = new List<string>();
            string tabName = project;
            //Update agenda
           
            JObject allsprints = new clsRestAPIHandler().get_all_project_sprints(tabName);
            
            JArray TaskArray = null;

            TaskArray = JArray.Parse(allsprints["sprint"].ToString());


           
            for (int i = 0; i <= TaskArray.Count - 1; i++)
            {
                string tasksList = TaskArray[i]["tasks"].ToString();
               
                JArray doingTasks = JArray.Parse(tasksList);
                int count = doingTasks.Count;

                var resultList = doingTasks.Where(x => x["listNumber"].ToString() == "2").ToList();

                for (int h = 0; h < resultList.Count; h++)
                {
                    list.Items.Add(resultList[h]["taskName"].ToString());
                }

            }
            return list;
        }

        #endregion

        #region DYNAMIC_CONTROL_EVENT_HANDLERS
        //On Click event handler for dynamically created Tile Control
        private void tile_click_event(object sender, EventArgs e)
        {
            MetroSet_UI.Controls.MetroSetTile tile = (MetroSet_UI.Controls.MetroSetTile)sender;
            frmKanbanTemplate3 kan = new frmKanbanTemplate3();
            //Get current project
            new clsFileHandler().writeToFile(tile.Parent.Name, new clsFileHandler().get_current_project());
            string current_project = new clsFileHandler().readFromFile(new clsFileHandler().get_current_project());
            JObject current_proj = new clsRestAPIHandler().get_single_project(current_project);
            string project = current_proj["project"][0]["projName"].ToString();
            //Get curent sprint
            new clsFileHandler().writeToFile(tile.Name, new clsFileHandler().get_current_sprint());
            string current_sprint = new clsFileHandler().readFromFile(new clsFileHandler().get_current_sprint());
            JObject current_spr = new clsRestAPIHandler().get_single_sprint(current_sprint, project);
            //Write sprint info
            new clsFileHandler().writeToFile(current_spr.ToString(), new clsFileHandler().get_sprint_info());
            kan.Show();

            this.Hide();
        }
        private void sprintbtn_click_event(object sender, EventArgs e)
        {
            MetroSet_UI.Controls.MetroSetTile tile = (MetroSet_UI.Controls.MetroSetTile)sender;
            new clsFileHandler().writeToFile(tile.Parent.Name, new clsFileHandler().get_current_project());
            addSprintForm cs = new addSprintForm();
            this.Hide();
            cs.Show();
        }
        #endregion

        #region GENERIC_METHODS
        public JArray get_sprints(string project)
        {
            JObject obj = new clsRestAPIHandler().get_single_project(project);
            string json_projects = obj["project"][0]["sprints"].ToString();
            JArray sprints_array = JArray.Parse(json_projects);
            return sprints_array;
        }


        #endregion

        
    }
}
