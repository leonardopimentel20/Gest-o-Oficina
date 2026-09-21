using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Permissao : BaseEntity
{
    public string Codigo { get; set; }
    public string? Descricao { get; set; }
}
