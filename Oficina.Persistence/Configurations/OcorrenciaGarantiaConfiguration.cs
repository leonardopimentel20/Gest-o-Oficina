using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class OcorrenciaGarantiaConfiguration : IEntityTypeConfiguration<OcorrenciaGarantia> {
 public void Configure(EntityTypeBuilder<OcorrenciaGarantia> b) {
  b.ConfigureCommon();
  b.Property(x => x.Descricao).HasMaxLength(255);
  b.Property(x => x.Status).HasMaxLength(255);
  b.Property(x => x.Resolucao).HasMaxLength(255);
 }
}
