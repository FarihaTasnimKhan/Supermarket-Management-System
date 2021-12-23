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
        public string Date;
        public static string SetValueForText3 = ""; //for attendance turning to 0 when logging out


        public Manager()
        {
            InitializeComponent();
            Date = DateTime.Today.ToString("dddd , MMM dd yyyy");
        }

        private void button1_Click(object sender, EventArgs e)//logs the manager out and turns attendance to 0.
        {
            /*SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
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

        private void button2_Click(object sender, EventArgs e)//ATTENDENCE--->logout button click korle attendence auto 0 hoye jabe and duita table ei insertion hobe with date 
        {
            /* SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString); //updates attendance value of the day in employeetable
             connection.Open();
             string sql = "UPDATE EmployeeTable SET Attendance='" +1.ToString() + "'     WHERE Name='"+Form1.SetValueForText1+"' ";
             SqlCommand command = new SqlCommand(sql, connection);
             int result = command.ExecuteNonQuery();
             connection.Close();*/


            string timing = DateTime.Today.ToString("h:mm tt");

            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString); //inserts attendance value in attendance table
            connection1.Open();
            string sql1 = "INSERT INTO Attendance(Name,Attendance,Date,Time) VALUES('" + Form1.SetValueForText1 + "','" + 1.ToString() + "','" + Date + "','" + timing + "')";
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

        private void SettingsButton_Click(object sender, EventArgs e)//goes to manager account settings page
        {
            ManagerAccountSettings MAS = new ManagerAccountSettings();
            MAS.Show();
            this.Hide();
        }

        private void Manager_Load(object sender, EventArgs e)// to show name of manager at top of dashboard
        {
           label5.Text = Form1.SetValueForText1;
          // textBox1.Text = Form1.SetValueForText1;

        }

        private void button4_Click(object sender, EventArgs e)//GOES TO EMPLOYEE ATTENDANCES PAGE
        {
            EmployeeAttendances_Manager_ em = new EmployeeAttendances_Manager_();
            em.Show();
            this.Hide();
        }

      

        private void button5_Click(object sender, EventArgs e)//message of manager
        {
            Message_Manager_ mg = new Message_Manager_();
            mg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
