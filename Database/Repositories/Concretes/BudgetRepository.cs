using AutoMapper;
using Database.Models;
using Database.Repositories.Factory;
using Database.Repositories.Interfaces;

namespace Database.Repositories.Concretes
{
    public class BudgetRepository : Repository<BudgetData>, IBudgetRepository
    {
        public BudgetRepository(BepContext bepContext, IMapper mapper) : base(bepContext, mapper)
        {

        }

        public Task methodRandomBudget()
        {
            throw new NotImplementedException();
        }
    }
}
