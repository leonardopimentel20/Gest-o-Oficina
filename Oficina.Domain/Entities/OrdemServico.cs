using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class OrdemServico : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public Guid ClienteId { get; set; }
    public Guid VeiculoId { get; set; }
    public Guid? OrcamentoVersaoId { get; set; }
    public long Numero { get; set; }
    public StatusOrdemServico Status { get; set; }
    public DateTimeOffset AbertaEm { get; set; }
    public DateTimeOffset? ConcluidaEm { get; set; }
    public DateTimeOffset? EntregueEm { get; set; }
    public string? Observacoes { get; set; }
}
