using AutoMapper;
using Database.Models;
using Database.Repositories.Factory;
using Database.Repositories.Interfaces;

namespace Database.Repositories.Concretes
{
    public class FinanceRepository : Repository<FinData>, IFinanceRepository
    {
        public FinanceRepository(
            BepContext bepContext,
            IMapper mapper) : base(bepContext, mapper)
        {

        }

        async Task<IEnumerable<Core.Models.FinData>> IFinanceRepository.GetAllAsync()
        {
            var datas = await base.GetAllAsync();
            return datas.Select(s => this.mapper.Map<FinData, Core.Models.FinData>(s));
        }
    }
}
