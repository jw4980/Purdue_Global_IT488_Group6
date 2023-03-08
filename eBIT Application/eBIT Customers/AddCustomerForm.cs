using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.customer_contactTableAdapter.Fill(this.eBITCustomerDataSet.customer_contact);
            // TODO: This line of code loads data into the 'eBITCustomerDataSet.customer_address' table. You can move, or remove it, as needed.
            this.customer_addressTableAdapter.Fill(this.eBITCustomerDataSet.customer_address);
            // TODO: This line of code loads data into the 'eBITCustomerDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.eBITCustomerDataSet.customers);

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {

            //Application.Run(new ViewCustomer());
        }
    }
}
