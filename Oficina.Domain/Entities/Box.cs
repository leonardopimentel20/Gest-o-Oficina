using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Box : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public string? Tipo { get; set; }
    public bool Ativo { get; set; }
}
