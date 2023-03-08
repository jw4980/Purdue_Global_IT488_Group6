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
    public partial class OrderReportForm : Form
    {
        public OrderReportForm()
        {
            InitializeComponent();
        }

        private void OrderReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.eBITDataSet.orders);

            this.OrderReportViewer.RefreshReport();
        }

    }
}
