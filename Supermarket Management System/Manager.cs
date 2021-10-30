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
    }
}
