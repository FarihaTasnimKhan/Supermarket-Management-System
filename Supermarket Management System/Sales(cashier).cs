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
    public partial class Sales_cashier_ : Form
    {
        public Sales_cashier_()
        {
            InitializeComponent();
        }

        private void Sales_cashier__FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Sales_cashier__Load(object sender, EventArgs e)//shows cashier name 
        {
            label2.Text = Form1.SetValueForText3;
        }

        private void button1_Click(object sender, EventArgs e)//goes back to cashier dashboard
        {
            CashierDashboard cd = new CashierDashboard();
            cd.Show();
            this.Hide();
        }
    }
}
