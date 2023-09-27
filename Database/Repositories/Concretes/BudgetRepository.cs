using Database.Models;
using Database.Repositories.Interfaces;
using Site.Repositories.Factory;

namespace Database.Repositories.Concretes
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
