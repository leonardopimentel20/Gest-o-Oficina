using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ReservaEstoqueConfiguration : IEntityTypeConfiguration<ReservaEstoque> {
 public void Configure(EntityTypeBuilder<ReservaEstoque> b) {
  b.ConfigureCommon();
  b.Property(x => x.Quantidade).HasPrecision(15,3);
  b.Property(x => x.Status).HasMaxLength(255);
 }
}
