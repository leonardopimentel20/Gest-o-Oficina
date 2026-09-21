using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class CaixaMovimentacaoConfiguration : IEntityTypeConfiguration<CaixaMovimentacao> {
 public void Configure(EntityTypeBuilder<CaixaMovimentacao> b) {
  b.ConfigureCommon();
  b.Property(x => x.Tipo).HasMaxLength(255);
  b.Property(x => x.Valor).HasPrecision(15,3);
  b.Property(x => x.Descricao).HasMaxLength(255);
 }
}
