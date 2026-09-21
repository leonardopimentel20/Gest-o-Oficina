using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario> {
 public void Configure(EntityTypeBuilder<Funcionario> b) {
  b.ConfigureCommon();
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Documento).HasMaxLength(255);
  b.Property(x => x.Email).HasMaxLength(255);
  b.Property(x => x.Telefone).HasMaxLength(255);
  b.Property(x => x.PercentualComissaoPadrao).HasPrecision(15,3);
 }
}
