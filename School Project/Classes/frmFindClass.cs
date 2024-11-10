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
    public partial class frmFindClass : Form
    {

        public Action<int?> DataBack;


        public frmFindClass()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           // DataBack?.Invoke(ctrlClassCardWithFilter1.ClassID);
        }

        private void ctrlClassCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DataBack?.Invoke(ctrlClassCardWithFilter1.ClassID);
        }
    }
}
