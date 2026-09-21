using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class OrdemServicoFuncionarioConfiguration : IEntityTypeConfiguration<OrdemServicoFuncionario> {
 public void Configure(EntityTypeBuilder<OrdemServicoFuncionario> b) {
  b.ConfigureCommon();
  b.Property(x => x.PercentualComissao).HasPrecision(15,3);
  b.Property(x => x.Funcao).HasMaxLength(255);
 }
}
