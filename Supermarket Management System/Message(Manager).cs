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
    public partial class Message_Manager_ : Form
    {
        public int Id;
        public string Date;
        public Message_Manager_()
        {
            InitializeComponent();
            Date = DateTime.Today.ToString("dddd , MMM dd yyyy");
        }

        private void Message_Manager__FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)//back button
        {
            Manager m = new Manager();
            m.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Message"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM Message WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("DELETED.");


            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Message"].ConnectionString);
            connection1.Open();
            string sql1 = "INSERT INTO Message(Position,[From],[To],Message,Date,Subject) VALUES('" + position.Text + "','" + Form1.SetValueForText3 + "','" + to.Text + "','" + textBox1.Text + "','" + Date + "','"+comboBox1.Text+"')";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            int result1 = command1.ExecuteNonQuery();
            connection1.Close();



            if (result1 > 0)
            {
                MessageBox.Show("Message Sent.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)//refresh
        {
            Message_Manager_ mm = new Message_Manager_();
            mm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Message"].ConnectionString);
            connection.Open();
            string sql = "SELECT Id,Position,[From],[To],Message,Date FROM Message   WHERE [From] LIKE '" + Form1.SetValueForText1 + "%' OR [To] LIKE '" + Form1.SetValueForText1 + "%'  ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Messages> list = new List<Messages>();
            while (reader.Read())
            {
                Messages AE = new Messages();

                AE.Id = (int)reader["Id"];
                AE.Position = reader["Position"].ToString();
                AE.From = reader["From"].ToString();
                AE.To = reader["To"].ToString();
                AE.Message = reader["Message"].ToString();
                AE.Date = reader["Date"].ToString();



                list.Add(AE);
            }
            dataGridView1.DataSource = list;

            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection1.Open();
            string sql1 = "SELECT Position,Name FROM EmployeeTable   ";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            SqlDataReader reader1 = command1.ExecuteReader();
            List<Message_EmployeeInfo_> list1 = new List<Message_EmployeeInfo_>();
            while (reader1.Read())
            {
                Message_EmployeeInfo_ AE = new Message_EmployeeInfo_();


                AE.Position = reader1["Position"].ToString();
                AE.Name = reader1["Name"].ToString();




                list1.Add(AE);
            }
            dataGridView2.DataSource = list1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            position.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//position
            name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();//from name
            to.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();//message typed
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();//message received
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();//message typed
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();//position
            to.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();//from name
        }
    }
}
