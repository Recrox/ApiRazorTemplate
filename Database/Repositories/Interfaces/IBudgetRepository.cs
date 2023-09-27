using Database.Models;
using Site.Repositories.Factory;

namespace Database.Repositories.Interfaces
{
    public interface IBudgetRepository : IRepository<BudgetData>
    {
        Task methodRandomBudget();
    }
}