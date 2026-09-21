using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class OrdemServicoStatusHistoricoConfiguration : IEntityTypeConfiguration<OrdemServicoStatusHistorico> {
 public void Configure(EntityTypeBuilder<OrdemServicoStatusHistorico> b) {
  b.ConfigureCommon();
  b.Property(x => x.Observacao).HasMaxLength(255);
 }
}
