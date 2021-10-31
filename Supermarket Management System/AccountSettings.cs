using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e) //goes back to admin dashboard
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void AccountSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void update_Click(object sender, EventArgs e) //updates account settings
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "UPDATE EmployeeTable SET Name='" + name.Text + "',Password='" + password.Text + "'   WHERE Position='Admin'";



            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("UPDATED");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
       
        }
    }

