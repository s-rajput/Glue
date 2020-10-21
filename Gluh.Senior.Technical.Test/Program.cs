using System;
using Gluh.TechnicalTest.Data;
using Gluh.TechnicalTest.Interfaces;
using Gluh.TechnicalTest.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace Gluh.TechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging(o =>o.AddConsole())
                .AddDbContext<Context>(o => o.UseInMemoryDatabase(databaseName: "Optimizer3000"))
                .AddSingleton<Optimizer3000>()
                .AddSingleton<IPurchaseOptimizer, Purchaser>()
                .BuildServiceProvider();

            var logger = serviceProvider
                .GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            using (var scope = serviceProvider.CreateScope())
            {
                logger.LogInformation("Initializing Data");
                var services = scope.ServiceProvider;
                DataGenerator.Initialize(services);
            }

            logger.LogInformation("Optimizer 3000 is starting");
            serviceProvider.GetService<Optimizer3000>().Run();

            logger.LogInformation("Optimizer 3000 Complete! Press any key to exit.");
            var wait = Console.ReadKey();
        }
    }
}
