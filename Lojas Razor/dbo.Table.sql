CREATE TABLE [dbo].[Usuario]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Senha] VARCHAR(50) NULL, 
    [DataDeNascimento] DATETIME NULL, 
    [Endereco] VARCHAR(50) NULL, 
    [Complemento] VARCHAR(50) NULL, 
    [CEP] VARCHAR(50) NULL, 
    [Observacoes] VARCHAR(50) NULL, 
    [RecebePromocoes] VARCHAR(50) NULL
)
