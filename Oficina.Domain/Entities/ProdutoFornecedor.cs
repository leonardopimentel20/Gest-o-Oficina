using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class ProdutoFornecedor : BaseEntity
{
    public Guid ProdutoId { get; set; }
    public Guid FornecedorId { get; set; }
    public string? CodigoFornecedor { get; set; }
    public decimal? PrecoUltimaCompra { get; set; }
    public int? PrazoGarantiaDias { get; set; }
}
