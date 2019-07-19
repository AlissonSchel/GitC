CREATE TABLE [dbo].[Notas] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Aluno] INT NOT NULL,
    [Nota1] INT NOT NULL,
    [Nota2] INT NOT NULL,
    [Nota3] INT NOT NULL,
    [Nota4] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_ToAluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Aluno] ([Id])
);

