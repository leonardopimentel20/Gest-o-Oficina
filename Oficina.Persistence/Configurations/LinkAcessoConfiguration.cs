using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class LinkAcessoConfiguration : IEntityTypeConfiguration<LinkAcesso> {
 public void Configure(EntityTypeBuilder<LinkAcesso> b) {
  b.ConfigureCommon();
  b.Property(x => x.TokenHash).HasMaxLength(255);
  b.HasIndex(x => x.TokenHash).IsUnique();
 }
}
