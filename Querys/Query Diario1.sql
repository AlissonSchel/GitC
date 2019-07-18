-- insert into Diario1 (Nome,Materia, Nota1, Nota2, Nota3, Nota4, Nota5, Nota6) values ('Cleivan','PHP',2,3,8,5,6,5);

select Nome, Materia, ((Nota1+Nota2+Nota3+Nota4+Nota5+Nota6)/6) as 'Média',
		IIF (((Nota1+Nota2+Nota3+Nota4+Nota5+Nota6)/6) >= 5, 'Aprovado', 'Reprovado') as 'Status' from Diario1
