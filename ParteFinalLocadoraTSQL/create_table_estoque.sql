CREATE TABLE [dbo].[Estoque]
(
    [Carro] INT NOT NULL, 
    [Quantidade] INT NOT NULL, 
    CONSTRAINT [FK_Estoque_To_Carros] FOREIGN KEY ([Carro]) REFERENCES [Carros]([Id])
)
