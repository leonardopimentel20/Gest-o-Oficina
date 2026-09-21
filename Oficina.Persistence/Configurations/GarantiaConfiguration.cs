using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class GarantiaConfiguration : IEntityTypeConfiguration<Garantia> {
 public void Configure(EntityTypeBuilder<Garantia> b) {
  b.ConfigureCommon();
  b.Property(x => x.Observacoes).HasMaxLength(255);
 }
}
