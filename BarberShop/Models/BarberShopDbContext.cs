using BarberShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Barber_shop.Models
{
    public class BarberShopDbContext: IdentityDbContext
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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(new Customer()
            {
                Id = 1,
                Name = "Ahmed",
                Surname = "Bashir",
                Number = 07805

            });

            modelBuilder.Entity<Cut>().HasData(new Cut()
            {
                Id = 1,
                Cuts = "Regular Cut",
                Price = 15



            },
            new Cut()
            {
                Id = 2,
                Cuts = "Childrens Cut",
                Price = 6



            }, 
            new Cut()
            {
                Id = 3,
                Cuts = "Beard Trim",
                Price = 5



            }, new Cut()
            {
                Id = 4,
                Cuts = "Mustache Trim",
                Price = 3



            }, new Cut()
            {
                Id = 5,
                Cuts = "Shape Ups",
                Price = 3
            }

            ) ;

            modelBuilder.Entity<Barber>().HasData(new Barber()
            {
                Id = 1,
                Name="Kabrone",
                Number=078,
                Shop= "Brixton"



            },
            new Barber()
            {
                Id = 2,
                Name = "Andre",
                Number = 0208,
                Shop = "Stockwell"



            });

            modelBuilder.Entity<Booking>()
        .HasOne(e => e.Customers)
        .WithMany()
        .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
