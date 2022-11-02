using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class AlimentosMap : IEntityTypeConfiguration<AlimentosModel>
    {
        public void Configure(EntityTypeBuilder<AlimentosModel> builder)
        {
            builder.ToTable("Alimentos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeAlimento).HasColumnName("NomeAlimento").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.ValorCalorico).HasColumnName("ValorCalorico").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.ValorNutricional).HasColumnName("ValorNutricional").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("Descricao").HasColumnType("varchar").HasMaxLength(250).IsRequired();
            builder.Property(x => x.IdAlimentoSimilar1).HasColumnName("CafeDaManha1").HasColumnType("bigint");
            builder.Property(x => x.IdAlimentoSimilar2).HasColumnName("CafeDaManha1").HasColumnType("bigint");
            builder.Property(x => x.IdAlimentoSimilar3).HasColumnName("CafeDaManha1").HasColumnType("bigint");
        }
    }
}
