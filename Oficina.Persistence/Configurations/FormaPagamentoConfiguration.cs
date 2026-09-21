using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento> {
 public void Configure(EntityTypeBuilder<FormaPagamento> b) {
  b.ConfigureCommon();
  b.Property(x => x.Nome).HasMaxLength(255);
  b.Property(x => x.Tipo).HasMaxLength(255);
 }
}
