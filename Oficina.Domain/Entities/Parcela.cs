using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Parcela : BaseEntity
{
    public Guid ContaReceberId { get; set; }
    public int Numero { get; set; }
    public DateTimeOffset Vencimento { get; set; }
    public decimal Valor { get; set; }
    public decimal ValorAberto { get; set; }
    public StatusParcela Status { get; set; }
}
