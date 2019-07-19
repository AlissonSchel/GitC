select 
       A.Nome,
	   (N.Nota1+N.Nota2+N.Nota3+N.Nota4)/4 as 'Media',
	   IIF((N.Nota1+N.Nota2+N.Nota3+N.Nota4)/4 >= 7,'Aprovado','Reprovado') as 'Status Media',
	   IIF((SUM(CONVERT(money,F.Presenca)) / CONVERT(money,COUNT(F.Presenca)) * 100) >= 75,'Aprovado','Reprovado') as 'Status Frequencia'
from Aluno A
inner join Frequencia F on A.Id = F.Aluno
join Notas N on A.Id = N.Aluno
group by A.Nome,N.Nota1,N.Nota2,N.Nota3,N.Nota4