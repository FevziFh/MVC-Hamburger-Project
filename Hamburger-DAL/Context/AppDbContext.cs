using Hamburger_DATA.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DAL.Context
{
    public class AppDbContext : IdentityDbContext<Customer>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDetail>().HasOne(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId);
            builder.Entity<OrderDetail>().HasOne(x => x.Menu)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.MenuId);
            builder.Entity<OrderDetail>().HasOne(x => x.Sauce)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.SaucesId);
            builder.Entity<OrderDetail>().HasKey(c => new
            {
                c.OrderId,
                c.MenuId,
                c.SaucesId
            });
            //builder.Entity<Order>().HasOne(x => x.Customer)
            //    .WithMany(x => x.Orders)
            //    .HasForeignKey(x => x.CustomerId);
            //builder.Entity<Customer>().HasKey(x => x.Id);
            base.OnModelCreating(builder);
        }
    }
}
