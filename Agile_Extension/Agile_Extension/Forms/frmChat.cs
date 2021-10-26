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
using CefSharp;
using CefSharp.WinForms;

namespace Agile_Extension.Forms
{
    public partial class frmChat : MetroSetForm
    {
        #region INSTANCE_VARIABLES
        private readonly ChromiumWebBrowser browser;
        #endregion

        #region FORM_METHODS
        public frmChat()
        {
            InitializeComponent();
            if(Cef.IsInitialized)
            {
                browser = new ChromiumWebBrowser("https://discord.gg/NpeJbX3xm9");
                this.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;
            }

        }

        private void frmChat_Load(object sender, EventArgs e)
        {

        }
        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!Cef.IsInitialized)
            {
                Cef.Shutdown();
            }
            this.Dispose();
        }
        #endregion

    }
}
