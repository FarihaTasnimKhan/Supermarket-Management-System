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
    public partial class EmployeeAttendances_Manager_ : Form
    {
        public int Id;
        public string Date;
        public EmployeeAttendances_Manager_()
        {
            InitializeComponent(); Date = DateTime.Today.ToString("dddd , MMM dd yyyy");
        }

    
        private void EmployeeAttendances_Manager__FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
        private void back_Click_1(object sender, EventArgs e)//back to manager dashboard
        {

            Manager manager = new Manager();
            manager.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString); //shows all employee attendances from Attendance table in datagridview2
            connection1.Open();
            string sql1 = "SELECT Name,Attendance,Date,Time FROM Attendance";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            SqlDataReader reader1 = command1.ExecuteReader();
            List<Attendances> list1 = new List<Attendances>();
            while (reader1.Read())
            {
                Attendances A = new Attendances();
                //  A.Id = (int)reader1["Id"];
                A.Name = reader1["Name"].ToString();
                A.Attendance = reader1["Attendance"].ToString();
                A.Date = reader1["Date"].ToString();
                A.Time = reader1["Time"].ToString();

                list1.Add(A);
            }
            dataGridView2.DataSource = list1;




            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "SELECT Id,Position,Name FROM EmployeeTable";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<AdminAttendances> list = new List<AdminAttendances>();
            while (reader.Read())
            {
                AdminAttendances AAF = new AdminAttendances();
                AAF.Id = (int)reader["Id"];
                AAF.Position = reader["Position"].ToString();
                AAF.Name = reader["Name"].ToString();


                list.Add(AAF);
            }
            dataGridView1.DataSource = list;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            label7.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Message"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Message(Position,[From],[To],Message,Date) VALUES('" + label7.Text + "','" + Form1.SetValueForText1 + "','" + label1.Text + "','" + textBox1.Text + "','" + Date + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("REMINDER SENT");
            }
            else
            {
                MessageBox.Show("UNSUCCESSFUL!!REMINDER NOT SEND");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = "Fired";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "UPDATE EmployeeTable SET EmployeeStatus='" + status + "'     WHERE Id=" + Id;



            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("FIRED");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
