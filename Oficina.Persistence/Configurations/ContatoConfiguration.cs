using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ContatoConfiguration : IEntityTypeConfiguration<Contato> {
 public void Configure(EntityTypeBuilder<Contato> b) {
  b.ConfigureCommon();
  b.Property(x => x.Valor).HasMaxLength(255);
 }
}
