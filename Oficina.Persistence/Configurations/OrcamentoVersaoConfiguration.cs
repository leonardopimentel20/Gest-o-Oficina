using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class OrcamentoVersaoConfiguration : IEntityTypeConfiguration<OrcamentoVersao> {
 public void Configure(EntityTypeBuilder<OrcamentoVersao> b) {
  b.ConfigureCommon();
  b.Property(x => x.Subtotal).HasPrecision(15,3);
  b.Property(x => x.Desconto).HasPrecision(15,3);
  b.Property(x => x.Total).HasPrecision(15,3);
  b.Property(x => x.Observacoes).HasMaxLength(255);
 }
}
