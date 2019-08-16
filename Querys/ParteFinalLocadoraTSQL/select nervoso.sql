select count(loc.Id) as 'Quantidade', MONTH(loc.[Data]) 'Mês' from Locacao loc inner join Clientes cl on cl.id = loc.Cliente inner join Carros ca on ca.Id = loc.Carro GROUP BY MONTH(loc.[Data]) order by Quantidade desc

select count(loc.Id) as 'Quantidade', YEAR(loc.[Data]) 'Ano' from Locacao loc inner join Clientes cl on cl.id = loc.Cliente inner join Carros ca on ca.Id = loc.Carro GROUP BY YEAR(loc.[Data]) order by Quantidade desc
