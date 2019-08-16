CREATE TABLE [dbo].[Locacao]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Carro] INT NOT NULL, 
    [Cliente] INT NOT NULL, 
    [Data] DATETIME NOT NULL, 
    CONSTRAINT [FK_Locacao_To_Clientes] FOREIGN KEY ([Cliente]) REFERENCES [Clientes]([Id]),
    CONSTRAINT [FK_Locacao_To_Carros] FOREIGN KEY ([Carro]) REFERENCES [Carros]([Id]),
)
