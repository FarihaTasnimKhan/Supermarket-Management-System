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
    public partial class CashierAccountSetting : Form
    {
        public CashierAccountSetting()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CashierDashboard cd = new CashierDashboard();
            cd.Show();
            this.Hide();
        }

        private void CashierAccountSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "UPDATE EmployeeTable SET Name='" + name.Text + "',Password='" + password.Text + "'   WHERE Email='" + textBox1.Text + "' ";



            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                if (name.Text == "")
                {
                    MessageBox.Show("Please mention your previous NAME if you donot want to update");
                }
                if (password.Text == "")
                {
                    MessageBox.Show("Please mention your previous PASSWORD if you donot want to update");
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please mention your EMAIL in order to update");
                }
                else
                {
                    MessageBox.Show("UPDATED");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
    }

