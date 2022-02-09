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
    public partial class Sales_cashier_ : Form
    {
        int Id;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "SELECT StockCategory,ItemName,SellingPrice FROM Stock";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<SaleItems> list = new List<SaleItems>();
            while (reader.Read())
            {
                SaleItems stocks = new SaleItems();
             //   stocks.Id = (int)reader["Id"];
               
                stocks.StockCategory = reader["StockCategory"].ToString();
                stocks.ItemName = reader["ItemName"].ToString();
               
                stocks.SellingPrice = reader["SellingPrice"].ToString();



                list.Add(stocks);
            }
            dataGridView1.DataSource = list;

        }

        private void button2_Click(object sender, EventArgs e)//back
        {
            CashierDashboard c = new CashierDashboard();
            c.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }


        

        private void button3_Click(object sender, EventArgs e)//add item * quantity
        {
           //add item press korle stock minus hoye jabe auto and arekta new table e sales of the day with date store hobe


            double a, b, c1,d,f;
            double.TryParse(Price.Text, out a);
            double.TryParse(textBox2.Text, out b);
            c1 = a * b;
            if (c1 > 0)
                total.Text = c1.ToString("c").Remove(0,1);
            label11.Text = c1.ToString("c").Remove(0, 1);









        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PAYMENT RECEIVED");
            Sales_cashier_ s = new Sales_cashier_();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PAYMENT RECEIVED");
            Sales_cashier_ s = new Sales_cashier_();
            s.Show();
            this.Hide();
        }
    }
}
