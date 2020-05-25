using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrdersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Persistence
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var converter = new EnumToStringConverter<Status>();
            builder.Entity<Order>()
                .Property(p => p.Status)
                .HasConversion(converter)
                ;
            builder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithOne(d => d.Order)
                .HasForeignKey(k => k.OrderId);
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
