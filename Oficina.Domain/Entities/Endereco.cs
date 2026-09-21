using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Endereco : BaseEntity
{
    public Guid ClienteId { get; set; }
    public string Logradouro { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string? Cep { get; set; }
    public bool Principal { get; set; }
}
