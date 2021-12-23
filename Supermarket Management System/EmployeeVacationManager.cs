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
    public partial class EmployeeVacationManager : Form
    {
        public int Id; public string Date;
        public EmployeeVacationManager()
        {
            InitializeComponent(); Date = DateTime.Today.ToString("dddd , MMM dd yyyy");
        }

        private void EmployeeVacationManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)//back
        {
            EmployeeAttendances_Manager_ emp = new EmployeeAttendances_Manager_();
            emp.Show();
            this.Hide();

      
    }
        string subject = "Vacation";
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Message"].ConnectionString);
            connection.Open();
            string sql = "SELECT Id,Position,[From],[To],Message,Date,Subject FROM Message   WHERE [To] LIKE '" + Form1.SetValueForText1 + "%' AND Subject LIKE '" + subject + "%'  ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<VacationAdmin> list = new List<VacationAdmin>();
            while (reader.Read())
            {
                VacationAdmin AE = new VacationAdmin();

                AE.Id = (int)reader["Id"];
                AE.Position = reader["Position"].ToString();
                AE.From = reader["From"].ToString();
                AE.To = reader["To"].ToString();
                AE.Message = reader["Message"].ToString();
                AE.Date = reader["Date"].ToString();

                AE.Subject = reader["Subject"].ToString();

                list.Add(AE);
            }
            dataGridView1.DataSource = list;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            label5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
        string message = "YOUR_VACATION_IS_GRANTED.";
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Message"].ConnectionString);
            connection1.Open();
            string sql1 = "INSERT INTO Message(Position,[From],[To],Message,Date) VALUES('" + label6.Text + "','" + Form1.SetValueForText1 + "','" + label4.Text + "','" + message + "','" + Date + "')";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            int result1 = command1.ExecuteNonQuery();
            connection1.Close();



            if (result1 > 0)
            {
                MessageBox.Show("THE VACATION IS GRANTED MESSAGE IS SENT TO THE EMPLOYEE.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        string message1 = "YOUR_VACATION_IS_NOT_GRANTED.";
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Message"].ConnectionString);
            connection1.Open();
            string sql1 = "INSERT INTO Message(Position,[From],[To],Message,Date) VALUES('" + label6.Text + "','" + Form1.SetValueForText1 + "','" + label4.Text + "','" + message1 + "','" + Date + "')";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            int result1 = command1.ExecuteNonQuery();
            connection1.Close();



            if (result1 > 0)
            {
                MessageBox.Show("THE VACATION IS NOT GRANTED MESSAGE IS SENT TO THE EMPLOYEE.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
