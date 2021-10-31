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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//login
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTable"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM EmployeeTable where Name='"+textBox1.Text+"'and password='"+textBox2.Text+ "' and position= '" + comboBox1.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if(dt.Rows.Count > 0)
            {
                for(int i=0; i<dt.Rows.Count;i++)
                {
                    if(dt.Rows[i]["Position"].ToString()==cmbItemValue)
                    {
                        MessageBox.Show("YOU ARE LOGGED IN AS---> "+dt.Rows[i][2]);
                        if(comboBox1.SelectedIndex==0)
                        {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                        }
                      else  if(comboBox1.SelectedIndex ==1)
                        {
                            Manager manager = new Manager();
                            manager.Show();
                            this.Hide();
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Black)
            {
                textBox2.PasswordChar = '\0';
                button2.BackColor = Color.Green;
            }
            else
            {
                textBox2.PasswordChar = '*';
                button2.BackColor = Color.Black;
            }
        }
    }
}
