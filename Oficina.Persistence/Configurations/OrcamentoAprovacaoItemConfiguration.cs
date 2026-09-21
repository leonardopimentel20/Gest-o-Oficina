using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class OrcamentoAprovacaoItemConfiguration : IEntityTypeConfiguration<OrcamentoAprovacaoItem> {
 public void Configure(EntityTypeBuilder<OrcamentoAprovacaoItem> b) {
  b.ConfigureCommon();
 }
}
