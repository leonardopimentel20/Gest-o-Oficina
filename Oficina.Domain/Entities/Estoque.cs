using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Estoque : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public Guid ProdutoId { get; set; }
    public decimal QuantidadeDisponivel { get; set; }
    public decimal QuantidadeReservada { get; set; }
    public string? Localizacao { get; set; }
}
