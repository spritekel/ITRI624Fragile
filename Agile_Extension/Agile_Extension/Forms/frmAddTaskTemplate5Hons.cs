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
using Agile_Extension.Classes;
using Newtonsoft.Json.Linq;

namespace Agile_Extension.Forms
{
    public partial class frmAddTaskTemplate5Hons : MetroSetForm
    {
        public frmAddTaskTemplate5Hons()
        {
            InitializeComponent();
            populateComboBox();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (validate(tbTaskName.Text, listMembers))
            {
                frmKanbanTemplate5Hons._Temp5Hons.AddItem(tbTaskName.Text);
            }

            ResetControls();
        }

        private void cmbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbMembers.SelectedIndex;

            listMembers.Items.Add(cmbMembers.Text);
            cmbMembers.Items.RemoveAt(index);
        }

        private void listMembers_SelectedIndexChanged(object sender)
        {
            int index = listMembers.SelectedIndex;
            cmbMembers.Items.Add(listMembers.Items[index]);
            listMembers.Items.RemoveAt(index);
        }
        private void populateComboBox()
        {
            JObject obj = new clsRestAPIHandler().get_all_users();
            int user_count = int.Parse(obj.GetValue("count").ToString());
            string current_user = new clsFileHandler().readFromFile(new clsFileHandler().get_user_file());

            for (int i = 0; i < user_count; i++)
            {
                string users = obj["users"][i]["username"].ToString();
                cmbMembers.Items.Add(users);
            }
            cmbMembers.Items.Remove(current_user);
        }
        private void ResetControls()
        {
            tbTaskName.Text = "";
            lblMembersDets.Text = "";
            cmbMembers.Items.Clear();
            listMembers.Items.Clear();
            populateComboBox();
        }

        private bool validate(string task_name, MetroSet_UI.Controls.MetroSetListBox list)
        {
            if (task_name.Length <= 0 || task_name.Contains(" "))
            {
                lblOutput.Text = "Please enter a valid task name eg: task_name";
                tbTaskName.Focus();
                return false;
            }

            if (list.Items.Count <= 0)
            {
                lblOutput.Text = "No members added to task";
                list.Focus();
                return false;
            }

            lblOutput.Text = "";
            return true;
        }
    }
}
