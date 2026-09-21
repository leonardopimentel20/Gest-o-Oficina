using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class GarantiaPeca : BaseEntity
{
    public Guid GarantiaId { get; set; }
    public Guid ProdutoId { get; set; }
    public decimal Quantidade { get; set; }
    public int DiasGarantia { get; set; }
}
