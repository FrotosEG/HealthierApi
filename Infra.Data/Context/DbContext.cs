using Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions options) : base(options)
        {
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

    }
}
