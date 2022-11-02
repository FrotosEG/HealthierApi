using Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra.Data.Context
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly IConfiguration _configuration;
        private string databaseName = "dd33aupr9q3mt1";
        public DbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new AlergiasMap());
            modelBuilder.ApplyConfiguration(new AlimentosMap());
            modelBuilder.ApplyConfiguration(new AlimentosSimilaresMap());
            modelBuilder.ApplyConfiguration(new FichaAlimentacaoMap());
            modelBuilder.ApplyConfiguration(new FichaPesoMap());
            modelBuilder.ApplyConfiguration(new FichaAlimentacaoMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString(databaseName));
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
