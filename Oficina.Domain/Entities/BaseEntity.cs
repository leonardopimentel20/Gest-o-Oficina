namespace Oficina.Domain.Entities;
public abstract class BaseEntity { public Guid Id { get; set; } = Guid.NewGuid(); public DateTimeOffset CriadoEm { get; set; } = DateTimeOffset.UtcNow; public DateTimeOffset? AtualizadoEm { get; set; } }
