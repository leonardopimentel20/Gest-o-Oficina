using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo> {
 public void Configure(EntityTypeBuilder<Veiculo> b) {
  b.ConfigureCommon();
  b.Property(x => x.Placa).HasMaxLength(255);
  b.Property(x => x.Renavam).HasMaxLength(255);
  b.Property(x => x.Chassi).HasMaxLength(255);
  b.Property(x => x.Marca).HasMaxLength(255);
  b.Property(x => x.Modelo).HasMaxLength(255);
  b.Property(x => x.Cor).HasMaxLength(255);
  b.Property(x => x.KmAtual).HasPrecision(15,3);
  b.Property(x => x.Observacoes).HasMaxLength(255);
  b.HasIndex(x => x.Placa).IsUnique();
 }
}
