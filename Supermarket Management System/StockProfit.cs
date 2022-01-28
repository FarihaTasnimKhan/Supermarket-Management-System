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
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Stock";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<StocksProfit> list = new List<StocksProfit>();
            while (reader.Read())
            {
                StocksProfit stocks = new StocksProfit();
               
              
                stocks.StockCategory = reader["StockCategory"].ToString();
                stocks.ItemName = reader["ItemName"].ToString();
              
                stocks.PricePerUnit = reader["PricePerUnit"].ToString();
               
                stocks.SellingPrice = reader["SellingPrice"].ToString();
               // stocks.ProfitPerUnit = reader["ProfitPerUnit"].ToString();


                list.Add(stocks);
            }
            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            cat.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            sellingprice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//calculation of profit
        {
            double a, b, c1;
            double.TryParse(price.Text, out a);
            double.TryParse(sellingprice.Text, out b);
            c1 = b - a;
            if (c1 > 0)
                profit.Text = c1.ToString("c").Remove(0, 1);
          


        }
    }
}
