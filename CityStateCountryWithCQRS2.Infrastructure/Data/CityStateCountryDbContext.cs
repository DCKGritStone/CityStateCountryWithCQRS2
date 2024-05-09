using CityStateCountryWithCQRS2.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CityStateCountryWithCQRS2.Infrastructure.Data
{
    public class CityStateCountryDbContext : DbContext
    {
        public CityStateCountryDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
