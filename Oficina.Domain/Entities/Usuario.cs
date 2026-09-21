using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Usuario : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public Guid? FuncionarioId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string SenhaHash { get; set; }
    public bool Ativo { get; set; }
    public DateTimeOffset? UltimoLoginEm { get; set; }
}
