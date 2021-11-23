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
using Newtonsoft.Json;

namespace Agile_Extension.Forms
{
    public partial class frmKanbanTemplate3 : MetroSetForm
    {
        public int count;
        public string[] sep_users;
        public string listname;
        public string taskname;
        public string listnum;

        public void spilt_users(string users_string)
        {
            sep_users = users_string.Split(',');
        }

        public frmKanbanTemplate3()
        {
            InitializeComponent();
            metroSetPanel1.AutoScroll = true;
            count = 3;

            _Temp3 = this;
            //Initially Load in progress of sprint from DB
           
            lstTodo.AllowDrop = true;
            lstDoing.AllowDrop = true;
            lstDone.AllowDrop = true;
        }
        public static frmKanbanTemplate3 _Temp3;


        public void LoadProgressBar(DateTime today)
        {
            string projectname = new clsFileHandler().readFromFile(new clsFileHandler().get_current_project());
            string sprintname = new clsFileHandler().readFromFile(new clsFileHandler().get_current_sprint());
            JObject sprint_info = new clsRestAPIHandler().get_single_sprint(sprintname, projectname);
            string startdate = sprint_info["sprint"][0]["startDate"].ToString();
            string enddate = sprint_info["sprint"][0]["endDate"].ToString();

            lbSD.Text = startdate;
            lbED.Text = enddate;

            DateTime start = DateTime.Parse(startdate);
            DateTime end = DateTime.Parse(enddate);

            double progPercent = ((today - start).TotalHours / (end - start).TotalHours) * 100;

            if (progPercent > 85)
            {
                metroSetProgressBar1.BorderColor = System.Drawing.Color.Red;
            }
            if (progPercent == 100)
            {
                metroSetProgressBar1.ProgressColor = System.Drawing.Color.Red;
            }
            metroSetProgressBar1.Value = ((int)progPercent);
        }

        public void AddItem(string value)
        {
            lstTodo.Items.Add(value);
        }



        #region Drag Drop Stuff

        private void lst_ItemDrag(object sender, ItemDragEventArgs e)
        {
            System.Windows.Forms.ListView lists = (System.Windows.Forms.ListView)sender;
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lists.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lists.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lst_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lst_DragDrop(object sender, DragEventArgs e)
        {
            System.Windows.Forms.ListView lists = (System.Windows.Forms.ListView)sender;
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lists.Items.Add(lvi);
                    taskname = lvi.SubItems[0].Text.ToString();

                    listname = lists.Columns[0].Text;

                    if (listname == "To Do")
                    {
                        listnum = "1";
                    }
                    else if (listname == "Doing")
                    {
                        listnum = "2";
                    }
                    else
                    {
                        listnum = "3";
                    }

                    string current_project = new clsFileHandler().readFromFile(new clsFileHandler().get_current_project());
                    string current_sprint = new clsFileHandler().readFromFile(new clsFileHandler().get_current_sprint());

                    string content = "{listNumber: '" + listnum + "'}";
                    JObject obj = JObject.Parse(content);
                    new clsRestAPIHandler().move_task(current_sprint, current_project, taskname, obj.ToString());
                    //MessageBox.Show(taskname);
                }

            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            frmAddTaskTemplate3 add = new frmAddTaskTemplate3();
            add.Show();
        }
        #endregion


        
    }
}
