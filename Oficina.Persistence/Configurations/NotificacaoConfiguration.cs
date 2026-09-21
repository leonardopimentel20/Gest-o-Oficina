using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class NotificacaoConfiguration : IEntityTypeConfiguration<Notificacao> {
 public void Configure(EntityTypeBuilder<Notificacao> b) {
  b.ConfigureCommon();
  b.Property(x => x.Titulo).HasMaxLength(255);
  b.Property(x => x.Mensagem).HasMaxLength(255);
 }
}
