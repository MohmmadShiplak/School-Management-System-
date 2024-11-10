namespace School_Project
{
    partial class frmListUsers
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
            this.cmUsers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvGetAllUsers = new System.Windows.Forms.DataGridView();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cmUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmUsers
            // 
            this.cmUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.updateUsersToolStripMenuItem,

            this.deleteUsersToolStripMenuItem});
            this.cmUsers.Name = "cmUsers";
            this.cmUsers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmUsers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmUsers.RenderStyle.ColorTable = null;
            this.cmUsers.RenderStyle.RoundedEdges = true;
            this.cmUsers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmUsers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmUsers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmUsers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmUsers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmUsers.Size = new System.Drawing.Size(211, 104);
           
            // 
            // updateUsersToolStripMenuItem
            // 
            this.updateUsersToolStripMenuItem.Name = "updateUsersToolStripMenuItem";
            this.updateUsersToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.updateUsersToolStripMenuItem.Text = "Update Users";
            this.updateUsersToolStripMenuItem.Click += new System.EventHandler(this.updateUsersToolStripMenuItem_Click);
            // 
            // deleteUsersToolStripMenuItem
            // 
            this.deleteUsersToolStripMenuItem.Name = "deleteUsersToolStripMenuItem";
            this.deleteUsersToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.deleteUsersToolStripMenuItem.Text = "Delete Users";
            this.deleteUsersToolStripMenuItem.Click += new System.EventHandler(this.deleteUsersToolStripMenuItem_Click);
            // 
            // dgvGetAllUsers
            // 
            this.dgvGetAllUsers.AllowUserToAddRows = false;
            this.dgvGetAllUsers.AllowUserToDeleteRows = false;
            this.dgvGetAllUsers.AllowUserToOrderColumns = true;
            this.dgvGetAllUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvGetAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAllUsers.ContextMenuStrip = this.cmUsers;
            this.dgvGetAllUsers.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetAllUsers.Location = new System.Drawing.Point(1, 172);
            this.dgvGetAllUsers.Name = "dgvGetAllUsers";
            this.dgvGetAllUsers.ReadOnly = true;
            this.dgvGetAllUsers.RowHeadersWidth = 51;
            this.dgvGetAllUsers.RowTemplate.Height = 24;
            this.dgvGetAllUsers.Size = new System.Drawing.Size(1075, 282);
            this.dgvGetAllUsers.TabIndex = 1;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem1.Text = "Show Users Info ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(921, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 48);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Class";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvGetAllUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListUsers";
            this.Text = "frmListUsers";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            this.cmUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmUsers;
        private System.Windows.Forms.ToolStripMenuItem updateUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUsersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvGetAllUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}