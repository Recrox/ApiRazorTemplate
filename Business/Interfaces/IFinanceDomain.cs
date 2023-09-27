using Core.Models;

namespace Business.Interfaces;

public interface IFinanceDomain
{
    Task InsertDataFin(FinData finDataToAdd);
    Task<IEnumerable<FinData>> GetAllAsync();
    Task GetFinData(int id);

    Task Delete(int id);

    Task Update(FinData finDataToUpdate);
}