namespace Site.Mapper;

using AutoMapper;
using Core.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Models.BudgetData, BudgetData>().ReverseMap();
        CreateMap<Models.FinData, FinData>().ReverseMap();
    }
}