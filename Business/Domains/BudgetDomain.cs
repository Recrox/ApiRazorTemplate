using Business.Interfaces;
using Core.Models;
using Database.Repositories.Interfaces;

namespace Business.Domains
{
    public class BudgetDomain : IBudgetDomain
    {
        private readonly IBudgetRepository budgetRepository;

        public BudgetDomain(
            IBudgetRepository budgetRepository)
        {
            this.budgetRepository=budgetRepository;
        }

        public async Task InsertBudgetData()
        {
            // Exemple d'ajout d'une entité à la base de données
            var finDataToAdd = new BudgetData
            {
                Name = $"name: {Guid.NewGuid().ToString()}",

            };

            //await budgetRepository.AddAsync(finDataToAdd);
        }

        public async Task ShowAllBudgetData()
        {
            var datas = await this.budgetRepository.GetAllAsync();
            foreach (var data in datas)
            {
                Console.WriteLine($"{data.Id} {data.Name}");
            }
        }

        public async Task GetBudgetData(int id)
        {
            var data = await this.budgetRepository.GetAsync(id);
            Console.WriteLine($"{data.Id} {data.Name}");
        }
    }
}
