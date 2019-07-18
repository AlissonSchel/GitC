select 
	TipoDog,
	(SUM(Vendas)) as Vendas,
	Month(DataVenda) as 'Mês'
from VendasDogs
where MONTH(DataVenda) between 6 and 7
GROUP BY  TipoDog, Month(DataVenda)
ORDER BY Vendas desc