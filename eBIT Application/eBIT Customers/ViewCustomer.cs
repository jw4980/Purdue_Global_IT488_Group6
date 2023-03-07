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

namespace eBIT_Customers
{
    public partial class ViewCustomer : Form
    {
        eBITEntities _context = new eBITEntities();

        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            customersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(eBITCustomerDataSet);

            // Save the changes to the database.
            _context.SaveChanges();

            customersDataGridView.Refresh();
           
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            // TODO: This line of code loads data into the 'eBITCustomerDataSet.customer_contact' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'eBITCustomerDataSet.customer_address' table. You can move, or remove it, as needed.

            _context.customers.Load();

            this.customersBindingSource.DataSource =
                _context.customers.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _context.Dispose();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Application.Run(new AddCustomerForm());
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
