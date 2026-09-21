using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class GarantiaServico : BaseEntity
{
    public Guid GarantiaId { get; set; }
    public Guid ServicoId { get; set; }
    public int DiasGarantia { get; set; }
}
