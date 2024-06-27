using FlashCard.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Data.Services
{
    internal class FlashCardDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public FlashCardDbContext(DbContextOptions<FlashCardDbContext> options) : base(options)
        {
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=FlashCard.db");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Card>().HasKey(p => p.ID);
            modelBuilder.Entity<Card>()
                .Property(p => p.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Card>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<DefaultCard>("DefaultCard");
        }
    }
}
