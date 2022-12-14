// <auto-generated />
using App.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.API.Migrations
{
    [DbContext(typeof(StarWarsDbContext))]
    [Migration("20221125153834_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.API.Data.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Side")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 3,
                            Name = "Luke Skywalker",
                            Side = "light"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 3,
                            Name = "Darth Vader",
                            Side = "dark"
                        });
                });

            modelBuilder.Entity("App.API.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Brasil",
                            ShortName = "BR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Estados Unidos",
                            ShortName = "EUA"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tatooine",
                            ShortName = "TA"
                        });
                });

            modelBuilder.Entity("App.API.Data.Character", b =>
                {
                    b.HasOne("App.API.Data.Country", "Country")
                        .WithMany("Character")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("App.API.Data.Country", b =>
                {
                    b.Navigation("Character");
                });
#pragma warning restore 612, 618
        }
    }
}
