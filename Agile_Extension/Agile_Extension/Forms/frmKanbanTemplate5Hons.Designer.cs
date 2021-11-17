
namespace Agile_Extension.Forms
{
    partial class frmKanbanTemplate5Hons
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
            this.lstResearch = new System.Windows.Forms.ListView();
            this.taskResearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDone = new System.Windows.Forms.ListView();
            this.taskDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroSetProgressBar1 = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.styleManager1 = new MetroSet_UI.StyleManager();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.lstDevelop = new System.Windows.Forms.ListView();
            this.taskDevelop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTesting = new System.Windows.Forms.ListView();
            this.taskTesting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRename1 = new System.Windows.Forms.Button();
            this.btnRename2 = new System.Windows.Forms.Button();
            this.btnRename3 = new System.Windows.Forms.Button();
            this.btnRename4 = new System.Windows.Forms.Button();
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
            this.lstNotStarted.Location = new System.Drawing.Point(15, 188);
            this.lstNotStarted.Name = "lstNotStarted";
            this.lstNotStarted.Size = new System.Drawing.Size(252, 297);
            this.lstNotStarted.TabIndex = 4;
            this.lstNotStarted.UseCompatibleStateImageBehavior = false;
            this.lstNotStarted.View = System.Windows.Forms.View.Details;
            this.lstNotStarted.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstNotStarted_ItemDrag);
            this.lstNotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstTodo_DragDrop);
            this.lstNotStarted.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskToDo
            // 
            this.taskToDo.Text = "Not Started";
            this.taskToDo.Width = 250;
            // 
            // lstResearch
            // 
            this.lstResearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskResearch});
            this.lstResearch.GridLines = true;
            this.lstResearch.HideSelection = false;
            this.lstResearch.Location = new System.Drawing.Point(273, 188);
            this.lstResearch.Name = "lstResearch";
            this.lstResearch.Size = new System.Drawing.Size(249, 297);
            this.lstResearch.TabIndex = 5;
            this.lstResearch.UseCompatibleStateImageBehavior = false;
            this.lstResearch.View = System.Windows.Forms.View.Details;
            this.lstResearch.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstResearch_ItemDrag);
            this.lstResearch.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDoing_DragDrop);
            this.lstResearch.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskResearch
            // 
            this.taskResearch.Text = "Research";
            this.taskResearch.Width = 250;
            // 
            // lstDone
            // 
            this.lstDone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDone});
            this.lstDone.GridLines = true;
            this.lstDone.HideSelection = false;
            this.lstDone.Location = new System.Drawing.Point(1039, 188);
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
            this.metroSetControlBox1.ThemeAuthor = null;
            this.metroSetControlBox1.ThemeName = null;
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
            this.metroSetButton1.Location = new System.Drawing.Point(15, 505);
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
            this.metroSetButton1.ThemeAuthor = null;
            this.metroSetButton1.ThemeName = null;
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // lstDevelop
            // 
            this.lstDevelop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDevelop});
            this.lstDevelop.GridLines = true;
            this.lstDevelop.HideSelection = false;
            this.lstDevelop.Location = new System.Drawing.Point(528, 189);
            this.lstDevelop.Name = "lstDevelop";
            this.lstDevelop.Size = new System.Drawing.Size(249, 297);
            this.lstDevelop.TabIndex = 20;
            this.lstDevelop.UseCompatibleStateImageBehavior = false;
            this.lstDevelop.View = System.Windows.Forms.View.Details;
            this.lstDevelop.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstDevelop_ItemDrag);
            this.lstDevelop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDevelop_DragDrop);
            this.lstDevelop.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskDevelop
            // 
            this.taskDevelop.Text = "Develop";
            this.taskDevelop.Width = 250;
            // 
            // lstTesting
            // 
            this.lstTesting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskTesting});
            this.lstTesting.GridLines = true;
            this.lstTesting.HideSelection = false;
            this.lstTesting.Location = new System.Drawing.Point(783, 188);
            this.lstTesting.Name = "lstTesting";
            this.lstTesting.Size = new System.Drawing.Size(249, 297);
            this.lstTesting.TabIndex = 24;
            this.lstTesting.UseCompatibleStateImageBehavior = false;
            this.lstTesting.View = System.Windows.Forms.View.Details;
            this.lstTesting.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstTesting_ItemDrag);
            this.lstTesting.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstTesting_DragDrop);
            this.lstTesting.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskTesting
            // 
            this.taskTesting.Text = "In Testing";
            this.taskTesting.Width = 250;
            // 
            // btnRename1
            // 
            this.btnRename1.BackgroundImage = global::Agile_Extension.Properties.Resources.renameIcon;
            this.btnRename1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRename1.Location = new System.Drawing.Point(242, 188);
            this.btnRename1.Name = "btnRename1";
            this.btnRename1.Size = new System.Drawing.Size(25, 25);
            this.btnRename1.TabIndex = 26;
            this.btnRename1.UseVisualStyleBackColor = true;
            this.btnRename1.Click += new System.EventHandler(this.btnRename1_Click);
            // 
            // btnRename2
            // 
            this.btnRename2.BackgroundImage = global::Agile_Extension.Properties.Resources.renameIcon;
            this.btnRename2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRename2.Location = new System.Drawing.Point(497, 188);
            this.btnRename2.Name = "btnRename2";
            this.btnRename2.Size = new System.Drawing.Size(25, 25);
            this.btnRename2.TabIndex = 27;
            this.btnRename2.UseVisualStyleBackColor = true;
            this.btnRename2.Click += new System.EventHandler(this.btnRename2_Click);
            // 
            // btnRename3
            // 
            this.btnRename3.BackgroundImage = global::Agile_Extension.Properties.Resources.renameIcon;
            this.btnRename3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRename3.Location = new System.Drawing.Point(752, 188);
            this.btnRename3.Name = "btnRename3";
            this.btnRename3.Size = new System.Drawing.Size(25, 25);
            this.btnRename3.TabIndex = 28;
            this.btnRename3.UseVisualStyleBackColor = true;
            this.btnRename3.Click += new System.EventHandler(this.btnRename3_Click);
            // 
            // btnRename4
            // 
            this.btnRename4.BackgroundImage = global::Agile_Extension.Properties.Resources.renameIcon;
            this.btnRename4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRename4.Location = new System.Drawing.Point(1007, 188);
            this.btnRename4.Name = "btnRename4";
            this.btnRename4.Size = new System.Drawing.Size(25, 25);
            this.btnRename4.TabIndex = 29;
            this.btnRename4.UseVisualStyleBackColor = true;
            this.btnRename4.Click += new System.EventHandler(this.btnRename4_Click);
            // 
            // frmKanbanTemplate5Hons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 588);
            this.Controls.Add(this.btnRename4);
            this.Controls.Add(this.btnRename3);
            this.Controls.Add(this.btnRename2);
            this.Controls.Add(this.btnRename1);
            this.Controls.Add(this.lstTesting);
            this.Controls.Add(this.lstDevelop);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetProgressBar1);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.lstResearch);
            this.Controls.Add(this.lstNotStarted);
            this.Name = "frmKanbanTemplate5Hons";
            this.StyleManager = this.styleManager1;
            this.Text = "Kanban Board - PostGrad Projects";
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView lstNotStarted;
        private System.Windows.Forms.ListView lstResearch;
        private System.Windows.Forms.ListView lstDone;
        private System.Windows.Forms.ColumnHeader taskToDo;
        private System.Windows.Forms.ColumnHeader taskResearch;
        private System.Windows.Forms.ColumnHeader taskDone;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private System.Windows.Forms.ListView lstDevelop;
        private System.Windows.Forms.ColumnHeader taskDevelop;
        private System.Windows.Forms.ListView lstTesting;
        private System.Windows.Forms.ColumnHeader taskTesting;
        private MetroSet_UI.StyleManager styleManager1;
        private System.Windows.Forms.Button btnRename1;
        private System.Windows.Forms.Button btnRename4;
        private System.Windows.Forms.Button btnRename3;
        private System.Windows.Forms.Button btnRename2;
    }
}