using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System
{
    class Stocks
    {
        public int Id { get; set; }
        public string StockRemainderFromAdmin { get; set; }
        public string StockCategory { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string PricePerUnit { get; set; }
        public string TotalCostOfStock { get; set; }
        public string SellingPrice { get; set; }

    }
}
