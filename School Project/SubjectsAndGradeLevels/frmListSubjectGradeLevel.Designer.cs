namespace School_Project
{
    partial class frmListSubjectGradeLevel
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
            this.dgvSubjectGradeLevel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showSubjectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSubjectTeacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoTeacherItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddClass = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectGradeLevel)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubjectGradeLevel
            // 
            this.dgvSubjectGradeLevel.AllowUserToAddRows = false;
            this.dgvSubjectGradeLevel.AllowUserToOrderColumns = true;
            this.dgvSubjectGradeLevel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvSubjectGradeLevel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjectGradeLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjectGradeLevel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubjectGradeLevel.ColumnHeadersHeight = 29;
            this.dgvSubjectGradeLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSubjectGradeLevel.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjectGradeLevel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubjectGradeLevel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvSubjectGradeLevel.Location = new System.Drawing.Point(-1, 190);
            this.dgvSubjectGradeLevel.Name = "dgvSubjectGradeLevel";
            this.dgvSubjectGradeLevel.RowHeadersVisible = false;
            this.dgvSubjectGradeLevel.RowHeadersWidth = 51;
            this.dgvSubjectGradeLevel.RowTemplate.Height = 24;
            this.dgvSubjectGradeLevel.ShowCellToolTips = false;
            this.dgvSubjectGradeLevel.Size = new System.Drawing.Size(987, 422);
            this.dgvSubjectGradeLevel.TabIndex = 1;
            this.dgvSubjectGradeLevel.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvSubjectGradeLevel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvSubjectGradeLevel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSubjectGradeLevel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSubjectGradeLevel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSubjectGradeLevel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSubjectGradeLevel.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubjectGradeLevel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvSubjectGradeLevel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvSubjectGradeLevel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSubjectGradeLevel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjectGradeLevel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSubjectGradeLevel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSubjectGradeLevel.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvSubjectGradeLevel.ThemeStyle.ReadOnly = false;
            this.dgvSubjectGradeLevel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvSubjectGradeLevel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSubjectGradeLevel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjectGradeLevel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubjectGradeLevel.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSubjectGradeLevel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvSubjectGradeLevel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.showSubjectDetailsToolStripMenuItem,
            this.showSubjectTeacherInfoToolStripMenuItem,
            this.whoTeacherItToolStripMenuItem,
            this.deleteToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(263, 124);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(262, 24);
            this.toolStripMenuItem1.Text = "Update Subject Grade Level";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // showSubjectDetailsToolStripMenuItem
            // 
            this.showSubjectDetailsToolStripMenuItem.Name = "showSubjectDetailsToolStripMenuItem";
            this.showSubjectDetailsToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.showSubjectDetailsToolStripMenuItem.Text = "Show Subject Details ";
            this.showSubjectDetailsToolStripMenuItem.Click += new System.EventHandler(this.showSubjectDetailsToolStripMenuItem_Click);
            // 
            // showSubjectTeacherInfoToolStripMenuItem
            // 
            this.showSubjectTeacherInfoToolStripMenuItem.Name = "showSubjectTeacherInfoToolStripMenuItem";
            this.showSubjectTeacherInfoToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.showSubjectTeacherInfoToolStripMenuItem.Text = "Show Subject Teacher Info ";
            this.showSubjectTeacherInfoToolStripMenuItem.Click += new System.EventHandler(this.showSubjectTeacherInfoToolStripMenuItem_Click);
            // 
            // whoTeacherItToolStripMenuItem
            // 
            this.whoTeacherItToolStripMenuItem.Name = "whoTeacherItToolStripMenuItem";
            this.whoTeacherItToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.whoTeacherItToolStripMenuItem.Text = "Who Teacher it ";
            this.whoTeacherItToolStripMenuItem.Click += new System.EventHandler(this.whoTeacherItToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.deleteToolStripMenuItem.Text = "Delete  Subject Grade ";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BorderThickness = 2;
            this.btnAddClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddClass.FillColor = System.Drawing.Color.Transparent;
            this.btnAddClass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.Color.Black;
            this.btnAddClass.Location = new System.Drawing.Point(811, 99);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(155, 48);
            this.btnAddClass.TabIndex = 5;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // frmListSubjectGradeLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 613);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.dgvSubjectGradeLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListSubjectGradeLevel";
            this.Text = "frmListSubjectGradeLevel";
            this.Load += new System.EventHandler(this.frmListSubjectGradeLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectGradeLevel)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvSubjectGradeLevel;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showSubjectDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSubjectTeacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoTeacherItToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddClass;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}