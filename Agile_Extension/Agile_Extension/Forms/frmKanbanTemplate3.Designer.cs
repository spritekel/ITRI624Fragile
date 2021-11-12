
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
            this.btnRename2 = new System.Windows.Forms.Button();
            this.btnRename1 = new System.Windows.Forms.Button();
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
            this.lstTodo.Location = new System.Drawing.Point(15, 188);
            this.lstTodo.Name = "lstTodo";
            this.lstTodo.Size = new System.Drawing.Size(252, 297);
            this.lstTodo.TabIndex = 4;
            this.lstTodo.UseCompatibleStateImageBehavior = false;
            this.lstTodo.View = System.Windows.Forms.View.Details;
            this.lstTodo.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstTodo_ItemDrag);
            this.lstTodo.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstTodo_DragDrop);
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
            this.lstDoing.Location = new System.Drawing.Point(273, 188);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(249, 297);
            this.lstDoing.TabIndex = 5;
            this.lstDoing.UseCompatibleStateImageBehavior = false;
            this.lstDoing.View = System.Windows.Forms.View.Details;
            this.lstDoing.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstDoing_ItemDrag);
            this.lstDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDoing_DragDrop);
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
            this.lstDone.Location = new System.Drawing.Point(528, 188);
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
            this.metroSetProgressBar1.Size = new System.Drawing.Size(762, 23);
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
            this.metroSetControlBox1.Location = new System.Drawing.Point(677, 17);
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
            this.btnAddTask.Location = new System.Drawing.Point(15, 506);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTask.NormalTextColor = System.Drawing.Color.White;
            this.btnAddTask.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddTask.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddTask.PressTextColor = System.Drawing.Color.White;
            this.btnAddTask.Size = new System.Drawing.Size(91, 30);
            this.btnAddTask.Style = MetroSet_UI.Design.Style.Light;
            this.btnAddTask.StyleManager = this.styleManager1;
            this.btnAddTask.TabIndex = 16;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.ThemeAuthor = null;
            this.btnAddTask.ThemeName = null;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRename2
            // 
            this.btnRename2.BackgroundImage = global::Agile_Extension.Properties.Resources.renameIcon;
            this.btnRename2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRename2.Location = new System.Drawing.Point(497, 188);
            this.btnRename2.Name = "btnRename2";
            this.btnRename2.Size = new System.Drawing.Size(25, 25);
            this.btnRename2.TabIndex = 19;
            this.btnRename2.UseVisualStyleBackColor = true;
            this.btnRename2.Click += new System.EventHandler(this.btnRename2_Click);
            // 
            // btnRename1
            // 
            this.btnRename1.BackgroundImage = global::Agile_Extension.Properties.Resources.renameIcon;
            this.btnRename1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRename1.Location = new System.Drawing.Point(15, 157);
            this.btnRename1.Name = "btnRename1";
            this.btnRename1.Size = new System.Drawing.Size(25, 25);
            this.btnRename1.TabIndex = 18;
            this.btnRename1.UseVisualStyleBackColor = true;
            this.btnRename1.Click += new System.EventHandler(this.btnRename1_Click);
            // 
            // frmKanbanTemplate3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 567);
            this.Controls.Add(this.btnRename2);
            this.Controls.Add(this.btnRename1);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetProgressBar1);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.lstDoing);
            this.Controls.Add(this.lstTodo);
            this.Name = "frmKanbanTemplate3";
            this.StyleManager = this.styleManager1;
            this.Text = "Kanban Board - Simple";
            this.ThemeAuthor = null;
            this.ThemeName = null;
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
        private System.Windows.Forms.Button btnRename1;
        private System.Windows.Forms.Button btnRename2;
    }
}