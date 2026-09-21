using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class OrdemServicoItemConfiguration : IEntityTypeConfiguration<OrdemServicoItem> {
 public void Configure(EntityTypeBuilder<OrdemServicoItem> b) {
  b.ConfigureCommon();
  b.Property(x => x.Descricao).HasMaxLength(255);
  b.Property(x => x.Quantidade).HasPrecision(15,3);
  b.Property(x => x.ValorUnitario).HasPrecision(15,3);
  b.Property(x => x.Desconto).HasPrecision(15,3);
  b.Property(x => x.Total).HasPrecision(15,3);
  b.Property(x => x.Tipo).HasMaxLength(255);
 }
}
