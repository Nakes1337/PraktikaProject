﻿using System;
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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void Form27_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Отдел_Кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_КадровTableAdapter.Fill(this.transportCompanyDataSet.Отдел_Кадров);

        }

        private void фИОLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
