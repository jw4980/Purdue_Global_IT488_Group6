using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBIT_Application
{
    public partial class AddUser : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=it488group6.database.windows.net;Initial Catalog=eBIT;User ID=JenniferW;Password=Password2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cm = new SqlCommand();
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnUserInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("Insert INTO dbo.users(first_name, last_name, email, user_name, password)VALUES(@first_name, @last_name, @email, @user_name, @password)", con);
                    cm.Parameters.AddWithValue("@first_name", txtUserFirst.Text);
                    cm.Parameters.AddWithValue("@last_name", txtUserLast.Text);
                    cm.Parameters.AddWithValue("@email", txtUserEmail.Text);
                    cm.Parameters.AddWithValue("@user_name", txtUserName.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }                
        public void Clear()
        {
            txtUserFirst.Clear();
            txtUserLast.Clear();
            txtUserEmail.Clear();
            txtPass.Clear();    
            txtUserName.Clear();
        }
            
    }
}
