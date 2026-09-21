using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class GarantiaServicoConfiguration : IEntityTypeConfiguration<GarantiaServico> {
 public void Configure(EntityTypeBuilder<GarantiaServico> b) {
  b.ConfigureCommon();
 }
}
