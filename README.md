# 📦 Controle de Estoque

Sistema desktop para gerenciamento de estoque, desenvolvido em **C#** com **Windows Forms**, utilizando **SQL Server** para persistência dos dados.

A aplicação permite controlar produtos, fornecedores e movimentações de entrada e saída de estoque por meio de uma interface simples e organizada.

---

## 🚀 Funcionalidades

- 🔐 Login de usuários
- 📦 Cadastro de produtos
- 🚚 Cadastro de fornecedores
- 📥 Registro de entradas de estoque
- 📤 Registro de saídas de estoque
- 📋 Consulta de produtos
- 📊 Relatórios de movimentações
- 💾 Persistência de dados em SQL Server

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET Framework
- Windows Forms (WinForms)
- SQL Server / SQL Server Express / LocalDB
- ADO.NET
- Visual Studio

---

## 📂 Estrutura do Projeto

```text
ControleEstoqueApp
│
├── Properties
│
├── FormProdutos.cs
├── FormFornecedores.cs
├── FormMovimentacoes.cs
├── FormRelatorios.cs
├── LoginForm.cs
├── MainForm.cs
│
├── Conexao.cs
├── App.config
├── Program.cs
│
├── ControleEstoqueApp.csproj
└── README.md
```

---

## 🏗️ Arquitetura

```text
Usuário
    │
    ▼
Windows Forms
    │
    ▼
ADO.NET
    │
    ▼
SQL Server
```

---

## ▶️ Como executar

### Clone o repositório

```bash
git clone https://github.com/Rester-fullstack/ControleEstoqueApp.git
```

Entre na pasta do projeto

```bash
cd ControleEstoqueApp
```

Abra o projeto no **Visual Studio**.

Configure a string de conexão no arquivo **App.config** conforme sua instalação do SQL Server.

Execute o projeto pressionando **F5** ou clicando em **Start** no Visual Studio.

---

## 🗄️ Banco de Dados

O sistema utiliza SQL Server para armazenar as informações.

As principais entidades são:

- Produtos
- Fornecedores
- Movimentações de Estoque

Caso necessário, crie as tabelas utilizando um script SQL compatível com a estrutura do projeto.

---

## 📊 Recursos da Aplicação

- Controle de estoque
- Cadastro de fornecedores
- Controle de movimentações
- Consulta de registros
- Relatórios básicos
- Interface desktop em Windows Forms

---

## 📸 Screenshots

Adicione imagens como:

- Tela de Login
- Tela Principal
- Cadastro de Produtos
- Cadastro de Fornecedores
- Movimentações
- Relatórios

---

## 📚 Objetivos do Projeto

Este projeto foi desenvolvido para praticar:

- Desenvolvimento Desktop com Windows Forms
- Programação em C#
- Integração com SQL Server
- ADO.NET
- CRUD completo
- Organização em múltiplos formulários
- Manipulação de banco de dados

---

## 🔮 Melhorias Futuras

- Implementação com Entity Framework Core
- Dashboard com indicadores
- Exportação de relatórios em PDF
- Controle de permissões por usuário
- Interface responsiva
- Tema escuro

---

## 👩‍💻 Desenvolvedora

**Ester da Costa Batista**

Desenvolvedora Full Stack

### Tecnologias

- C#
- .NET
- ASP.NET Core
- React
- SQL Server
- Entity Framework Core
- APIs REST

GitHub:

https://github.com/Rester-fullstack

---

## 📄 Licença

Projeto desenvolvido para fins de estudo e portfólio.
