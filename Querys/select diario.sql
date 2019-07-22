select 
	d.[Data],
	tr.Aluno, 
	n.Nota as 'Média',
	IIF(ISNULL(p.Id,0) > 0,'Presente','Ausente') as 'Presenças'
from Diario d 
inner join TurmaAlunos tr on d.Turma = tr.Turma
left join Presenca p on d.Id = p.Diario and tr.Aluno = p.Aluno
left join Nota n on tr.Aluno = n.Aluno and d.Id = n.DiarioId
group by d.[Data],tr.Aluno,n.Nota,p.Id