using AutoMapper;
using Core.Models;

namespace Business.Mapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Database.Models.BudgetData, BudgetData>().ReverseMap();
        CreateMap<Database.Models.FinData, FinData>().ReverseMap();
    }
}