using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente> {
 public void Configure(EntityTypeBuilder<Cliente> b) {
  b.ConfigureCommon();
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Documento).HasMaxLength(255);
  b.Property(x => x.Email).HasMaxLength(255);
  b.Property(x => x.Observacoes).HasMaxLength(255);
 }
}
