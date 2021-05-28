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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void грузыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.грузыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportCompanyDataSet);

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Грузы". При необходимости она может быть перемещена или удалена.
            this.грузыTableAdapter.Fill(this.transportCompanyDataSet.Грузы);

        }

        private void особенностиLabel_Click(object sender, EventArgs e)
        {

        }

        private void особенностиTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.грузыBindingSource.AddNew();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.грузыBindingSource.RemoveCurrent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.грузыBindingSource.EndEdit();
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
