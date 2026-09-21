using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Produto : BaseEntity
{
    public Guid? CategoriaProdutoId { get; set; }
    public string Codigo { get; set; }
    public string Nome { get; set; }
    public string? Descricao { get; set; }
    public string UnidadeMedida { get; set; }
    public decimal PrecoVenda { get; set; }
    public decimal CustoMedio { get; set; }
    public decimal EstoqueMinimo { get; set; }
    public bool Ativo { get; set; }
}
