using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class EntradaEstoqueItemConfiguration : IEntityTypeConfiguration<EntradaEstoqueItem> {
 public void Configure(EntityTypeBuilder<EntradaEstoqueItem> b) {
  b.ConfigureCommon();
  b.Property(x => x.Quantidade).HasPrecision(15,3);
  b.Property(x => x.CustoUnitario).HasPrecision(15,3);
  b.Property(x => x.Lote).HasMaxLength(255);
 }
}
