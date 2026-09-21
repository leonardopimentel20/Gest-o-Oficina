using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class PagamentoConfiguration : IEntityTypeConfiguration<Pagamento> {
 public void Configure(EntityTypeBuilder<Pagamento> b) {
  b.ConfigureCommon();
  b.Property(x => x.Valor).HasPrecision(15,3);
  b.Property(x => x.TransacaoReferencia).HasMaxLength(255);
  b.Property(x => x.Observacao).HasMaxLength(255);
 }
}
