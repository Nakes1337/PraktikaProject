using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Frm = new Form2();
            Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 Frm = new Form12();
            Frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form22 frm = new Form22();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form23 frm = new Form23();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form24 frm = new Form24();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form35 frm = new Form35();
            frm.Show();
        }
    }
}
