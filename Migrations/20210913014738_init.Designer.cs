// <auto-generated />
using ApiFilms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiFilms.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210913014738_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("ApiFilms.Films", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("producers")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("studios")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("winner")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("year")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            id = -999,
                            producers = "teste producers",
                            studios = "teste studios",
                            title = "teste title",
                            winner = "year",
                            year = "2021"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
