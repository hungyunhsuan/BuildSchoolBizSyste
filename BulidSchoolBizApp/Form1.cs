﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulidSchoolBizApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSalesManForm form = new AddSalesManForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProcurementForm form = new AddProcurementForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddSellingForm form = new AddSellingForm();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QueryStockForm form = new QueryStockForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuerySellingBySalesForm form = new QuerySellingBySalesForm();
            form.ShowDialog();
        }
    }
}
