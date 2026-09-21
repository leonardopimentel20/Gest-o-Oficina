using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class MovimentacaoEstoqueConfiguration : IEntityTypeConfiguration<MovimentacaoEstoque> {
 public void Configure(EntityTypeBuilder<MovimentacaoEstoque> b) {
  b.ConfigureCommon();
  b.Property(x => x.Quantidade).HasPrecision(15,3);
  b.Property(x => x.CustoUnitario).HasPrecision(15,3);
  b.Property(x => x.DocumentoReferencia).HasMaxLength(255);
  b.Property(x => x.Observacao).HasMaxLength(255);
 }
}
