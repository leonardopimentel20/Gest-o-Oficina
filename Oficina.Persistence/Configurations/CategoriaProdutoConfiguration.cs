using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class CategoriaProdutoConfiguration : IEntityTypeConfiguration<CategoriaProduto> {
 public void Configure(EntityTypeBuilder<CategoriaProduto> b) {
  b.ConfigureCommon();
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Descricao).HasMaxLength(255);
 }
}
