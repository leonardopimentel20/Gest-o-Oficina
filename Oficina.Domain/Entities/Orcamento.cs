using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Orcamento : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public Guid ClienteId { get; set; }
    public Guid VeiculoId { get; set; }
    public long Numero { get; set; }
    public StatusOrcamento Status { get; set; }
    public DateTimeOffset? ValidadeEm { get; set; }
    public int VersaoAtualNumero { get; set; }
    public string? Observacoes { get; set; }
}
