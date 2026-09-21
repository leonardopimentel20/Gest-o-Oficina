# OficinaMecanica .NET + EF Core

Base do projeto conforme o DER v4.0: entidades, enums, DbContext, configurações EF Core, PostgreSQL/Npgsql e API inicial.

Comandos:
```bash
dotnet restore
dotnet ef migrations add InitialCreate --project Oficina.Persistence --startup-project Oficina.Api
dotnet ef database update --project Oficina.Persistence --startup-project Oficina.Api
dotnet run --project Oficina.Api
```

Antes de produção: implementar regras de domínio, autenticação/autorização, transições de OS, aprovação imutável, estoque transacional, financeiro, auditoria, LGPD e integrações.
