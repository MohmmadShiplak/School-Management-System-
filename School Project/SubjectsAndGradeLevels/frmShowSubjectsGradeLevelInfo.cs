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
    public partial class frmShowSubjectsGradeLevelInfo : Form
    {
        public int? _SubjectGradeLevelID = null;

        public frmShowSubjectsGradeLevelInfo(int? SubjectGradeLevelID)
        {
            InitializeComponent();
            _SubjectGradeLevelID = SubjectGradeLevelID; 
        }

        private void frmShowSubjectsGradeLevelInfo_Load(object sender, EventArgs e)
        {
            ctrlSubjectGradeLevelCard1.LoadData(_SubjectGradeLevelID);
        }
    }
}
