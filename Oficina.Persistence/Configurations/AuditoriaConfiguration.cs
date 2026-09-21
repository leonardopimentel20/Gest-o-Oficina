using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria> {
 public void Configure(EntityTypeBuilder<Auditoria> b) {
  b.ConfigureCommon();
  b.Property(x => x.Entidade).HasMaxLength(255);
  b.Property(x => x.DadosAntes).HasMaxLength(255);
  b.Property(x => x.DadosDepois).HasMaxLength(255);
  b.Property(x => x.Ip).HasMaxLength(255);
 }
}
