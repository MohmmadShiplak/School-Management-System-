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
    public partial class frmShowSubjectTeacherInfo : Form
    {
        private int ?_SubjectTeacherID = null;


        public frmShowSubjectTeacherInfo(int? SubjectTeacherID)
        {
            InitializeComponent();
            _SubjectTeacherID = SubjectTeacherID;   
        }

        private void frmShowSubjectTeacherInfo_Load(object sender, EventArgs e)
        {
            ctrlSubjectTeacherCard1.LoadSubjectTeacherInfo(_SubjectTeacherID);
        }
    }
}
