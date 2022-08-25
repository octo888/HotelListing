using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data;
#nullable disable

public class HotelListingDbContext : DbContext
{
    public HotelListingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }

    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasData(
            new Country {Id = 1, Name = "USA", ShortName = "US"},
            new Country {Id = 2, Name = "Germany", ShortName = "DE"}
        );

        modelBuilder.Entity<Hotel>().HasData(
            new Hotel {Id = 1, Name = "Redisson", CountryId = 1},
            new Hotel {Id = 2, Name = "Plaza", CountryId = 2, Rating = 4.3}
        );
    }
}
