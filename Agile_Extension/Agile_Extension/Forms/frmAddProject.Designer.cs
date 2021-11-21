
namespace Agile_Extension.Forms
{
    partial class frmAddProject
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tcProjects = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tpAddProj = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.lblSprintF = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblOutput = new MetroSet_UI.Controls.MetroSetLabel();
            this.listMembers = new MetroSet_UI.Controls.MetroSetListBox();
            this.lblFMembers = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblProjFName = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblProjFDetails = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.dEnd = new System.Windows.Forms.DateTimePicker();
            this.dStart = new System.Windows.Forms.DateTimePicker();
            this.lblspr1ed = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblspr1sd = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtSprintName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblSprintName = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnAddProj = new MetroSet_UI.Controls.MetroSetButton();
            this.lblProjDetails = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbMembers = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblMembers = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtProjName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblProjName = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbManageProj = new MetroSet_UI.Child.MetroSetTabPage();
            this.tpDeleteProj = new MetroSet_UI.Child.MetroSetTabPage();
            this.btnDelete = new MetroSet_UI.Controls.MetroSetButton();
            this.lblDelProjName = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbDeleteProj = new System.Windows.Forms.ComboBox();
            this.lblDelResult = new MetroSet_UI.Controls.MetroSetLabel();
            this.tcProjects.SuspendLayout();
            this.tpAddProj.SuspendLayout();
            this.metroSetPanel2.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            this.tpDeleteProj.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\henro\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager1.ThemeAuthor = null;
            this.styleManager1.ThemeName = null;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(531, 13);
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
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = null;
            this.metroSetControlBox1.ThemeName = null;
            // 
            // tcProjects
            // 
            this.tcProjects.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tcProjects.AnimateTime = 200;
            this.tcProjects.Controls.Add(this.tpAddProj);
            this.tcProjects.Controls.Add(this.tbManageProj);
            this.tcProjects.Controls.Add(this.tpDeleteProj);
            this.tcProjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcProjects.ItemSize = new System.Drawing.Size(100, 38);
            this.tcProjects.Location = new System.Drawing.Point(15, 88);
            this.tcProjects.Name = "tcProjects";
            this.tcProjects.SelectedIndex = 2;
            this.tcProjects.Size = new System.Drawing.Size(648, 425);
            this.tcProjects.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcProjects.Speed = 20;
            this.tcProjects.Style = MetroSet_UI.Design.Style.Light;
            this.tcProjects.StyleManager = this.styleManager1;
            this.tcProjects.TabIndex = 7;
            this.tcProjects.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.tcProjects.ThemeAuthor = null;
            this.tcProjects.ThemeName = null;
            this.tcProjects.UseAnimation = true;
            // 
            // tpAddProj
            // 
            this.tpAddProj.BaseColor = System.Drawing.Color.White;
            this.tpAddProj.Controls.Add(this.metroSetPanel2);
            this.tpAddProj.Controls.Add(this.metroSetPanel1);
            this.tpAddProj.ImageIndex = 0;
            this.tpAddProj.ImageKey = null;
            this.tpAddProj.Location = new System.Drawing.Point(4, 42);
            this.tpAddProj.Name = "tpAddProj";
            this.tpAddProj.Size = new System.Drawing.Size(640, 379);
            this.tpAddProj.Style = MetroSet_UI.Design.Style.Light;
            this.tpAddProj.StyleManager = null;
            this.tpAddProj.TabIndex = 0;
            this.tpAddProj.Text = "Add Projects";
            this.tpAddProj.ThemeAuthor = "Narwin";
            this.tpAddProj.ThemeName = "MetroLite";
            this.tpAddProj.ToolTipText = null;
            this.tpAddProj.Enter += new System.EventHandler(this.tpAddProj_Enter);
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.lblSprintF);
            this.metroSetPanel2.Controls.Add(this.lblOutput);
            this.metroSetPanel2.Controls.Add(this.listMembers);
            this.metroSetPanel2.Controls.Add(this.lblFMembers);
            this.metroSetPanel2.Controls.Add(this.lblProjFName);
            this.metroSetPanel2.Controls.Add(this.lblProjFDetails);
            this.metroSetPanel2.Location = new System.Drawing.Point(324, 13);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(305, 355);
            this.metroSetPanel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetPanel2.StyleManager = this.styleManager1;
            this.metroSetPanel2.TabIndex = 7;
            this.metroSetPanel2.ThemeAuthor = null;
            this.metroSetPanel2.ThemeName = null;
            // 
            // lblSprintF
            // 
            this.lblSprintF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSprintF.Location = new System.Drawing.Point(12, 59);
            this.lblSprintF.Name = "lblSprintF";
            this.lblSprintF.Size = new System.Drawing.Size(273, 23);
            this.lblSprintF.Style = MetroSet_UI.Design.Style.Light;
            this.lblSprintF.StyleManager = null;
            this.lblSprintF.TabIndex = 13;
            this.lblSprintF.ThemeAuthor = "Narwin";
            this.lblSprintF.ThemeName = "MetroLite";
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOutput.Location = new System.Drawing.Point(12, 317);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(273, 23);
            this.lblOutput.Style = MetroSet_UI.Design.Style.Light;
            this.lblOutput.StyleManager = null;
            this.lblOutput.TabIndex = 12;
            this.lblOutput.ThemeAuthor = "Narwin";
            this.lblOutput.ThemeName = "MetroLite";
            // 
            // listMembers
            // 
            this.listMembers.BorderColor = System.Drawing.Color.LightGray;
            this.listMembers.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.listMembers.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.listMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listMembers.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.listMembers.HoveredItemColor = System.Drawing.Color.DimGray;
            this.listMembers.ItemHeight = 30;
            this.listMembers.Location = new System.Drawing.Point(12, 119);
            this.listMembers.MultiSelect = false;
            this.listMembers.Name = "listMembers";
            this.listMembers.SelectedIndex = -1;
            this.listMembers.SelectedItem = null;
            this.listMembers.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.listMembers.SelectedItemColor = System.Drawing.Color.White;
            this.listMembers.SelectedValue = null;
            this.listMembers.ShowBorder = false;
            this.listMembers.ShowScrollBar = false;
            this.listMembers.Size = new System.Drawing.Size(273, 171);
            this.listMembers.Style = MetroSet_UI.Design.Style.Light;
            this.listMembers.StyleManager = null;
            this.listMembers.TabIndex = 11;
            this.listMembers.ThemeAuthor = "Narwin";
            this.listMembers.ThemeName = "MetroLite";
            this.listMembers.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.listMembers_SelectedIndexChanged);
            // 
            // lblFMembers
            // 
            this.lblFMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFMembers.Location = new System.Drawing.Point(12, 102);
            this.lblFMembers.Name = "lblFMembers";
            this.lblFMembers.Size = new System.Drawing.Size(235, 23);
            this.lblFMembers.Style = MetroSet_UI.Design.Style.Light;
            this.lblFMembers.StyleManager = null;
            this.lblFMembers.TabIndex = 10;
            this.lblFMembers.Text = "Members:";
            this.lblFMembers.ThemeAuthor = "Narwin";
            this.lblFMembers.ThemeName = "MetroLite";
            // 
            // lblProjFName
            // 
            this.lblProjFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjFName.Location = new System.Drawing.Point(12, 32);
            this.lblProjFName.Name = "lblProjFName";
            this.lblProjFName.Size = new System.Drawing.Size(273, 23);
            this.lblProjFName.Style = MetroSet_UI.Design.Style.Light;
            this.lblProjFName.StyleManager = null;
            this.lblProjFName.TabIndex = 9;
            this.lblProjFName.ThemeAuthor = "Narwin";
            this.lblProjFName.ThemeName = "MetroLite";
            // 
            // lblProjFDetails
            // 
            this.lblProjFDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjFDetails.Location = new System.Drawing.Point(12, 9);
            this.lblProjFDetails.Name = "lblProjFDetails";
            this.lblProjFDetails.Size = new System.Drawing.Size(235, 23);
            this.lblProjFDetails.Style = MetroSet_UI.Design.Style.Light;
            this.lblProjFDetails.StyleManager = null;
            this.lblProjFDetails.TabIndex = 7;
            this.lblProjFDetails.Text = "Project Summary:";
            this.lblProjFDetails.ThemeAuthor = "Narwin";
            this.lblProjFDetails.ThemeName = "MetroLite";
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.dEnd);
            this.metroSetPanel1.Controls.Add(this.dStart);
            this.metroSetPanel1.Controls.Add(this.lblspr1ed);
            this.metroSetPanel1.Controls.Add(this.lblspr1sd);
            this.metroSetPanel1.Controls.Add(this.txtSprintName);
            this.metroSetPanel1.Controls.Add(this.lblSprintName);
            this.metroSetPanel1.Controls.Add(this.btnAddProj);
            this.metroSetPanel1.Controls.Add(this.lblProjDetails);
            this.metroSetPanel1.Controls.Add(this.cmbMembers);
            this.metroSetPanel1.Controls.Add(this.lblMembers);
            this.metroSetPanel1.Controls.Add(this.txtProjName);
            this.metroSetPanel1.Controls.Add(this.lblProjName);
            this.metroSetPanel1.Location = new System.Drawing.Point(3, 13);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(315, 355);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetPanel1.StyleManager = this.styleManager1;
            this.metroSetPanel1.TabIndex = 3;
            this.metroSetPanel1.ThemeAuthor = null;
            this.metroSetPanel1.ThemeName = null;
            // 
            // dEnd
            // 
            this.dEnd.Location = new System.Drawing.Point(156, 152);
            this.dEnd.Name = "dEnd";
            this.dEnd.Size = new System.Drawing.Size(149, 32);
            this.dEnd.TabIndex = 11;
            // 
            // dStart
            // 
            this.dStart.Location = new System.Drawing.Point(156, 119);
            this.dStart.Name = "dStart";
            this.dStart.Size = new System.Drawing.Size(149, 32);
            this.dStart.TabIndex = 10;
            // 
            // lblspr1ed
            // 
            this.lblspr1ed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblspr1ed.Location = new System.Drawing.Point(9, 156);
            this.lblspr1ed.Name = "lblspr1ed";
            this.lblspr1ed.Size = new System.Drawing.Size(141, 23);
            this.lblspr1ed.Style = MetroSet_UI.Design.Style.Light;
            this.lblspr1ed.StyleManager = null;
            this.lblspr1ed.TabIndex = 9;
            this.lblspr1ed.Text = "Sprint 1 End Date:";
            this.lblspr1ed.ThemeAuthor = "Narwin";
            this.lblspr1ed.ThemeName = "MetroLite";
            // 
            // lblspr1sd
            // 
            this.lblspr1sd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblspr1sd.Location = new System.Drawing.Point(9, 119);
            this.lblspr1sd.Name = "lblspr1sd";
            this.lblspr1sd.Size = new System.Drawing.Size(141, 23);
            this.lblspr1sd.Style = MetroSet_UI.Design.Style.Light;
            this.lblspr1sd.StyleManager = null;
            this.lblspr1sd.TabIndex = 8;
            this.lblspr1sd.Text = "Sprint 1 Start Date:";
            this.lblspr1sd.ThemeAuthor = "Narwin";
            this.lblspr1sd.ThemeName = "MetroLite";
            // 
            // txtSprintName
            // 
            this.txtSprintName.AutoCompleteCustomSource = null;
            this.txtSprintName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSprintName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSprintName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSprintName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSprintName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSprintName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSprintName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSprintName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSprintName.Image = null;
            this.txtSprintName.Lines = null;
            this.txtSprintName.Location = new System.Drawing.Point(156, 78);
            this.txtSprintName.MaxLength = 32767;
            this.txtSprintName.Multiline = false;
            this.txtSprintName.Name = "txtSprintName";
            this.txtSprintName.ReadOnly = false;
            this.txtSprintName.Size = new System.Drawing.Size(149, 30);
            this.txtSprintName.Style = MetroSet_UI.Design.Style.Light;
            this.txtSprintName.StyleManager = null;
            this.txtSprintName.TabIndex = 3;
            this.txtSprintName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSprintName.ThemeAuthor = "Narwin";
            this.txtSprintName.ThemeName = "MetroLite";
            this.txtSprintName.UseSystemPasswordChar = false;
            this.txtSprintName.WatermarkText = "";
            this.txtSprintName.TextChanged += new MetroSet_UI.Controls.MetroSetTextBox.TextChangedEventHandler(this.txtSprintName_TextChanged);
            // 
            // lblSprintName
            // 
            this.lblSprintName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSprintName.Location = new System.Drawing.Point(9, 85);
            this.lblSprintName.Name = "lblSprintName";
            this.lblSprintName.Size = new System.Drawing.Size(141, 23);
            this.lblSprintName.Style = MetroSet_UI.Design.Style.Light;
            this.lblSprintName.StyleManager = null;
            this.lblSprintName.TabIndex = 2;
            this.lblSprintName.Text = "1st Sprint Name:";
            this.lblSprintName.ThemeAuthor = "Narwin";
            this.lblSprintName.ThemeName = "MetroLite";
            // 
            // btnAddProj
            // 
            this.btnAddProj.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddProj.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddProj.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddProj.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddProj.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddProj.HoverTextColor = System.Drawing.Color.White;
            this.btnAddProj.Location = new System.Drawing.Point(68, 287);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddProj.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddProj.NormalTextColor = System.Drawing.Color.White;
            this.btnAddProj.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddProj.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddProj.PressTextColor = System.Drawing.Color.White;
            this.btnAddProj.Size = new System.Drawing.Size(150, 53);
            this.btnAddProj.Style = MetroSet_UI.Design.Style.Light;
            this.btnAddProj.StyleManager = null;
            this.btnAddProj.TabIndex = 7;
            this.btnAddProj.Text = "Add Project";
            this.btnAddProj.ThemeAuthor = "Narwin";
            this.btnAddProj.ThemeName = "MetroLite";
            this.btnAddProj.Click += new System.EventHandler(this.btnAddProj_Click);
            // 
            // lblProjDetails
            // 
            this.lblProjDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjDetails.Location = new System.Drawing.Point(9, 9);
            this.lblProjDetails.Name = "lblProjDetails";
            this.lblProjDetails.Size = new System.Drawing.Size(241, 23);
            this.lblProjDetails.Style = MetroSet_UI.Design.Style.Light;
            this.lblProjDetails.StyleManager = null;
            this.lblProjDetails.TabIndex = 6;
            this.lblProjDetails.Text = "New Project Details:";
            this.lblProjDetails.ThemeAuthor = "Narwin";
            this.lblProjDetails.ThemeName = "MetroLite";
            // 
            // cmbMembers
            // 
            this.cmbMembers.AllowDrop = true;
            this.cmbMembers.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbMembers.BackColor = System.Drawing.Color.Transparent;
            this.cmbMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbMembers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbMembers.CausesValidation = false;
            this.cmbMembers.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbMembers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbMembers.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbMembers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.ItemHeight = 20;
            this.cmbMembers.Location = new System.Drawing.Point(156, 208);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbMembers.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbMembers.Size = new System.Drawing.Size(149, 26);
            this.cmbMembers.Style = MetroSet_UI.Design.Style.Light;
            this.cmbMembers.StyleManager = null;
            this.cmbMembers.TabIndex = 5;
            this.cmbMembers.ThemeAuthor = "Narwin";
            this.cmbMembers.ThemeName = "MetroLite";
            this.cmbMembers.SelectedIndexChanged += new System.EventHandler(this.cmbMembers_SelectedIndexChanged);
            // 
            // lblMembers
            // 
            this.lblMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMembers.Location = new System.Drawing.Point(9, 211);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(155, 23);
            this.lblMembers.Style = MetroSet_UI.Design.Style.Light;
            this.lblMembers.StyleManager = null;
            this.lblMembers.TabIndex = 4;
            this.lblMembers.Text = "Project Members:";
            this.lblMembers.ThemeAuthor = "Narwin";
            this.lblMembers.ThemeName = "MetroLite";
            // 
            // txtProjName
            // 
            this.txtProjName.AutoCompleteCustomSource = null;
            this.txtProjName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProjName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProjName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtProjName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProjName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtProjName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtProjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProjName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtProjName.Image = null;
            this.txtProjName.Lines = null;
            this.txtProjName.Location = new System.Drawing.Point(156, 39);
            this.txtProjName.MaxLength = 32767;
            this.txtProjName.Multiline = false;
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.ReadOnly = false;
            this.txtProjName.Size = new System.Drawing.Size(149, 30);
            this.txtProjName.Style = MetroSet_UI.Design.Style.Light;
            this.txtProjName.StyleManager = null;
            this.txtProjName.TabIndex = 1;
            this.txtProjName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProjName.ThemeAuthor = "Narwin";
            this.txtProjName.ThemeName = "MetroLite";
            this.txtProjName.UseSystemPasswordChar = false;
            this.txtProjName.WatermarkText = "";
            this.txtProjName.TextChanged += new MetroSet_UI.Controls.MetroSetTextBox.TextChangedEventHandler(this.txtProjName_TextChanged);
            // 
            // lblProjName
            // 
            this.lblProjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjName.Location = new System.Drawing.Point(9, 46);
            this.lblProjName.Name = "lblProjName";
            this.lblProjName.Size = new System.Drawing.Size(155, 23);
            this.lblProjName.Style = MetroSet_UI.Design.Style.Light;
            this.lblProjName.StyleManager = null;
            this.lblProjName.TabIndex = 0;
            this.lblProjName.Text = "Project Name:";
            this.lblProjName.ThemeAuthor = "Narwin";
            this.lblProjName.ThemeName = "MetroLite";
            // 
            // tbManageProj
            // 
            this.tbManageProj.BaseColor = System.Drawing.Color.White;
            this.tbManageProj.ImageIndex = 0;
            this.tbManageProj.ImageKey = null;
            this.tbManageProj.Location = new System.Drawing.Point(4, 42);
            this.tbManageProj.Name = "tbManageProj";
            this.tbManageProj.Size = new System.Drawing.Size(640, 379);
            this.tbManageProj.Style = MetroSet_UI.Design.Style.Light;
            this.tbManageProj.StyleManager = null;
            this.tbManageProj.TabIndex = 1;
            this.tbManageProj.Text = "Manage Projects";
            this.tbManageProj.ThemeAuthor = "Narwin";
            this.tbManageProj.ThemeName = "MetroLite";
            this.tbManageProj.ToolTipText = null;
            // 
            // tpDeleteProj
            // 
            this.tpDeleteProj.BaseColor = System.Drawing.Color.White;
            this.tpDeleteProj.Controls.Add(this.lblDelResult);
            this.tpDeleteProj.Controls.Add(this.cmbDeleteProj);
            this.tpDeleteProj.Controls.Add(this.lblDelProjName);
            this.tpDeleteProj.Controls.Add(this.btnDelete);
            this.tpDeleteProj.ImageIndex = 0;
            this.tpDeleteProj.ImageKey = null;
            this.tpDeleteProj.Location = new System.Drawing.Point(4, 42);
            this.tpDeleteProj.Name = "tpDeleteProj";
            this.tpDeleteProj.Size = new System.Drawing.Size(640, 379);
            this.tpDeleteProj.Style = MetroSet_UI.Design.Style.Light;
            this.tpDeleteProj.StyleManager = null;
            this.tpDeleteProj.TabIndex = 2;
            this.tpDeleteProj.Text = "Delete Projects";
            this.tpDeleteProj.ThemeAuthor = "Narwin";
            this.tpDeleteProj.ThemeName = "MetroLite";
            this.tpDeleteProj.ToolTipText = null;
            this.tpDeleteProj.Enter += new System.EventHandler(this.tpDeleteProj_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDelete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDelete.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(3, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.NormalTextColor = System.Drawing.Color.White;
            this.btnDelete.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDelete.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDelete.PressTextColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(136, 45);
            this.btnDelete.Style = MetroSet_UI.Design.Style.Light;
            this.btnDelete.StyleManager = null;
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Project";
            this.btnDelete.ThemeAuthor = "Narwin";
            this.btnDelete.ThemeName = "MetroLite";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDelProjName
            // 
            this.lblDelProjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDelProjName.Location = new System.Drawing.Point(3, 24);
            this.lblDelProjName.Name = "lblDelProjName";
            this.lblDelProjName.Size = new System.Drawing.Size(136, 23);
            this.lblDelProjName.Style = MetroSet_UI.Design.Style.Light;
            this.lblDelProjName.StyleManager = null;
            this.lblDelProjName.TabIndex = 1;
            this.lblDelProjName.Text = "Select Project:";
            this.lblDelProjName.ThemeAuthor = "Narwin";
            this.lblDelProjName.ThemeName = "MetroLite";
            // 
            // cmbDeleteProj
            // 
            this.cmbDeleteProj.FormattingEnabled = true;
            this.cmbDeleteProj.Location = new System.Drawing.Point(145, 13);
            this.cmbDeleteProj.Name = "cmbDeleteProj";
            this.cmbDeleteProj.Size = new System.Drawing.Size(214, 34);
            this.cmbDeleteProj.TabIndex = 2;
            // 
            // lblDelResult
            // 
            this.lblDelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDelResult.Location = new System.Drawing.Point(156, 79);
            this.lblDelResult.Name = "lblDelResult";
            this.lblDelResult.Size = new System.Drawing.Size(337, 23);
            this.lblDelResult.Style = MetroSet_UI.Design.Style.Light;
            this.lblDelResult.StyleManager = null;
            this.lblDelResult.TabIndex = 3;
            this.lblDelResult.ThemeAuthor = "Narwin";
            this.lblDelResult.ThemeName = "MetroLite";
            // 
            // frmAddProject
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(662, 512);
            this.Controls.Add(this.tcProjects);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "frmAddProject";
            this.StyleManager = this.styleManager1;
            this.Text = "Manage Projects";
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProject_FormClosing);
            this.Load += new System.EventHandler(this.frmAddProject_Load);
            this.tcProjects.ResumeLayout(false);
            this.tpAddProj.ResumeLayout(false);
            this.metroSetPanel2.ResumeLayout(false);
            this.metroSetPanel1.ResumeLayout(false);
            this.tpDeleteProj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl tcProjects;
        private MetroSet_UI.Child.MetroSetTabPage tpAddProj;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private MetroSet_UI.Controls.MetroSetLabel lblSprintF;
        private MetroSet_UI.Controls.MetroSetLabel lblOutput;
        private MetroSet_UI.Controls.MetroSetListBox listMembers;
        private MetroSet_UI.Controls.MetroSetLabel lblFMembers;
        private MetroSet_UI.Controls.MetroSetLabel lblProjFName;
        private MetroSet_UI.Controls.MetroSetLabel lblProjFDetails;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private System.Windows.Forms.DateTimePicker dEnd;
        private System.Windows.Forms.DateTimePicker dStart;
        private MetroSet_UI.Controls.MetroSetLabel lblspr1ed;
        private MetroSet_UI.Controls.MetroSetLabel lblspr1sd;
        private MetroSet_UI.Controls.MetroSetTextBox txtSprintName;
        private MetroSet_UI.Controls.MetroSetLabel lblSprintName;
        private MetroSet_UI.Controls.MetroSetButton btnAddProj;
        private MetroSet_UI.Controls.MetroSetLabel lblProjDetails;
        private MetroSet_UI.Controls.MetroSetComboBox cmbMembers;
        private MetroSet_UI.Controls.MetroSetLabel lblMembers;
        private MetroSet_UI.Controls.MetroSetTextBox txtProjName;
        private MetroSet_UI.Controls.MetroSetLabel lblProjName;
        private MetroSet_UI.Child.MetroSetTabPage tbManageProj;
        private MetroSet_UI.Child.MetroSetTabPage tpDeleteProj;
        private System.Windows.Forms.ComboBox cmbDeleteProj;
        private MetroSet_UI.Controls.MetroSetLabel lblDelProjName;
        private MetroSet_UI.Controls.MetroSetButton btnDelete;
        private MetroSet_UI.Controls.MetroSetLabel lblDelResult;
    }
}