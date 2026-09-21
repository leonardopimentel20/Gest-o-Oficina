using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario> {
 public void Configure(EntityTypeBuilder<Usuario> b) {
  b.ConfigureCommon();
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Email).HasMaxLength(255);
  b.Property(x => x.SenhaHash).HasMaxLength(255);
  b.HasIndex(x => x.Email).IsUnique();
 }
}
