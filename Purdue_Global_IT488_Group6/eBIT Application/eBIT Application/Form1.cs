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

        private void AddInventory_Load(object sender, EventArgs e)
        {
            inventoryBindingSource.DataSource = new inventory();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((inventoryBindingSource.Current as inventory).sale_end.ToString().Contains("1/1/0001") ||
                (inventoryBindingSource.Current as inventory).sale_start.ToString().Contains("1/1/0001") 
                 ){
                MessageBox.Show("Error: one or both date inputs are invalid");
                return;
            }

            eBITEntities db = new eBITEntities();
            db.inventories.Add(inventoryBindingSource.Current as inventory);
            int result = db.SaveChanges();
            if (result > 0)
                MessageBox.Show("Data has been entered successfully");
        }

       
    }
}
