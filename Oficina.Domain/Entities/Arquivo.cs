using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities;

public class Arquivo : BaseEntity
{
    public Guid UnidadeId { get; set; }
    public string Nome { get; set; }
    public string Caminho { get; set; }
    public string? ContentType { get; set; }
    public long? TamanhoBytes { get; set; }
    public string? Hash { get; set; }
    public TipoArquivo Tipo { get; set; }
    public string? DriveFileId { get; set; }
}
