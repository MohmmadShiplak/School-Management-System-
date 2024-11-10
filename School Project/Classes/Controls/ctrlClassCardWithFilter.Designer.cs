namespace School_Project
{
    partial class ctrlClassCardWithFilter
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
            this.ctrlClassCard1 = new School_Project.ctrlClassCard();
            this.ctrlFilter1 = new School_Project.ctrlFilter();
            this.SuspendLayout();
            // 
            // ctrlClassCard1
            // 
            this.ctrlClassCard1.BackColor = System.Drawing.Color.White;
            this.ctrlClassCard1.Location = new System.Drawing.Point(3, 121);
            this.ctrlClassCard1.Name = "ctrlClassCard1";
            this.ctrlClassCard1.Size = new System.Drawing.Size(814, 221);
            this.ctrlClassCard1.TabIndex = 3;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlFilter1.FilterEnabled = true;
            this.ctrlFilter1.Location = new System.Drawing.Point(4, 4);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.ShowAddPersonButton = true;
            this.ctrlFilter1.Size = new System.Drawing.Size(817, 113);
            this.ctrlFilter1.TabIndex = 4;
            this.ctrlFilter1.TextSearch = "";
            this.ctrlFilter1.OnFindNumericClick += new System.EventHandler<School_Project.ctrlFilter.FindNumericClickEventArgs>(this.ctrlFilter1_OnFindNumericClick_1);
            // 
            // ctrlClassCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlFilter1);
            this.Controls.Add(this.ctrlClassCard1);
            this.Name = "ctrlClassCardWithFilter";
            this.Size = new System.Drawing.Size(821, 370);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlClassCard ctrlClassCard1;
        private ctrlFilter ctrlFilter1;
    }
}
