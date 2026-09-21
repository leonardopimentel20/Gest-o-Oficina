using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Auditoria : BaseEntity
{
    public Guid? UsuarioId { get; set; }
    public TipoAuditoria Tipo { get; set; }
    public string Entidade { get; set; }
    public Guid? EntidadeId { get; set; }
    public string? DadosAntes { get; set; }
    public string? DadosDepois { get; set; }
    public string? Ip { get; set; }
    public DateTimeOffset CriadaEm { get; set; }
}
