# DESF5-Atividade_do_Desafio_Final

## Visão Geral

Esta documentação mostra como configurar, compilar e executar a **XPEducacao.API** (.NET 9) localmente, incluindo:

- Instalação dos pré‑requisitos (.NET 9 SDK, Git).  
- Clonagem do repositório e navegação na estrutura de pastas.  
- Restauração de dependências e compilação via CLI do .NET.  
- Execução da API e acesso ao Swagger UI.  
- Teste de endpoints via navegador, `curl` ou arquivo HTTP.

---

## 1. Pré‑requisitos

### 1.1 .NET 9 SDK  
Você precisa do **.NET 9 SDK** (inclui runtime e CLI) para compilar e rodar a aplicação.

- Para Windows/macOS/Linux, baixe em:
  https://dotnet.microsoft.com/en-us/download/dotnet/9.0

- No Windows, instale via WinGet:
  ```powershell
  winget install dotnet-sdk-9
  ```

### 1.2 Git  
Instale o Git para clonar o repositório:

https://git-scm.com

### 1.3 IDE ou Editor (Opcional)  
Use Visual Studio 2022 v17.12+ (suporta .NET 9), VS Code com C# Dev Kit ou Rider.

---

## 2. Clonar o Repositório

```bash
git clone https://github.com/Murillofilho86/DESF5-Atividade_do_Desafio_Final.git
cd DESF5-Atividade_do_Desafio_Final
```

---

## 3. Estrutura do Projeto

- **Solução**: `XPEducacao.sln`
- **Projeto API**: `src/XPEdicacao.API/XPEdicacao.API.csproj` (TargetFramework `net9.0`)
- **Program.cs**: configura serviços, controladores e Swagger
- **Controladores**: `Controllers/CostomerController.cs` (CRUD de clientes)
- **Pastas de código**:
  - `Models/`
  - `Services/`
  - `Repository/`
  - `Mapping/`

---

## 4. Restaurar e Compilar

No diretório raiz (onde está o `.sln`), execute:

```bash
dotnet restore    # baixa pacotes NuGet
dotnet build      # compila todos os projetos
```

Para compilar apenas o projeto da API:

```bash
dotnet restore src/XPEdicacao.API
dotnet build   src/XPEdicacao.API
```

---

## 5. Executar a API

No root ou em `src/XPEdicacao.API`, execute:

```bash
dotnet run --project src/XPEdicacao.API
```

- O console exibirá URLs do Kestrel (por exemplo, `https://localhost:7233` e `http://localhost:5233`).  
- Em **Development**, o Swagger UI fica disponível em `/swagger` e a spec OpenAPI em `/openapi`.

---

## 6. Testar Endpoints

### 6.1 Swagger UI  
Abra no navegador:
```
https://localhost:<porta>/swagger/index.html
```

## Referências Rápidas

| Ação                            | Comando / URL                                                         |
|---------------------------------|----------------------------------------------------------------------|
| Instalar .NET 9 SDK             | `winget install dotnet-sdk-9`                                         |
| Baixar .NET 9                   | https://dotnet.microsoft.com/en-us/download/dotnet/9.0                |
| Clonar repositório              | `git clone https://github.com/...`                                    |
| Build & Restore                 | `dotnet restore` / `dotnet build`                                     |
| Swagger (ambiente Dev)          | `/swagger/index.html`                                                 |

