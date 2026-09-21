using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor> {
 public void Configure(EntityTypeBuilder<Fornecedor> b) {
  b.ConfigureCommon();
  b.Property(x => x.RazaoSocial).HasMaxLength(255);
  b.Property(x => x.NomeFantasia).HasMaxLength(255);
  b.Property(x => x.Cnpj).HasMaxLength(255);
  b.Property(x => x.Email).HasMaxLength(255);
  b.Property(x => x.Telefone).HasMaxLength(255);
  b.HasIndex(x => x.Cnpj).IsUnique();
 }
}
