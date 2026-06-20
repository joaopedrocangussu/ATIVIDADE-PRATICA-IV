# CENÁRIO 03 - EMPRESA DE SERVIÇOS TÉCNICOS

Projeto desenvolvido em C# com Windows Forms e SQL Server LocalDB para representar o cenário de uma empresa que presta serviços técnicos, como manutenção, instalação e suporte.

O sistema permite cadastrar uma ordem de serviço, informar o cliente, o técnico responsável, o tipo de serviço, a descrição do atendimento e o valor base. Depois disso, o programa calcula o valor final conforme o tipo de serviço e salva os dados no banco.

## Objetivo do projeto

Aplicar os conceitos de Programação Orientada a Objetos II usando um sistema simples de ordens de serviço.

O projeto segue a estrutura do passo a passo da aula:

- Windows Forms.
- Pasta `Models`.
- Pasta `DAL`.
- Classe de conexão com banco.
- Classe responsável por salvar e listar os dados.
- Banco SQL Server LocalDB.
- Exibição dos registros em um `DataGridView`.

## Cenário escolhido

Uma empresa presta serviços técnicos e precisa controlar:

- Clientes.
- Técnicos.
- Ordens de serviço.
- Tipos de serviço.

Os tipos de serviço implementados são:

- `Manutencao`
- `Instalacao`
- `Suporte`

Cada tipo possui uma forma própria de execução e um cálculo diferente para o preço final.

## Conceitos de POO utilizados

### Classe abstrata

A classe `Servico` é abstrata e representa um serviço genérico. Ela possui:

- `Descricao`
- `ValorBase`
- `Executar()`
- `CalcularPreco()`

Como ela é abstrata, não deve ser usada diretamente. As classes específicas herdam dela.

### Herança

As classes abaixo herdam de `Servico`:

- `Manutencao`
- `Instalacao`
- `Suporte`

Cada uma sobrescreve os métodos de execução e cálculo de preço.

### Interface

A interface `IExecutavel` define o método:

```csharp
string Executar();
```

A classe `Servico` implementa essa interface, e as classes filhas fornecem a execução específica de cada serviço.

### Polimorfismo

O formulário trabalha com uma variável do tipo `Servico`, mas em tempo de execução ela pode receber:

- `Manutencao`
- `Instalacao`
- `Suporte`

Assim, o método `CalcularPreco()` se comporta de forma diferente conforme o tipo escolhido.

### Tratamento de exceções

O projeto possui exceções personalizadas para representar regras de negócio:

- `TecnicoIndisponivelException`
- `OrdemJaFinalizadaException`
- `ServicoInexistenteException`
- `ValorInvalidoException`

Também há validações no formulário para evitar cadastro sem cliente, sem técnico, sem descrição ou com valor inválido.

## Estrutura do projeto

```text
CENÁRIO 03 - EMPRESA DE SERVIÇOS TÉCNICOS/
  DAL/
    Conexao.cs
    OrdemServicoDAL.cs

  Exceptions/
    OrdemJaFinalizadaException.cs
    ServicoInexistenteException.cs
    TecnicoIndisponivelException.cs
    ValorInvalidoException.cs

  Interfaces/
    IExecutavel.cs

  Models/
    Cliente.cs
    Tecnico.cs
    OrdemServico.cs
    Servico.cs
    Manutencao.cs
    Instalacao.cs
    Suporte.cs

  Scripts/
    CriarBanco.sql

  Form1.cs
  Form1.Designer.cs
  Program.cs
```

## Banco de dados

O banco usado no projeto é:

```text
ServicosTecnicosJP
```

A tabela usada é:

```text
OrdemServico
```

O script para criar o banco e a tabela está em:

```text
Scripts/CriarBanco.sql
```

Campos da tabela:

- `Id`
- `Cliente`
- `TelefoneCliente`
- `Tecnico`
- `TipoServico`
- `Descricao`
- `ValorBase`
- `ValorFinal`
- `Status`

## Conexão com o banco

A conexão está na classe:

```text
DAL/Conexao.cs
```

Connection string usada:

```text
Server=(localdb)\MSSQLLocalDB;
Database=ServicosTecnicosJP;
Trusted_Connection=True;
Encrypt=False;
TrustServerCertificate=True;
```

## Como executar

1. Abra a pasta do projeto no Visual Studio.
2. Abra o arquivo `CENÁRIO 03 – EMPRESA DE SERVIÇOS TÉCNICOS.csproj`.
3. Execute o script `Scripts/CriarBanco.sql` no SQL Server Management Studio.
4. Rode o projeto pelo botão verde do Visual Studio.
5. Preencha os campos do formulário:
   - Cliente
   - Telefone
   - Técnico
   - Tipo de serviço
   - Descrição
   - Valor base
6. Clique em `Salvar ordem`.
7. A ordem será salva no banco e exibida no grid.

## Fluxo do sistema

```text
Usuário
  ↓
Formulário Windows Forms
  ↓
Models
  ↓
OrdemServicoDAL
  ↓
Conexao
  ↓
SQL Server LocalDB
  ↓
Tabela OrdemServico
```

## Exemplo de uso

Exemplo de cadastro:

```text
Cliente: Padaria Pão Dourado
Telefone: (31) 99999-0000
Técnico: Renato Alves
Tipo de serviço: Instalacao
Descrição: Instalação de câmera de segurança
Valor base: 200,00
```

Se o tipo escolhido for `Instalacao`, o sistema calcula:

```text
Valor final = Valor base + 95,00
Valor final = 295,00
```

## Testes realizados

Foram realizados os seguintes testes:

- Compilação do projeto.
- Abertura do formulário.
- Criação do banco LocalDB.
- Salvamento de ordem de serviço.
- Listagem de ordens no `DataGridView`.
- Teste dos cálculos de `Manutencao`, `Instalacao` e `Suporte`.
- Teste das exceções de valor inválido e ordem finalizada.

Resultado:

```text
Todos os testes passaram.
```
