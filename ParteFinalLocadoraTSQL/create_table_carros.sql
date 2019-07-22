CREATE TABLE [dbo].[Carros]
(
	[Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (50)  NOT NULL,
    [Observacao]    VARCHAR (250) NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Carros_To_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Carros_To_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
)
