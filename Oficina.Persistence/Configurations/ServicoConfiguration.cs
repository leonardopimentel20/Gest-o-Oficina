using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ServicoConfiguration : IEntityTypeConfiguration<Servico> {
 public void Configure(EntityTypeBuilder<Servico> b) {
  b.ConfigureCommon();
  b.Property(x => x.Codigo).HasMaxLength(255);
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Descricao).HasMaxLength(255);
  b.Property(x => x.PrecoPadrao).HasPrecision(15,3);
  b.Property(x => x.CustoPadrao).HasPrecision(15,3);
  b.HasIndex(x => x.Codigo).IsUnique();
 }
}
