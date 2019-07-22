select 
	a.Aluno,
	SUM(n.Nota) / count(d.[Data]) as 'Média'
from Alunos a

inner join TurmaAlunos ta on a.Id = ta.Aluno
inner join Diario d on ta.Turma = d.Turma
left join Nota n on d.Id = n.DiarioId and a.Id = n.Aluno
where ta.Turma = 2
GROUP BY a.Aluno