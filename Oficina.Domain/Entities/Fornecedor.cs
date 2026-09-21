using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Fornecedor : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public string RazaoSocial { get; set; }
    public string? NomeFantasia { get; set; }
    public string? Cnpj { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public bool Ativo { get; set; }
}
