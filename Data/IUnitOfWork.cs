using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public interface IUnitOfWork
    {
        IOrderDetailsRepository OrderDetailsRepository { get; }

        IOrderRepository OrderRepository { get; }

        IPaymentRepository PaymentRepository { get; }


        IProductCategoryRepository ProductCategoryRepository { get; }

        IProductRepository ProductRepository { get; }

        IReviewRepository ReviewRepository { get; }

        IUserRepository UserRepository{ get; }

        Task SaveAsync();
    }
}
