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
    public partial class SalesClerkDashboard : Form
    {
        public string Date;
        public SalesClerkDashboard()
        {
            InitializeComponent(); 
            Date = DateTime.Today.ToString("dddd , MMM dd yyyy");
        }

        private void SalesClerkDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SalesClerkDashboard_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.SetValueForText6;
        }

        private void button2_Click(object sender, EventArgs e)//attendance
        {

            string timing = DateTime.Today.ToString("h:mm tt");

            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString); //inserts attendance value in attendance table
            connection1.Open();
            string sql1 = "INSERT INTO Attendance(Name,Attendance,Date,Time) VALUES('" + Form1.SetValueForText6 + "','" + 1.ToString() + "','" + Date + "','" + timing + "')";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            int result1 = command1.ExecuteNonQuery();
            connection1.Close();



            if (result1 > 0)
            {
                MessageBox.Show("TODAYS ATTENDANCE GIVEN.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)//logout
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)//account settings
        {
            SalesClerkAccountSettings s = new SalesClerkAccountSettings();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//message
        {
            SalesClerkMessages sm = new SalesClerkMessages();
            sm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//report stock
        {
            
        }
    }
}
