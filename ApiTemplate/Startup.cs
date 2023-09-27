using Business.Domains;
using Database;
using Database.Repositories;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Site
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<BepContext>();

            services.AddTransient<IFinanceRepository, FinanceRepository>();
            services.AddTransient<FinanceDomain, FinanceDomain>();

            services.AddTransient<IBudgetRepository, BudgetRepository>();
            services.AddTransient<BudgetDomain, BudgetDomain>();

            // Ajoutez d'autres services si nécessaire.
            services.AddRazorPages();
            services.AddAutoMapper(typeof(Startup));
            
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            //});

        }

        public void Configure(IApplicationBuilder app)
        {
            //if (app.Environment.IsDevelopment())
            //{ 
            
            //}
            app.UseSwagger();

            app.UseSwaggerUI();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            //});

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
}
