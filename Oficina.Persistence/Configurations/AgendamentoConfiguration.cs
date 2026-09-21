using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class AgendamentoConfiguration : IEntityTypeConfiguration<Agendamento> {
 public void Configure(EntityTypeBuilder<Agendamento> b) {
  b.ConfigureCommon();
  b.Property(x => x.Motivo).HasMaxLength(255);
  b.Property(x => x.Status).HasMaxLength(255);
  b.Property(x => x.Observacoes).HasMaxLength(255);
 }
}
