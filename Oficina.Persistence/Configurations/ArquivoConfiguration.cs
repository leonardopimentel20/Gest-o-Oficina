using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ArquivoConfiguration : IEntityTypeConfiguration<Arquivo> {
 public void Configure(EntityTypeBuilder<Arquivo> b) {
  b.ConfigureCommon();
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Caminho).HasMaxLength(255);
  b.Property(x => x.ContentType).HasMaxLength(255);
  b.Property(x => x.Hash).HasMaxLength(255);
  b.Property(x => x.DriveFileId).HasMaxLength(255);
 }
}
