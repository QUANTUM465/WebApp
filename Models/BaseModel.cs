using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public abstract class BaseModel
    {
        protected BaseModel(int id)
        {
            this.Id = id;
        }

        protected BaseModel()
        {
            this.Id = 0;
        }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
