using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ProdutoFornecedorConfiguration : IEntityTypeConfiguration<ProdutoFornecedor> {
 public void Configure(EntityTypeBuilder<ProdutoFornecedor> b) {
  b.ConfigureCommon();
  b.Property(x => x.CodigoFornecedor).HasMaxLength(255);
  b.Property(x => x.PrecoUltimaCompra).HasPrecision(15,3);
 }
}
