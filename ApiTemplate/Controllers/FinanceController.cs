using AutoMapper;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Site.Models;

namespace Site.Controllers;

[ApiController]
[Route("[controller]")]
public class FinanceController
{
    private readonly IMapper mapper;
    private readonly IFinanceDomain financeDomain;

    public FinanceController(
        IMapper mapper,
        IFinanceDomain financeDomain 
        )
    {
        this.mapper = mapper;
        this.financeDomain = financeDomain;
    }

    [HttpGet(Name = "Get")]
    public async Task<IEnumerable<FinData>> GetAllAsync() => this.mapper.Map<IEnumerable<Core.Models.FinData>, IEnumerable<FinData>>(await this.financeDomain.GetAllAsync());
}
