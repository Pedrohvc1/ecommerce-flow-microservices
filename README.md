# 📦 Estrutura do Projeto: EcommerceFlow.Microservices

Este projeto segue uma arquitetura de **microserviços com .NET**, com separação por domínio (Estoque, Vendas) e por camadas (Presentation, Domain, Infrastructure, etc).

## 🔖 Estrutura Geral

```plaintext
EcommerceFlow.Microservices.sln
└── src/
    ├── InventoryService/
    │   ├── 1-Presentation/
    │   │   └── EcommerceFlow.InventoryService.API/
    │   ├── 2-Domain/
    │   │   ├── EcommerceFlow.InventoryService.Domain.Application/
    │   │   └── EcommerceFlow.InventoryService.Domain.Core/
    │   ├── 3-Infrastructure/
    │   │   ├── EcommerceFlow.InventoryService.Infrastructure.Data/
    │   │   └── EcommerceFlow.InventoryService.Infrastructure.Services/
    │   ├── 4-CrossCutting/
    │   │   └── EcommerceFlow.InventoryService.CrossCutting.Exceptions/
    │   └── 5-Test/
    │       └── EcommerceFlow.InventoryService.Tests/
    │
    ├── SalesService/
    │   ├── 1-Presentation/
    │   │   └── EcommerceFlow.SalesService.API/
    │   ├── 2-Domain/
    │   │   ├── EcommerceFlow.SalesService.Application/
    │   │   └── EcommerceFlow.SalesService.Domain/
    │   ├── 3-Infrastructure/
    │   │   ├── EcommerceFlow.SalesService.Infrastructure.Data/
    │   │   └── EcommerceFlow.SalesService.Infrastructure.Services/
    │   ├── 4-CrossCutting/
    │   │   └── EcommerceFlow.SalesService.CrossCutting.Exceptions/
    │   └── 5-Test/
    │       └── EcommerceFlow.SalesService.Tests/
    │
    ├── ApiGateway/
    │   └── EcommerceFlow.ApiGateway/
    │
    └── BuildingBlocks/
        ├── EcommerceFlow.BuildingBlocks/
        ├── EcommerceFlow.BuildingBlocks.Authentication/
        └── EcommerceFlow.BuildingBlocks.Messaging/
```

### ✅ Descrição dos Componentes

| Caminho                                                    | Responsabilidade |
|-----------------------------------------------------------|------------------|
| `InventoryService/1-Presentation/API`                     | API do microserviço de Estoque |
| `InventoryService/2-Domain/Domain.Application`            | Camada de aplicação do Estoque |
| `InventoryService/2-Domain/Domain.Core`                   | Domínio central do Estoque |
| `InventoryService/3-Infrastructure/Infrastructure.Data`   | Infraestrutura de dados do Estoque |
| `InventoryService/3-Infrastructure/Infrastructure.Services`| Serviços externos do Estoque |
| `InventoryService/4-CrossCutting/CrossCutting.Exceptions` | Tratamento de exceções do Estoque |
| `InventoryService/5-Test/Tests`                           | Testes automatizados do Estoque |
| `SalesService/1-Presentation/API`                         | API do microserviço de Vendas |
| `SalesService/2-Domain/Application`                       | Camada de aplicação de Vendas |
| `SalesService/2-Domain/Domain`                            | Domínio central de Vendas |
| `SalesService/3-Infrastructure/Infrastructure.Data`       | Infraestrutura de dados de Vendas |
| `SalesService/3-Infrastructure/Infrastructure.Services`   | Serviços externos de Vendas |
| `SalesService/4-CrossCutting/CrossCutting.Exceptions`     | Tratamento de exceções de Vendas |
| `SalesService/5-Test/Tests`                               | Testes automatizados de Vendas |
| `ApiGateway/`                                             | Roteador principal das requisições |
| `BuildingBlocks/`                                         | Bibliotecas reutilizáveis (ex: JWT, Messaging) |
| `BuildingBlocks/Authentication`                           | Autenticação compartilhada |
| `BuildingBlocks/Messaging`                                | Mensageria compartilhada |

### 🛠️ Funcionalidades e melhorias implementadas

- Estrutura de pastas e projetos padronizada para InventoryService e SalesService, seguindo o mesmo padrão de camadas.
- Todos os projetos configurados para .NET 9.
- Swagger configurado e funcional nas APIs (InventoryService.API, SalesService.API e ApiGateway).
- Projeto ApiGateway simplificado, mas já preparado para documentação via Swagger.
- Projetos de teste com xUnit e coverlet configurados.
- BuildingBlocks preparado para bibliotecas compartilhadas (ex: autenticação, mensageria).
- Solution (.sln) organizada refletindo a estrutura de pastas dos microserviços.

## 📌 Tecnologias Utilizadas

- .NET 9
- ASP.NET Core
- Entity Framework Core
- RabbitMQ
- JWT Authentication
- Docker

## 📦 Como rodar

Em breve: docker-compose e instruções de execução.
