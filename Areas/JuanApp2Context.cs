using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using JuanApp2.Areas.BasicCore.Entities;
using JuanApp2.Areas.BasicCore.Entities.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.Entities;
using JuanApp2.Areas.JuanApp2.Entities.EntitiesConfiguration;

namespace JuanApp2.Areas.BasicCore
{
    public class JuanApp2Context : DbContext
    {
        protected IConfiguration _configuration { get; }

        public DbSet<Failure> Failure { get; set; }

        //DbSet de JuanApp2
        public DbSet<Caja> Caja { get; set; }

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

                ConnectionString = "Password=Zc2s4~7n0;" +
                    "Persist Security Info=True;" +
                    "User ID=fiyista1_JuanAppAdmin;" +
                    "Initial Catalog=fiyista1_JuanApp;" +
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
                modelBuilder.ApplyConfiguration(new CajaConfiguration());
            }
            catch (Exception) { throw; }
        }
    }
}
