using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class UsuarioPerfil : BaseEntity
{
    public Guid UsuarioId { get; set; }
    public Guid PerfilId { get; set; }
}
