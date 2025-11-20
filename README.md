# API CRUD Completa

![App Screenshot](https://i.ibb.co/QFTQ7w0L/Captura-de-tela-2025-11-20-134830.png)

## Descrição do Projeto

Este projeto é uma API completa para realizar operações CRUD (Create, Read, Update, Delete) em um banco de dados SQLite. Ele foi desenvolvido utilizando o framework .NET 8.0 e o Entity Framework Core para gerenciar o banco de dados. A API é projetada para gerenciar informações de pessoas, incluindo dados como nome, gênero, documento, e-mail, telefone, endereço, cidade, estado, CEP e data de nascimento.

A estrutura do projeto segue boas práticas de organização, com separação de responsabilidades em diferentes camadas, como Models, Data e Routes.

---

## Tecnologias Utilizadas

- **.NET 8.0**: Framework principal para desenvolvimento da API.
- **Entity Framework Core**: ORM (Object-Relational Mapper) para gerenciar o banco de dados SQLite.
- **SQLite**: Banco de dados leve e portátil utilizado para persistência de dados.

---

## Pré-requisitos

Antes de começar, certifique-se de ter as seguintes ferramentas instaladas em sua máquina:

1. **.NET SDK 8.0**
   - Você pode baixar e instalar o SDK do .NET 8.0 no site oficial da Microsoft: [Download .NET](https://dotnet.microsoft.com/download)

2. **SQLite** (opcional)
   - Embora o Entity Framework Core gerencie o banco de dados SQLite automaticamente, você pode instalar o cliente SQLite para inspecionar o banco de dados diretamente.

3. **Git** (opcional)
   - Para clonar o repositório, você precisará do Git instalado. Baixe em: [Download Git](https://git-scm.com/)

4. **Editor de Código**
   - Recomenda-se o uso do Visual Studio Code ou Visual Studio para trabalhar com o projeto.

---

## Passo a Passo para Inicializar o Projeto

### 1. Clonar o Repositório

Se você ainda não clonou o repositório, execute o seguinte comando no terminal:

```bash
# Substitua <URL_DO_REPOSITORIO> pela URL do repositório Git
git clone <URL_DO_REPOSITORIO>
```

### 2. Navegar até o Diretório do Projeto

Entre no diretório do projeto clonado:

```bash
cd "API CRUD Completa"
```

### 3. Restaurar Dependências

Restaure as dependências do projeto utilizando o comando abaixo:

```bash
dotnet restore
```

### 4. Aplicar as Migrações do Banco de Dados

Certifique-se de que as migrações estão atualizadas e aplique-as ao banco de dados:

```bash
dotnet ef database update
```

> **Nota:** O comando acima criará o arquivo `person.sqlite` no diretório do projeto, que será o banco de dados utilizado pela aplicação.

### 5. Executar o Projeto

Inicie o servidor da API com o seguinte comando:

```bash
dotnet run
```

Se tudo estiver configurado corretamente, a API estará disponível em `http://localhost:5000` (ou outra porta configurada).

### 6. Testar a API

Você pode testar os endpoints da API utilizando ferramentas como:

- **Postman**
- **Insomnia**
- **Extensão REST Client no VS Code** (arquivo `Person.http` já incluído no projeto)

---

## Estrutura do Projeto

Abaixo está uma visão geral da estrutura do projeto:

```
API CRUD Completa/
├── Person/
│   ├── Data/                # Configuração do contexto do banco de dados
│   │   └── PersonContext.cs
│   ├── Models/              # Modelos de dados
│   │   ├── PersonModel.cs
│   │   └── PersonRequest.cs
│   ├── Routes/              # Definição das rotas da API
│   │   └── PersonRoute.cs
│   ├── Migrations/          # Arquivos de migração do Entity Framework
│   ├── appsettings.json     # Configurações da aplicação
│   ├── Program.cs           # Ponto de entrada da aplicação
│   └── Person.csproj        # Arquivo de configuração do projeto
└── API CRUD Completa.sln    # Solução do projeto
```

---

## Explicação dos Arquivos Principais

- **`PersonContext.cs`**: Configura o Entity Framework Core para usar o banco de dados SQLite.
- **`PersonModel.cs`**: Define o modelo de dados principal da aplicação.
- **`PersonRequest.cs`**: Define o modelo de requisição para criar ou atualizar pessoas.
- **`PersonRoute.cs`**: Contém as rotas da API para gerenciar pessoas.
- **`Migrations/`**: Contém os arquivos de migração gerados pelo Entity Framework Core.
- **`appsettings.json`**: Arquivo de configuração da aplicação.

---

## Considerações Finais

Este projeto foi desenvolvido para ser simples e funcional, utilizando tecnologias modernas e boas práticas de desenvolvimento. Sinta-se à vontade para contribuir ou adaptar o projeto às suas necessidades.

Para dúvidas ou sugestões, entre em contato com o desenvolvedor ou abra uma issue no repositório.

---

**Autor:** Ender Josue Guaina Vera

**Licença:** Este projeto está licenciado sob a licença MIT.
