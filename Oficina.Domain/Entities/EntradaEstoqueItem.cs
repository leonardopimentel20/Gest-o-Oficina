using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class EntradaEstoqueItem : BaseEntity
{
    public Guid EntradaEstoqueId { get; set; }
    public Guid ProdutoId { get; set; }
    public decimal Quantidade { get; set; }
    public decimal CustoUnitario { get; set; }
    public string? Lote { get; set; }
    public int? GarantiaDias { get; set; }
}
