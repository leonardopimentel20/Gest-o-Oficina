using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class UnidadeConfiguration : IEntityTypeConfiguration<Unidade> {
 public void Configure(EntityTypeBuilder<Unidade> b) {
  b.ConfigureCommon();
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Codigo).HasMaxLength(255);
  b.Property(x => x.Cnpj).HasMaxLength(255);
  b.Property(x => x.Telefone).HasMaxLength(255);
  b.Property(x => x.Email).HasMaxLength(255);
 }
}
