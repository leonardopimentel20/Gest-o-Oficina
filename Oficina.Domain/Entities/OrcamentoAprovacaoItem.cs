using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class OrcamentoAprovacaoItem : BaseEntity
{
    public Guid OrcamentoAprovacaoId { get; set; }
    public Guid OrcamentoItemId { get; set; }
    public bool Aprovado { get; set; }
}
