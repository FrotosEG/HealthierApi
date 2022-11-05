using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class FichaPesoMap : IEntityTypeConfiguration<FichaPesoModel>
    {
        public void Configure(EntityTypeBuilder<FichaPesoModel> builder)
        {
            builder.ToTable("fichapeso");
            builder.HasKey(x => x.id);

            builder.Property(x => x.IdUsuario).HasColumnName("idusuario").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.PesoUsuarioNaCriacao).HasColumnName("pesousuarionacriacao").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.TipoObjetivoUsuario).HasColumnName("tipoobjetivousuario").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.AlturaUsuario).HasColumnName("alturausuario").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.PesoDesejadoUsuario).HasColumnName("pesodesejadousuario").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.CinturaUsuario).HasColumnName("cinturausuario").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.IdFichaAlimentacao).HasColumnName("idfichaalimentacao").HasColumnType("bigint");
            builder.Property(x => x.FrequenciaAlimentar).HasColumnName("frequenciaalimentar").HasColumnType("int").IsRequired(); 
            builder.Property(x => x.IdAlergia1).HasColumnName("idalergia1").HasColumnType("smallint");
            builder.Property(x => x.IdAlergia2).HasColumnName("idalergia2").HasColumnType("smallint");
            builder.Property(x => x.IdAlergia3).HasColumnName("idalergia3").HasColumnType("smallint");
            builder.Property(x => x.IdAlergia4).HasColumnName("idalergia4").HasColumnType("smallint");
            builder.Property(x => x.IdAlergia5).HasColumnName("idalergia5").HasColumnType("smallint");

            builder.HasOne(d => d.Usuario).WithMany().HasForeignKey(d => d.IdUsuario);
            builder.HasOne(d => d.FichaAlimentacao).WithMany().HasForeignKey(d => d.IdFichaAlimentacao);
        }
    }
}
