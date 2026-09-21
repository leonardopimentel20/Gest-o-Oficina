using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class CategoriaProduto : BaseEntity
{
    public string Nome { get; set; }
    public string? Descricao { get; set; }
    public bool Ativa { get; set; }
}
