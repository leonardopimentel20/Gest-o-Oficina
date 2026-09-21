using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class ComissaoLancamento : BaseEntity
{
    public Guid OrdemServicoId { get; set; }
    public Guid FuncionarioId { get; set; }
    public TipoComissao Tipo { get; set; }
    public decimal BaseCalculo { get; set; }
    public decimal Percentual { get; set; }
    public decimal Valor { get; set; }
    public DateTimeOffset GeradoEm { get; set; }
    public DateTimeOffset? PagoEm { get; set; }
}
