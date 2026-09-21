using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class ComissaoLancamentoConfiguration : IEntityTypeConfiguration<ComissaoLancamento> {
 public void Configure(EntityTypeBuilder<ComissaoLancamento> b) {
  b.ConfigureCommon();
  b.Property(x => x.BaseCalculo).HasPrecision(15,3);
  b.Property(x => x.Percentual).HasPrecision(15,3);
  b.Property(x => x.Valor).HasPrecision(15,3);
 }
}
