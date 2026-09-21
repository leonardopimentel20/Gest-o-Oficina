using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class PerfilPermissao : BaseEntity
{
    public Guid PerfilId { get; set; }
    public Guid PermissaoId { get; set; }
}
