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
    public partial class CashierDashboard : Form
    {
        public string Date;
        public static string SetValueForText3 = ""; //for attendance turning to 0 when logging out
        public CashierDashboard()
        {
            InitializeComponent();
            Date = DateTime.Today.ToString("dddd , MMM dd yyyy");
        }

        private void CashierDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            label5.Text = Form1.SetValueForText3;
        }

        private void SettingsButton_Click(object sender, EventArgs e)//goes to cashier settings 
        {
            CashierAccountSetting cas = new CashierAccountSetting();
            cas.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//logs the cashier out and turns attendance to 0.
        {
           /* SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection2.Open();
            string sql2 = "UPDATE EmployeeTable SET Attendance='" + 0.ToString() + "'     WHERE Name='" + Form1.SetValueForText1 + "' ";
            SqlCommand command2 = new SqlCommand(sql2, connection2);
            int result2 = command2.ExecuteNonQuery();
            connection2.Close();
           */


            Form1 form = new Form1();//takes to the login form
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//cashier goes to sell form to sell
        {
            Sales_cashier_ cs = new Sales_cashier_();
            cs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /* SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString); //updates attendance value of the day in employeetable
             connection.Open();
             string sql = "UPDATE EmployeeTable SET Attendance='" + 1.ToString() + "'     WHERE Name='" + Form1.SetValueForText3 + "' ";
             SqlCommand command = new SqlCommand(sql, connection);
             int result = command.ExecuteNonQuery();
             connection.Close();*/
            string timing = DateTime.Today.ToString("h:mm tt");


            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString); //inserts attendance value in attendance table
            connection1.Open();
            string sql1 = "INSERT INTO Attendance(Name,Attendance,Date,Time) VALUES('" + Form1.SetValueForText3 + "','" + 1.ToString() + "','" + Date + "','" + timing + "')";
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

        private void button4_Click(object sender, EventArgs e)//messages of cashier
        {
            Message_cashier_ mc = new Message_cashier_();
            mc.Show();
            this.Hide();
        }
    }
}
