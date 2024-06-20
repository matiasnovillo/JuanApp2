using JuanApp2.Areas.JuanApp2.CobradorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.CobradorBack.Repositories;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Interfaces;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Repositories;
using JuanApp2.Areas.JuanApp2.CompraBack.Interfaces;
using JuanApp2.Areas.JuanApp2.CompraBack.Repositories;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Repositories;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Repositories;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Repositories;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Interfaces;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Repositories;
using JuanApp2.Areas.JuanApp2.TipoDeMovimientoBack.Interfaces;
using JuanApp2.Areas.JuanApp2.TipoDeMovimientoBack.Repositories;
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
            services.AddScoped<ICobranzaRepository, CobranzaRepository>();
            services.AddScoped<IProveedorRepository, ProveedorRepository>();
            services.AddScoped<ICompraRepository, CompraRepository>();
            services.AddScoped<IModuloVarioRepository, ModuloVarioRepository>();
            services.AddScoped<IModuloGastoRepository, ModuloGastoRepository>();
            services.AddScoped<IModuloProveedorRepository, ModuloProveedorRepository>();
            services.AddScoped<ITipoDeMovimientoRepository, TipoDeMovimientoRepository>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main(serviceProvider));
        }
    }
}