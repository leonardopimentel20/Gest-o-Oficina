using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco> {
 public void Configure(EntityTypeBuilder<Endereco> b) {
  b.ConfigureCommon();
  b.Property(x => x.Logradouro).HasMaxLength(255);
  b.Property(x => x.Numero).HasMaxLength(255);
  b.Property(x => x.Complemento).HasMaxLength(255);
  b.Property(x => x.Bairro).HasMaxLength(255);
  b.Property(x => x.Cidade).HasMaxLength(255);
  b.Property(x => x.Estado).HasMaxLength(255);
  b.Property(x => x.Cep).HasMaxLength(255);
 }
}
