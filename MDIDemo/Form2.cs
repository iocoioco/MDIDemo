using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MDIDemo
{
    public partial class Form2 : Form
    {
        private MdiMainForm _parent;
        private Form2 _form2;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            _parent = (MdiMainForm)this.ParentForm;

            _parent.x += 1.0;

            dt_update(_parent.x);
        }


        public void dt_update(double x) //
        {
            _parent = (MdiMainForm)this.ParentForm;

            _parent.x += 1.0;// When called from MDIMainForm.dt_update() '개체 참조가 개체의 인스턴스로 설정되지 않았습니다.'

            int a = g.a++;

            dt = new DataTable(); // dt.Clear();
            dt.Columns.Add("A");
            dt.Columns.Add("B");
            dt.Columns.Add("C");

            for (int i = 0; i < 2; i++)
            {
                dt.Rows.Add("1", "2", "3");
            }

            dt.Rows[0][0] = g.a;

            dataGridView1.DataSource = dt;
        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string value = Convert.ToString(dt.Rows[e.RowIndex][e.ColumnIndex]);
            textBox1.Text = value;

            _parent.textbox1(value);
            //_form2.textbox1(value); // Error
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
