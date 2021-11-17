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

namespace Agile_Extension.Forms
{
    public partial class frmKanban : MetroSetForm
    {
        public int count;
        public frmKanban()
        {
            InitializeComponent();
            metroSetPanel1.AutoScroll = true;
            count = 2;

            _Temp = this;
            //Initially Load in progress of sprint from DB
            LoadProgressBar(DateTime.Now);
            

            lstTodo.AllowDrop = true;
            lstDone.AllowDrop = true;
        }
        public static frmKanban _Temp;
        public void genTemp3()
        {
            createNewListTemplate("lstDoing","Doing");
        }
        public void genTemp5()
        {
            createNewListTemplate("lstDoing", "Doing");
            createNewListTemplate("lstCodeReview", "Code Review");
            createNewListTemplate("lstTest", "Testing");
        }
        public void genTemp5Hons()
        {
            createNewListTemplate("lstResearch", "Research");
            createNewListTemplate("lstDevelop", "Develop");
            createNewListTemplate("lstTest", "Testing");
        }
        public void genTemp9()
        {
            createNewListTemplate("lstDesign", "Design/Analysis");
            createNewListTemplate("lstDevelop", "In Development");
            createNewListTemplate("lstCodeReview", "Code Review");
            createNewListTemplate("lstTestReady", "Ready to Test");
            createNewListTemplate("lstTest", "Testing");
            createNewListTemplate("lstSignOff", "Sign Off");
            createNewListTemplate("lstDeployment", "Deployment");
        }
        private void createNewListTemplate(string ListNameID, string ListName)
        {
            //initialisation of needed vars
            ListView list = new ListView();
            System.Windows.Forms.ColumnHeader colHead = new System.Windows.Forms.ColumnHeader();
            metroSetPanel1.AutoScrollPosition = new Point(metroSetPanel1.AutoScrollPosition.X, 0);
            //Resets scroll position so that formulas below work as intended
            metroSetPanel1.VerticalScroll.Value = 0;

            //Adds list before done
            this.lstDone.Location = new System.Drawing.Point(count * 250, 0);
            list.Location = new System.Drawing.Point((count - 1) * 250, 0);

            //List set up/formatting
            list.Name = ListNameID;
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
            colHead.Text = ListName;
            metroSetPanel1.Controls.Add(list);
            //used in formulae for placements
            count += 1;
        }
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
            list.Name = "DynaList"+ Convert.ToString(count);
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
            //place holder dates, will read from db
            string startdate = "2021/09/01 12:00:00";
            string enddate = "2021/11/30 12:00:00";

            //creating date objects
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

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            genTemp3();
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            genTemp5(); 
        }

        private void metroSetButton4_Click(object sender, EventArgs e)
        {
            genTemp5Hons();
        }

        private void metroSetButton5_Click(object sender, EventArgs e)
        {
            genTemp9();
        }
    }
}
