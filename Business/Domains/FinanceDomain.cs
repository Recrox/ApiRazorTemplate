using Business.Interfaces;
using Core.Models;
using Database.Repositories.Interfaces;

namespace Business.Domains
{
    public class FinanceDomain : IFinanceDomain
    {
        private readonly IFinanceRepository financeRepository;

        public FinanceDomain(
            IFinanceRepository financeRepository)
        {
            this.financeRepository = financeRepository;
        }

        public async Task InsertDataFin(FinData finDataToAdd)
        {
            //await financeRepository.AddAsync(finDataToAdd);
        }

        public async Task<IEnumerable<FinData>> GetAllAsync()
        {
            var databaseFinData = await this.financeRepository.GetAllAsync();
            return databaseFinData.Select(finData =>finData);
        }

        public async Task GetFinData(int id)
        {
            var data = await this.financeRepository.GetAsync(id);
            Console.WriteLine($"{data.Id} {data.ENVIRO} {data.REALIZED}");
        }

        public async Task Delete(int id)
        {
            try
            {
                var existingData = await this.financeRepository.GetAsync(id);
                await this.financeRepository.DeleteAsync(existingData);
                Console.WriteLine($"{existingData.Id} {existingData.ENVIRO} {existingData.REALIZED} DELETED");
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        public async Task Update(FinData finDataToUpdate)
        {
            //await this.financeRepository.UpdateAsync();
            Console.WriteLine($"{finDataToUpdate.Id} {finDataToUpdate.ENVIRO} {finDataToUpdate.REALIZED} UPDATED");
        }
    }
}
