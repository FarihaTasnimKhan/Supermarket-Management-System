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
    public partial class Stock : Form
    {
        int Id;
        public Stock()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//go back to admin dashboard
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void Stock_FormClosing(object sender, FormClosingEventArgs e)
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
            List<Stocks> list = new List<Stocks>();
            while (reader.Read())
            {
                Stocks stocks = new Stocks();
                stocks.Id = (int)reader["Id"];
                stocks.StockRemainderFromAdmin = reader["StockRemainderFromAdmin"].ToString();
                stocks.StockCategory = reader["StockCategory"].ToString();
                stocks.ItemName = reader["ItemName"].ToString();
                stocks.Quantity = reader["Quantity"].ToString();
                stocks.PricePerUnit = reader["PricePerUnit"].ToString();
              //  stocks.TotalCostOfStock = reader["TotalCostOfStock"].ToString();
                stocks.SellingPrice = reader["SellingPrice"].ToString();



                list.Add(stocks);
            }
            dataGridView2.DataSource = list;




        }

        private void set_Click(object sender, EventArgs e)// sets stock price
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Stock SET SellingPrice='" + SellingPrice.Text + "' WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {

                {
                    if (SellingPrice.Text == "")
                    {
                        MessageBox.Show("Please mention the PRICE.");
                    }
                    else
                    {
                        MessageBox.Show("THE STOCK PRICE IS SUCCESSFULLY ADDED.");

                    }
                }

            }

            else
            {
                MessageBox.Show("Error!!!.\nTHE PRICE WAS NOT ADDED.\nPlease try again.");
                AddStock addstock = new AddStock();
                addstock.Show();
                this.Hide();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
          //  Item.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            SellingPrice.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void refresh_Click(object sender, EventArgs e) //refresh
        {
            Stock s = new Stock();
            s.Show();
            this.Hide();
        }

       

        private void refresh_Click_1(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
          //  Item.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            SellingPrice.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();



            cat.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            name.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

            price.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            label5.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void set_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Stock SET SellingPrice='" + SellingPrice.Text + "' WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {

                {
                    if (SellingPrice.Text == "")
                    {
                        MessageBox.Show("Please mention the PRICE.");
                    }
                    else
                    {
                        MessageBox.Show("THE STOCK PRICE IS SUCCESSFULLY ADDED.");

                    }
                }

            }

            else
            {
                MessageBox.Show("Error!!!.\nTHE PRICE WAS NOT ADDED.\nPlease try again.");
                Stock addstock = new Stock();
                addstock.Show();
                this.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//stock remainder.
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Stock SET StockRemainderFromAdmin='" + 1.ToString() + "'     WHERE ItemName='" + name.Text + "' ";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {

                MessageBox.Show("THE STOCK REMAINDER IS SENT TO THE MANAGER.");

            }

            else
            {
                MessageBox.Show("Error!!!.\nTRY AGAIN");
                Stock stock = new Stock();
                stock.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)//stock profit
        {
            StockProfit s = new StockProfit();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c1;
            double.TryParse(price.Text, out a);
            double.TryParse(label5.Text, out b);
            c1 = b - a;
            if (c1 > 0)
                profit.Text = c1.ToString("c").Remove(0, 1);
        }
    }
}
