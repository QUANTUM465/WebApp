using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Review:BaseModel
    {
        public int Product_ID { get; set; }
        public int User_ID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime Created_at { get; set; }

        public User User { get; set; }

        public Product Product { get; set; }
    }
}
