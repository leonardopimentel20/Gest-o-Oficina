using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class OrcamentoConfiguration : IEntityTypeConfiguration<Orcamento> {
 public void Configure(EntityTypeBuilder<Orcamento> b) {
  b.ConfigureCommon();
  b.Property(x => x.Observacoes).HasMaxLength(255);
  b.HasIndex(x => new { x.UnidadeId, x.Numero }).IsUnique();
 }
}
