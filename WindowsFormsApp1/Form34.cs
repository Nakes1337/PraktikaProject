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
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Транспортировка". При необходимости она может быть перемещена или удалена.
            this.транспортировкаTableAdapter.Fill(this.transportCompanyDataSet.Транспортировка);
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
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
            }
            if (radioButton1.Checked)
            {
                транспортировкаDataGridView.Sort(Col,
                System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                транспортировкаDataGridView.Sort(Col,
                System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            транспортировкаBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < транспортировкаDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < транспортировкаDataGridView.RowCount; j++)
                {
                    транспортировкаDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    транспортировкаDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < транспортировкаDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < транспортировкаDataGridView.RowCount; j++)
                {
                    var value = транспортировкаDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            транспортировкаDataGridView.Rows[j].Cells[i].Style.BackColor =
                            Color.Aqua;
                            транспортировкаDataGridView.Rows[j].Cells[i].Style.ForeColor =
                            Color.Blue;
                        }
                    }
                }
            }
        }
    }
}
