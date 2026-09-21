using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ChecklistEntradaConfiguration : IEntityTypeConfiguration<ChecklistEntrada> {
 public void Configure(EntityTypeBuilder<ChecklistEntrada> b) {
  b.ConfigureCommon();
  b.Property(x => x.KmEntrada).HasPrecision(15,3);
  b.Property(x => x.CombustivelPercentual).HasPrecision(15,3);
  b.Property(x => x.Observacoes).HasMaxLength(255);
 }
}
