using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class FormaPagamento : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public string Nome { get; set; }
    public string Tipo { get; set; }
    public bool Ativa { get; set; }
}
