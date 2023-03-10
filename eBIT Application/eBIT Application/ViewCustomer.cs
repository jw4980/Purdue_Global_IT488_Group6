using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using eBIT_Application;
using System.Runtime.Remoting;

namespace eBIT_Customers
{
    public partial class ViewCustomer : Form
    {
       eBITDataSet _context = new eBITDataSet();

        public ViewCustomer()
        {
            InitializeComponent();
        }
       

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.customers' table. You can move, or remove it, as needed.
            this.customersDataGridView.Show();
            this.customersTableAdapter1.Fill(eBITDataSet.customers);
            
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(eBITDataSet.customers);
            customersDataGridView.Invalidate();
            customersDataGridView.Refresh();
        }
    }
}
