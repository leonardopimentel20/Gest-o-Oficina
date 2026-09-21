using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Foto : BaseEntity
{
    public Guid ArquivoId { get; set; }
    public Guid? VeiculoId { get; set; }
    public Guid? OrdemServicoId { get; set; }
    public Guid? DiagnosticoId { get; set; }
    public string? Descricao { get; set; }
    public DateTimeOffset TiradaEm { get; set; }
}
