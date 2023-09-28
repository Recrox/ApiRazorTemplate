namespace Site.Mapper;

using AutoMapper;
using Core.Models;

public class MappingSite : Profile
{
    public MappingSite()
    {
        CreateMap<BudgetData, Models.BudgetData>().ReverseMap();
        CreateMap<FinData, Models.FinData>().ReverseMap();
    }
}