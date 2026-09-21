using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Perfil : BaseEntity
{
    public string Nome { get; set; }
    public string? Descricao { get; set; }
    public bool Ativo { get; set; }
}
