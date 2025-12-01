# Imersão .NET Expert - Projetos e Exemplos

Este repositório contém uma coleção abrangente de projetos desenvolvidos durante a jornada de especialização em .NET. Abaixo você encontra a lista organizada por módulos, padrões de projeto e arquiteturas.

## 📚 Módulos do Curso (Evolução do DevFreela)

Acompanhe a evolução da API `DevFreela` através dos diferentes estágios de desenvolvimento:

- **03 - Desenvolvimento de APIs com ASP.NET Core**: Estrutura básica da API.
- **04 - Arquitetura Limpa**: Refatoração para Clean Architecture.
- **05 - Persistência com Entity Framework Core**: Implementação de banco de dados SQL Server.
- **06 - CQRS**: Segregação de responsabilidades com Commands e Queries.
- **07 - Padrão Repository**: Abstração da camada de acesso a dados.
- **08 - Validação de APIs**: Implementação de FluentValidation.
- **09 - Autenticação e Autorização com JWT**: Segurança da API.
- **10 - Testes Unitários com xUnit**: Cobertura de testes automatizados.
- **11 - Azure DevOps**: Pipelines de CI/CD.
- **12 - Microsserviços e Mensageria**: Evolução para arquitetura distribuída.

---

## 🏗️ Arquitetura e Design Patterns

Exemplos práticos e focados de padrões de arquitetura e design de software.

### 🧱 Princípios SOLID
Localizado em `14 - Arquitetura/05 - Princípios SOLID`
- **SRP**: Single Responsibility Principle
- **OCP**: Open/Closed Principle
- **LSP**: Liskov Substitution Principle
- **ISP**: Interface Segregation Principle
- **DIP**: Dependency Inversion Principle

### 🎨 Design Patterns - Criacionais (Creational)
Localizado em `14 - Arquitetura/07 - Design Patterns - Creational`
- **Abstract Factory**: Famílias de objetos relacionados.
- **Builder**: Construção de objetos complexos passo-a-passo.
- **Factory Method**: Interface para criar objetos, deixando subclasses decidirem.
- **Prototype**: Clonagem de objetos.
- **Singleton**: Instância única global.

### 🧩 Design Patterns - Estruturais (Structural)
Localizado em `14 - Arquitetura/08 - Design Patterns - Structural`
- **Adapter**: Colaboração entre interfaces incompatíveis.
- **Bridge**: Desacopla abstração da implementação.
- **Composite**: Estruturas de árvore (parte-todo).
- **Decorator**: Adiciona responsabilidades dinamicamente.
- **Facade**: Interface simplificada para subsistemas complexos.
- **Flyweight**: Compartilhamento eficiente de objetos.
- **Proxy**: Substituto ou placeholder para outro objeto.

### 🧠 Design Patterns - Comportamentais (Behavioral)
Localizado em `14 - Arquitetura/09 - Design Patterns - Behavioral`
Projeto: `AwesomeShopPatterns.API`
Implementações de padrões como:
- **Strategy**
- **Observer**
- **Chain of Responsibility**
- **Command**
- **State**
- **Template Method**
- *(E outros implementados dentro da solução)*

### 🏛️ Estilos Arquiteturais
Localizado em `14 - Arquitetura/10 - Arquiteturas de Software`
- **Clean Architecture**: Foco no domínio e inversão de dependência.
- **Hexagonal Architecture (Ports & Adapters)**: Isolamento da aplicação via portas e adaptadores.
- **Event Driven Architecture (Arquitetura Orientada a Eventos)**: Comunicação assíncrona entre serviços via mensageria (RabbitMQ).
  - `EventDrivenArchitecture.Orders`: Serviço produtor de eventos de pedidos.
  - `EventDrivenArchitecture.Warehouse`: Serviço consumidor que reage a eventos de pedidos.
- **Serverless Architecture**: Aplicação de referência utilizando Azure Functions.
  - `EcommerceServerless.App`: Processamento de pedidos com HttpTrigger, ServiceBusTrigger e CosmosDBTrigger (`14 - Arquitetura/10 - Arquiteturas de Software/Serverless`).

---

## ☁️ Microsserviços

- **AwesomeShop.Services.Customers**: Exemplo de microsserviço focado em gestão de clientes (`13- Microserviços`).
- **DevFreela (Versão Microservices)**: Implementação distribuída do projeto principal (`12 - Microsserviços e Mensageria`).

---



## 🛠️ Tecnologias Utilizadas

- **.NET Core / .NET 5+**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **Dapper**
- **MediatR** (CQRS)
- **FluentValidation**
- **xUnit & Moq**
- **SQL Server**
- **RabbitMQ** (Mensageria)
- **Docker**
- **Azure Functions**
