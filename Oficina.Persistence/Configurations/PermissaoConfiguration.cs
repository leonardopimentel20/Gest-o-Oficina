using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class PermissaoConfiguration : IEntityTypeConfiguration<Permissao> {
 public void Configure(EntityTypeBuilder<Permissao> b) {
  b.ConfigureCommon();
  b.Property(x => x.Codigo).HasMaxLength(255);
  b.Property(x => x.Descricao).HasMaxLength(255);
 }
}
