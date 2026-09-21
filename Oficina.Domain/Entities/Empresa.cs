using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Empresa : BaseEntity
{
    public string RazaoSocial { get; set; }
    public string? NomeFantasia { get; set; }
    public string? Cnpj { get; set; }
    public string? InscricaoEstadual { get; set; }
    public bool Ativa { get; set; }
}
