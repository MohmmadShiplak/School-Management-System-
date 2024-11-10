namespace School_Project
{
    partial class frmListTeachers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTeachersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showTeachersInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectHeTeachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesHeTeachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.cbPages = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddTeacher = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersList)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeachersList
            // 
            this.dgvTeachersList.AllowUserToAddRows = false;
            this.dgvTeachersList.AllowUserToOrderColumns = true;
            this.dgvTeachersList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvTeachersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeachersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeachersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeachersList.ColumnHeadersHeight = 29;
            this.dgvTeachersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTeachersList.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeachersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeachersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvTeachersList.Location = new System.Drawing.Point(5, 264);
            this.dgvTeachersList.Name = "dgvTeachersList";
            this.dgvTeachersList.RowHeadersVisible = false;
            this.dgvTeachersList.RowHeadersWidth = 51;
            this.dgvTeachersList.RowTemplate.Height = 24;
            this.dgvTeachersList.ShowCellToolTips = false;
            this.dgvTeachersList.Size = new System.Drawing.Size(1214, 411);
            this.dgvTeachersList.TabIndex = 0;
            this.dgvTeachersList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTeachersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTeachersList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeachersList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvTeachersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvTeachersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTeachersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTeachersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTeachersList.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvTeachersList.ThemeStyle.ReadOnly = false;
            this.dgvTeachersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvTeachersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTeachersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTeachersList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTeachersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvTeachersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTeachersInfoToolStripMenuItem,
            this.updateTeachersToolStripMenuItem,
            this.deleteTeachersToolStripMenuItem,
            this.subjectHeTeachesToolStripMenuItem,
            this.classesHeTeachesToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(211, 152);
            // 
            // showTeachersInfoToolStripMenuItem
            // 
            this.showTeachersInfoToolStripMenuItem.Name = "showTeachersInfoToolStripMenuItem";
            this.showTeachersInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showTeachersInfoToolStripMenuItem.Text = "Show Teachers Info";
            this.showTeachersInfoToolStripMenuItem.Click += new System.EventHandler(this.showTeachersInfoToolStripMenuItem_Click);
            // 
            // updateTeachersToolStripMenuItem
            // 
            this.updateTeachersToolStripMenuItem.Name = "updateTeachersToolStripMenuItem";
            this.updateTeachersToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateTeachersToolStripMenuItem.Text = "Update Teachers ";
            this.updateTeachersToolStripMenuItem.Click += new System.EventHandler(this.updateTeachersToolStripMenuItem_Click);
            // 
            // deleteTeachersToolStripMenuItem
            // 
            this.deleteTeachersToolStripMenuItem.Name = "deleteTeachersToolStripMenuItem";
            this.deleteTeachersToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteTeachersToolStripMenuItem.Text = "Delete Teachers ";
            this.deleteTeachersToolStripMenuItem.Click += new System.EventHandler(this.deleteTeachersToolStripMenuItem_Click);
            // 
            // subjectHeTeachesToolStripMenuItem
            // 
            this.subjectHeTeachesToolStripMenuItem.Name = "subjectHeTeachesToolStripMenuItem";
            this.subjectHeTeachesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.subjectHeTeachesToolStripMenuItem.Text = "Subject he Teaches ";
            this.subjectHeTeachesToolStripMenuItem.Click += new System.EventHandler(this.subjectHeTeachesToolStripMenuItem_Click);
            // 
            // classesHeTeachesToolStripMenuItem
            // 
            this.classesHeTeachesToolStripMenuItem.Name = "classesHeTeachesToolStripMenuItem";
            this.classesHeTeachesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.classesHeTeachesToolStripMenuItem.Text = "Classes he Teaches ";
            this.classesHeTeachesToolStripMenuItem.Click += new System.EventHandler(this.classesHeTeachesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Records :";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(151, 704);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(48, 25);
            this.lblRecords.TabIndex = 2;
            this.lblRecords.Text = "???";
            // 
            // cbPages
            // 
            this.cbPages.BackColor = System.Drawing.Color.Transparent;
            this.cbPages.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbPages.BorderRadius = 17;
            this.cbPages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPages.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbPages.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbPages.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbPages.ForeColor = System.Drawing.Color.Black;
            this.cbPages.ItemHeight = 30;
            this.cbPages.Location = new System.Drawing.Point(949, 206);
            this.cbPages.Name = "cbPages";
            this.cbPages.Size = new System.Drawing.Size(140, 36);
            this.cbPages.TabIndex = 224;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Checked = true;
            this.btnAddTeacher.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTeacher.FillColor = System.Drawing.Color.White;
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.Color.Black;
            this.btnAddTeacher.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTeacher.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnAddTeacher.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddTeacher.Location = new System.Drawing.Point(1131, 197);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(79, 45);
            this.btnAddTeacher.TabIndex = 225;
            this.btnAddTeacher.Text = "Add";
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // frmListTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 751);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.cbPages);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTeachersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Manage Teachers ";
            this.Text = "frmListTeachers";
            this.Load += new System.EventHandler(this.frmListTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersList)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTeachersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecords;
        private Guna.UI2.WinForms.Guna2ComboBox cbPages;
        private Guna.UI2.WinForms.Guna2Button btnAddTeacher;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showTeachersInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectHeTeachesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesHeTeachesToolStripMenuItem;
    }
}