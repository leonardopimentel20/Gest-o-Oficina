using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class MovimentacaoEstoque : BaseEntity
{
    public Guid EstoqueId { get; set; }
    public Guid? OrdemServicoId { get; set; }
    public Guid ProdutoId { get; set; }
    public TipoMovimentacaoEstoque Tipo { get; set; }
    public decimal Quantidade { get; set; }
    public decimal? CustoUnitario { get; set; }
    public string? DocumentoReferencia { get; set; }
    public string? Observacao { get; set; }
    public Guid? UsuarioId { get; set; }
    public DateTimeOffset MovimentadaEm { get; set; }
}
