using Database;
using Database.Models;
using Site.Repositories.Factory;

namespace Database.Repositories
{
    public class FinanceRepository : Repository<FinData>, IFinanceRepository
    {
        public FinanceRepository(BepContext bepContext) : base(bepContext) 
        {
        
        }
    }
}
