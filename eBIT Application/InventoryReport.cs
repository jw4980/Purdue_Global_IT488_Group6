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
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }
     
        private void InventoryReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.eBITDataSet.inventory);
            this.InventoryReportViewer.RefreshReport();
        }

      

      
    }
}
