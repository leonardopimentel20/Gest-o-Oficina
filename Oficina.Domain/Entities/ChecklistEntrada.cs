using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class ChecklistEntrada : BaseEntity
{
    public Guid VeiculoId { get; set; }
    public Guid? AgendamentoId { get; set; }
    public Guid? OrdemServicoId { get; set; }
    public decimal? KmEntrada { get; set; }
    public decimal? CombustivelPercentual { get; set; }
    public string? Observacoes { get; set; }
    public Guid? CriadoPorUsuarioId { get; set; }
}
