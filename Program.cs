using JuanApp2.Areas.BasicCore;
using JuanApp2.Areas.BasicCore.Interfaces;
using JuanApp2.Areas.BasicCore.Repositories;
using JuanApp2.Areas.JuanApp2.Interfaces;
using JuanApp2.Areas.JuanApp2.Repositories;
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
            services.AddScoped<ICajaRepository, CajaRepository>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main(serviceProvider));
        }
    }
}