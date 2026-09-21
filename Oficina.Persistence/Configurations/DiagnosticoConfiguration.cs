using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class DiagnosticoConfiguration : IEntityTypeConfiguration<Diagnostico> {
 public void Configure(EntityTypeBuilder<Diagnostico> b) {
  b.ConfigureCommon();
  b.Property(x => x.Descricao).HasMaxLength(255);
  b.Property(x => x.Recomendacoes).HasMaxLength(255);
 }
}
