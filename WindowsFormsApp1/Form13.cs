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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void автомобилиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобилиBindingSource.EndEdit();
            _ = tableAdapterManager.UpdateAll(transportCompanyDataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.transportCompanyDataSet.Автомобили);

        }

        private void дата_Последнего_ТОLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.автомобилиBindingSource.AddNew();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.автомобилиBindingSource.RemoveCurrent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.автомобилиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.transportCompanyDataSet);
                MessageBox.Show("Update successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
