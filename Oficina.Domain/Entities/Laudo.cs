using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Laudo : BaseEntity
{
    public Guid OrdemServicoId { get; set; }
    public Guid ArquivoId { get; set; }
    public string Titulo { get; set; }
    public DateTimeOffset GeradoEm { get; set; }
}
