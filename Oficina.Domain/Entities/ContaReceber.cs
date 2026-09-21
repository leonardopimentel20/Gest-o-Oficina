using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class ContaReceber : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public Guid? ClienteId { get; set; }
    public Guid? OrdemServicoId { get; set; }
    public string Descricao { get; set; }
    public decimal ValorOriginal { get; set; }
    public decimal ValorAberto { get; set; }
    public DateTimeOffset Vencimento { get; set; }
    public StatusParcela Status { get; set; }
}
