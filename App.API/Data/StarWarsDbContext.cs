using App.API.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.API.Data
{
    public class StarWarsDbContext : IdentityDbContext<ApiUser>
    {
        public StarWarsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
        }

    }
}
