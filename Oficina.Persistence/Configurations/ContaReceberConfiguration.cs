using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ContaReceberConfiguration : IEntityTypeConfiguration<ContaReceber> {
 public void Configure(EntityTypeBuilder<ContaReceber> b) {
  b.ConfigureCommon();
  b.Property(x => x.Descricao).HasMaxLength(255);
  b.Property(x => x.ValorOriginal).HasPrecision(15,3);
  b.Property(x => x.ValorAberto).HasPrecision(15,3);
 }
}
