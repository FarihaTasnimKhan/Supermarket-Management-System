using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System
{
    class Messages//made for messages to and from cashier
    {
       public int Id { get; set; }
        public string Position { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
      
       
        public string Date { get; set; }
       

    }
}
