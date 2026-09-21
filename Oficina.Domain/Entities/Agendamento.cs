using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Agendamento : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public Guid ClienteId { get; set; }
    public Guid VeiculoId { get; set; }
    public Guid? BoxId { get; set; }
    public DateTimeOffset Inicio { get; set; }
    public DateTimeOffset Fim { get; set; }
    public string? Motivo { get; set; }
    public string Status { get; set; }
    public string? Observacoes { get; set; }
}
