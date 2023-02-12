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
    public partial class formProduct : Form
    {
        public formProduct()
        {
            InitializeComponent();
        }

        private void formProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.eBITDataSet.inventory);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillBy(this.eBITDataSet.inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureAdd_Click(object sender, EventArgs e)
        {
            AddInventory addInventory = new AddInventory();
            addInventory.TopLevel = false;
            addInventory.FormBorderStyle = FormBorderStyle.None;
            addInventory.Dock = DockStyle.None;
            addInventory.BringToFront();
            addInventory.Show();

        }
    }
}
