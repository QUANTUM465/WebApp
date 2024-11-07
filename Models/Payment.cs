using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Payment:BaseModel
    {
        public int Order_ID { get; set; }
        public DateTime Payment_Date { get; set; }
        public float Amount { get; set; }
        public bool Payment_Status { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
