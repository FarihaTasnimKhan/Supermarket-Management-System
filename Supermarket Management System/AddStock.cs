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
        int Id; public string Date;
        public AddStock()
        {
            InitializeComponent(); Date = DateTime.Today.ToString("dddd , MMM dd yyyy");
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



            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["StockPurchaseList"].ConnectionString); //stock purchase list er table e insertion 
            connection1.Open();
            string sql1 = "INSERT INTO StockPurchaseList(Name,Date,Quantity) VALUES('" + item.Text + "','" + Date + "','" + quantitytextbox.Text + "')";

            SqlCommand command1 = new SqlCommand(sql1, connection1);
            int result1 = command1.ExecuteNonQuery();
            connection1.Close();
            if (result1 > 0)
            {


            }
            else
            {
                MessageBox.Show("Error");
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
               
                
                MessageBox.Show("STOCK ADDED.");

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


           
          




            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["StockPurchaseList"].ConnectionString); //stock purchase list er table e insertion 
            connection1.Open(); 
            string sql1 = "INSERT INTO StockPurchaseList(Name,Date,Quantity,TotalCostOfStock) VALUES('" + item.Text + "','" + Date + "','" + quantitytextbox.Text + "','"+textBox1.Text+"')";

            SqlCommand command1 = new SqlCommand(sql1, connection1);
            int result1 = command1.ExecuteNonQuery();
            connection1.Close();
            if (result1 > 0)
            {
            
           
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
            sellingprice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
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
               // stocks.TotalCostOfStock = reader["TotalCostOfStock"].ToString();
                stocks.SellingPrice = reader["SellingPrice"].ToString();



                list.Add(stocks);
            }
            dataGridView1.DataSource = list;
           

            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Supplier"].ConnectionString);
            connection1.Open();
            string sql1 = "SELECT * FROM Supplier";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            SqlDataReader reader12 = command1.ExecuteReader();
            List<Supplier> list1 = new List<Supplier>();
            while (reader12.Read())
            {
                Supplier stocks1 = new Supplier();
                
                stocks1.Name = reader12["Name"].ToString();
                stocks1.PricePerUnit = reader12["PricePerUnit"].ToString();
            



                list1.Add(stocks1);
            }
            dataGridView2.DataSource = list1;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            AddStock addstock = new AddStock();
            addstock.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            item.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            price.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c1;
            double.TryParse(quantitytextbox.Text, out a);
            double.TryParse(price.Text, out b);
            c1 = a * b;

            if (c1 > 0)
                textBox1.Text = c1.ToString("c").Remove(0, 1);
        }
    }
}
