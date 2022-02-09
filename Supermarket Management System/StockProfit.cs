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
    public partial class StockProfit : Form
    {
        public StockProfit()
        {
            InitializeComponent();
        }

        private void StockProfit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["StockPurchaseList"].ConnectionString);
            connection1.Open();
            string sql1 = "SELECT * FROM StockPurchaseList";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            SqlDataReader reader12 = command1.ExecuteReader();
            List<PurchaseList> list1 = new List<PurchaseList>();
            while (reader12.Read())
            {
                PurchaseList stocks1 = new PurchaseList();

                stocks1.Name = reader12["Name"].ToString();
                stocks1.Date = reader12["Date"].ToString();
                stocks1.Quantity = reader12["Quantity"].ToString();

                stocks1.TotalCostOfStock = reader12["TotalCostOfStock"].ToString();

                list1.Add(stocks1);
            }
            dataGridView1.DataSource = list1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)//calculation of profit
        {
            
          


        }
    }
}
