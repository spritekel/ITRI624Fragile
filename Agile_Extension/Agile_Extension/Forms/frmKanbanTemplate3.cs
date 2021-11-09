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

namespace Agile_Extension.Forms
{
    public partial class frmKanbanTemplate3 : MetroSetForm
    {
        public frmKanbanTemplate3()
        {
            InitializeComponent();

            //Initially Load in progress of sprint from DB
            LoadProgressBar(DateTime.Now);

            lstTodo.AllowDrop = true;
            lstDoing.AllowDrop = true;
            lstDone.AllowDrop = true;
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

        private void frmKanban_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            ListViewItem listTodo = new ListViewItem(inpTodo.Text);
            lstTodo.Items.Add(listTodo);
        }

        private void btnDoing_Click(object sender, EventArgs e)
        {
            ListViewItem listDoing = new ListViewItem(inpDoing.Text);
            lstDoing.Items.Add(listDoing);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            ListViewItem listDone = new ListViewItem(inpDone.Text);
            lstDone.Items.Add(listDone);
        }



//DRAG AND DROP:
        private void lstTodo_ItemDrag_Doing(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstTodo.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstTodo.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstTodo_ItemDrag_Done(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstTodo.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstTodo.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstDoing_ItemDrag_Todo(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstDoing.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstDoing.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstDoing_ItemDrag_Done(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstDoing.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstDoing.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstDone_ItemDrag_Todo(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstDoing.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstDone.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstDone_ItemDrag_Doing(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstDoing.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstDone.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lst_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lstDoing_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstDoing.Items.Add(lvi);
                }
            }
        }

        private void lstTodo_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstTodo.Items.Add(lvi);
                }
            }
        }

        private void lstDone_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstDone.Items.Add(lvi);
                }
            }
        }

        private void TodoRename_Click(object sender, EventArgs e)
        {
            this.taskToDo.Text = "aaaaaaaaaaaaa";
        }

        private void DoingRename_Click(object sender, EventArgs e)
        {
            //frmTodoRename renameDoing = new frmTodoRename();
            //renameDoing.Show();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            frmAddTask add = new frmAddTask();
            add.Show();
        }
    }
}
