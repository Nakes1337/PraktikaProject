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
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Перевозимые_грузы". При необходимости она может быть перемещена или удалена.
            this.перевозимые_грузыTableAdapter.Fill(this.transportCompanyDataSet.Перевозимые_грузы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = default;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
            }
            if (radioButton1.Checked)
            {
                перевозимые_грузыDataGridView.Sort(Col,
                System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                перевозимые_грузыDataGridView.Sort(Col,
                System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            перевозимые_грузыBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < перевозимые_грузыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < перевозимые_грузыDataGridView.RowCount; j++)
                {
                    перевозимые_грузыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    перевозимые_грузыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < перевозимые_грузыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < перевозимые_грузыDataGridView.RowCount; j++)
                {
                    var value = перевозимые_грузыDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            перевозимые_грузыDataGridView.Rows[j].Cells[i].Style.BackColor =
                            Color.Aqua;
                            перевозимые_грузыDataGridView.Rows[j].Cells[i].Style.ForeColor =
                            Color.Blue;
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            перевозимые_грузыBindingSource.Filter = "Expr1='" + comboBox1.Text + "'";
        }
    }
}
