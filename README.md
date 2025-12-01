📦 ControleEstoqueApp

Aplicação desktop para gerenciamento de estoque, desenvolvida em C# com Windows Forms (WinForms).
Ideal para controle interno de produtos, fornecedores e movimentações de entrada e saída.

🚀 Descrição Geral

O ControleEstoqueApp foi criado para oferecer uma solução simples e funcional de gestão de estoque, com tela de login, controle de usuários, cadastro de produtos, movimentações e relatórios básicos.

O sistema pode ser utilizado por pequenas empresas, lojas ou como estudo de aplicações desktop conectadas a banco de dados.

🛠️ Tecnologias Utilizadas
Camada	Tecnologia
Linguagem	C#
Interface	Windows Forms
Banco de Dados	SQL Server Express ou LocalDB
Acesso a Dados	ADO.NET
IDE	Visual Studio
📌 Funcionalidades
✅ Login e autenticação

Tela de login para acesso ao sistema

Validação de usuário e senha

🧾 Cadastro

Produtos (nome, preço, quantidade, descrição)

Fornecedores

Movimentações de entrada/saída do estoque

📊 Consultas e Relatórios

Consulta de produtos cadastrados

Consulta de movimentações

Geração de relatórios simples

🎨 Interface

Layout intuitivo com múltiplas telas

Menus organizados por módulos

DataGridViews para listagens

📁 Estrutura do Projeto
ControleEstoqueApp/
│
├── FormProdutos/            # Cadastro e edição de produtos
├── FormFornecedores/        # Cadastro de fornecedores
├── FormMovimentacoes/       # Entradas e saídas do estoque
├── FormRelatorios/          # Relatórios gerais
├── LoginForm.cs             # Tela de login
├── MainForm.cs              # Tela principal após login
│
├── Conexao.cs               # Classe de conexão com banco
├── App.config               # String de conexão
└── README.md

🗄️ Banco de Dados

Um exemplo de tabelas usadas:

CREATE TABLE Produtos (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100),
    Preco DECIMAL(10,2),
    Quantidade INT,
    Descricao NVARCHAR(255)
);

CREATE TABLE Fornecedores (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100),
    Telefone NVARCHAR(20),
    Email NVARCHAR(100)
);

CREATE TABLE Movimentacoes (
    Id INT PRIMARY KEY IDENTITY,
    ProdutoId INT FOREIGN KEY REFERENCES Produtos(Id),
    Tipo NVARCHAR(20), -- Entrada ou Saída
    Quantidade INT,
    DataMovimentacao DATETIME DEFAULT GETDATE()
);

▶️ Como Executar

Clone o repositório:

git clone https://github.com/Rester-fullstack/ControleEstoqueApp.git


Abra no Visual Studio

Configure a conexão com seu banco de dados em App.config:

<connectionStrings>
    <add name="Conexao"
         connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ControleEstoqueDB;Integrated Security=True" />
</connectionStrings>


Crie as tabelas manualmente (caso necessário)

Execute com F5

📌 Melhorias Futuras

✔ Migração para Entity Framework
✔ Relatórios em PDF
✔ Controle de usuários e permissões
✔ Dashboard com gráficos
✔ Modo dark

👤 Autora

Ester da Costa Batista
🖥️ Técnica em TI • Desenvolvedora Fullstack
📍 Aracaju – SE
📫 ester.retse30@gmail.com
