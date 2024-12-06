using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Services;
using Fretefy.Test.Infra.EntityFramework;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

// Refactor the code to use the WebApplication class.
var builder = WebApplication.CreateBuilder(args);

// Inject services into the container.
var services = builder.Services;


services.AddScoped<DbContext, TestDbContext>();

// Register DbContext
services.AddDbContext<TestDbContext>(options => {
    options.UseSqlite("Data Source=Data/Test.db");
    options.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
});
    

// Services injection. TODO: On Infra Module create DI classes for services registrations.
services.AddScoped<ICidadeRepository, CidadeRepository>();
services.AddScoped<ICidadeService, CidadeService>();

// Add Swagger services.
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Fretefy API", Version = "v1" });
});


// Add controllers.
services.AddControllers();

// Build the app.
var app = builder.Build();

// Ensure the database is created.
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TestDbContext>();
    context.Database.EnsureCreated();
}



// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
// specifying the Swagger JSON endpoint.
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Fretefy API V1");
    c.RoutePrefix = "docs"; //  Sets the path to the Swagger UI to /docs
});



// Configure the HTTP request pipeline.
app.UseRouting();
// Add controllers to the request pipeline.
app.MapControllers();

// Run the app.
app.Run();

// host.Run();

// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;

// namespace Fretefy.Test.WebApi
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             var host = CreateHostBuilder(args).Build();

//             // Apenas devido ao uso do InMemory
//             using (var scope = host.Services.CreateScope())
//             {
//                 var context = scope.ServiceProvider.GetRequiredService<TestDbContext>();
//                 context.Database.EnsureCreated();
//             }

//             host.Run();
//         }

//         public static IHostBuilder CreateHostBuilder(string[] args) =>
//             Host.CreateDefaultBuilder(args)
//                 .ConfigureWebHostDefaults(webBuilder =>
//                 {
//                     webBuilder.UseStartup<Startup>();
//                 });
//     }
// }
