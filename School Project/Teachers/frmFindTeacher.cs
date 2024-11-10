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
    public partial class frmFindTeacher : Form
    {

        public Action<int?> TeacherDataBack;


        public frmFindTeacher()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TeacherDataBack?.Invoke(ctrlTeacherCardWithFilter1.TeacherID);
        }

        private void frmFindTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
