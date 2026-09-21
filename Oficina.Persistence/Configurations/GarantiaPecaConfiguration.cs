using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class GarantiaPecaConfiguration : IEntityTypeConfiguration<GarantiaPeca> {
 public void Configure(EntityTypeBuilder<GarantiaPeca> b) {
  b.ConfigureCommon();
  b.Property(x => x.Quantidade).HasPrecision(15,3);
 }
}
