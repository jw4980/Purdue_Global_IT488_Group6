﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBIT_Application
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddInventory form = new AddInventory();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //inventoryDataGridView.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
