using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using JuanApp2.Areas.System.FailureBack.Entities;
using JuanApp2.Areas.System.FailureBack.EntitiesConfiguration;
using JuanApp2.Areas.JuanApp2.CobradorBack.Entities;
using JuanApp2.Areas.JuanApp2.CobradorBack.EntitiesConfiguration;

namespace JuanApp2.DatabaseContexts
{
    public class JuanApp2Context : DbContext
    {
        protected IConfiguration _configuration { get; }

        public DbSet<Failure> Failure { get; set; }

        //DbSet de JuanApp2
        public DbSet<Cobrador> Cobrador { get; set; }

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
                modelBuilder.Entity<Failure>().ToTable("System.Failure");

                //JuanApp2
                modelBuilder.ApplyConfiguration(new CobradorConfiguration());
                modelBuilder.Entity<Cobrador>().ToTable("JuanApp2.Cobrador");
            }
            catch (Exception) { throw; }
        }
    }
}
