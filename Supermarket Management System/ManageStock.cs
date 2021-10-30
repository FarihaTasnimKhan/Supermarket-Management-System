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
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//goes to stock viewing page
        {

            ManagerStockView MSV = new ManagerStockView();
            MSV.Show();
            this.Hide();

        }

        private void back_Click(object sender, EventArgs e)//back button-->goes back to manager dashboard
        {
            Manager M = new Manager();
            M.Show();
            this.Hide();
        }

        private void ManageStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
