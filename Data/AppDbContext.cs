using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilms
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Films> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Films>()
                .Property(p => p.title).HasMaxLength(200);

            modelBuilder.Entity<Films>()
                .Property(p => p.year).HasMaxLength(4);

            modelBuilder.Entity<Films>()
                .Property(p => p.studios).HasMaxLength(200);

            modelBuilder.Entity<Films>()
                .Property(p => p.producers).HasMaxLength(200);

            modelBuilder.Entity<Films>()
                .Property(p => p.winner).HasMaxLength(3);

            modelBuilder.Entity<Films>().HasKey(m => m.id);

            modelBuilder.Entity<Films>()
                .HasData(
                    new Films { id = -999, title = "teste title", year = "2021", studios = "teste studios", producers = "teste producers", winner = "year" }                    
                );
        }


    }
}
