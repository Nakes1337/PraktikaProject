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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void виды_АвтомобилейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_АвтомобилейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportCompanyDataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Виды_Автомобилей". При необходимости она может быть перемещена или удалена.
            this.виды_АвтомобилейTableAdapter.Fill(this.transportCompanyDataSet.Виды_Автомобилей);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.виды_АвтомобилейBindingSource.AddNew();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.виды_АвтомобилейBindingSource.RemoveCurrent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.виды_АвтомобилейBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.transportCompanyDataSet);
                MessageBox.Show("Update successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
