using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class LaudoConfiguration : IEntityTypeConfiguration<Laudo> {
 public void Configure(EntityTypeBuilder<Laudo> b) {
  b.ConfigureCommon();
  b.Property(x => x.Titulo).HasMaxLength(255);
 }
}
