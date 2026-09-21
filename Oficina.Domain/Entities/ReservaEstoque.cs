using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class ReservaEstoque : BaseEntity
{
    public Guid OrdemServicoId { get; set; }
    public Guid ProdutoId { get; set; }
    public decimal Quantidade { get; set; }
    public string Status { get; set; }
    public DateTimeOffset ReservadaEm { get; set; }
    public DateTimeOffset? LiberadaEm { get; set; }
}
