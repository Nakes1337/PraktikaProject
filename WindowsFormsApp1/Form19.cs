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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void рейсыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рейсыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportCompanyDataSet);

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.transportCompanyDataSet.Рейсы);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.AddNew();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.RemoveCurrent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.рейсыBindingSource.EndEdit();
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

