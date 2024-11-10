namespace School_Project
{
    partial class ctrlTeacherCardWithFilter
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
            this.ctrlTeacherCard1 = new School_Project.ctrlTeacherCard();
            this.ctrlFilter1 = new School_Project.ctrlFilter();
            this.SuspendLayout();
            // 
            // ctrlTeacherCard1
            // 
            this.ctrlTeacherCard1.Location = new System.Drawing.Point(6, 129);
            this.ctrlTeacherCard1.Name = "ctrlTeacherCard1";
            this.ctrlTeacherCard1.Size = new System.Drawing.Size(940, 705);
            this.ctrlTeacherCard1.TabIndex = 5;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlFilter1.FilterEnabled = true;
            this.ctrlFilter1.Location = new System.Drawing.Point(6, 3);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.ShowAddPersonButton = true;
            this.ctrlFilter1.Size = new System.Drawing.Size(937, 123);
            this.ctrlFilter1.TabIndex = 6;
            this.ctrlFilter1.TextSearch = "";
            this.ctrlFilter1.OnFindNumericClick += new System.EventHandler<School_Project.ctrlFilter.FindNumericClickEventArgs>(this.ctrlFilter1_OnFindNumericClick);
            // 
            // ctrlTeacherCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlFilter1);
            this.Controls.Add(this.ctrlTeacherCard1);
            this.Name = "ctrlTeacherCardWithFilter";
            this.Size = new System.Drawing.Size(946, 834);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlTeacherCard ctrlTeacherCard1;
        private ctrlFilter ctrlFilter1;
    }
}
