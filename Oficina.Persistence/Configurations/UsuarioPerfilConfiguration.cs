using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;
public class UsuarioPerfilConfiguration : IEntityTypeConfiguration<UsuarioPerfil> {
 public void Configure(EntityTypeBuilder<UsuarioPerfil> b) {
  b.ConfigureCommon();
 }
}
