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
    public partial class Form1 : Form
    {
        private MdiMainForm _parent;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            _parent = (MdiMainForm)this.ParentForm;
            _parent.x += 1.0;
            Form2 frmForm2 = new Form2();
            frmForm2.dt_update(_parent.x);
        }


        public void textbox1(string value)
        {
            textBox1.Text = value;
        }
    }
}
