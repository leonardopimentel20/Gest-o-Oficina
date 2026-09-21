using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class ChecklistItem : BaseEntity
{
    public Guid ChecklistEntradaId { get; set; }
    public string Descricao { get; set; }
    public bool Conforme { get; set; }
    public string? Observacao { get; set; }
}
