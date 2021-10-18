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
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            getProjects();

        }

        private void metroSetListBox1_SelectedIndexChanged(object sender)
        {

        }

        private void metroSetEllipse1_Click(object sender, EventArgs e)
        {
            frmChat chat = new frmChat();
            chat.Show();
        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            frmAddProject frmProjAdd = new frmAddProject();
            frmProjAdd.ShowDialog();
           
            //Figure out how to close form
        }


        private void getProjects()
        {      
            //Add tabPages
            metroSetTabControl1.TabPages.Add("PROJ_3", "PROJECT 3");
            int pageIndex = metroSetTabControl1.TabPages.IndexOfKey("PROJ_3");
            
            //Adds Tiles Dynamically
            int first_c_local_one = 30;
            int first_c_local_two = 35;
            int tile_size = 75;
            List<MetroSet_UI.Controls.MetroSetTile> tiles = new List<MetroSet_UI.Controls.MetroSetTile>();
            
            for(int i = 0; i < 8; i++)
            {
                tiles.Add(new clsDynamicFormControls(first_c_local_one, first_c_local_two, tile_size*3, tile_size).createDynamicTile(metroSetTabControl1.GetControl(pageIndex)));
                first_c_local_one += tile_size * 3 + 20;
            }

            //Adds Progress Bar
            int progress_bar_local_one = 13;
            int progress_bar_local_two = 200;
            int progress_bar_size = 150;


            CircularProgressBar.CircularProgressBar progress = new clsDynamicFormControls("Progress",progress_bar_local_one, progress_bar_local_two, progress_bar_size, progress_bar_size).createDynamicProgressBar(metroSetTabControl1.GetControl(pageIndex));
            progress.Value = 75;
            
            //Adds Panel TODO: Fix this please.
            int panel_local_one = 5;
            int panel_local_two = 5;
            int panel_size = 250;
            Panel panel = new clsDynamicFormControls(panel_local_one, panel_local_two, panel_size, panel_size).createDynamicPanel(metroSetTabControl1.GetControl(pageIndex));
           
        }

    }
}
