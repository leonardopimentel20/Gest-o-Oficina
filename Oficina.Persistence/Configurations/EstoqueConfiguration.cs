using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque> {
 public void Configure(EntityTypeBuilder<Estoque> b) {
  b.ConfigureCommon();
  b.Property(x => x.QuantidadeDisponivel).HasPrecision(15,3);
  b.Property(x => x.QuantidadeReservada).HasPrecision(15,3);
  b.Property(x => x.Localizacao).HasMaxLength(255);
  b.HasIndex(x => new { x.UnidadeId, x.ProdutoId }).IsUnique();
 }
}
