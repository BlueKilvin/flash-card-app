using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard
{
    internal class DatabaseInitialiser
    {

/* Unmerged change from project 'FlashCard (net8.0-android)'
Before:
        private readonly Data.Models.FlashCardDbContext _dbContext;
After:
        private readonly FlashCardDbContext _dbContext;
*/
        private readonly Data.Services.FlashCardDbContext _dbContext;


/* Unmerged change from project 'FlashCard (net8.0-android)'
Before:
        public DatabaseInitialiser(Data.Models.FlashCardDbContext dbContext)
After:
        public DatabaseInitialiser(FlashCardDbContext dbContext)
*/
        public DatabaseInitialiser(Data.Services.FlashCardDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Initialize()
        {
            _dbContext.Database.EnsureCreated();
        }
    }
}
