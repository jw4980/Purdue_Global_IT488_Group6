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
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private async void AddInventory_Load(object sender, EventArgs e)
        {
            inventoryBindingSource.DataSource = new inventory();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            eBITEntities db = new eBITEntities();
            db.inventories.Add(inventoryBindingSource.Current as inventory);
            int result = await db.SaveChangesAsync();
            if (result > 0)
                MessageBox.Show("Data has been entered successfully");
        }

        private void category_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
