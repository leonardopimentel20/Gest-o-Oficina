using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class IntegracaoLogConfiguration : IEntityTypeConfiguration<IntegracaoLog> {
 public void Configure(EntityTypeBuilder<IntegracaoLog> b) {
  b.ConfigureCommon();
  b.Property(x => x.Provedor).HasMaxLength(255);
  b.Property(x => x.Operacao).HasMaxLength(255);
  b.Property(x => x.Mensagem).HasMaxLength(255);
  b.Property(x => x.ReferenciaExterna).HasMaxLength(255);
 }
}
