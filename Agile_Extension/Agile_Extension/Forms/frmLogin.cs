﻿using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;
using Agile_Extension.Classes;

namespace Agile_Extension.Forms
{
    public partial class frmLogin : MetroSetForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(new clsRestAPIHandler().login_user(txtUsername.Text,txtPassword.Text))
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                frmDashboard dash = new frmDashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                lblEMessage.Text = "Invalid login credentials";
            }
              
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void metroSetLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
