
namespace Agile_Extension.Forms
{
    partial class frmAddTaskTemplate3
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.styleManager1 = new MetroSet_UI.StyleManager();
            this.tbTaskName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lbTaskName = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnAddTask = new MetroSet_UI.Controls.MetroSetButton();
            this.lblOutput = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblMembers = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbMembers = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblMembersDets = new MetroSet_UI.Controls.MetroSetLabel();
            this.listMembers = new MetroSet_UI.Controls.MetroSetListBox();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(485, 10);
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
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\RKW-PostGrad\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager1.ThemeAuthor = null;
            this.styleManager1.ThemeName = null;
            // 
            // tbTaskName
            // 
            this.tbTaskName.AutoCompleteCustomSource = null;
            this.tbTaskName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbTaskName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbTaskName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbTaskName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbTaskName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbTaskName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTaskName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbTaskName.Image = null;
            this.tbTaskName.Lines = null;
            this.tbTaskName.Location = new System.Drawing.Point(138, 107);
            this.tbTaskName.MaxLength = 32767;
            this.tbTaskName.Multiline = false;
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.ReadOnly = false;
            this.tbTaskName.Size = new System.Drawing.Size(147, 30);
            this.tbTaskName.Style = MetroSet_UI.Design.Style.Light;
            this.tbTaskName.StyleManager = this.styleManager1;
            this.tbTaskName.TabIndex = 1;
            this.tbTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTaskName.ThemeAuthor = null;
            this.tbTaskName.ThemeName = null;
            this.tbTaskName.UseSystemPasswordChar = false;
            this.tbTaskName.WatermarkText = "";
            // 
            // lbTaskName
            // 
            this.lbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTaskName.Location = new System.Drawing.Point(32, 107);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(100, 30);
            this.lbTaskName.Style = MetroSet_UI.Design.Style.Light;
            this.lbTaskName.StyleManager = this.styleManager1;
            this.lbTaskName.TabIndex = 0;
            this.lbTaskName.Text = "Task Name";
            this.lbTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTaskName.ThemeAuthor = null;
            this.lbTaskName.ThemeName = null;
            // 
            // btnAddTask
            // 
            this.btnAddTask.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddTask.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddTask.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddTask.HoverTextColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(32, 228);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.NormalTextColor = System.Drawing.Color.White;
            this.btnAddTask.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddTask.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddTask.PressTextColor = System.Drawing.Color.White;
            this.btnAddTask.Size = new System.Drawing.Size(100, 38);
            this.btnAddTask.Style = MetroSet_UI.Design.Style.Light;
            this.btnAddTask.StyleManager = this.styleManager1;
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.ThemeAuthor = null;
            this.btnAddTask.ThemeName = null;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(139, 228);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(146, 38);
            this.lblOutput.Style = MetroSet_UI.Design.Style.Light;
            this.lblOutput.StyleManager = this.styleManager1;
            this.lblOutput.TabIndex = 0;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.ThemeAuthor = null;
            this.lblOutput.ThemeName = null;
            // 
            // lblMembers
            // 
            this.lblMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMembers.Location = new System.Drawing.Point(32, 154);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(100, 30);
            this.lblMembers.Style = MetroSet_UI.Design.Style.Light;
            this.lblMembers.StyleManager = this.styleManager1;
            this.lblMembers.TabIndex = 0;
            this.lblMembers.Text = "Members";
            this.lblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMembers.ThemeAuthor = null;
            this.lblMembers.ThemeName = null;
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
            this.cmbMembers.Location = new System.Drawing.Point(138, 157);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbMembers.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbMembers.Size = new System.Drawing.Size(147, 26);
            this.cmbMembers.Style = MetroSet_UI.Design.Style.Light;
            this.cmbMembers.StyleManager = this.styleManager1;
            this.cmbMembers.TabIndex = 2;
            this.cmbMembers.ThemeAuthor = null;
            this.cmbMembers.ThemeName = null;
            this.cmbMembers.SelectedIndexChanged += new System.EventHandler(this.cmbMembers_SelectedIndexChanged);
            // 
            // lblMembersDets
            // 
            this.lblMembersDets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMembersDets.Location = new System.Drawing.Point(314, 52);
            this.lblMembersDets.Name = "lblMembersDets";
            this.lblMembersDets.Size = new System.Drawing.Size(100, 23);
            this.lblMembersDets.Style = MetroSet_UI.Design.Style.Light;
            this.lblMembersDets.StyleManager = this.styleManager1;
            this.lblMembersDets.TabIndex = 0;
            this.lblMembersDets.Text = "Members:";
            this.lblMembersDets.ThemeAuthor = null;
            this.lblMembersDets.ThemeName = null;
            // 
            // listMembers
            // 
            this.listMembers.BorderColor = System.Drawing.Color.LightGray;
            this.listMembers.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.listMembers.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.listMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listMembers.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.listMembers.HoveredItemColor = System.Drawing.Color.DimGray;
            this.listMembers.ItemHeight = 30;
            this.listMembers.Location = new System.Drawing.Point(314, 78);
            this.listMembers.MultiSelect = false;
            this.listMembers.Name = "listMembers";
            this.listMembers.SelectedIndex = -1;
            this.listMembers.SelectedItem = null;
            this.listMembers.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.listMembers.SelectedItemColor = System.Drawing.Color.White;
            this.listMembers.SelectedValue = null;
            this.listMembers.ShowBorder = false;
            this.listMembers.ShowScrollBar = true;
            this.listMembers.Size = new System.Drawing.Size(250, 190);
            this.listMembers.Style = MetroSet_UI.Design.Style.Light;
            this.listMembers.StyleManager = this.styleManager1;
            this.listMembers.TabIndex = 3;
            this.listMembers.ThemeAuthor = null;
            this.listMembers.ThemeName = null;
            this.listMembers.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.listMembers_SelectedIndexChanged);
            // 
            // frmAddTaskTemplate3
            // 
            this.AllowResize = false;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.listMembers);
            this.Controls.Add(this.lblMembersDets);
            this.Controls.Add(this.cmbMembers);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lbTaskName);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "frmAddTaskTemplate3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StyleManager = this.styleManager1;
            this.Text = "Add Task";
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.ResumeLayout(false);

        }
        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTextBox tbTaskName;
        private MetroSet_UI.Controls.MetroSetLabel lbTaskName;
        private MetroSet_UI.Controls.MetroSetButton btnAddTask;
        private MetroSet_UI.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetLabel lblOutput;
        private MetroSet_UI.Controls.MetroSetLabel lblMembers;
        private MetroSet_UI.Controls.MetroSetComboBox cmbMembers;
        private MetroSet_UI.Controls.MetroSetLabel lblMembersDets;
        private MetroSet_UI.Controls.MetroSetListBox listMembers;
    }
}