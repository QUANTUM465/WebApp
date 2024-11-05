using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OrderDetails
    {
        public int Order_ID { get; set; }  
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
