using Database.Models;
using Database.Repositories.Factory;

namespace Database.Repositories.Interfaces
{
    public interface IFinanceRepository : IRepository<FinData>
    {
        Task<IEnumerable<Core.Models.FinData>> GetAllAsync();
    }
}