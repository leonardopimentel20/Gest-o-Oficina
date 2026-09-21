using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class ArquivoIntegracao : BaseEntity
{
    public Guid ArquivoId { get; set; }
    public string Provedor { get; set; }
    public string IdentificadorExterno { get; set; }
    public string Status { get; set; }
    public DateTimeOffset? UltimaSincronizacaoEm { get; set; }
}
