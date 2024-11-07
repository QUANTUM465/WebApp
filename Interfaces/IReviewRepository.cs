using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IReviewRepository:IGenericRepository<Review>
    {
        Task<IEnumerable<Review>> GetAllWithDetailsAsync();
        Task<Review> GetByIdWithDetailsAsync(int id);
    }
}
