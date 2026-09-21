using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa> {
 public void Configure(EntityTypeBuilder<Empresa> b) {
  b.ConfigureCommon();
  b.Property(x => x.RazaoSocial).HasMaxLength(255);
  b.Property(x => x.NomeFantasia).HasMaxLength(255);
  b.Property(x => x.Cnpj).HasMaxLength(255);
  b.Property(x => x.InscricaoEstadual).HasMaxLength(255);
  b.HasIndex(x => x.Cnpj).IsUnique();
 }
}
