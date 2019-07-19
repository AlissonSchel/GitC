CREATE TABLE [dbo].[Frequencia] (
    [Aluno]    INT  NOT NULL,
    [Data]     DATE NOT NULL,
    [Presenca] BIT  NOT NULL, 
    CONSTRAINT [FK_Frequencia_ToAluno] FOREIGN KEY ([Aluno]) REFERENCES [Aluno]([Id])
);

