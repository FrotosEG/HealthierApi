using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class FichaAlimentacaoMap : IEntityTypeConfiguration<FichaAlimentacaoModel>
    {
        public void Configure(EntityTypeBuilder<FichaAlimentacaoModel> builder)
        {
            builder.ToTable("FichaAlimentacao");
            builder.HasKey(x => x.id);

            builder.Property(x => x.CafeDaManha1).HasColumnName("CafeDaManha1").HasColumnType("bigint");
            builder.Property(x => x.CafeDaManha2).HasColumnName("CafeDaManha2").HasColumnType("bigint");
            builder.Property(x => x.CafeDaManha3).HasColumnName("CafeDaManha3").HasColumnType("bigint");
            builder.Property(x => x.CafeDaManha4).HasColumnName("CafeDaManha4").HasColumnType("bigint");
            builder.Property(x => x.CafeDaManha5).HasColumnName("CafeDaManha5").HasColumnType("bigint");
            builder.Property(x => x.Almoco1).HasColumnName("Almoco1").HasColumnType("bigint");
            builder.Property(x => x.Almoco2).HasColumnName("Almoco2").HasColumnType("bigint");
            builder.Property(x => x.Almoco3).HasColumnName("Almoco3").HasColumnType("bigint");
            builder.Property(x => x.Almoco4).HasColumnName("Almoco4").HasColumnType("bigint");
            builder.Property(x => x.Almoco5).HasColumnName("Almoco5").HasColumnType("bigint");
            builder.Property(x => x.CafeDaTarde1).HasColumnName("CafeDaTarde1").HasColumnType("bigint");
            builder.Property(x => x.CafeDaTarde2).HasColumnName("CafeDaTarde2").HasColumnType("bigint");
            builder.Property(x => x.CafeDaTarde3).HasColumnName("CafeDaTarde3").HasColumnType("bigint");
            builder.Property(x => x.CafeDaTarde4).HasColumnName("CafeDaTarde4").HasColumnType("bigint");
            builder.Property(x => x.CafeDaTarde5).HasColumnName("CafeDaTarde5").HasColumnType("bigint");
            builder.Property(x => x.Janta1).HasColumnName("Janta1").HasColumnType("bigint");
            builder.Property(x => x.Janta2).HasColumnName("Janta2").HasColumnType("bigint");
            builder.Property(x => x.Janta3).HasColumnName("Janta3").HasColumnType("bigint");
            builder.Property(x => x.Janta4).HasColumnName("Janta4").HasColumnType("bigint");
            builder.Property(x => x.Janta5).HasColumnName("Janta5").HasColumnType("bigint");
        }
    }
}
