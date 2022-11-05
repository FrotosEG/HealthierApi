using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class AlimentosSimilaresMap : IEntityTypeConfiguration<AlimentosSimilaresModel>
    {
        public void Configure(EntityTypeBuilder<AlimentosSimilaresModel> builder)
        {
            builder.ToTable("alimentossimilares");
            builder.HasKey(x => x.id);

            builder.Property(x => x.NomeAlimento).HasColumnName("nomealimento").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.ValorCalorico).HasColumnName("valorcalorico").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.ValorNutricional).HasColumnName("valornutricional").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar").HasMaxLength(250).IsRequired();
            builder.Property(x => x.MotivosParaSubstituirOutroAlimento).HasColumnName("motivosparasubstituiroutroalimento").HasColumnType("varchar").HasMaxLength(300).IsRequired();
        }
    }
}
