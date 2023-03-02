using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBIT_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                ProductForm newMDIChild = new ProductForm();
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Show();
            }
            else
            {
                ProductForm newMDIChild = new ProductForm();
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Show();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                UserForm newMDIChild = new UserForm();
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
            else
            {
                UserForm newMDIChild = new UserForm();
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }

        
    }
}
