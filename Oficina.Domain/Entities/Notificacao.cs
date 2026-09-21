using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Notificacao : BaseEntity
{
    public Guid? UsuarioId { get; set; }
    public TipoNotificacao Tipo { get; set; }
    public string Titulo { get; set; }
    public string Mensagem { get; set; }
    public DateTimeOffset? LidaEm { get; set; }
    public DateTimeOffset CriadaEm { get; set; }
}
