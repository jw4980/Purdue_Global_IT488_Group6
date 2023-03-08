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
    public partial class ProductCategoryReportForm : Form
    {
        public ProductCategoryReportForm()
        {
            InitializeComponent();
        }

        private void ProductCategoryReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.product_category' table. You can move, or remove it, as needed.
            this.product_categoryTableAdapter.Fill(this.eBITDataSet.product_category);

            this.ProductCategoryReport.RefreshReport();
        }
    }
}
