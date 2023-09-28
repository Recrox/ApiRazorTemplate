using AutoMapper;
using Core.Models;

namespace Database.Mapper;
public class MappingDatabase : Profile
{
    public MappingDatabase()
    {
        CreateMap<Models.BudgetData, BudgetData>().ReverseMap();
        CreateMap<Models.FinData, FinData>().ReverseMap();
    }
}