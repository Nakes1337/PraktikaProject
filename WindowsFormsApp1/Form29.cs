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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportCompanyDataSet.Транспортировка". При необходимости она может быть перемещена или удалена.
            this.транспортировкаTableAdapter.Fill(this.transportCompanyDataSet.Транспортировка);

        }
    }
}
