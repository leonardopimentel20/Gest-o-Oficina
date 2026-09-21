using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Funcionario : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public string Nome { get; set; }
    public string? Documento { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public decimal PercentualComissaoPadrao { get; set; }
    public bool Ativo { get; set; }
}
