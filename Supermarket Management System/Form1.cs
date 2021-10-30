using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Fariha Khan" && textBox2.Text == "123456")
            {
                Admin admin= new Admin();
                admin.Show();
                this.Hide();
            }
            else if (textBox1.Text == "fk" && textBox2.Text == "123456")
            {
                Manager manager = new Manager();
                manager.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Fariha Khan" && textBox2.Text == "123456")
            {
               
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR!\n Name Is Empty");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("ERROR!\n Password Is Empty");

            }
            else
            {
                MessageBox.Show("Error! Invalid Name or Password.\nTry Again!!");
            }
        }
    }
}
