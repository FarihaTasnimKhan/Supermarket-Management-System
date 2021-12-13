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
    public partial class ManagerStockView : Form
    {
        int Id;
        public ManagerStockView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ManageStock managestock = new ManageStock();
            managestock.Show();
            this.Hide();
        }

        private void ManagerStockView_FormClosing(object sender, FormClosingEventArgs e)
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
                stocks.Quantity= reader["Quantity"].ToString();
                stocks.PricePerUnit = reader["PricePerUnit"].ToString();
                stocks.TotalCostOfStock = reader["TotalCostOfStock"].ToString();
                stocks.SellingPrice = reader["SellingPrice"].ToString();



                list.Add(stocks);
            }
            dataGridView1.DataSource = list;
        }

        private void set_Click(object sender, EventArgs e) //sets price of stock
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Stock SET SellingPrice='" + textBox1.Text + "' WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {

                {
                    if (textBox1.Text == "")
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            Item.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
           
        }

        private void refresh_Click(object sender, EventArgs e)//refresh
        {
            ManagerStockView MSV = new ManagerStockView();
            MSV.Show();
            this.Hide();
        }
    }
}
