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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form30 frm = new Form30();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form31 frm = new Form31();
             frm.Show();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form32 frm = new Form32();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form33 frm = new Form33();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form34 frm = new Form34();
            frm.Show();
        }
    }
}
