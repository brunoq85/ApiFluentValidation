
# API de Usuários com Fluent Validation e Banco de Dados In-Memory

Este projeto é uma API simples construída com ASP.NET Core Web API, que utiliza o Fluent Validation para validação de dados e o Entity Framework Core com banco de dados In-Memory para persistência temporária durante o desenvolvimento e testes.

## Funcionalidades

- **Criação de Usuários:** Permite criar novos usuários na API.
- **Validação de Dados:** Utiliza a biblioteca Fluent Validation para garantir que os dados dos usuários sejam válidos antes de serem armazenados.
- **Persistência In-Memory:** Armazena os dados temporariamente em um banco de dados In-Memory, ideal para desenvolvimento e testes sem a necessidade de configurar um banco de dados real.

## Pacotes Utilizados

- **[FluentValidation](https://fluentvalidation.net/):** Biblioteca para validação de objetos e suas propriedades.
- **[Microsoft.EntityFrameworkCore.InMemory](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory):** Provedor de banco de dados In-Memory para Entity Framework Core.

## Como Executar o Projeto

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/brunoq85/ApiFluentValidation.git
   cd seu-repositorio
   ```

2. **Instale as dependências:**
   ```bash
   dotnet restore
   ```

3. **Execute o projeto:**
   ```bash
   dotnet run
   ```

## Endpoints Disponíveis

- **POST /api/users:** Cria um novo usuário.
- **GET /api/users/by-id/{id}:** Obtém um usuário pelo seu ID.
- **GET /api/users/by-name/{firstName}:** Obtém um usuário pelo seu primeiro nome.

## Contribuição

Sinta-se à vontade para contribuir com este projeto, fazendo um fork do repositório e enviando suas sugestões através de pull requests.

## Licença

Este projeto é licenciado sob a [MIT License](LICENSE).
