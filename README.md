# Projeto_API_Definitivo
A api apresentada tem como objetivo realizar o gerenciamento de produtos, incluindo categorias e produtos, com as funcionalidades apresentadas a seguir.

# Funcionalidades de Categoria:

* Cadastrar categoria
* Alterar categoria
* Listar categorias (com filtragem por nome e situação)

# Funcionalidades de Produto:

* Cadastrar produto
* Alterar produto
* Listar produtos (com filtragem por categoria, descrição e situação)

# Estrutura do Banco de Dados:

* Categoria (Id, Nome, Situação - Ativo ou inativo)
* Produto (Id, Nome, Descrição, Preço, Situação - Ativo ou inativo)

O projeto foi implementado utilizando sistema de Migrations, usando Entity Framework Core para gerenciar o esquema de banco de dados, com AutoMapper para mapeamento entre entidades e DTOs.

# Requisitos
* Possuir .NET Core SDK 7.0.
* Ter instalado os pacotes a seguir:  
  * AutoMapper: Biblioteca para mapeamento de objetos.
  * AutoMapper.Extensions.Microsoft.DependencyInjection: Extensão do AutoMapper para injeção de dependência no ASP.NET Core.
  * Microsoft.AspNetCore.OpenApi: Pacote para geração de documentação interativa da API usando o Swagger.
  * Microsoft.EntityFrameworkCore e Microsoft.EntityFrameworkCore.Design**: Pacotes para acesso e gerenciamento de banco de dados com o Entity Framework Core.
  * Microsoft.VisualStudio.Web.CodeGeneration.Design: Pacote para geração de código usando o CLI do ASP.NET Core.
  * Npgsql.EntityFrameworkCore.PostgreSQL: Integração do Entity Framework Core com o PostgreSQL.
  * Swashbuckle.AspNetCore: Pacote para geração de documentação Swagger (OpenAPI) para a API ASP.NET Core.

* Possuir o PostegreSQL instalado na máquina.


# Configuração
* Lembre-se de possuir o PostegreSQL instalado na máquina.
* Clone o Repositório utilizando o comando : **git clone** https://github.com/FillypeNogueira/Projeto_API_Definitivo.git.
* Para que tudo ocorra conforme o esperado, insira as credenciais de banco de dados no campo referente a **ConnectionString** no arquivo **appsettings.json**, também esteja atento ao arquivo **DataAppDbContextFactory.cs**.
* Execute as Migrations, no terminal navegue até a pasta do projeto onde o arquivo .csproj está localizado e utilize o comando :**dotnet ef database update**. Isso configurará o banco de dados de acordo com o modelo definido na API.
* Execute a Aplicação, utilize o comando: **dotnet run**.
* Utilize o Swagger para efetuar os procedimentos de teste de funcionalidade.
