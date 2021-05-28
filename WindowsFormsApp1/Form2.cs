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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Form = new Form4();
            Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Form = new Form5();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Form = new Form6();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 Form = new Form7();
            Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 Form = new Form8();
            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 Form = new Form9();
            Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 Form = new Form10();
            Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 Form = new Form11();
            Form.Show();
        }
    }
}
