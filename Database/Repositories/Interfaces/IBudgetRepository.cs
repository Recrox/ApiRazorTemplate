using Database.Models;
using Database.Repositories.Factory;

namespace Database.Repositories.Interfaces
{
    public interface IBudgetRepository : IRepository<BudgetData>
    {
        Task methodRandomBudget();
    }
}