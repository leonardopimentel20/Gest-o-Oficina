using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Unidade : BaseEntity
{
    public Guid EmpresaId { get; set; }
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public string? Cnpj { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public bool Ativa { get; set; }
}
