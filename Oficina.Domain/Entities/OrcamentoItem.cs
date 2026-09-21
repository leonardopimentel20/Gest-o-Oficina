using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class OrcamentoItem : BaseEntity
{
    public Guid OrcamentoVersaoId { get; set; }
    public Guid? ServicoId { get; set; }
    public Guid? ProdutoId { get; set; }
    public string Descricao { get; set; }
    public decimal Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal Desconto { get; set; }
    public decimal Total { get; set; }
    public bool Aprovado { get; set; }
}
