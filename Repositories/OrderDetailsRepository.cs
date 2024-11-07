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
    public class OrderDetailsRepository : GenericRepository<OrderDetails>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(ShopDBContext dBContext) : base(dBContext)
        {


        }

        public async Task<IEnumerable<OrderDetails>> GetAllWithDetailsAsync()
        {
            return await _shopDBContext.Set<OrderDetails>()
            .Include(p => p.Product)
            .Include(o => o.Order)
            .ToListAsync();
        }

        public async Task<OrderDetails> GetByIdWithDetailsAsync(int id)
        {
            return await _shopDBContext.Set<OrderDetails>()
            .Include(p => p.Product)
            .Include(o => o.Order)
            .FirstAsync(od => od.Id == id);
        }
    }
}
