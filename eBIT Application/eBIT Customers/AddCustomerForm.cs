using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//This was a prototype form for adding a new customer record to the database.
//


namespace eBIT_Customers
{
    public partial class AddCustomerForm : Form
    {
        eBITEntities db = new eBITEntities();
        public AddCustomerForm()
        {
            InitializeComponent();
        }
       
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            customersBindingSource.DataSource = new customer();            
            //customersTableAdapter.Fill(this.eBITCustomerDataSet.customers);
        }

        private async void btnAddCust_Click(object sender, EventArgs e)
        {
            db.customers.Add(customersBindingSource.Current as customer);
            int i = await db.SaveChangesAsync();
            if (i > 0) 
            {
                MessageBox.Show("Customer has been added successfully");
            }
        }
    }
}
