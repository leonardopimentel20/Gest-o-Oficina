using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class CategoriaServico : BaseEntity
{
    public string Nome { get; set; }
    public string? Descricao { get; set; }
    public bool Ativa { get; set; }
}
