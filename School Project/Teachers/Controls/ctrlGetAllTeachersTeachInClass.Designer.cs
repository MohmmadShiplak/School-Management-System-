namespace School_Project
{
    partial class ctrlGetAllTeachersTeachInClass
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
            this.ctrlSubList1 = new School_Project.ctrlSubList();
            this.SuspendLayout();
            // 
            // ctrlSubList1
            // 
            this.ctrlSubList1.BackColor = System.Drawing.Color.White;
            this.ctrlSubList1.Location = new System.Drawing.Point(0, 0);
            this.ctrlSubList1.Name = "ctrlSubList1";
            this.ctrlSubList1.Size = new System.Drawing.Size(1255, 413);
            this.ctrlSubList1.TabIndex = 0;
            this.ctrlSubList1.Title = "Title";
            // 
            // ctrlGetAllTeachersTeachInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlSubList1);
            this.Name = "ctrlGetAllTeachersTeachInClass";
            this.Size = new System.Drawing.Size(1258, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSubList ctrlSubList1;
    }
}
