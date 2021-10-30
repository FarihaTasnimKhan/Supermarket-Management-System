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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void chart1Button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM EmployeeTable";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
              
                chart1.Series["Attendance"].Points.AddXY(reader["Position"].ToString(), reader["Attendance"].ToString());
            }
        }

        private void EmployeeButton_Click(object sender, EventArgs e) //goes to employee dashboard after click
        {

            Employee employee= new Employee();
            employee.Show();
            this.Hide();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //logout
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e) //goes to account settings page
        {
            AccountSettings accountsettings = new AccountSettings();
            accountsettings.Show();
            this.Hide();

        }

        private void stock_Click(object sender, EventArgs e)
        {
           Stock stock = new Stock();
            stock.Show();
            this.Hide();
        }
    }
}
