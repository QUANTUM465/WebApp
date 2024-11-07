using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class ShopDBContext : DbContext
    {
        public ShopDBContext(DbContextOptions<ShopDBContext> options)
             : base(options) { }

        // Confuguring DbSet for entities
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderDetails> Order_Details { get; set; }
        public DbSet<ProductCategory> Product_Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (modelBuilder is null)
            {
                throw new ArgumentNullException($"{modelBuilder} is null here");
            }

            // Configure Order and Payments relationship
            modelBuilder.Entity<Order>()
                .HasOne(c => c.Payment)
                .WithMany(p => p.Orders)
                .HasForeignKey(c => c.Payment_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Order and User relationship
            modelBuilder.Entity<Order>()
                .HasOne(c => c.User)
                .WithMany(p => p.Orders)
                .HasForeignKey(c => c.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure OrderDetails and Order relationship
            modelBuilder.Entity<OrderDetails>()
                .HasOne(p => p.Order)
                .WithMany(c=> c.OrdersDetails)
                .HasForeignKey(c => c.Order_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure OrderDetails and Product relationship
            modelBuilder.Entity<OrderDetails>()
                .HasOne(c => c.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(c => c.Product_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Product and Product_Category relationship
            modelBuilder.Entity<Product>()
                .HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(c => c.Product_CategoryID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Reviews and Product relationship
            modelBuilder.Entity<Review>()
                .HasOne(c => c.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(c => c.Product_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Reviews and Product relationship
            modelBuilder.Entity<Review>()
                .HasOne(c => c.User)
                .WithMany(p => p.Reviews)
                .HasForeignKey(c => c.User_ID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
