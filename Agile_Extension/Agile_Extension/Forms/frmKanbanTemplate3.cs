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


        private void createNewList()
        {
            //initialisation of needed vars
            ListView list = new ListView();
            Random rnd = new Random();
            System.Windows.Forms.ColumnHeader colHead = new System.Windows.Forms.ColumnHeader();
            metroSetPanel1.AutoScrollPosition = new Point(metroSetPanel1.AutoScrollPosition.X, 0);
            //Resets scroll position so that formulas below work as intended
            metroSetPanel1.VerticalScroll.Value = 0;

            //Adds list before done
            this.lstDone.Location = new System.Drawing.Point(count * 250, 0);
            list.Location = new System.Drawing.Point((count - 1) * 250, 0);

            //List set up/formatting
            list.Name = "DynaList"+rnd.Next();
            colHead.Width = 250;
            list.Size = new System.Drawing.Size(250, 400);
            list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colHead });
            list.GridLines = true;
            list.HideSelection = false;
            list.UseCompatibleStateImageBehavior = false;
            list.View = System.Windows.Forms.View.Details;
            list.ItemDrag += lst_ItemDrag;
            list.DragDrop += lst_DragDrop;
            list.DragOver += lst_DragOver;
            list.ColumnClick += lstRename_ColumnClick;
            list.AllowDrop = true;
            colHead.Text = Rename(colHead.Text);
            metroSetPanel1.Controls.Add(list);
            //used in formulae for placements
            count += 1;
        }


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
            metroSetProgressBar1.Value = ((int)progPercent);
        }

        public void AddItem(string value)
        {
            lstTodo.Items.Add(value);
        }


        #region Rename
        public string Rename(string listName)
        {
            string newName = Interaction.InputBox("New Name", "Rename" + listName + "List", listName, (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            if (!string.IsNullOrWhiteSpace(newName))
            {
                return newName;
            }
            else
            {
                MessageBox.Show("Invalid Name");
                return listName;
            }

        }

        
        private void lstRename_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            System.Windows.Forms.ListView lists = (System.Windows.Forms.ListView)sender;
            lists.Columns[0].Text = Rename(lists.Columns[0].Text);
        }


        #endregion


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
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            frmAddTaskTemplate3 add = new frmAddTaskTemplate3();
            add.Show();
        }
        #endregion

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            createNewList();
        }

        private void frmKanbanTemplate3_Load(object sender, EventArgs e)
        {
            //populate data
            //string sprintinfo = new clsFileHandler().readFromFile(new clsFileHandler().get_sprint_info());
            //MessageBox.Show(sprintinfo);
        }

        private void frmKanbanTemplate3_Shown(object sender, EventArgs e)
        {
            LoadProgressBar(DateTime.Now);
            string projectname = new clsFileHandler().readFromFile(new clsFileHandler().get_current_project());
            string sprintname = new clsFileHandler().readFromFile(new clsFileHandler().get_current_sprint());
            MessageBox.Show(projectname, sprintname);

            JObject sprint_info = new clsRestAPIHandler().get_single_sprint(sprintname, projectname);
            string tasks = sprint_info["sprint"][0]["tasks"].ToString();
            JArray tasks_array = JArray.Parse(tasks);
            int length = tasks_array.Count;

            for (int i = 0; i < length; i++)
            {
                string listnumber = sprint_info["sprint"][0]["tasks"][i]["listNumber"].ToString();
                string taskname = sprint_info["sprint"][0]["tasks"][i]["taskName"].ToString();

                if (listnumber == "1")
                {
                    lstTodo.Items.Add(taskname);
                }
                else if (listnumber == "2")
                {
                    lstDoing.Items.Add(taskname);
                }
                else
                {
                    lstDone.Items.Add(taskname);
                }
            }
            
        }
    }
}
