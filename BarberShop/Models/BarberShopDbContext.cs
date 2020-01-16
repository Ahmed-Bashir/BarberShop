using BarberShop.Models;
using Microsoft.EntityFrameworkCore;

namespace Barber_shop.Models
{
    public class BarberShopDbContext: DbContext
    {
        
        public BarberShopDbContext(DbContextOptions<BarberShopDbContext> options) : base(options)
        {



        }


        public DbSet<Customer> Customers { get; set; }

        public DbSet<Barber> Barbers { get; set; }

        public DbSet<Cut> Cuts { get; set; }

        public DbSet<Booking> Bookings { get; set; }


        public DbSet<Order> Orders { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer()
            {
                Id = 1,
                Name = "Ahmed",
                Surname = "Bashir",
                Number = 07805

            });

            modelBuilder.Entity<Booking>()
        .HasOne(e => e.Customers)
        .WithMany()
        .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
