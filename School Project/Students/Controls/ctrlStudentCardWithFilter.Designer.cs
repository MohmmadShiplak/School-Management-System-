namespace School_Project
{
    partial class ctrlStudentCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlStudentCard1 = new School_Project.ctrlStudentCard();
            this.ctrlFilter1 = new School_Project.ctrlFilter();
            this.SuspendLayout();
            // 
            // ctrlStudentCard1
            // 
            this.ctrlStudentCard1.BackColor = System.Drawing.Color.White;
            this.ctrlStudentCard1.Location = new System.Drawing.Point(3, 118);
            this.ctrlStudentCard1.Name = "ctrlStudentCard1";
            this.ctrlStudentCard1.Size = new System.Drawing.Size(913, 592);
            this.ctrlStudentCard1.TabIndex = 5;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlFilter1.FilterEnabled = true;
            this.ctrlFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.ShowAddPersonButton = true;
            this.ctrlFilter1.Size = new System.Drawing.Size(913, 113);
            this.ctrlFilter1.TabIndex = 6;
            this.ctrlFilter1.TextSearch = "";
            this.ctrlFilter1.OnFindNumericClick += new System.EventHandler<School_Project.ctrlFilter.FindNumericClickEventArgs>(this.ctrlFilter1_OnFindNumericClick);
            // 
            // ctrlStudentCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlFilter1);
            this.Controls.Add(this.ctrlStudentCard1);
            this.Name = "ctrlStudentCardWithFilter";
            this.Size = new System.Drawing.Size(920, 713);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlStudentCard ctrlStudentCard1;
        private ctrlFilter ctrlFilter1;
    }
}
