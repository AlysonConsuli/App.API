using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.API.Data.Configurations
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasData(
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
