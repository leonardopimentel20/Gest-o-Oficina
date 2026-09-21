using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class OrcamentoAprovacaoConfiguration : IEntityTypeConfiguration<OrcamentoAprovacao> {
 public void Configure(EntityTypeBuilder<OrcamentoAprovacao> b) {
  b.ConfigureCommon();
  b.Property(x => x.Ip).HasMaxLength(255);
  b.Property(x => x.UserAgent).HasMaxLength(255);
  b.Property(x => x.Observacao).HasMaxLength(255);
 }
}
