﻿
namespace Agile_Extension.Forms
{
    partial class frmKanbanTemplate9
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lstNotStarted = new System.Windows.Forms.ListView();
            this.taskToDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDesignAnalysis = new System.Windows.Forms.ListView();
            this.taskDoing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDone = new System.Windows.Forms.ListView();
            this.taskDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroSetProgressBar1 = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.styleManager1 = new MetroSet_UI.StyleManager();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.lstCodeReview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTesting = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTestReady = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSignOff = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDeployment = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDevelopment = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lstNotStarted
            // 
            this.lstNotStarted.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskToDo});
            this.lstNotStarted.GridLines = true;
            this.lstNotStarted.HideSelection = false;
            this.lstNotStarted.Location = new System.Drawing.Point(16, 137);
            this.lstNotStarted.Name = "lstNotStarted";
            this.lstNotStarted.Size = new System.Drawing.Size(252, 297);
            this.lstNotStarted.TabIndex = 4;
            this.lstNotStarted.UseCompatibleStateImageBehavior = false;
            this.lstNotStarted.View = System.Windows.Forms.View.Details;
            this.lstNotStarted.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstNotStarted_ItemDrag);
            this.lstNotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstNotStarted_DragDrop);
            this.lstNotStarted.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskToDo
            // 
            this.taskToDo.Text = "Not Started";
            this.taskToDo.Width = 250;
            // 
            // lstDesignAnalysis
            // 
            this.lstDesignAnalysis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDoing});
            this.lstDesignAnalysis.GridLines = true;
            this.lstDesignAnalysis.HideSelection = false;
            this.lstDesignAnalysis.Location = new System.Drawing.Point(274, 137);
            this.lstDesignAnalysis.Name = "lstDesignAnalysis";
            this.lstDesignAnalysis.Size = new System.Drawing.Size(249, 297);
            this.lstDesignAnalysis.TabIndex = 5;
            this.lstDesignAnalysis.UseCompatibleStateImageBehavior = false;
            this.lstDesignAnalysis.View = System.Windows.Forms.View.Details;
            this.lstDesignAnalysis.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstDesignAnalysis_ItemDrag);
            this.lstDesignAnalysis.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDesignAnalysis_DragDrop);
            this.lstDesignAnalysis.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskDoing
            // 
            this.taskDoing.Text = "Design/Analysis";
            this.taskDoing.Width = 250;
            // 
            // lstDone
            // 
            this.lstDone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDone});
            this.lstDone.GridLines = true;
            this.lstDone.HideSelection = false;
            this.lstDone.Location = new System.Drawing.Point(911, 443);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(249, 296);
            this.lstDone.TabIndex = 6;
            this.lstDone.UseCompatibleStateImageBehavior = false;
            this.lstDone.View = System.Windows.Forms.View.Details;
            this.lstDone.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstDone_ItemDrag);
            this.lstDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDone_DragDrop);
            this.lstDone.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskDone
            // 
            this.taskDone.Text = "Done";
            this.taskDone.Width = 250;
            // 
            // metroSetProgressBar1
            // 
            this.metroSetProgressBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar1.Location = new System.Drawing.Point(15, 96);
            this.metroSetProgressBar1.Maximum = 100;
            this.metroSetProgressBar1.Minimum = 0;
            this.metroSetProgressBar1.Name = "metroSetProgressBar1";
            this.metroSetProgressBar1.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.metroSetProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar1.Size = new System.Drawing.Size(1273, 23);
            this.metroSetProgressBar1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetProgressBar1.StyleManager = this.styleManager1;
            this.metroSetProgressBar1.TabIndex = 13;
            this.metroSetProgressBar1.Text = "metroSetProgressBar1";
            this.metroSetProgressBar1.ThemeAuthor = "Narwin";
            this.metroSetProgressBar1.ThemeName = "MetroLite";
            this.metroSetProgressBar1.Value = 0;
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\RKW-PostGrad\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1188, 17);
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
            this.metroSetControlBox1.TabIndex = 14;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Location = new System.Drawing.Point(29, 490);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(91, 30);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton1.StyleManager = this.styleManager1;
            this.metroSetButton1.TabIndex = 16;
            this.metroSetButton1.Text = "Add Task";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // lstCodeReview
            // 
            this.lstCodeReview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstCodeReview.GridLines = true;
            this.lstCodeReview.HideSelection = false;
            this.lstCodeReview.Location = new System.Drawing.Point(787, 137);
            this.lstCodeReview.Name = "lstCodeReview";
            this.lstCodeReview.Size = new System.Drawing.Size(249, 297);
            this.lstCodeReview.TabIndex = 20;
            this.lstCodeReview.UseCompatibleStateImageBehavior = false;
            this.lstCodeReview.View = System.Windows.Forms.View.Details;
            this.lstCodeReview.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstCodeReview_ItemDrag);
            this.lstCodeReview.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstCodeReview_DragDrop);
            this.lstCodeReview.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code Review";
            this.columnHeader1.Width = 250;
            // 
            // lstTesting
            // 
            this.lstTesting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstTesting.GridLines = true;
            this.lstTesting.HideSelection = false;
            this.lstTesting.Location = new System.Drawing.Point(146, 440);
            this.lstTesting.Name = "lstTesting";
            this.lstTesting.Size = new System.Drawing.Size(249, 297);
            this.lstTesting.TabIndex = 24;
            this.lstTesting.UseCompatibleStateImageBehavior = false;
            this.lstTesting.View = System.Windows.Forms.View.Details;
            this.lstTesting.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstTesting_ItemDrag);
            this.lstTesting.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstTesting_DragDrop);
            this.lstTesting.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "In Testing";
            this.columnHeader2.Width = 250;
            // 
            // lstTestReady
            // 
            this.lstTestReady.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lstTestReady.GridLines = true;
            this.lstTestReady.HideSelection = false;
            this.lstTestReady.Location = new System.Drawing.Point(1040, 137);
            this.lstTestReady.Name = "lstTestReady";
            this.lstTestReady.Size = new System.Drawing.Size(249, 297);
            this.lstTestReady.TabIndex = 36;
            this.lstTestReady.UseCompatibleStateImageBehavior = false;
            this.lstTestReady.View = System.Windows.Forms.View.Details;
            this.lstTestReady.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstTestReady_ItemDrag);
            this.lstTestReady.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstTestReady_DragDrop);
            this.lstTestReady.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ready to Test";
            this.columnHeader3.Width = 250;
            // 
            // lstSignOff
            // 
            this.lstSignOff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lstSignOff.GridLines = true;
            this.lstSignOff.HideSelection = false;
            this.lstSignOff.Location = new System.Drawing.Point(401, 440);
            this.lstSignOff.Name = "lstSignOff";
            this.lstSignOff.Size = new System.Drawing.Size(249, 297);
            this.lstSignOff.TabIndex = 33;
            this.lstSignOff.UseCompatibleStateImageBehavior = false;
            this.lstSignOff.View = System.Windows.Forms.View.Details;
            this.lstSignOff.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstSignOff_ItemDrag);
            this.lstSignOff.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstSignOff_DragDrop);
            this.lstSignOff.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sign Off";
            this.columnHeader4.Width = 250;
            // 
            // lstDeployment
            // 
            this.lstDeployment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lstDeployment.GridLines = true;
            this.lstDeployment.HideSelection = false;
            this.lstDeployment.Location = new System.Drawing.Point(656, 440);
            this.lstDeployment.Name = "lstDeployment";
            this.lstDeployment.Size = new System.Drawing.Size(249, 297);
            this.lstDeployment.TabIndex = 29;
            this.lstDeployment.UseCompatibleStateImageBehavior = false;
            this.lstDeployment.View = System.Windows.Forms.View.Details;
            this.lstDeployment.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstDeployment_ItemDrag);
            this.lstDeployment.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDeployment_DragDrop);
            this.lstDeployment.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Deployment";
            this.columnHeader5.Width = 250;
            // 
            // lstDevelopment
            // 
            this.lstDevelopment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lstDevelopment.GridLines = true;
            this.lstDevelopment.HideSelection = false;
            this.lstDevelopment.Location = new System.Drawing.Point(529, 137);
            this.lstDevelopment.Name = "lstDevelopment";
            this.lstDevelopment.Size = new System.Drawing.Size(252, 297);
            this.lstDevelopment.TabIndex = 28;
            this.lstDevelopment.UseCompatibleStateImageBehavior = false;
            this.lstDevelopment.View = System.Windows.Forms.View.Details;
            this.lstDevelopment.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstDevelopment_ItemDrag);
            this.lstDevelopment.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDevelopment_DragDrop);
            this.lstDevelopment.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "In Development";
            this.columnHeader6.Width = 250;
            // 
            // frmKanbanTemplate9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 813);
            this.Controls.Add(this.lstTestReady);
            this.Controls.Add(this.lstSignOff);
            this.Controls.Add(this.lstDeployment);
            this.Controls.Add(this.lstDevelopment);
            this.Controls.Add(this.lstTesting);
            this.Controls.Add(this.lstCodeReview);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetProgressBar1);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.lstDesignAnalysis);
            this.Controls.Add(this.lstNotStarted);
            this.Name = "frmKanbanTemplate9";
            this.StyleManager = this.styleManager1;
            this.Text = "Kanban Board - Software Dev Team";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView lstNotStarted;
        private System.Windows.Forms.ListView lstDesignAnalysis;
        private System.Windows.Forms.ListView lstDone;
        private System.Windows.Forms.ColumnHeader taskToDo;
        private System.Windows.Forms.ColumnHeader taskDoing;
        private System.Windows.Forms.ColumnHeader taskDone;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private System.Windows.Forms.ListView lstCodeReview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstTesting;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstTestReady;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstSignOff;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lstDeployment;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lstDevelopment;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroSet_UI.StyleManager styleManager1;
    }
}