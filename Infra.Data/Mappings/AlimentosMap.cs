using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class AlimentosMap : IEntityTypeConfiguration<AlimentosModel>
    {
        public void Configure(EntityTypeBuilder<AlimentosModel> builder)
        {
            builder.ToTable("alimentos");
            builder.HasKey(x => x.id);

            builder.Property(x => x.NomeAlimento).HasColumnName("nomealimento").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.ValorCalorico).HasColumnName("valorcalorico").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.ValorNutricional).HasColumnName("valornutricional").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar").HasMaxLength(250).IsRequired();
            builder.Property(x => x.IdAlimentoSimilar1).HasColumnName("idalimentosimilar1").HasColumnType("bigint");
            builder.Property(x => x.IdAlimentoSimilar2).HasColumnName("idalimentosimilar2").HasColumnType("bigint");
            builder.Property(x => x.IdAlimentoSimilar3).HasColumnName("idalimentosimilar3").HasColumnType("bigint");
        }
    }
}
