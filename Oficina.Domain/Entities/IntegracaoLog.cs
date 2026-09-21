using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class IntegracaoLog : BaseEntity
{
    public string Provedor { get; set; }
    public string Operacao { get; set; }
    public bool Sucesso { get; set; }
    public string? Mensagem { get; set; }
    public string? ReferenciaExterna { get; set; }
    public DateTimeOffset CriadoEm { get; set; }
}
