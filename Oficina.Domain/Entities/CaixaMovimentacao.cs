using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class CaixaMovimentacao : BaseEntity
{
    public Guid CaixaId { get; set; }
    public Guid? FormaPagamentoId { get; set; }
    public string Tipo { get; set; }
    public decimal Valor { get; set; }
    public string? Descricao { get; set; }
    public DateTimeOffset CriadoEm { get; set; }
}
