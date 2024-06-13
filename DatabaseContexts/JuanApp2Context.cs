using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using JuanApp2.Areas.System.FailureBack.Entities;
using JuanApp2.Areas.System.FailureBack.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
using JuanApp2.Areas.JuanApp2.CobradorBack.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.CobranzaBack.Entities;
using JuanApp2.Areas.JuanApp2.CobranzaBack.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.ProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ProveedorBack.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.CompraBack.Entities;
using JuanApp2.Areas.JuanApp2.CompraBack.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.Entities;
using JuanApp2.Areas.JuanApp2.ModuloProveedorBack.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.ModuloVarioBack.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.ModuloGastoBack.EntitiesConfiguration;

namespace JuanApp2.DatabaseContexts
{
    public class JuanApp2Context : DbContext
    {
        protected IConfiguration _configuration { get; }

        public DbSet<Failure> Failure { get; set; }

        //DbSet de JuanApp2
        public DbSet<Cobrador> Cobrador { get; set; }
        public DbSet<Cobranza> Cobranza { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<ModuloVario> ModuloVario { get; set; }
        public DbSet<ModuloGasto> ModuloGasto { get; set; }
        public DbSet<ModuloProveedor> ModuloProveedor { get; set; }

        public JuanApp2Context(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string ConnectionString = "";
#if DEBUG
                ConnectionString = "data source =.; " +
                   "initial catalog = JuanApp2; " +
                   "Integrated Security = SSPI;" +
                   " MultipleActiveResultSets=True;" +
                   "Pooling=false;" +
                   "Persist Security Info=True;" +
                   "App=EntityFramework;" +
                   "TrustServerCertificate=True;";
#else
                string IP = "192.168.28.14";
                string Server = "sql4.baehost.com";

                ConnectionString = "Password=1vb&10tD5;" +
                    "Persist Security Info=True;" +
                    "User ID=fiyista1_JuanApp2Admin;" +
                    "Initial Catalog=fiyista1_JuanApp2;" +
                    "Data Source=sql4.baehost.com;" +
                    "TrustServerCertificate=True";
#endif
                optionsBuilder
                    .UseSqlServer(ConnectionString);
            }
            catch (Exception) { throw; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.ApplyConfiguration(new FailureConfiguration());
                modelBuilder.Entity<Failure>().ToTable("System.Failure");

                //JuanApp2
                modelBuilder.ApplyConfiguration(new CobradorConfiguration());
                modelBuilder.Entity<Cobrador>().ToTable("JuanApp2.Cobrador");
                modelBuilder.ApplyConfiguration(new CobranzaConfiguration());
                modelBuilder.Entity<Cobranza>().ToTable("JuanApp2.Cobranza");
                modelBuilder.ApplyConfiguration(new ProveedorConfiguration());
                modelBuilder.Entity<Proveedor>().ToTable("JuanApp2.Proveedor");
                modelBuilder.ApplyConfiguration(new ModuloProveedorConfiguration());
                modelBuilder.Entity<ModuloProveedor>().ToTable("JuanApp2.ModuloProveedor");
                modelBuilder.ApplyConfiguration(new ModuloVarioConfiguration());
                modelBuilder.Entity<ModuloVario>().ToTable("JuanApp2.ModuloVario");
                modelBuilder.ApplyConfiguration(new ModuloGastoConfiguration());
                modelBuilder.Entity<Compra>().ToTable("JuanApp2.ModuloGasto");
            }
            catch (Exception) { throw; }
        }
    }
}
