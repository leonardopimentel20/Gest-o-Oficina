using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Garantia : BaseEntity
{
    public Guid OrdemServicoId { get; set; }
    public Guid ClienteId { get; set; }
    public Guid VeiculoId { get; set; }
    public TipoGarantia Tipo { get; set; }
    public StatusGarantia Status { get; set; }
    public DateTimeOffset InicioEm { get; set; }
    public DateTimeOffset FimEm { get; set; }
    public string? Observacoes { get; set; }
}
