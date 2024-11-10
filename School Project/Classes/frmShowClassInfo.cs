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
    public partial class frmShowClassInfo : Form
    {

        private int ?_ClassID = null;

        public frmShowClassInfo(int ClassID )
        {
            InitializeComponent();
            _ClassID = ClassID;
        }

        private void frmShowClassInfo_Load(object sender, EventArgs e)
        {
            ctrlClassCard1.LoadClassInfoByClassID(_ClassID);
        }
    }
}
