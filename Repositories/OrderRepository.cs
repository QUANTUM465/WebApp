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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ShopDBContext dBContext) : base(dBContext)
        {
        }

        public async Task<IEnumerable<Order>> GetAllWithDetailsAsync()
        {
            return await _shopDBContext.Set<Order>()
            .Include(p => p.Payment)
            .Include(od => od.OrdersDetails)
            .ToListAsync();
        }

        public async Task<Order> GetByIdWithDetailsAsync(int id)
        {
            return await _shopDBContext.Set<Order>()
            .Include(p => p.Payment)
            .Include(od => od.OrdersDetails)
            .FirstAsync(o => o.Id == id);
        }
    }
}
