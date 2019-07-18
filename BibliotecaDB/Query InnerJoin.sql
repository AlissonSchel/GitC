-- select * from Biblioteca BL inner join Livros LV on BL.Id = LV.Biblioteca
/*
select
	LV.Id,
	LV.Nome,
	IIF(LV.Disponível = 1,'Sim','Não') as 'Disponível',
	BL.Nome
from Biblioteca BL inner join Livros LV on BL.Id = LV.Biblioteca
*/

select BL.Nome,
COUNT(LV.Id) as 'Quantidade de Títulos',
US.Nome as 'Usuario' from Biblioteca BL
inner join Livros LV on BL.Id = LV.Biblioteca
inner join Usuario US on LV.UserInc = US.Id
group by BL.Nome, US.Nome