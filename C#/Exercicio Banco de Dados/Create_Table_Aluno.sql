CREATE TABLE [dbo].[Aluno] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (200) NOT NULL,
    [Ativo] BIT           NOT NULL,
    [Turma] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Aluno_ToTurma] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turma] ([Id])
);

