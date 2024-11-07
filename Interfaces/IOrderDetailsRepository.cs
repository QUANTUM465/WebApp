using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IOrderDetailsRepository:IGenericRepository<OrderDetails>
    {
        Task<IEnumerable<OrderDetails>> GetAllWithDetailsAsync();
        Task<OrderDetails> GetByIdWithDetailsAsync(int id);
    }
}
