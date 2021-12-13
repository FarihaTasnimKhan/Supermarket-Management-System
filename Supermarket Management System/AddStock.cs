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
    public partial class AddStock : Form
    {
        int Id;
        public AddStock()
        {
            InitializeComponent();
        }

        private void AddStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)//go back to stock dashboard
        {
            ManageStock managestock = new ManageStock();
            managestock.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)//add NEW stock(not introduced before)
        {
          SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Stock(StockCategory,ItemName,Quantity,PricePerUnit,SellingPrice) VALUES('" + stockcategory.Text + "','" + item.Text + "','" + quantitytextbox.Text + "','"+price.Text+"','"+sellingprice.Text+"')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {

                {
                    if (stockcategory.Text == "")
                    {
                        MessageBox.Show("Please mention the Stock Category.");
                    }
                    else if (item.Text == "")
                    {
                        MessageBox.Show("Please mention the Name of the Item.");
                    }
                    else if (quantitytextbox.Text == "")
                    {
                        MessageBox.Show("Please mention the Quantity.");
                    }
                    
                    else
                    {
                        MessageBox.Show("THE STOCK IS SUCCESSFULLY ADDED.");

                    }
                }

            }

            else
            {
                MessageBox.Show("Error!!!.\nTHE AMOUNT OF STOCK WAS NOT ADDED.\nPlease try again.");
               AddStock addstock = new AddStock();
                addstock.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)//ADD TO EXISTING STOCK
        {
           
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Stock SET StockCategory='" + stockcategory.Text + "',ItemName='" + item.Text + "',Quantity='" + quantitytextbox.Text+ "' ,StockRemainderFromAdmin='" + stockremainder.Text+"'      WHERE Id=" + Id;



            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
               
                
                MessageBox.Show("UPDATED");

                /* MessageBox.Show("UPDATED");
                 SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                 connection1.Open();
                 string sql1 = "UPDATE Stock SET StockRemainderFromAdmin='" + 0.ToString() + "'     WHERE ItemName='" + item.Text + "' ";
                 SqlCommand command1 = new SqlCommand(sql1, connection1);
                 int result1 = command.ExecuteNonQuery();
                 connection1.Close();*/
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            stockcategory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            item.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            price.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            sellingprice.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
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
                stocks.TotalCostOfStock = reader["TotalCostOfStock"].ToString();
                stocks.SellingPrice = reader["SellingPrice"].ToString();



                list.Add(stocks);
            }
            dataGridView1.DataSource = list;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            AddStock addstock = new AddStock();
            addstock.Show();
            this.Hide();
        }
    }
}
