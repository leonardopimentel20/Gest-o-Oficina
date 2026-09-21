using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Contato : BaseEntity
{
    public Guid ClienteId { get; set; }
    public TipoContato Tipo { get; set; }
    public string Valor { get; set; }
    public bool Principal { get; set; }
}
