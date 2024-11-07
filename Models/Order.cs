using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order:BaseModel
    {
        public int User_ID { get; set; }
        public int Payment_ID { get; set; }
        public DateTime Order_date { get; set; }
        public float Total_amount { get; set; }
        public Enums.Enums Order_status { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Payment Payment{ get; set; }
        public User User { get; set; } 
        public ICollection<OrderDetails> OrdersDetails { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.    

    }
}
