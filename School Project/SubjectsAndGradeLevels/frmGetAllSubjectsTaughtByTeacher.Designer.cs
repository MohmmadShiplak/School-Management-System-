namespace School_Project
{
    partial class frmGetAllSubjectsTaughtByTeacher
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
            this.ctrlGetAllSubjectsTaughtByTeacher1 = new School_Project.ctrlGetAllSubjectsTaughtByTeacher();
            this.ctrlTeacherCard1 = new School_Project.ctrlTeacherCard();
            this.SuspendLayout();
            // 
            // ctrlGetAllSubjectsTaughtByTeacher1
            // 
            this.ctrlGetAllSubjectsTaughtByTeacher1.BackColor = System.Drawing.Color.White;
            this.ctrlGetAllSubjectsTaughtByTeacher1.Location = new System.Drawing.Point(-4, 575);
            this.ctrlGetAllSubjectsTaughtByTeacher1.Name = "ctrlGetAllSubjectsTaughtByTeacher1";
            this.ctrlGetAllSubjectsTaughtByTeacher1.Size = new System.Drawing.Size(1686, 298);
            this.ctrlGetAllSubjectsTaughtByTeacher1.TabIndex = 1;
            // 
            // ctrlTeacherCard1
            // 
            this.ctrlTeacherCard1.Location = new System.Drawing.Point(-4, 2);
            this.ctrlTeacherCard1.Name = "ctrlTeacherCard1";
            this.ctrlTeacherCard1.Size = new System.Drawing.Size(1686, 615);
            this.ctrlTeacherCard1.TabIndex = 0;
            // 
            // frmGetAllSubjectsTaughtByTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1694, 781);
            this.Controls.Add(this.ctrlGetAllSubjectsTaughtByTeacher1);
            this.Controls.Add(this.ctrlTeacherCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGetAllSubjectsTaughtByTeacher";
            this.Text = "GetAllSubjectsTaughtByTeacher";
            this.Load += new System.EventHandler(this.frmGetAllSubjectsTaughtByTeacher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTeacherCard ctrlTeacherCard1;
        private ctrlGetAllSubjectsTaughtByTeacher ctrlGetAllSubjectsTaughtByTeacher1;
    }
}