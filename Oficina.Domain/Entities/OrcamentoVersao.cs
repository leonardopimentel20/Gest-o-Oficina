using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class OrcamentoVersao : BaseEntity
{
    public Guid OrcamentoId { get; set; }
    public int Numero { get; set; }
    public StatusOrcamento Status { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Desconto { get; set; }
    public decimal Total { get; set; }
    public string? Observacoes { get; set; }
    public bool Imutavel { get; set; }
}
