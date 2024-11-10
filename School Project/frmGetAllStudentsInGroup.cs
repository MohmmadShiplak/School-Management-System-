using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class frmGetAllStudentsInGroup : Form
    {

        private int ?_GroupID = null;
        private string _GroupName = null;   

        public frmGetAllStudentsInGroup(int GroupID)
        {
            InitializeComponent();

            _GroupID = GroupID;
      //      _GroupName = GroupName;

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmGetAllStudentsInGroup_Load(object sender, EventArgs e)
        {

            ctrlGetAllStudentInGroup1.LoadAllStudentsInGroup(_GroupID);












        }
    }
}
