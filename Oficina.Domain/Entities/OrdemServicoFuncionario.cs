using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class OrdemServicoFuncionario : BaseEntity
{
    public Guid OrdemServicoId { get; set; }
    public Guid FuncionarioId { get; set; }
    public decimal PercentualComissao { get; set; }
    public string? Funcao { get; set; }
}
