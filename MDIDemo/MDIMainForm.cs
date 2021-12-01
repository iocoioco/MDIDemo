using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIDemo
{
    public partial class MdiMainForm : Form
    {
        public double x = 100.0;
        public MdiMainForm()
        {
            InitializeComponent();
        }

        public void textbox1(string value)
        {
            textBox1.Text = value;
        }

        Form1 frmForm1;
        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmForm1 == null)
            {
                frmForm1 = new Form1();
                frmForm1.MdiParent = this;
                frmForm1.Show();
            }
            else
                frmForm1.Activate();

        }

        Form2 frmForm2;
        /*
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmForm2 == null)
            {
                frmForm2 = new Form2();
                frmForm2.MdiParent = this;
                frmForm2.Show();

            }
            else
                frmForm2.Activate();

        }
        */


        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test();
        }
        
        private void MdiMainForm_Load(object sender, EventArgs e)
        {

        }

        public void test()
        {
            Form2 frmForm2 = new Form2();
            frmForm2.MdiParent = this;
            frmForm2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
