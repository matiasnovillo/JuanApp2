using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.CobradorBack.Repositories;
using JuanApp2.Areas.System.FailureBack.Interfaces;
using JuanApp2.Areas.System.FailureBack.Repositories;
using JuanApp2.DatabaseContexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

            var services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(configuration);

            services.AddDbContext<JuanApp2Context>();

            services.AddScoped<IFailureRepository, FailureRepository>();

            //Servicios de JuanApp2
            services.AddScoped<ICobradorRepository, CobradorRepository>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main(serviceProvider));
        }
    }
}