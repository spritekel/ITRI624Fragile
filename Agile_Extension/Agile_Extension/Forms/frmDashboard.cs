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
    public partial class frmDashboard : MetroSetForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void metroSetListBox1_SelectedIndexChanged(object sender)
        {

        }

        private void metroSetEllipse1_Click(object sender, EventArgs e)
        {
            frmChat chat = new frmChat();
            chat.Show();
        }
    }
}