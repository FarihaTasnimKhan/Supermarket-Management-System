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
             //   stocks.TotalCostOfStock = reader["TotalCostOfStock"].ToString();
                stocks.SellingPrice = reader["SellingPrice"].ToString();



                list.Add(stocks);
            }
            dataGridView1.DataSource = list;


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
                stocks1.Quantity= reader12["Quantity"].ToString();
                stocks1.TotalCostOfStock = reader12["TotalCostOfStock"].ToString();



                list1.Add(stocks1);
            }
            dataGridView2.DataSource = list1;
        }

        

       

        private void refresh_Click(object sender, EventArgs e)//refresh
        {
            ManagerStockView MSV = new ManagerStockView();
            MSV.Show();
            this.Hide();
        }
    }
}
