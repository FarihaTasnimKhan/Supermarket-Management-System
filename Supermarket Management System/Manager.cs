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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//logout
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeButton_Click(object sender, EventArgs e) //go to employee modifying page
        {
            Manager_Employee Memployee = new Manager_Employee();
            Memployee.Show();
            this.Hide();
        }

        private void stock_Click(object sender, EventArgs e) //go to stock dashboard
        {
           
            ManageStock MS = new ManageStock();
            MS.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//ATTENDENCE
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "UPDATE EmployeeTable SET Attendance='" +1.ToString() + "'     WHERE Name='"+textBox1.Text+"' and Password='"+textBox2.Text+"' ";



            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("TODAYS ATTENDANCE GIVEN.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)//goes to manager account settings page
        {
            ManagerAccountSettings MAS = new ManagerAccountSettings();
            MAS.Show();
            this.Hide();
        }
    }
}
