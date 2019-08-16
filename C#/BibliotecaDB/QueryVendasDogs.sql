select 
	TipoDog,
	(SUM(Vendas)) as Vendas,
	Month(DataVenda) as 'Mês'
from VendasDogs
GROUP BY  TipoDog, Month(DataVenda)
ORDER BY Vendas desc