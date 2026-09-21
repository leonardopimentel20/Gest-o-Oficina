using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class EntradaEstoque : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public Guid? FornecedorId { get; set; }
    public string? NumeroDocumento { get; set; }
    public string? ChaveNfe { get; set; }
    public DateTimeOffset DataEntrada { get; set; }
    public decimal ValorTotal { get; set; }
    public Guid? XmlArquivoId { get; set; }
    public Guid? PdfArquivoId { get; set; }
}
