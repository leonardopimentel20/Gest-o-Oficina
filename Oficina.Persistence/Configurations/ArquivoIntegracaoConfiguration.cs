using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ArquivoIntegracaoConfiguration : IEntityTypeConfiguration<ArquivoIntegracao> {
 public void Configure(EntityTypeBuilder<ArquivoIntegracao> b) {
  b.ConfigureCommon();
  b.Property(x => x.Provedor).HasMaxLength(255);
  b.Property(x => x.IdentificadorExterno).HasMaxLength(255);
  b.Property(x => x.Status).HasMaxLength(255);
 }
}
