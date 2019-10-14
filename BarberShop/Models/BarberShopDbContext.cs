using Microsoft.EntityFrameworkCore;

namespace Barber_shop.Models
{
    public class BarberShopDbContext: DbContext
    {

        public BarberShopDbContext(DbContextOptions<BarberShopDbContext> options) : base(options)
        {



        }

        public DbSet<Customer> Customers { get; set; }
    }
}
