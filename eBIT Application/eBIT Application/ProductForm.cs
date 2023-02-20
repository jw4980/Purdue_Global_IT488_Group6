using System;
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

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBITDataSet);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.eBITDataSet.inventory);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddInventory form = new AddInventory();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            inventoryDataGridView.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
