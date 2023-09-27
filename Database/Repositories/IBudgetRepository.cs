using Database.Models;
using Site.Repositories.Factory;

namespace Database.Repositories
{
    public interface IBudgetRepository : IRepository<BudgetData>
    {
        Task methodRandomBudget();
    }
}