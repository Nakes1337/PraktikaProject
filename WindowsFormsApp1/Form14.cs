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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void вида_ГрузовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вида_ГрузовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportCompanyDataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Вида_Грузов". При необходимости она может быть перемещена или удалена.
            this.вида_ГрузовTableAdapter.Fill(this.transportCompanyDataSet.Вида_Грузов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.вида_ГрузовBindingSource.AddNew();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.вида_ГрузовBindingSource.RemoveCurrent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.вида_ГрузовBindingSource.EndEdit();
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
