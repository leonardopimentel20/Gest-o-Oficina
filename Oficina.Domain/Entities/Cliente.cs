using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Cliente : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public TipoPessoa TipoPessoa { get; set; }
    public string Nome { get; set; }
    public string? Documento { get; set; }
    public string? Email { get; set; }
    public string? Observacoes { get; set; }
    public bool Ativo { get; set; }
}
