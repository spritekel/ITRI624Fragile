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
    public partial class frmSignUp : MetroSetForm
    {
        #region FORM_METHODS
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(validate(txtUsrName.Text, txtPassWd.Text, txtCPassWd.Text))
            {
                string is_lead = isProjectLead();
                if (new clsRestAPIHandler().create_user(txtUsrName.Text, txtPassWd.Text, is_lead))
                {
                    lblEMessage.Text = "User: " + txtUsrName.Text + " Created Successfully (Role: " + is_lead + ").";
                    resetControls();
                }
                else
                {
                    lblEMessage.Text = "Error orrcured";
                }
            }
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }
        #endregion

        #region METHODS
        private bool validate(string username, string password, string confirm)
        {
            if (username.Length <= 0)
            {
                txtUsrName.Focus();
                lblEMessage.Text = "Provide username";
                return false;
            }

            if (password.Length <= 0)
            {
                txtPassWd.Focus();
                lblEMessage.Text = "Provide password";
                return false;
            }

            if (confirm.Length <= 0)
            {
                txtCPassWd.Focus();
                lblEMessage.Text = "Provide confirmation password";
                return false;
            }

            if (password != confirm)
            {
                txtPassWd.Text = "";
                txtCPassWd.Text = "";
                txtPassWd.Focus();
                lblEMessage.Text = "Passwords do not match";
                return false;
            }

            return true;
        }

        private string isProjectLead()
        {
            if (swProjectLead.Switched)
            {
                return "admin";
            }
            return "member";
        }
        #endregion

        #region METHODS
        private void resetControls()
        {
            txtUsrName.Text = "";
            txtPassWd.Text = "";
            txtCPassWd.Text = "";
            lblEMessage.Text = "";
            swProjectLead.Switched = false;
        }
        #endregion
    }
}
