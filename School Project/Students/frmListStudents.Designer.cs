namespace School_Project
{
    partial class frmListStudents
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
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showStudentsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.AllowUserToOrderColumns = true;
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.dgvAllUsers.GridColor = System.Drawing.Color.White;
            this.dgvAllUsers.Location = new System.Drawing.Point(2, 130);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.RowTemplate.Height = 24;
            this.dgvAllUsers.Size = new System.Drawing.Size(943, 321);
            this.dgvAllUsers.TabIndex = 0;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStudentsInfoToolStripMenuItem,
            this.updateStudentsToolStripMenuItem,
            this.deleteStudentsToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(210, 76);
            // 
            // showStudentsInfoToolStripMenuItem
            // 
            this.showStudentsInfoToolStripMenuItem.Name = "showStudentsInfoToolStripMenuItem";
            this.showStudentsInfoToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.showStudentsInfoToolStripMenuItem.Text = "Show Students Info ";
            this.showStudentsInfoToolStripMenuItem.Click += new System.EventHandler(this.showStudentsInfoToolStripMenuItem_Click);
            // 
            // updateStudentsToolStripMenuItem
            // 
            this.updateStudentsToolStripMenuItem.Name = "updateStudentsToolStripMenuItem";
            this.updateStudentsToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.updateStudentsToolStripMenuItem.Text = "Update Students ";
            this.updateStudentsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentsToolStripMenuItem_Click);
            // 
            // deleteStudentsToolStripMenuItem
            // 
            this.deleteStudentsToolStripMenuItem.Name = "deleteStudentsToolStripMenuItem";
            this.deleteStudentsToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.deleteStudentsToolStripMenuItem.Text = "Delete Students ";
            this.deleteStudentsToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentsToolStripMenuItem_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.FillColor = System.Drawing.Color.White;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(845, 59);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(59, 45);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "guna2Button1";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // frmListStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.dgvAllUsers);
            this.Name = "frmListStudents";
            this.Text = "frmListStudents";
            this.Load += new System.EventHandler(this.frmListStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllUsers;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showStudentsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentsToolStripMenuItem;
    }
}