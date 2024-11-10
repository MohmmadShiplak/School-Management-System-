namespace School_Project
{
    partial class frmShowSubjectsGradeLevelInfo
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
            this.ctrlSubjectGradeLevelCard1 = new School_Project.ctrlSubjectGradeLevelCard();
            this.SuspendLayout();
            // 
            // ctrlSubjectGradeLevelCard1
            // 
            this.ctrlSubjectGradeLevelCard1.BackColor = System.Drawing.Color.White;
            this.ctrlSubjectGradeLevelCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlSubjectGradeLevelCard1.Name = "ctrlSubjectGradeLevelCard1";
            this.ctrlSubjectGradeLevelCard1.Size = new System.Drawing.Size(798, 303);
            this.ctrlSubjectGradeLevelCard1.TabIndex = 0;
            // 
            // frmShowSubjectsGradeLevelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.ctrlSubjectGradeLevelCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowSubjectsGradeLevelInfo";
            this.Text = "Show Subjects Grade Level Info";
            this.Load += new System.EventHandler(this.frmShowSubjectsGradeLevelInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSubjectGradeLevelCard ctrlSubjectGradeLevelCard1;
    }
}