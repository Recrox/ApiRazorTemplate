using Database;
using Database.Models;
using Site.Repositories.Factory;

namespace Database.Repositories
{
    public class BudgetRepository : Repository<BudgetData>, IBudgetRepository
    {
        public BudgetRepository(BepContext bepContext) : base(bepContext) 
        {

        }

        public Task methodRandomBudget()
        {
            throw new NotImplementedException();
        }
    }
}
