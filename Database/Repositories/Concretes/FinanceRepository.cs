using Database.Models;
using Database.Repositories.Interfaces;
using Site.Repositories.Factory;

namespace Database.Repositories.Concretes
{
    public class FinanceRepository : Repository<FinData>, IFinanceRepository
    {
        public FinanceRepository(BepContext bepContext) : base(bepContext)
        {

        }
    }
}
