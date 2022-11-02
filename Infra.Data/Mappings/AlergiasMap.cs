using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class AlergiasMap : IEntityTypeConfiguration<AlergiasModel>
    {
        public void Configure(EntityTypeBuilder<AlergiasModel> builder)
        {
            builder.ToTable("Alergias");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeAlergia).HasColumnName("NomeAlergia").HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.Descricao).HasColumnName("Descricao").HasColumnType("varchar").HasMaxLength(250);
            builder.Property(x => x.Causas).HasColumnName("Causas").HasColumnType("varchar").HasMaxLength(250);
        }
    }
}
