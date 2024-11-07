using DAL.Data;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ShopDBContext dBContext) : base(dBContext)
        {
        }

        public async Task<IEnumerable<Review>> GetAllWithDetailsAsync()
        {
            return await _shopDBContext.Set<Review>()
              .Include(p => p.Product)
              .Include(u => u.User)
              .ToListAsync();
        }

        public async Task<Review> GetByIdWithDetailsAsync(int id)
        {
            return await _shopDBContext.Set<Review>()
              .Include(p => p.Product)
              .Include(u => u.User)
              .FirstAsync(r => r.Id == id);
        }
    }
}
