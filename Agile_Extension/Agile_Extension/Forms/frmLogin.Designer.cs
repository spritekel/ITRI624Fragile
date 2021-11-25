
namespace Agile_Extension.Forms
{
    partial class frmLogin
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
            this.txtUsername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnLogin = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLink1 = new MetroSet_UI.Controls.MetroSetLink();
            this.lblEMessage = new MetroSet_UI.Controls.MetroSetLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(187, 8);
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
            this.styleManager1.CustomTheme = "C:\\Users\\henro\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager1.ThemeAuthor = null;
            this.styleManager1.ThemeName = null;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteCustomSource = null;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsername.Image = null;
            this.txtUsername.Lines = null;
            this.txtUsername.Location = new System.Drawing.Point(15, 259);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(262, 25);
            this.txtUsername.Style = MetroSet_UI.Design.Style.Light;
            this.txtUsername.StyleManager = this.styleManager1;
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.ThemeAuthor = null;
            this.txtUsername.ThemeName = null;
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(91, 232);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(118, 24);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Username:";
            this.metroSetLabel1.ThemeAuthor = null;
            this.metroSetLabel1.ThemeName = null;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.Location = new System.Drawing.Point(91, 289);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(118, 24);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = this.styleManager1;
            this.metroSetLabel2.TabIndex = 0;
            this.metroSetLabel2.Text = "Password:";
            this.metroSetLabel2.ThemeAuthor = null;
            this.metroSetLabel2.ThemeName = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteCustomSource = null;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPassword.Image = null;
            this.txtPassword.Lines = null;
            this.txtPassword.Location = new System.Drawing.Point(15, 316);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(262, 25);
            this.txtPassword.Style = MetroSet_UI.Design.Style.Light;
            this.txtPassword.StyleManager = this.styleManager1;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.ThemeAuthor = null;
            this.txtPassword.ThemeName = null;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WatermarkText = "";
            // 
            // btnLogin
            // 
            this.btnLogin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogin.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLogin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(105, 357);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.NormalTextColor = System.Drawing.Color.White;
            this.btnLogin.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLogin.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLogin.PressTextColor = System.Drawing.Color.White;
            this.btnLogin.Size = new System.Drawing.Size(80, 37);
            this.btnLogin.Style = MetroSet_UI.Design.Style.Light;
            this.btnLogin.StyleManager = this.styleManager1;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.ThemeAuthor = null;
            this.btnLogin.ThemeName = null;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroSetLink1
            // 
            this.metroSetLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetLink1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLink1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.metroSetLink1.Location = new System.Drawing.Point(13, 450);
            this.metroSetLink1.Name = "metroSetLink1";
            this.metroSetLink1.Size = new System.Drawing.Size(264, 23);
            this.metroSetLink1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLink1.StyleManager = this.styleManager1;
            this.metroSetLink1.TabIndex = 4;
            this.metroSetLink1.TabStop = true;
            this.metroSetLink1.Text = "Not signed up yet? Click here to sign up";
            this.metroSetLink1.ThemeAuthor = null;
            this.metroSetLink1.ThemeName = null;
            this.metroSetLink1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.metroSetLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metroSetLink1_LinkClicked);
            // 
            // lblEMessage
            // 
            this.lblEMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEMessage.Location = new System.Drawing.Point(15, 408);
            this.lblEMessage.Name = "lblEMessage";
            this.lblEMessage.Size = new System.Drawing.Size(100, 23);
            this.lblEMessage.Style = MetroSet_UI.Design.Style.Light;
            this.lblEMessage.StyleManager = this.styleManager1;
            this.lblEMessage.TabIndex = 0;
            this.lblEMessage.ThemeAuthor = null;
            this.lblEMessage.ThemeName = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Agile_Extension.Properties.Resources.logoFragile;
            this.pictureBox1.Location = new System.Drawing.Point(57, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(292, 484);
            this.Controls.Add(this.lblEMessage);
            this.Controls.Add(this.metroSetLink1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StyleManager = this.styleManager1;
            this.Text = "LOGIN";
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTextBox txtUsername;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox txtPassword;
        private MetroSet_UI.Controls.MetroSetButton btnLogin;
        private MetroSet_UI.Controls.MetroSetLink metroSetLink1;
        private MetroSet_UI.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetLabel lblEMessage;
    }
}