using Microsoft.EntityFrameworkCore;

namespace Barber_shop.Models
{
    public class MyDbContext: DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {



        }
    }
}
