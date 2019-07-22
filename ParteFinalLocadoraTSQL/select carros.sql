select
ca.Nome as 'Carro',
count(ca.Id) as 'Quantidade'

from Locacao loc
inner join Clientes cl on cl.id = loc.Cliente
inner join Carros ca on ca.Id = loc.Carro
GROUP BY ca.Nome
order by Quantidade desc