using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class FotoConfiguration : IEntityTypeConfiguration<Foto> {
 public void Configure(EntityTypeBuilder<Foto> b) {
  b.ConfigureCommon();
  b.Property(x => x.Descricao).HasMaxLength(255);
 }
}
