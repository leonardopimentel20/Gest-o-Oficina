using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class OrcamentoAprovacao : BaseEntity
{
    public Guid OrcamentoVersaoId { get; set; }
    public Guid ClienteId { get; set; }
    public bool Aprovado { get; set; }
    public DateTimeOffset AprovadoEm { get; set; }
    public string? Ip { get; set; }
    public string? UserAgent { get; set; }
    public string? Observacao { get; set; }
}
