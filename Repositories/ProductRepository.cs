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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ShopDBContext dBContext) : base(dBContext)
        {
        }

        public async Task<IEnumerable<Product>> GetAllWithDetailsAsync()
        {
            return await _shopDBContext.Set<Product>()
               .Include(pc => pc.Category)
               .Include(rv => rv.Reviews)
               .Include(od => od.OrderDetails)
               .ToListAsync();
        }

        public async Task<Product> GetByIdWithDetailsAsync(int id)
        {
            return await _shopDBContext.Set<Product>()
                .Include(pc => pc.Category)
                .Include(rv => rv.Reviews)
                .Include(od => od.OrderDetails)
                .FirstAsync(p => p.Id == id);
        }
    }
}
