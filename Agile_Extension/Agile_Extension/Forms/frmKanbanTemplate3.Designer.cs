
namespace Agile_Extension.Forms
{
    partial class frmKanbanTemplate3
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
            this.lstTodo = new System.Windows.Forms.ListView();
            this.taskToDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDoing = new System.Windows.Forms.ListView();
            this.taskDoing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDone = new System.Windows.Forms.ListView();
            this.taskDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroSetProgressBar1 = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.styleManager1 = new MetroSet_UI.StyleManager();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.btnAddTask = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.lbED = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbSD = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lstTodo
            // 
            this.lstTodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskToDo});
            this.lstTodo.GridLines = true;
            this.lstTodo.HideSelection = false;
            this.lstTodo.Location = new System.Drawing.Point(0, 0);
            this.lstTodo.Name = "lstTodo";
            this.lstTodo.Size = new System.Drawing.Size(250, 400);
            this.lstTodo.TabIndex = 4;
            this.lstTodo.UseCompatibleStateImageBehavior = false;
            this.lstTodo.View = System.Windows.Forms.View.Details;
            this.lstTodo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstRename_ColumnClick);
            this.lstTodo.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lst_ItemDrag);
            this.lstTodo.Click += new System.EventHandler(this.lstTodo_Click);
            this.lstTodo.DragDrop += new System.Windows.Forms.DragEventHandler(this.lst_DragDrop);
            this.lstTodo.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskToDo
            // 
            this.taskToDo.Text = "To Do";
            this.taskToDo.Width = 250;
            // 
            // lstDoing
            // 
            this.lstDoing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDoing});
            this.lstDoing.GridLines = true;
            this.lstDoing.HideSelection = false;
            this.lstDoing.Location = new System.Drawing.Point(250, 0);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(250, 400);
            this.lstDoing.TabIndex = 5;
            this.lstDoing.UseCompatibleStateImageBehavior = false;
            this.lstDoing.View = System.Windows.Forms.View.Details;
            this.lstDoing.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstRename_ColumnClick);
            this.lstDoing.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lst_ItemDrag);
            this.lstDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.lst_DragDrop);
            this.lstDoing.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskDoing
            // 
            this.taskDoing.Text = "Doing";
            this.taskDoing.Width = 250;
            // 
            // lstDone
            // 
            this.lstDone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDone});
            this.lstDone.GridLines = true;
            this.lstDone.HideSelection = false;
            this.lstDone.LabelEdit = true;
            this.lstDone.Location = new System.Drawing.Point(500, 0);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(250, 400);
            this.lstDone.TabIndex = 6;
            this.lstDone.UseCompatibleStateImageBehavior = false;
            this.lstDone.View = System.Windows.Forms.View.Details;
            this.lstDone.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lst_ItemDrag);
            this.lstDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.lst_DragDrop);
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
            this.metroSetProgressBar1.Location = new System.Drawing.Point(15, 95);
            this.metroSetProgressBar1.Maximum = 100;
            this.metroSetProgressBar1.Minimum = 0;
            this.metroSetProgressBar1.Name = "metroSetProgressBar1";
            this.metroSetProgressBar1.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.metroSetProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar1.Size = new System.Drawing.Size(750, 23);
            this.metroSetProgressBar1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetProgressBar1.StyleManager = this.styleManager1;
            this.metroSetProgressBar1.TabIndex = 13;
            this.metroSetProgressBar1.Text = "metroSetProgressBar1";
            this.metroSetProgressBar1.ThemeAuthor = null;
            this.metroSetProgressBar1.ThemeName = null;
            this.metroSetProgressBar1.Value = 0;
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\RKW-PostGrad\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
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
            this.metroSetControlBox1.Location = new System.Drawing.Point(680, 15);
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
            this.metroSetControlBox1.ThemeAuthor = null;
            this.metroSetControlBox1.ThemeName = null;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddTask.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddTask.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddTask.HoverTextColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(15, 145);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.NormalTextColor = System.Drawing.Color.White;
            this.btnAddTask.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddTask.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddTask.PressTextColor = System.Drawing.Color.White;
            this.btnAddTask.Size = new System.Drawing.Size(100, 30);
            this.btnAddTask.Style = MetroSet_UI.Design.Style.Light;
            this.btnAddTask.StyleManager = this.styleManager1;
            this.btnAddTask.TabIndex = 16;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.ThemeAuthor = null;
            this.btnAddTask.ThemeName = null;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
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
            this.metroSetButton1.Location = new System.Drawing.Point(665, 145);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(100, 30);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton1.StyleManager = this.styleManager1;
            this.metroSetButton1.TabIndex = 23;
            this.metroSetButton1.Text = "Add New List";
            this.metroSetButton1.ThemeAuthor = null;
            this.metroSetButton1.ThemeName = null;
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.lstTodo);
            this.metroSetPanel1.Controls.Add(this.lstDoing);
            this.metroSetPanel1.Controls.Add(this.lstDone);
            this.metroSetPanel1.Location = new System.Drawing.Point(15, 195);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(750, 417);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetPanel1.StyleManager = this.styleManager1;
            this.metroSetPanel1.TabIndex = 24;
            this.metroSetPanel1.ThemeAuthor = null;
            this.metroSetPanel1.ThemeName = null;
            // 
            // lbED
            // 
            this.lbED.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbED.Location = new System.Drawing.Point(665, 69);
            this.lbED.Name = "lbED";
            this.lbED.Size = new System.Drawing.Size(100, 23);
            this.lbED.Style = MetroSet_UI.Design.Style.Light;
            this.lbED.StyleManager = this.styleManager1;
            this.lbED.TabIndex = 25;
            this.lbED.Text = "end";
            this.lbED.ThemeAuthor = null;
            this.lbED.ThemeName = null;
            // 
            // lbSD
            // 
            this.lbSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSD.Location = new System.Drawing.Point(15, 69);
            this.lbSD.Name = "lbSD";
            this.lbSD.Size = new System.Drawing.Size(100, 23);
            this.lbSD.Style = MetroSet_UI.Design.Style.Light;
            this.lbSD.StyleManager = this.styleManager1;
            this.lbSD.TabIndex = 26;
            this.lbSD.Text = "start";
            this.lbSD.ThemeAuthor = null;
            this.lbSD.ThemeName = null;
            // 
            // frmKanbanTemplate3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 635);
            this.Controls.Add(this.lbSD);
            this.Controls.Add(this.lbED);
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetProgressBar1);
            this.Name = "frmKanbanTemplate3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StyleManager = this.styleManager1;
            this.Text = "Kanban Board - Simple";
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.Load += new System.EventHandler(this.frmKanbanTemplate3_Load);
            this.Shown += new System.EventHandler(this.frmKanbanTemplate3_Shown);
            this.metroSetPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView lstTodo;
        private System.Windows.Forms.ListView lstDoing;
        private System.Windows.Forms.ListView lstDone;
        private System.Windows.Forms.ColumnHeader taskToDo;
        private System.Windows.Forms.ColumnHeader taskDoing;
        private System.Windows.Forms.ColumnHeader taskDone;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton btnAddTask;
        private MetroSet_UI.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetLabel lbSD;
        private MetroSet_UI.Controls.MetroSetLabel lbED;
    }
}