using hotel.Entities;
using Microsoft.EntityFrameworkCore;

namespace hotel.Data
{
    public class HotelDbContext : DbContext
    {
        public DbSet<HotelRoom> HotelRooms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<HotelRoom>().HasData(new[]
            {
                new HotelRoom { Id = 1, Number= 101,Rating = 3,Flour = 1, AmoundOfPeople = 2, AmoundOfBed = 1, Price = 1400, Discount = 7 },
                new HotelRoom { Id = 2, Number= 201,Rating = 5,Flour = 2, AmoundOfPeople = 3, AmoundOfBed = 3, Price = 1500, Discount = 3 },
                new HotelRoom { Id = 3, Number= 202,Rating = 3,Flour = 2, AmoundOfPeople = 2, AmoundOfBed = 2, Price = 1250, Discount = 0 },
                new HotelRoom { Id = 4, Number= 203,Rating = 3,Flour = 2, AmoundOfPeople = 1, AmoundOfBed = 1, Price = 1130, Discount = 4 },
                new HotelRoom { Id = 5, Number= 301,Rating = 4,Flour = 3, AmoundOfPeople = 4, AmoundOfBed = 2, Price = 1376, Discount = 1 },
            });
        }
    }
}
