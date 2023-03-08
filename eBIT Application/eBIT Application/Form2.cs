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
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }

        private async void AddSale_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = new order();
        }

        private async void button_addsale_Click(object sender, EventArgs e)
        {
            eBITEntities db = new eBITEntities();
            db.orders.Add(orderBindingSource.Current as order);
            int result = await db.SaveChangesAsync();
            if (result > 0)
                MessageBox.Show("Data has been entered successfully");
        }
    }
}
