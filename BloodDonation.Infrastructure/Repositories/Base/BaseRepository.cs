using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Infrastructure.Repositories.Base
{
    public class BaseRepository
    {
        protected readonly BloodDonationDbContext _dbContext;

        public BaseRepository(BloodDonationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
