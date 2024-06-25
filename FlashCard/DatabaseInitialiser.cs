using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard
{
    internal class DatabaseInitialiser
    {
        private readonly Data.Models.FlashCardDbContext _dbContext;

        public DatabaseInitialiser(Data.Models.FlashCardDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Initialize()
        {
            _dbContext.Database.EnsureCreated();
        }
    }
}
