using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Services;
using Fretefy.Test.Infra.EntityFramework;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Fretefy.Test.WebApi
{
    // TODO: Remove this file
    
    // Migrate Startup class to sim0plified new program.cs approach with WebApplication class.
    // public class Startup
    // {
    //     public void ConfigureServices(IServiceCollection services)
    //     {
    //         services.AddScoped<DbContext, TestDbContext>();
    //         services.AddDbContext<TestDbContext>((provider, options) =>
    //         {
    //             options.UseSqlite("Data Source=Data\\Test.db");
    //         });

    //         ConfigureInfraService(services);
    //         ConfigureDomainService(services);

    //         services.AddMvc();
    //     }

    //     private void ConfigureDomainService(IServiceCollection services)
    //     {
    //         services.AddScoped<ICidadeService, CidadeService>();
    //     }

    //     private void ConfigureInfraService(IServiceCollection services)
    //     {
    //         services.AddScoped<ICidadeRepository, CidadeRepository>();
    //     }

    //     public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //     {
    //         if (env.IsDevelopment())
    //         {
    //             app.UseDeveloperExceptionPage();
    //         }

    //         app.UseRouting();

    //         app.UseEndpoints(endpoints =>
    //         {
    //             endpoints.MapControllers();
    //         });
    //     }
    // }
}
