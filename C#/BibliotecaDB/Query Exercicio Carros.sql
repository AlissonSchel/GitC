SELECT 
	Modelo,
	Ano,
	(SUM(Vendas) / count(Vendas)) as 'Média de Vendas',
	YEAR(DataVenda) as 'Ano das Vendas'
FROM Carros where YEAR(DataVenda) = 2019
GROUP BY Modelo, Ano, YEAR(DataVenda);