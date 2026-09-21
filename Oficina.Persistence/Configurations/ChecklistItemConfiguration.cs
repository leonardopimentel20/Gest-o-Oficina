using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ChecklistItemConfiguration : IEntityTypeConfiguration<ChecklistItem> {
 public void Configure(EntityTypeBuilder<ChecklistItem> b) {
  b.ConfigureCommon();
  b.Property(x => x.Descricao).HasMaxLength(255);
  b.Property(x => x.Observacao).HasMaxLength(255);
 }
}
