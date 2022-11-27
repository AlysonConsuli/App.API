using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
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
        }
    }
}
