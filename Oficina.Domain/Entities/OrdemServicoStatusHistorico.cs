using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class OrdemServicoStatusHistorico : BaseEntity
{
    public Guid OrdemServicoId { get; set; }
    public StatusOrdemServico? StatusAnterior { get; set; }
    public StatusOrdemServico StatusNovo { get; set; }
    public DateTimeOffset AlteradoEm { get; set; }
    public Guid? UsuarioId { get; set; }
    public string? Observacao { get; set; }
}
