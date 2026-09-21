using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Veiculo : BaseEntity
{
    public Guid ClienteId { get; set; }
    public string Placa { get; set; }
    public string? Renavam { get; set; }
    public string? Chassi { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int? Ano { get; set; }
    public string? Cor { get; set; }
    public TipoVeiculo Tipo { get; set; }
    public decimal? KmAtual { get; set; }
    public string? Observacoes { get; set; }
}
