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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        public ShopDBContext _shopDBContext { get; }

        public GenericRepository(ShopDBContext dBContext) 
        {
            _shopDBContext = dBContext;
        }
        public async Task AddAsync(T entity)
        {
            _shopDBContext.Set<T>().Add(entity);
            await _shopDBContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _shopDBContext.Set<T>().Remove(entity); 
            _shopDBContext.SaveChanges();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await _shopDBContext.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _shopDBContext.Set<T>().Remove(entity);
                await _shopDBContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _shopDBContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _shopDBContext.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            _shopDBContext.Set<T>().Update(entity);
            _shopDBContext.SaveChanges();
        }
    }
}
