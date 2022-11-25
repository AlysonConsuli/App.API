using Microsoft.EntityFrameworkCore;

namespace App.API.Data
{
    public class StarWarsDbContext : DbContext
    {
        public StarWarsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id= 1,
                    Name = "Brasil",
                    ShortName = "BR"
                },
                new Country
                {
                    Id = 2,
                    Name = "Estados Unidos",
                    ShortName = "EUA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Tatooine",
                    ShortName = "TA"
                }
            );

            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1,
                    Name = "Luke Skywalker",
                    Side = "light",
                    CountryId = 3,
                },
                new Character
                {
                    Id = 2,
                    Name = "Darth Vader",
                    Side = "dark",
                    CountryId = 3,
                }
            );
        }

    }
}
