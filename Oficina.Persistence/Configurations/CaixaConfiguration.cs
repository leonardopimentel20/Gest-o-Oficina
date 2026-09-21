using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class CaixaConfiguration : IEntityTypeConfiguration<Caixa> {
 public void Configure(EntityTypeBuilder<Caixa> b) {
  b.ConfigureCommon();
  b.Property(x => x.SaldoInicial).HasPrecision(15,3);
  b.Property(x => x.SaldoFinal).HasPrecision(15,3);
  b.Property(x => x.Status).HasMaxLength(255);
 }
}
