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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form32_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Отдел_Кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_КадровTableAdapter.Fill(this.transportCompanyDataSet.Отдел_Кадров);

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
                case 3:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
            {
                отдел_КадровDataGridView.Sort(Col,
                System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                отдел_КадровDataGridView.Sort(Col,
                System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            отдел_КадровBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < отдел_КадровDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < отдел_КадровDataGridView.RowCount; j++)
                {
                    отдел_КадровDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    отдел_КадровDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < отдел_КадровDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < отдел_КадровDataGridView.RowCount; j++)
                {
                    var value = отдел_КадровDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            отдел_КадровDataGridView.Rows[j].Cells[i].Style.BackColor =
                            Color.Aqua;
                            отдел_КадровDataGridView.Rows[j].Cells[i].Style.ForeColor =
                            Color.Blue;
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            отдел_КадровBindingSource.Filter = "Наименование_Должности='" + comboBox1.Text + "'";
        }
    }
}
