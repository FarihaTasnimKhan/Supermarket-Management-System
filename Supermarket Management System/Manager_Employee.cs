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
    public partial class Manager_Employee : Form
    {
        int Id;
        public Manager_Employee()
        {
            InitializeComponent();
        }

        private void addemployee_Click(object sender, EventArgs e)
        {
            string gen = null;
            if (radioButton1.Checked)
            {
                gen = "Female";
            }
            else
            {
                gen = "Male";
            }

            string status = "CurrentlyEmployed";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO EmployeeTable(Position,Name,DateOfBirth,Password,Gender,Email,Salary) VALUES('" + position.Text + "','" + name.Text + "','" + dateTimePicker1.Text + "','" + password.Text + "','" + gen + "','" + email.Text + "','" + salary.Text + "','" + status + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {

                {
                    if (name.Text == "")
                    {
                        MessageBox.Show("Please mention the NAME of the employee");
                    }
                    else if (position.Text == "")
                    {
                        MessageBox.Show("Please mention the POSITION of the employee");
                    }
                    else if (dateTimePicker1.Text == "")
                    {
                        MessageBox.Show("Please mention the BIRTH DATE of the employee");
                    }
                    else if (password.Text == "")
                    {
                        MessageBox.Show("Please mention the PASSWORD of the employee");
                    }
                    else if (email.Text == "")
                    {
                        MessageBox.Show("Please mention the EMAIL of the employee");
                    }
                    else if (salary.Text == "")
                    {
                        MessageBox.Show("Please mention the SALARY of the employee");
                    }
                    else if (radioButton1.Checked == false && radioButton2.Checked == false)
                    {
                        MessageBox.Show("Please choose ATLEAST ONE OF THE GENDERS to continue.");
                    }
                    else
                    {
                        MessageBox.Show("THE EMPLOYEE IS SUCCESSFULLY ADDED.");

                    }
                }

            }

            else
            {
                MessageBox.Show("Error!!!.\nTHE EMPLOYEE WAS NOT ADDED.\nPlease try again.");
                Employee em = new Employee();
                em.Show();
                this.Hide();
            }





          /*  SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Message"].ConnectionString);//insertion in message table
            connection1.Open();
            string sql1 = "INSERT INTO Message(Position,[From]) VALUES('" + position.Text + "','" + name.Text + "')";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            int result1 = command1.ExecuteNonQuery();
            connection1.Close();

            if (result1 > 0)
            {

                {
                    if (name.Text == "")
                    {
                        MessageBox.Show("Please mention the NAME of the employee");
                    }
                    else if (position.Text == "")
                    {
                        MessageBox.Show("Please mention the POSITION of the employee");
                    }
                    else if (dateTimePicker1.Text == "")
                    {
                        MessageBox.Show("Please mention the BIRTH DATE of the employee");
                    }

                }

            }

            else
            {
                MessageBox.Show("Error!!!.\nTHE EMPLOYEE WAS NOT ADDED.\nPlease try again.");

            }*/
        }

        private void updateemployee_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "UPDATE EmployeeTable SET Position='" + position.Text + "',Salary='" + salary.Text + "',Email='" + email.Text + "'  ,Name='" + name.Text + "'        WHERE Id=" + Id;



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

        private void deleteemployee_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM EmployeeTable WHERE Id=" + Id;
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

        private void refresh_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            position.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            password.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            email.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            salary.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM EmployeeTable";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<AddEmployee> list = new List<AddEmployee>();
            while (reader.Read())
            {
                AddEmployee AE = new AddEmployee();
                AE.Id = (int)reader["Id"];
                AE.Name = reader["Name"].ToString();
                AE.Position = reader["Position"].ToString();
                AE.DateOfBirth = reader["DateOfBirth"].ToString();
                AE.Password = reader["Password"].ToString();
                AE.Gender = reader["Gender"].ToString();
                AE.Email = reader["Email"].ToString();
                AE.Salary = reader["Salary"].ToString();
                AE.EmployeeStatus = reader["EmployeeStatus"].ToString();


                list.Add(AE);
            }
            dataGridView1.DataSource = list;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            this.Hide();
        }

        private void Manager_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
