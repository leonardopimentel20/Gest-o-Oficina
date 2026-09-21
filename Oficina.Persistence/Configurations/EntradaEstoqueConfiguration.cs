using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class EntradaEstoqueConfiguration : IEntityTypeConfiguration<EntradaEstoque> {
 public void Configure(EntityTypeBuilder<EntradaEstoque> b) {
  b.ConfigureCommon();
  b.Property(x => x.NumeroDocumento).HasMaxLength(255);
  b.Property(x => x.ChaveNfe).HasMaxLength(255);
  b.Property(x => x.ValorTotal).HasPrecision(15,3);
 }
}
