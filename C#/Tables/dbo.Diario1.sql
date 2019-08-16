CREATE TABLE [dbo].[Diario1]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[Nome] varchar(100) not null,
	[Materia] varchar(50) not null,
	[Nota1] int not null DEFAULT 0,
	[Nota2] int not null DEFAULT 0,
	[Nota3] int not null DEFAULT 0,
	[Nota4] int not null DEFAULT 0,
	[Nota5] int not null DEFAULT 0,
	[Nota6] int not null DEFAULT 0,
	[Media] as ((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/6),
	[Status] as IIF (((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/6) >= 5, 'Aprovado', 'Reprovado')
)
