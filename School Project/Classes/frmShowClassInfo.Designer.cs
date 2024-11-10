namespace School_Project
{
    partial class frmShowClassInfo
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
            this.ctrlClassCard1 = new School_Project.ctrlClassCard();
            this.SuspendLayout();
            // 
            // ctrlClassCard1
            // 
            this.ctrlClassCard1.BackColor = System.Drawing.Color.White;
            this.ctrlClassCard1.Location = new System.Drawing.Point(-5, 0);
            this.ctrlClassCard1.Name = "ctrlClassCard1";
            this.ctrlClassCard1.Size = new System.Drawing.Size(1217, 290);
            this.ctrlClassCard1.TabIndex = 0;
            // 
            // frmShowClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 358);
            this.Controls.Add(this.ctrlClassCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowClassInfo";
            this.Text = "frmShowClassInfo";
            this.Load += new System.EventHandler(this.frmShowClassInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlClassCard ctrlClassCard1;
    }
}