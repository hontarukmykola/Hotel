using Microsoft.EntityFrameworkCore;

namespace hotel.Data
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("conection...str");

        }
    }
}
