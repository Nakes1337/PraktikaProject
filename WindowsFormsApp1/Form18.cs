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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void марки_АвтомобилейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.марки_АвтомобилейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportCompanyDataSet);

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Марки_Автомобилей". При необходимости она может быть перемещена или удалена.
            this.марки_АвтомобилейTableAdapter.Fill(this.transportCompanyDataSet.Марки_Автомобилей);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.марки_АвтомобилейBindingSource.AddNew();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.марки_АвтомобилейBindingSource.RemoveCurrent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.марки_АвтомобилейBindingSource.EndEdit();
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
