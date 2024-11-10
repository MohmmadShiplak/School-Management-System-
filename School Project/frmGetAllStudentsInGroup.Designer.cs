namespace School_Project
{
    partial class frmGetAllStudentsInGroup
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
            this.ctrlGetAllStudentInGroup1 = new School_Project.ctrlGetAllStudentInGroup();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlGetAllStudentInGroup1
            // 
            this.ctrlGetAllStudentInGroup1.BackColor = System.Drawing.Color.White;
            this.ctrlGetAllStudentInGroup1.Location = new System.Drawing.Point(3, 133);
            this.ctrlGetAllStudentInGroup1.Name = "ctrlGetAllStudentInGroup1";
            this.ctrlGetAllStudentInGroup1.Size = new System.Drawing.Size(1024, 403);
            this.ctrlGetAllStudentInGroup1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.lblTitle.Location = new System.Drawing.Point(47, 32);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(883, 66);
            this.lblTitle.TabIndex = 222;
            this.lblTitle.Text = "Students are in a Group";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // frmGetAllStudentsInGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 563);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlGetAllStudentInGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGetAllStudentsInGroup";
            this.Text = "frmGetAllStudentsInGroup";
            this.Load += new System.EventHandler(this.frmGetAllStudentsInGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlGetAllStudentInGroup ctrlGetAllStudentInGroup1;
        private System.Windows.Forms.Label lblTitle;
    }
}