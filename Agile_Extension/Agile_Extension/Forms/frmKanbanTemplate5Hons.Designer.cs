
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
            this.inpNotStarted = new System.Windows.Forms.TextBox();
            this.inpDone = new System.Windows.Forms.TextBox();
            this.inpResearch = new System.Windows.Forms.TextBox();
            this.lstNotStarted = new System.Windows.Forms.ListView();
            this.taskToDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstResearch = new System.Windows.Forms.ListView();
            this.taskDoing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDone = new System.Windows.Forms.ListView();
            this.taskDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNotStarted = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.metroSetProgressBar1 = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.btnDevelop = new System.Windows.Forms.Button();
            this.lstDevelop = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inpDevelop = new System.Windows.Forms.TextBox();
            this.btnTesting = new System.Windows.Forms.Button();
            this.lstTesting = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inpTesting = new System.Windows.Forms.TextBox();
            this.styleManager1 = new MetroSet_UI.StyleManager();
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
            // inpResearch
            // 
            this.inpResearch.Location = new System.Drawing.Point(273, 491);
            this.inpResearch.Name = "inpResearch";
            this.inpResearch.Size = new System.Drawing.Size(206, 27);
            this.inpResearch.TabIndex = 2;
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
            this.taskDoing});
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
            // taskDoing
            // 
            this.taskDoing.Text = "Research";
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
            // btnResearch
            // 
            this.btnResearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnResearch.Location = new System.Drawing.Point(485, 491);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(37, 27);
            this.btnResearch.TabIndex = 8;
            this.btnResearch.Text = "Add";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
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
            this.metroSetProgressBar1.StyleManager = this.styleManager1;
            this.metroSetProgressBar1.TabIndex = 13;
            this.metroSetProgressBar1.Text = "metroSetProgressBar1";
            this.metroSetProgressBar1.ThemeAuthor = null;
            this.metroSetProgressBar1.ThemeName = null;
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
            this.metroSetButton1.StyleManager = this.styleManager1;
            this.metroSetButton1.TabIndex = 16;
            this.metroSetButton1.Text = "Add Task";
            this.metroSetButton1.ThemeAuthor = null;
            this.metroSetButton1.ThemeName = null;
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // btnDevelop
            // 
            this.btnDevelop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDevelop.Location = new System.Drawing.Point(740, 492);
            this.btnDevelop.Name = "btnDevelop";
            this.btnDevelop.Size = new System.Drawing.Size(37, 27);
            this.btnDevelop.TabIndex = 21;
            this.btnDevelop.Text = "Add";
            this.btnDevelop.UseVisualStyleBackColor = true;
            this.btnDevelop.Click += new System.EventHandler(this.btnCodeReview_Click);
            // 
            // lstDevelop
            // 
            this.lstDevelop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Develop";
            this.columnHeader1.Width = 250;
            // 
            // inpDevelop
            // 
            this.inpDevelop.Location = new System.Drawing.Point(528, 492);
            this.inpDevelop.Name = "inpDevelop";
            this.inpDevelop.Size = new System.Drawing.Size(206, 27);
            this.inpDevelop.TabIndex = 19;
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
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\RKW-PostGrad\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager1.ThemeAuthor = null;
            this.styleManager1.ThemeName = null;
            // 
            // frmKanbanTemplate5Hons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 588);
            this.Controls.Add(this.btnTesting);
            this.Controls.Add(this.lstTesting);
            this.Controls.Add(this.inpTesting);
            this.Controls.Add(this.btnDevelop);
            this.Controls.Add(this.lstDevelop);
            this.Controls.Add(this.inpDevelop);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetProgressBar1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnNotStarted);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.lstResearch);
            this.Controls.Add(this.lstNotStarted);
            this.Controls.Add(this.inpDone);
            this.Controls.Add(this.inpResearch);
            this.Controls.Add(this.inpNotStarted);
            this.Name = "frmKanbanTemplate5Hons";
            this.StyleManager = this.styleManager1;
            this.Text = "Kanban Board - PostGrad Projects";
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox inpNotStarted;
        private System.Windows.Forms.TextBox inpDone;
        private System.Windows.Forms.TextBox inpResearch;
        private System.Windows.Forms.ListView lstNotStarted;
        private System.Windows.Forms.ListView lstResearch;
        private System.Windows.Forms.ListView lstDone;
        private System.Windows.Forms.Button btnNotStarted;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ColumnHeader taskToDo;
        private System.Windows.Forms.ColumnHeader taskDoing;
        private System.Windows.Forms.ColumnHeader taskDone;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private System.Windows.Forms.Button btnDevelop;
        private System.Windows.Forms.ListView lstDevelop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox inpDevelop;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.ListView lstTesting;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox inpTesting;
        private MetroSet_UI.StyleManager styleManager1;
    }
}