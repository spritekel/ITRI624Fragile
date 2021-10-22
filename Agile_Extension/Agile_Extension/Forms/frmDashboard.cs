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
            getProjects();
            List<string> projects = new clsFileHandler().readMultipleLinesFromFIle(new clsFileHandler().get_project_file());
            if (new clsFileHandler().readFromFile(new clsFileHandler().get_role_file()).Contains("admin"))
            {
                btnAddProj.Enabled = true;
            }
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
            frmLogin login = new frmLogin();
            login.Show();
        }
        #endregion

        #region DYNAMIC_FORM_CREATION

        private void getProjects()
        {      
            //Add tabPages
            MetroSet_UI.Child.MetroSetTabPage tabPage = new MetroSet_UI.Child.MetroSetTabPage();
            tabPage.AutoScroll = true;
            tabPage.Name = "PROJ_3";
            tabPage.Text = "PROJECT 3";
            metroSetTabControl1.Controls.Add(tabPage);
            int page_index = metroSetTabControl1.TabPages.IndexOf(tabPage);
            
            //Adds Tiles Dynamically
            int first_c_local_one = 30;
            int first_c_local_two = 35;
            int tile_size = 75;
            List<MetroSet_UI.Controls.MetroSetTile> tiles = new List<MetroSet_UI.Controls.MetroSetTile>();
            
            for(int i = 0; i < 8; i++)
            {
                tiles.Add(new clsDynamicFormControls("Sprint " + (i+1),first_c_local_one, first_c_local_two, tile_size*2, tile_size).createDynamicTile(metroSetTabControl1.TabPages[page_index]));
                first_c_local_one += tile_size * 2 + 20;
                tiles[i].Click += tile_click_event;
                tiles[i].Name = "tile " + (i + 1);
            }

            //Adds Progress Bar
            int progress_bar_local_one = 13;
            int progress_bar_local_two = 200;
            int progress_bar_size = 150;
            CircularProgressBar.CircularProgressBar progress = new clsDynamicFormControls("Progress",progress_bar_local_one, progress_bar_local_two, progress_bar_size, progress_bar_size).createDynamicProgressBar(metroSetTabControl1.GetControl(page_index));
            progress.Value = 75;
            
            //Adds Panel
            int panel_local_one = 450;
            int panel_local_two = 120;
            int panel_size = 250;
            MetroSet_UI.Controls.MetroSetPanel panel = new clsDynamicFormControls(panel_local_one, panel_local_two, panel_size, panel_size).createDynamicPanel(metroSetTabControl1.TabPages[page_index]);

            //Add label to Panel
            int lbl_local_one = 9;
            int lbl_local_two = 9;
            int lbl_size_one = 240;
            int lbl_size_two = 23;
            MetroSet_UI.Controls.MetroSetLabel label = new clsDynamicFormControls("AGENDA",lbl_local_one, lbl_local_two, lbl_size_one, lbl_size_two).createDynamicLabel(panel);

            //Adds Listbox to Panel
            int list_local_one = 8;
            int list_local_two = 47;
            int list_size = 200;
            MetroSet_UI.Controls.MetroSetListBox list = new clsDynamicFormControls(list_local_one, list_local_two, list_size, list_size).createDynamicListBox(panel);
            list.Items.Add("Generate Dynamic GUI");
        }
        #endregion

        #region DYNAMIC_CONTROL_EVENT_HANDLERS
        //On Click event handler for dynamically created Tile Control
        private void tile_click_event(object sender, EventArgs e)
        {

            MetroSet_UI.Controls.MetroSetTile tile = (MetroSet_UI.Controls.MetroSetTile)sender;
            string name = tile.Name;
            MetroSetMessageBox.Show(this, name, name);
        }
        #endregion

    }
}
