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
    public partial class frmShowTeachersInfo : Form
    {

        public int _TeacherID = -1;

        public frmShowTeachersInfo(int TeacherID)
        {
            InitializeComponent();
            _TeacherID = TeacherID;
        }

        private void frmShowTeachersInfo_Load(object sender, EventArgs e)
        {
            ctrlTeacherCard1.LoadTeacherInfoByTeacherID(_TeacherID);
        }
    }
}
