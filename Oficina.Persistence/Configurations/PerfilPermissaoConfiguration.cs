using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class PerfilPermissaoConfiguration : IEntityTypeConfiguration<PerfilPermissao> {
 public void Configure(EntityTypeBuilder<PerfilPermissao> b) {
  b.ConfigureCommon();
 }
}
