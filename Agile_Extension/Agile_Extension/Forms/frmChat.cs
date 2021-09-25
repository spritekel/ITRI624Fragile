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
        private ChromiumWebBrowser chromeBrowser;

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            //settings.CachePath = @"C:\Users\kelvi\Documents\1. honours\ITRI 624\Development\ITRI624Project\Agile_Extension\Agile_Extension\chromeCache\";
            // Initialize cef with the provided settings
            //Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://web.telegram.org");
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

        }
        public frmChat()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void frmChat_Load(object sender, EventArgs e)
        {

        }

        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
