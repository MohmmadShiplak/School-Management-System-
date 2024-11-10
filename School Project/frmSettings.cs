using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class frmSettings : Form
    {

        frmLogin _frmLogin;


      private void ShowSchoolSettingsFromConfigFile()
        {

            lblOpeningTime.Text = ConfigurationManager.AppSettings["SchoolOpeningTime"] ?? "N/A";
            lblClosingTime.Text = ConfigurationManager.AppSettings["SchoolClosingTime"] ?? "N/A";
            lblWorkingDays.Text = ConfigurationManager.AppSettings["Working Days"] ?? "N/A";
            lblholidays.Text = ConfigurationManager.AppSettings["holidays"] ?? "N/A";

        }
      
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            ShowSchoolSettingsFromConfigFile();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUsersInfo frm1 = new frmShowUsersInfo(clsGlobal.CurrentUser.UserID);
            frm1.ShowDialog();  
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm1 = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm1.ShowDialog();  
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
           _frmLogin.ShowDialog();
            this.Close();
        }
    }
}
