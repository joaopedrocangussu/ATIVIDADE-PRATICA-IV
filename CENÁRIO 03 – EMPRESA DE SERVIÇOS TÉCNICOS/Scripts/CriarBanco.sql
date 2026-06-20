IF DB_ID('ServicosTecnicosJP') IS NULL
BEGIN
    CREATE DATABASE ServicosTecnicosJP;
END
GO

USE ServicosTecnicosJP;
GO

IF OBJECT_ID('OrdemServico', 'U') IS NULL
BEGIN
CREATE TABLE OrdemServico
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Cliente VARCHAR(100) NOT NULL,
    TelefoneCliente VARCHAR(30) NOT NULL,
    Tecnico VARCHAR(100) NOT NULL,
    TipoServico VARCHAR(30) NOT NULL,
    Descricao VARCHAR(200) NOT NULL,
    ValorBase DECIMAL(10,2) NOT NULL,
    ValorFinal DECIMAL(10,2) NOT NULL,
    Status VARCHAR(30) NOT NULL
);
END
