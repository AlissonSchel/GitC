﻿CREATE TABLE [dbo].[Autores]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nome] NCHAR(100) NOT NULL, 
    [Descricao] VARCHAR(1000) NOT NULL,
)
