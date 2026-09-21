using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Diagnostico : BaseEntity
{
    public Guid OrdemServicoId { get; set; }
    public Guid? FuncionarioId { get; set; }
    public string Descricao { get; set; }
    public string? Recomendacoes { get; set; }
    public DateTimeOffset CriadoEm { get; set; }
}
