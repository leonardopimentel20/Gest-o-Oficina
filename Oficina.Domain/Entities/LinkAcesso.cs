using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class LinkAcesso : BaseEntity
{
    public Guid? OrcamentoId { get; set; }
    public Guid? OrcamentoVersaoId { get; set; }
    public Guid? OrdemServicoId { get; set; }
    public string TokenHash { get; set; }
    public DateTimeOffset ExpiraEm { get; set; }
    public DateTimeOffset? RevogadoEm { get; set; }
    public DateTimeOffset? UltimoAcessoEm { get; set; }
}
