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
    public partial class frmShowStudentsInfo : Form
    {

        public int _StudentID = -1;

        public frmShowStudentsInfo(int StudentID)
        {
            InitializeComponent();

            _StudentID = StudentID;
        }

        private void frmShowStudentsInfo_Load(object sender, EventArgs e)
        {

           ctrlStudentCard1.LoadStudentsInfoByStudentID(_StudentID);    

        }
    }
}
