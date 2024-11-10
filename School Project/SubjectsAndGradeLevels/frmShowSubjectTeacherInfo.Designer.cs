namespace School_Project
{
    partial class frmShowSubjectTeacherInfo
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
            this.ctrlSubjectTeacherCard1 = new School_Project.ctrlSubjectTeacherCard();
            this.SuspendLayout();
            // 
            // ctrlSubjectTeacherCard1
            // 
            this.ctrlSubjectTeacherCard1.Location = new System.Drawing.Point(-3, -2);
            this.ctrlSubjectTeacherCard1.Name = "ctrlSubjectTeacherCard1";
            this.ctrlSubjectTeacherCard1.Size = new System.Drawing.Size(799, 262);
            this.ctrlSubjectTeacherCard1.TabIndex = 0;
            // 
            // frmShowSubjectTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.ctrlSubjectTeacherCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowSubjectTeacherInfo";
            this.Text = "frmShowSubjectTeacherInfo";
            this.Load += new System.EventHandler(this.frmShowSubjectTeacherInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSubjectTeacherCard ctrlSubjectTeacherCard1;
    }
}