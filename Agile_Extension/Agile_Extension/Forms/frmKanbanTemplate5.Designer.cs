
namespace Agile_Extension.Forms
{
    partial class frmKanbanTemplate5
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
            this.inpNotStarted = new System.Windows.Forms.TextBox();
            this.inpDone = new System.Windows.Forms.TextBox();
            this.inpProgress = new System.Windows.Forms.TextBox();
            this.lstNotStarted = new System.Windows.Forms.ListView();
            this.taskToDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstProgress = new System.Windows.Forms.ListView();
            this.taskDoing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDone = new System.Windows.Forms.ListView();
            this.taskDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNotStarted = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.metroSetProgressBar1 = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCodeReview = new System.Windows.Forms.Button();
            this.lstCodeReview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inpCodeReview = new System.Windows.Forms.TextBox();
            this.btnTesting = new System.Windows.Forms.Button();
            this.lstTesting = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inpTesting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inpNotStarted
            // 
            this.inpNotStarted.Location = new System.Drawing.Point(15, 492);
            this.inpNotStarted.Name = "inpNotStarted";
            this.inpNotStarted.Size = new System.Drawing.Size(206, 27);
            this.inpNotStarted.TabIndex = 1;
            // 
            // inpDone
            // 
            this.inpDone.Location = new System.Drawing.Point(1039, 490);
            this.inpDone.Name = "inpDone";
            this.inpDone.Size = new System.Drawing.Size(206, 27);
            this.inpDone.TabIndex = 3;
            // 
            // inpProgress
            // 
            this.inpProgress.Location = new System.Drawing.Point(273, 491);
            this.inpProgress.Name = "inpProgress";
            this.inpProgress.Size = new System.Drawing.Size(206, 27);
            this.inpProgress.TabIndex = 2;
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
            // lstProgress
            // 
            this.lstProgress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskDoing});
            this.lstProgress.GridLines = true;
            this.lstProgress.HideSelection = false;
            this.lstProgress.Location = new System.Drawing.Point(273, 188);
            this.lstProgress.Name = "lstProgress";
            this.lstProgress.Size = new System.Drawing.Size(249, 297);
            this.lstProgress.TabIndex = 5;
            this.lstProgress.UseCompatibleStateImageBehavior = false;
            this.lstProgress.View = System.Windows.Forms.View.Details;
            this.lstProgress.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstProgress_ItemDrag);
            this.lstProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDoing_DragDrop);
            this.lstProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.lst_DragOver);
            // 
            // taskDoing
            // 
            this.taskDoing.Text = "In Progress";
            this.taskDoing.Width = 250;
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
            // btnNotStarted
            // 
            this.btnNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnNotStarted.Location = new System.Drawing.Point(227, 491);
            this.btnNotStarted.Name = "btnNotStarted";
            this.btnNotStarted.Size = new System.Drawing.Size(40, 27);
            this.btnNotStarted.TabIndex = 7;
            this.btnNotStarted.Text = "Add";
            this.btnNotStarted.UseVisualStyleBackColor = true;
            this.btnNotStarted.Click += new System.EventHandler(this.btnNotStarted_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnProgress.Location = new System.Drawing.Point(485, 491);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(37, 27);
            this.btnProgress.TabIndex = 8;
            this.btnProgress.Text = "Add";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDone.Location = new System.Drawing.Point(1251, 490);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(37, 27);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Add";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
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
            this.metroSetProgressBar1.StyleManager = null;
            this.metroSetProgressBar1.TabIndex = 13;
            this.metroSetProgressBar1.Text = "metroSetProgressBar1";
            this.metroSetProgressBar1.ThemeAuthor = "Narwin";
            this.metroSetProgressBar1.ThemeName = "MetroLite";
            this.metroSetProgressBar1.Value = 0;
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
            this.metroSetControlBox1.StyleManager = null;
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
            this.metroSetButton1.Location = new System.Drawing.Point(15, 525);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(91, 30);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 16;
            this.metroSetButton1.Text = "Add Task";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // btnCodeReview
            // 
            this.btnCodeReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCodeReview.Location = new System.Drawing.Point(740, 492);
            this.btnCodeReview.Name = "btnCodeReview";
            this.btnCodeReview.Size = new System.Drawing.Size(37, 27);
            this.btnCodeReview.TabIndex = 21;
            this.btnCodeReview.Text = "Add";
            this.btnCodeReview.UseVisualStyleBackColor = true;
            this.btnCodeReview.Click += new System.EventHandler(this.btnCodeReview_Click);
            // 
            // lstCodeReview
            // 
            this.lstCodeReview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstCodeReview.GridLines = true;
            this.lstCodeReview.HideSelection = false;
            this.lstCodeReview.Location = new System.Drawing.Point(528, 189);
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
            // inpCodeReview
            // 
            this.inpCodeReview.Location = new System.Drawing.Point(528, 492);
            this.inpCodeReview.Name = "inpCodeReview";
            this.inpCodeReview.Size = new System.Drawing.Size(206, 27);
            this.inpCodeReview.TabIndex = 19;
            // 
            // btnTesting
            // 
            this.btnTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnTesting.Location = new System.Drawing.Point(995, 491);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(37, 27);
            this.btnTesting.TabIndex = 25;
            this.btnTesting.Text = "Add";
            this.btnTesting.UseVisualStyleBackColor = true;
            this.btnTesting.Click += new System.EventHandler(this.btnTesting_Click);
            // 
            // lstTesting
            // 
            this.lstTesting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
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
            // columnHeader2
            // 
            this.columnHeader2.Text = "In Testing";
            this.columnHeader2.Width = 250;
            // 
            // inpTesting
            // 
            this.inpTesting.Location = new System.Drawing.Point(783, 491);
            this.inpTesting.Name = "inpTesting";
            this.inpTesting.Size = new System.Drawing.Size(206, 27);
            this.inpTesting.TabIndex = 23;
            // 
            // frmKanbanTemplate5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 588);
            this.Controls.Add(this.btnTesting);
            this.Controls.Add(this.lstTesting);
            this.Controls.Add(this.inpTesting);
            this.Controls.Add(this.btnCodeReview);
            this.Controls.Add(this.lstCodeReview);
            this.Controls.Add(this.inpCodeReview);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetProgressBar1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnNotStarted);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.lstProgress);
            this.Controls.Add(this.lstNotStarted);
            this.Controls.Add(this.inpDone);
            this.Controls.Add(this.inpProgress);
            this.Controls.Add(this.inpNotStarted);
            this.Name = "frmKanbanTemplate5";
            this.Text = "Kanban Board - ICT Projects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox inpNotStarted;
        private System.Windows.Forms.TextBox inpDone;
        private System.Windows.Forms.TextBox inpProgress;
        private System.Windows.Forms.ListView lstNotStarted;
        private System.Windows.Forms.ListView lstProgress;
        private System.Windows.Forms.ListView lstDone;
        private System.Windows.Forms.Button btnNotStarted;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ColumnHeader taskToDo;
        private System.Windows.Forms.ColumnHeader taskDoing;
        private System.Windows.Forms.ColumnHeader taskDone;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private System.Windows.Forms.Button btnCodeReview;
        private System.Windows.Forms.ListView lstCodeReview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox inpCodeReview;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.ListView lstTesting;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox inpTesting;
    }
}