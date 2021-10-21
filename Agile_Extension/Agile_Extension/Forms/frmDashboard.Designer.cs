
namespace Agile_Extension.Forms
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.styleManager1 = new MetroSet_UI.StyleManager();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetTabPage1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroSetListBox1 = new MetroSet_UI.Controls.MetroSetListBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.metroSetTile3 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetTile2 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetTabPage2 = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetEllipse1 = new MetroSet_UI.Controls.MetroSetEllipse();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.btnAddProj = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetTabControl1.SuspendLayout();
            this.metroSetTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\kelvi\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroLite";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.Controls.Add(this.metroSetTabPage1);
            this.metroSetTabControl1.Controls.Add(this.metroSetTabPage2);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(5, 146);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.Size = new System.Drawing.Size(1040, 556);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 20;
            this.metroSetTabControl1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabControl1.StyleManager = this.styleManager1;
            this.metroSetTabControl1.TabIndex = 0;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UseAnimation = true;
            // 
            // metroSetTabPage1
            // 
            this.metroSetTabPage1.AutoScroll = true;
            this.metroSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage1.Controls.Add(this.panel1);
            this.metroSetTabPage1.Controls.Add(this.circularProgressBar1);
            this.metroSetTabPage1.Controls.Add(this.metroSetTile3);
            this.metroSetTabPage1.Controls.Add(this.metroSetTile2);
            this.metroSetTabPage1.Controls.Add(this.metroSetTile1);
            this.metroSetTabPage1.ImageIndex = 0;
            this.metroSetTabPage1.ImageKey = null;
            this.metroSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage1.Name = "metroSetTabPage1";
            this.metroSetTabPage1.Size = new System.Drawing.Size(1032, 510);
            this.metroSetTabPage1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage1.StyleManager = this.styleManager1;
            this.metroSetTabPage1.TabIndex = 0;
            this.metroSetTabPage1.Text = "Project 1";
            this.metroSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetTabPage1.ThemeName = "MetroLite";
            this.metroSetTabPage1.ToolTipText = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroSetListBox1);
            this.panel1.Controls.Add(this.metroSetLabel1);
            this.panel1.Location = new System.Drawing.Point(760, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 273);
            this.panel1.TabIndex = 4;
            // 
            // metroSetListBox1
            // 
            this.metroSetListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.metroSetListBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetListBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetListBox1.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.metroSetListBox1.HoveredItemColor = System.Drawing.Color.DimGray;
            this.metroSetListBox1.ItemHeight = 30;
            this.metroSetListBox1.Items.Add("Setup GUI");
            this.metroSetListBox1.Items.Add("Voice chat integration");
            this.metroSetListBox1.Items.Add("Meeting with project manager");
            this.metroSetListBox1.Location = new System.Drawing.Point(8, 47);
            this.metroSetListBox1.MultiSelect = false;
            this.metroSetListBox1.Name = "metroSetListBox1";
            this.metroSetListBox1.SelectedIndex = -1;
            this.metroSetListBox1.SelectedItem = null;
            this.metroSetListBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetListBox1.SelectedItemColor = System.Drawing.Color.White;
            this.metroSetListBox1.SelectedValue = null;
            this.metroSetListBox1.ShowBorder = false;
            this.metroSetListBox1.ShowScrollBar = false;
            this.metroSetListBox1.Size = new System.Drawing.Size(234, 223);
            this.metroSetListBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetListBox1.StyleManager = this.styleManager1;
            this.metroSetListBox1.TabIndex = 1;
            this.metroSetListBox1.ThemeAuthor = "Narwin";
            this.metroSetListBox1.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline);
            this.metroSetLabel1.Location = new System.Drawing.Point(8, 9);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(240, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Agenda";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(13, 373);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 20;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.circularProgressBar1.ProgressWidth = 19;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.circularProgressBar1.Size = new System.Drawing.Size(126, 121);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "65";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 3;
            this.circularProgressBar1.Text = "Progress";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 65;
            // 
            // metroSetTile3
            // 
            this.metroSetTile3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile3.Location = new System.Drawing.Point(545, 35);
            this.metroSetTile3.Name = "metroSetTile3";
            this.metroSetTile3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile3.Size = new System.Drawing.Size(243, 99);
            this.metroSetTile3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTile3.StyleManager = this.styleManager1;
            this.metroSetTile3.TabIndex = 2;
            this.metroSetTile3.Text = "Sprint 1";
            this.metroSetTile3.ThemeAuthor = "Narwin";
            this.metroSetTile3.ThemeName = "MetroLite";
            this.metroSetTile3.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            // 
            // metroSetTile2
            // 
            this.metroSetTile2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile2.Location = new System.Drawing.Point(290, 35);
            this.metroSetTile2.Name = "metroSetTile2";
            this.metroSetTile2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile2.Size = new System.Drawing.Size(243, 99);
            this.metroSetTile2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTile2.StyleManager = this.styleManager1;
            this.metroSetTile2.TabIndex = 1;
            this.metroSetTile2.Text = "Sprint 1";
            this.metroSetTile2.ThemeAuthor = "Narwin";
            this.metroSetTile2.ThemeName = "MetroLite";
            this.metroSetTile2.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            // 
            // metroSetTile1
            // 
            this.metroSetTile1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Location = new System.Drawing.Point(29, 35);
            this.metroSetTile1.Name = "metroSetTile1";
            this.metroSetTile1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Size = new System.Drawing.Size(243, 99);
            this.metroSetTile1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTile1.StyleManager = this.styleManager1;
            this.metroSetTile1.TabIndex = 0;
            this.metroSetTile1.Text = "Sprint 1";
            this.metroSetTile1.ThemeAuthor = "Narwin";
            this.metroSetTile1.ThemeName = "MetroLite";
            this.metroSetTile1.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            // 
            // metroSetTabPage2
            // 
            this.metroSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage2.ImageIndex = 0;
            this.metroSetTabPage2.ImageKey = null;
            this.metroSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage2.Name = "metroSetTabPage2";
            this.metroSetTabPage2.Size = new System.Drawing.Size(1032, 510);
            this.metroSetTabPage2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage2.StyleManager = this.styleManager1;
            this.metroSetTabPage2.TabIndex = 1;
            this.metroSetTabPage2.Text = "Project 2";
            this.metroSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetTabPage2.ThemeName = "MetroLite";
            this.metroSetTabPage2.ToolTipText = null;
            // 
            // metroSetEllipse1
            // 
            this.metroSetEllipse1.BorderThickness = 7;
            this.metroSetEllipse1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetEllipse1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetEllipse1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetEllipse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.metroSetEllipse1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetEllipse1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetEllipse1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetEllipse1.Image = null;
            this.metroSetEllipse1.ImageSize = new System.Drawing.Size(64, 64);
            this.metroSetEllipse1.Location = new System.Drawing.Point(5, 708);
            this.metroSetEllipse1.Name = "metroSetEllipse1";
            this.metroSetEllipse1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetEllipse1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetEllipse1.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetEllipse1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetEllipse1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetEllipse1.PressTextColor = System.Drawing.Color.White;
            this.metroSetEllipse1.Size = new System.Drawing.Size(112, 110);
            this.metroSetEllipse1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetEllipse1.StyleManager = this.styleManager1;
            this.metroSetEllipse1.TabIndex = 1;
            this.metroSetEllipse1.Text = "Chat";
            this.metroSetEllipse1.ThemeAuthor = "Narwin";
            this.metroSetEllipse1.ThemeName = "MetroLite";
            this.metroSetEllipse1.Click += new System.EventHandler(this.metroSetEllipse1_Click);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(929, 17);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 2;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // btnAddProj
            // 
            this.btnAddProj.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddProj.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddProj.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddProj.Enabled = false;
            this.btnAddProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddProj.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddProj.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddProj.HoverTextColor = System.Drawing.Color.White;
            this.btnAddProj.Location = new System.Drawing.Point(5, 105);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddProj.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddProj.NormalTextColor = System.Drawing.Color.White;
            this.btnAddProj.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddProj.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddProj.PressTextColor = System.Drawing.Color.White;
            this.btnAddProj.Size = new System.Drawing.Size(112, 35);
            this.btnAddProj.Style = MetroSet_UI.Design.Style.Light;
            this.btnAddProj.StyleManager = this.styleManager1;
            this.btnAddProj.TabIndex = 3;
            this.btnAddProj.Text = "Add Project";
            this.btnAddProj.ThemeAuthor = "Narwin";
            this.btnAddProj.ThemeName = "MetroLite";
            this.btnAddProj.Click += new System.EventHandler(this.btnAddProj_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 823);
            this.Controls.Add(this.btnAddProj);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetEllipse1);
            this.Controls.Add(this.metroSetTabControl1);
            this.Name = "frmDashboard";
            this.StyleManager = this.styleManager1;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.metroSetTabControl1.ResumeLayout(false);
            this.metroSetTabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage1;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile3;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile2;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetListBox metroSetListBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetEllipse metroSetEllipse1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton btnAddProj;
    }
}