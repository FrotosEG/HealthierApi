using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.ToTable("usuario");
            builder.HasKey(x => x.id);
            
            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Cpf).HasColumnName("cpf").HasColumnType("varchar").HasMaxLength(11);
            builder.Property(x => x.TelefoneDDD).HasColumnName("telefoneddd").HasColumnType("varchar").HasMaxLength(2);
            builder.Property(x => x.Telefone).HasColumnName("telefone").HasColumnType("varchar").HasMaxLength(9);
            builder.Property(x => x.Email).HasColumnName("email").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Premium).HasColumnName("premium").HasColumnType("smallint");
            builder.Property(x => x.SenhaCriptografada).HasColumnName("senhacriptografada").HasColumnType("varchar").HasMaxLength(100).IsRequired();
        }
    }
}
