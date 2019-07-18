INSERT INTO aulaCsharp (Aluno, Idade, Ativo, UsuInc,
UsuAlt, DatInc, DatAlt) 
values ('Pedro', 20, 1, 10, 10, GETDATE(), GETDATE() );

INSERT INTO aulaCsharp (Aluno, Idade, Ativo, UsuInc,
UsuAlt, DatInc, DatAlt) 
values ('Lucas', 19, 0, 10, 10, GETDATE(), GETDATE());

INSERT INTO aulaCsharp (Aluno, Idade, Ativo, UsuInc,
UsuAlt, DatInc, DatAlt) 
values ('Enzo', 19, 1, 10, 10, GETDATE(), GETDATE());

INSERT INTO aulaCsharp (Aluno, Idade, Ativo, UsuInc,
UsuAlt, DatInc, DatAlt) 
values ('Dave', 21, 1, 10, 10, GETDATE(), GETDATE());

INSERT INTO aulaCsharp (Aluno, Idade, Ativo, UsuInc,
UsuAlt, DatInc, DatAlt) 
values ('Cleivan', 18, 0, 10, 10, GETDATE(), GETDATE());

GO
SELECT * FROM AulaCsharp;