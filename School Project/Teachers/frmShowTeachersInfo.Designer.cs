namespace School_Project
{
    partial class frmShowTeachersInfo
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
            this.ctrlTeacherCard1 = new School_Project.ctrlTeacherCard();
            this.SuspendLayout();
            // 
            // ctrlTeacherCard1
            // 
            this.ctrlTeacherCard1.Location = new System.Drawing.Point(-7, -4);
            this.ctrlTeacherCard1.Name = "ctrlTeacherCard1";
            this.ctrlTeacherCard1.Size = new System.Drawing.Size(799, 757);
            this.ctrlTeacherCard1.TabIndex = 0;
            // 
            // frmShowTeachersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 755);
            this.Controls.Add(this.ctrlTeacherCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowTeachersInfo";
            this.Text = "frmShowTeachersInfo";
            this.Load += new System.EventHandler(this.frmShowTeachersInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTeacherCard ctrlTeacherCard1;
    }
}