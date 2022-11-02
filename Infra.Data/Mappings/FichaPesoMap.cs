using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class FichaPesoMap : IEntityTypeConfiguration<FichaPesoModel>
    {
        public void Configure(EntityTypeBuilder<FichaPesoModel> builder)
        {
            builder.ToTable("FichaPeso");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IdUsuario).HasColumnName("idUsuario").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.PesoUsuarioNaCriacao).HasColumnName("pesoUsuarioNaCriacao").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.TipoObjetivoUsuario).HasColumnName("TipoObjetivoUsuario").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.AlturaUsuario).HasColumnName("alturaUsuario").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.PesoDesejadoUsuario).HasColumnName("PesoDesejadoUsuario").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.CinturaUsuario).HasColumnName("CinturaUsuario").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.IdFichaAlimentacao).HasColumnName("IdFichaAlimentacao").HasColumnType("bigint");
            builder.Property(x => x.FrequenciaAlimentar).HasColumnName("FrequenciaAlimentar").HasColumnType("int").IsRequired(); 
            builder.Property(x => x.IdAlergia1).HasColumnName("IdAlergia1").HasColumnType("smallint");
            builder.Property(x => x.IdAlergia2).HasColumnName("IdAlergia2").HasColumnType("smallint");
            builder.Property(x => x.IdAlergia3).HasColumnName("IdAlergia3").HasColumnType("smallint");
            builder.Property(x => x.IdAlergia4).HasColumnName("IdAlergia4").HasColumnType("smallint");
            builder.Property(x => x.IdAlergia5).HasColumnName("IdAlergia5").HasColumnType("smallint");

            builder.HasOne(d => d.Usuario).WithMany().HasForeignKey(d => d.IdUsuario);
            builder.HasOne(d => d.FichaAlimentacao).WithMany().HasForeignKey(d => d.IdFichaAlimentacao);
        }
    }
}
