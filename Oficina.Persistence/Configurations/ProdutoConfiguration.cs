using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ProdutoConfiguration : IEntityTypeConfiguration<Produto> {
 public void Configure(EntityTypeBuilder<Produto> b) {
  b.ConfigureCommon();
  b.Property(x => x.Codigo).HasMaxLength(255);
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Descricao).HasMaxLength(255);
  b.Property(x => x.UnidadeMedida).HasMaxLength(255);
  b.Property(x => x.PrecoVenda).HasPrecision(15,3);
  b.Property(x => x.CustoMedio).HasPrecision(15,3);
  b.Property(x => x.EstoqueMinimo).HasPrecision(15,3);
  b.HasIndex(x => x.Codigo).IsUnique();
 }
}
