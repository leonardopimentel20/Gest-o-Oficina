using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Caixa : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public DateTimeOffset DataAbertura { get; set; }
    public DateTimeOffset? DataFechamento { get; set; }
    public decimal SaldoInicial { get; set; }
    public decimal? SaldoFinal { get; set; }
    public string Status { get; set; }
}
