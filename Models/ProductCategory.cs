using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductCategory:BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; }  
    }
}
