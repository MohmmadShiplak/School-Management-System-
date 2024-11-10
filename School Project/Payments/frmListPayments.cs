using SchoolBusiness;
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
    public partial class frmListPayments : Form
    {


        private DataTable _dtPayments;

        public frmListPayments()
        {
            InitializeComponent();
        }

        private void frmListPayments_Load(object sender, EventArgs e)
        {

           _dtPayments=clsPayments.GetAllPayments();
            dgvPayments.DataSource = _dtPayments;

            dgvPayments.Columns[0].HeaderText = "Payment ID";
            dgvPayments.Columns[0].Width = 120;

            dgvPayments.Columns[1].HeaderText = "Student Name";
            dgvPayments.Columns[1].Width = 130;

            dgvPayments.Columns[2].HeaderText = "Amount Paid";
            dgvPayments.Columns[2].Width = 140;

            dgvPayments.Columns[3].HeaderText = "Payment Date";
            dgvPayments.Columns[3].Width = 150;




        }

        private void studentsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PaymentID = (int)dgvPayments.CurrentRow.Cells[0].Value;


            frmShowStudentsInfo frm1 = new frmShowStudentsInfo(PaymentID);
            frm1.ShowDialog();

        }

        private void subjectGradeLevelDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PaymentID = (int)dgvPayments.CurrentRow.Cells[0].Value;


            frmShowSubjectsGradeLevelInfo frm1=new frmShowSubjectsGradeLevelInfo(PaymentID);    
            frm1.ShowDialog();

        }
    }
}
