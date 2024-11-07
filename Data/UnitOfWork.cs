using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class UnitOfWork:IUnitOfWork
    {
        public ShopDBContext context { get; }

        public UnitOfWork(ShopDBContext context)
        {
            this.context = context;
            OrderDetailsRepository = new OrderDetailsRepository(context);
            OrderRepository = new OrderRepository(context);
            PaymentRepository = new PaymentRepository(context);
            ProductCategoryRepository = new ProductCategoryRepository(context);
            ProductRepository = new ProductRepository(context);
            ReviewRepository = new ReviewRepository(context);
            UserRepository = new UserRepository(context);
        }

        
        public IOrderDetailsRepository OrderDetailsRepository { get; }

        public IOrderRepository OrderRepository { get; }

        public IPaymentRepository PaymentRepository { get; }

        public IProductCategoryRepository ProductCategoryRepository { get; }

        public IProductRepository ProductRepository { get; }

        public IReviewRepository ReviewRepository { get; }

        public IUserRepository UserRepository { get; }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
