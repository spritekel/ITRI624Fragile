
namespace Agile_Extension.Forms
{
    partial class addSprintForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tbSprintName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnCreateSprint = new MetroSet_UI.Controls.MetroSetButton();
            this.lblOutput = new MetroSet_UI.Controls.MetroSetLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblOut = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sprint Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date:";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(397, 4);
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
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // tbSprintName
            // 
            this.tbSprintName.AutoCompleteCustomSource = null;
            this.tbSprintName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSprintName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSprintName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbSprintName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSprintName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbSprintName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbSprintName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSprintName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbSprintName.Image = null;
            this.tbSprintName.Lines = null;
            this.tbSprintName.Location = new System.Drawing.Point(196, 89);
            this.tbSprintName.MaxLength = 32767;
            this.tbSprintName.Multiline = false;
            this.tbSprintName.Name = "tbSprintName";
            this.tbSprintName.ReadOnly = false;
            this.tbSprintName.Size = new System.Drawing.Size(287, 30);
            this.tbSprintName.Style = MetroSet_UI.Design.Style.Light;
            this.tbSprintName.StyleManager = null;
            this.tbSprintName.TabIndex = 1;
            this.tbSprintName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSprintName.ThemeAuthor = "Narwin";
            this.tbSprintName.ThemeName = "MetroLite";
            this.tbSprintName.UseSystemPasswordChar = false;
            this.tbSprintName.WatermarkText = "";
            // 
            // btnCreateSprint
            // 
            this.btnCreateSprint.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCreateSprint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCreateSprint.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCreateSprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateSprint.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCreateSprint.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCreateSprint.HoverTextColor = System.Drawing.Color.White;
            this.btnCreateSprint.Location = new System.Drawing.Point(363, 217);
            this.btnCreateSprint.Name = "btnCreateSprint";
            this.btnCreateSprint.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCreateSprint.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCreateSprint.NormalTextColor = System.Drawing.Color.White;
            this.btnCreateSprint.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCreateSprint.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCreateSprint.PressTextColor = System.Drawing.Color.White;
            this.btnCreateSprint.Size = new System.Drawing.Size(123, 35);
            this.btnCreateSprint.Style = MetroSet_UI.Design.Style.Light;
            this.btnCreateSprint.StyleManager = null;
            this.btnCreateSprint.TabIndex = 4;
            this.btnCreateSprint.Text = "Create Sprint";
            this.btnCreateSprint.ThemeAuthor = "Narwin";
            this.btnCreateSprint.ThemeName = "MetroLite";
            this.btnCreateSprint.Click += new System.EventHandler(this.btnCreateSprint_Click_1);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOutput.Location = new System.Drawing.Point(21, 217);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(311, 23);
            this.lblOutput.Style = MetroSet_UI.Design.Style.Light;
            this.lblOutput.StyleManager = null;
            this.lblOutput.TabIndex = 0;
            this.lblOutput.ThemeAuthor = "Narwin";
            this.lblOutput.ThemeName = "MetroLite";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 32);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 24, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(196, 174);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(287, 32);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2021, 12, 8, 0, 0, 0, 0);
            // 
            // lblOut
            // 
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOut.Location = new System.Drawing.Point(21, 217);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(311, 23);
            this.lblOut.Style = MetroSet_UI.Design.Style.Light;
            this.lblOut.StyleManager = null;
            this.lblOut.TabIndex = 5;
            this.lblOut.Text = "metroSetLabel1";
            this.lblOut.ThemeAuthor = "Narwin";
            this.lblOut.ThemeName = "MetroLite";
            // 
            // addSprintForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 265);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCreateSprint);
            this.Controls.Add(this.tbSprintName);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "addSprintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Sprint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addSprintForm_FormClosing);
            this.Load += new System.EventHandler(this.addSprintForm_Load);
            this.Shown += new System.EventHandler(this.addSprintForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTextBox tbSprintName;
        private MetroSet_UI.Controls.MetroSetButton btnCreateSprint;
        private MetroSet_UI.Controls.MetroSetLabel lblOutput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroSet_UI.Controls.MetroSetLabel lblOut;
    }
}