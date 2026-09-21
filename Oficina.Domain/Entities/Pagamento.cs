using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Pagamento : BaseEntity
{
    public Guid ParcelaId { get; set; }
    public Guid FormaPagamentoId { get; set; }
    public decimal Valor { get; set; }
    public DateTimeOffset PagoEm { get; set; }
    public string? TransacaoReferencia { get; set; }
    public string? Observacao { get; set; }
}
