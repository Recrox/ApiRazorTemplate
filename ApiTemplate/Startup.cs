using Business.Domains;
using Database;
using Database.Repositories;

namespace Site
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BepContext>();

            services.AddTransient<IFinanceRepository, FinanceRepository>();
            services.AddTransient<FinanceDomain, FinanceDomain>();

            services.AddTransient<IBudgetRepository, BudgetRepository>();
            services.AddTransient<BudgetDomain, BudgetDomain>();

            // Ajoutez d'autres services si nécessaire.
            services.AddRazorPages();
            services.AddAutoMapper(typeof(Startup));
        }

        public void Configure(IApplicationBuilder app)
        {
            if (!app.ApplicationServices.GetRequiredService<IHostEnvironment>().IsDevelopment())
            {
                app.UseSwagger();

                app.UseSwaggerUI();

                app.UseExceptionHandler("/Error");
                // La valeur HSTS par défaut est de 30 jours. Vous voudrez peut-être la changer pour les scénarios de production.
                app.UseHsts();
            }

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
