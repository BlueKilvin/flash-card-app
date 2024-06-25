using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Data.Models
{
    internal class FlashCardDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public FlashCardDbContext(DbContextOptions<FlashCardDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=FlashCard.db");
            }
        }
    }
}
