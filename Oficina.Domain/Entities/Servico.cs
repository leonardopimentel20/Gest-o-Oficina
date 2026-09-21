using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Servico : BaseEntity
{
    public Guid? CategoriaServicoId { get; set; }
    public string Codigo { get; set; }
    public string Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal PrecoPadrao { get; set; }
    public decimal? CustoPadrao { get; set; }
    public bool Ativo { get; set; }
}
