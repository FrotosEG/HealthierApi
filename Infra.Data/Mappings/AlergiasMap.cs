using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class AlergiasMap : IEntityTypeConfiguration<AlergiasModel>
    {
        public void Configure(EntityTypeBuilder<AlergiasModel> builder)
        {
            builder.ToTable("alergias");
            builder.HasKey(x => x.id);

            builder.Property(x => x.NomeAlergia).HasColumnName("nomealergia").HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar").HasMaxLength(250);
            builder.Property(x => x.Causas).HasColumnName("causas").HasColumnType("varchar").HasMaxLength(250);
        }
    }
}
