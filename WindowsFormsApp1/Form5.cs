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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Вида_Грузов". При необходимости она может быть перемещена или удалена.
            this.вида_ГрузовTableAdapter.Fill(this.transportCompanyDataSet.Вида_Грузов);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = default;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = кодВидаГрузаDataGridViewTextBoxColumn;
                    break;
                case 1:
                    Col = наименованиеDataGridViewTextBoxColumn;
                    break;
                case 2:
                    Col = кодВидаАвтомобиляДляТранспортировкиDataGridViewTextBoxColumn;
                    break;
                case 3:
                    Col = описаниеDataGridViewTextBoxColumn;
                    break;
            }
            if (radioButton1.Checked)
            {
                dataGridView1.Sort(Col,
                System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                dataGridView1.Sort(Col,
                System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            вида_ГрузовBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (j = 0; j < dataGridView1.RowCount; j++)
                {
                    var value = dataGridView1.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            dataGridView1.Rows[j].Cells[i].Style.BackColor =
                            Color.Aqua;
                            dataGridView1.Rows[j].Cells[i].Style.ForeColor =
                            Color.Blue;
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
