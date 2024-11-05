using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product:BaseModel
    {
        public int Product_CategoryID { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string Image_url { get; set; } = string.Empty;

    }
}   
