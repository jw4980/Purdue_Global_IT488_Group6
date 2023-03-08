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
    public partial class CustomerReportForm : Form
    {
        public CustomerReportForm()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.eBITDataSet.customers);
            this.CustomerReportViewer.RefreshReport();
        }
    }
}
