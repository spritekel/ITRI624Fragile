﻿using System;
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
    public partial class frmKanbanTemplate9 : MetroSetForm
    {
        public frmKanbanTemplate9()
        {
            InitializeComponent();

            //Initially Load in progress of sprint from DB
            LoadProgressBar(DateTime.Now);

            lstNotStarted.AllowDrop = true;
            lstDesignAnalysis.AllowDrop = true;
            lstDevelopment.AllowDrop = true;
            lstCodeReview.AllowDrop = true;
            lstTestReady.AllowDrop = true;
            lstTesting.AllowDrop = true;
            lstSignOff.AllowDrop = true;
            lstDeployment.AllowDrop = true;
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

        private void btnNotStarted_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpNotStarted.Text);
            lstNotStarted.Items.Add(item);
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpDesignAnalysis.Text);
            lstDesignAnalysis.Items.Add(item);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpDone.Text);
            lstDone.Items.Add(item);
        }

        private void btnCodeReview_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpCodeReview.Text);
            lstCodeReview.Items.Add(item);
        }
    

        private void btnTesting_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpTesting.Text);
            lstTesting.Items.Add(item);
        }

        private void btnSignOff_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpSignOff.Text);
            lstSignOff.Items.Add(item);
        }

        private void btnDeployment_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpDeployment.Text);
            lstDeployment.Items.Add(item);
        }

        private void btnTestReady_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpTestReady.Text);
            lstTestReady.Items.Add(item);
        }

        private void btnDevelopment_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(inpDevelopment.Text);
            lstDevelopment.Items.Add(item);
        }




        //DRAG AND DROP:

        private void lstNotStarted_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstNotStarted.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstNotStarted.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstDesignAnalysis_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstDesignAnalysis.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstDesignAnalysis.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstDevelopment_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstNotStarted.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstDevelopment.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstCodeReview_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstDesignAnalysis.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstCodeReview.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstTestReady_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstNotStarted.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstTestReady.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstTesting_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstDesignAnalysis.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstTesting.DoDragDrop(items, DragDropEffects.Move);
        }
                
        private void lstSignOff_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstNotStarted.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstSignOff.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstDeployment_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstNotStarted.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lstDeployment.DoDragDrop(items, DragDropEffects.Move);
        }

        private void lstDone_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lstDesignAnalysis.SelectedItems)
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

        private void lstNotStarted_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstNotStarted.Items.Add(lvi);
                }
            }
        }

        private void lstDesignAnalysis_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstDesignAnalysis.Items.Add(lvi);
                }
            }
        }

        private void lstDevelopment_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstDevelopment.Items.Add(lvi);
                }
            }
        }


        private void lstCodeReview_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstCodeReview.Items.Add(lvi);
                }
            }
        }

        private void lstTestReady_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstTestReady.Items.Add(lvi);
                }
            }
        }

        private void lstTesting_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstTesting.Items.Add(lvi);
                }
            }
        }
    
        private void lstSignOff_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstSignOff.Items.Add(lvi);
                }
            }
        }

        private void lstDeployment_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lstDeployment.Items.Add(lvi);
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


        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            frmAddTask add = new frmAddTask();
            add.Show();
        }

        
    }
}
