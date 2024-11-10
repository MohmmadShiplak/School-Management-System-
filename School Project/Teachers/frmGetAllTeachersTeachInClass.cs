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
    public partial class frmGetAllTeachersTeachInClass : Form
    {

        private int? _ClassID = null;


        public frmGetAllTeachersTeachInClass(int? ClassID)
        {
            InitializeComponent();
            _ClassID = ClassID; 
        }

        private void frmGetAllTeachersTeachInClass_Load(object sender, EventArgs e)
        {
            ctrlGetAllTeachersTeachInClass1.LoadAllTeachersTeachSubject(_ClassID);
        }
    }
}
