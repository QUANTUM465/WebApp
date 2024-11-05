using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Orders:BaseModel
    {
        public int User_ID { get; set; }
        public DateTime Order_date { get; set; }
        public float Total_amount { get; set; }
        public OrderStatus Order_status { get; set; }

    }
}
