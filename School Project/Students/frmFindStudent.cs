using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class frmFindStudent : Form
    {
        //this is Delegation 
        public Action<int?> StudentDataBack;

    //    private int _StudentID = -1;



        public frmFindStudent()
        {
            InitializeComponent();

        }

        private void frmFindStudent_Load(object sender, EventArgs e)
        {
           // ctrlStudentCard1.LoadStudentsInfoByStudentID(_StudentID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StudentDataBack?.Invoke( ctrlStudentCardWithFilter1.StudentID);
        }
    }
}
