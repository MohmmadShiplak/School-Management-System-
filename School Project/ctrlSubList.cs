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
    public partial class ctrlSubList : UserControl
    {
        public ctrlSubList()
        {
            InitializeComponent();
        }
        private int? _value = null;

        public string Title
        {
            get => gbList.Text;
            set => gbList.Text = value;
        }

        public int RowsCount => dgvList.Rows.Count;


        private void _RefreshAllTeachersTeachSubjectList(object dataSource,
            (string columnName, int width)[] columns = null)
        {
            dgvList.DataSource = dataSource;

            lblNumberOfRecords.Text = dgvList.Rows.Count.ToString();

            if (columns == null || dgvList.Rows.Count == 0)
                return;

            for (int i = 0; i < columns.Length; i++)
            {
                dgvList.Columns[i].HeaderText = columns[i].columnName;
                dgvList.Columns[i].Width = columns[i].width;
            }
        }
        public void LoadInfo(int? value, object dataSource, (string columnName, int width)[] columns)
        {
            _value = value;

            _RefreshAllTeachersTeachSubjectList(dataSource, columns);
        }

        private void ctrlSubList_Load(object sender, EventArgs e)
        {

        }
    }
}
