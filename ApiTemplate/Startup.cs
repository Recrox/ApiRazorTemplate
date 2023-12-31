﻿using Business.Domains;
using Business.Interfaces;
using Database;
using Database.Mapper;
using Database.Repositories.Concretes;
using Database.Repositories.Interfaces;
using Site.Mapper;

namespace Site;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddDbContext<BepContext>();

        services.AddTransient<IFinanceRepository, FinanceRepository>();
        services.AddTransient<IFinanceDomain, FinanceDomain>();

        services.AddTransient<IBudgetRepository, BudgetRepository>();
        services.AddTransient<IBudgetDomain, BudgetDomain>();

        services.AddRazorPages();
        services.AddAutoMapper(cfg => {
            cfg.AddProfile<MappingSite>();
            cfg.AddProfile<MappingDatabase>();
        });
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseExceptionHandler("/Error");
        // La valeur HSTS par défaut est de 30 jours. Vous voudrez peut-être la changer pour les scénarios de production.
        app.UseHsts();

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
            endpoints.MapControllers();
        });
        
    }
}
