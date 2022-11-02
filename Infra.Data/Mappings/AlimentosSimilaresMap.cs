using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class AlimentosSimilaresMap : IEntityTypeConfiguration<AlimentosSimilaresModel>
    {
        public void Configure(EntityTypeBuilder<AlimentosSimilaresModel> builder)
        {
            builder.ToTable("AlimentosSimilares");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeAlimento).HasColumnName("NomeAlimento").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.ValorCalorico).HasColumnName("ValorCalorico").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.ValorNutricional).HasColumnName("ValorNutricional").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("Descricao").HasColumnType("varchar").HasMaxLength(250).IsRequired();
            builder.Property(x => x.MotivosParaSubstituirOutroAlimento).HasColumnName("MotivosParaSubstituirOutroAlimento").HasColumnType("varchar").HasMaxLength(300).IsRequired();
        }
    }
}
