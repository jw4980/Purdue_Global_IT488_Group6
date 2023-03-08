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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void Userreportbutton_Click(object sender, EventArgs e)
        {
            UserReportForm userReportForm = new UserReportForm();
            userReportForm.Show();
        }

        private void inventoryreportbutton_Click(object sender, EventArgs e)
        {
            InventoryReport inventoryReportForm = new InventoryReport();
            inventoryReportForm.Show();
        }

        private void orderreportbutton_Click(object sender, EventArgs e)
        {
            OrderReportForm orderReportForm = new OrderReportForm();
            orderReportForm.Show();
        }

        private void customerreportbutton_Click(object sender, EventArgs e)
        {
            CustomerReportForm customerReport = new CustomerReportForm();
            customerReport.Show();
        }

        private void productcategoryreportbutton_Click(object sender, EventArgs e)
        {
            ProductCategoryReportForm productCategoryReportForm = new ProductCategoryReportForm();
            productCategoryReportForm.Show();
        }
    }
}
