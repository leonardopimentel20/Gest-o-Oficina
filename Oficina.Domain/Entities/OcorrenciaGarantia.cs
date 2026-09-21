using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class OcorrenciaGarantia : BaseEntity
{
    public Guid GarantiaId { get; set; }
    public string Descricao { get; set; }
    public DateTimeOffset AbertaEm { get; set; }
    public DateTimeOffset? EncerradaEm { get; set; }
    public string Status { get; set; }
    public string? Resolucao { get; set; }
}
