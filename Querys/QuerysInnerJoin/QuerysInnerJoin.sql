--Trazer somente as marcas que Felipe cadastrou
		select UsuInc,Nome from Marcas where UsuInc = 1;

--Trazer somente as marcas que Giomar cadastrou
		select Id,Nome,UsuInc from Marcas where UsuInc = 2;




--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
		select COUNT(Id) as 'Quantidade',Nome,UsuInc from Marcas where UsuInc = 1 GROUP BY Nome,UsuInc order by Quantidade desc;

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
		select COUNT(Id) as 'Quantidade',Nome,UsuInc from Marcas where UsuInc = 2 GROUP BY Nome,UsuInc order by Quantidade asc;


--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram
		select COUNT(m.Id) as 'Quantidade',Nome,u.Usuario from Marcas m inner join Usuarios u on u.Id = m.UsuInc where m.UsuInc = 1 or m.UsuInc= 2 GROUP BY Nome,u.Usuario order by Quantidade;




--Trazer somente os carros que Felipe cadastrou
		select Id, Modelo, UsuInc from Carros where UsuInc = 1;

--Trazer somente os carros que Giomar cadastrou
		select Id, Modelo, UsuInc from Carros where UsuInc = 2;




--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
		select COUNT(Id) as 'Quantidade',Marca,UsuInc from Carros where UsuInc = 1 GROUP BY Marca,UsuInc order by Quantidade desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
		select COUNT(Id) as 'Quantidade',Marca,UsuInc from Carros where UsuInc = 2 GROUP BY Marca,UsuInc order by Quantidade asc;




--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram
		select COUNT(c.Id) as 'Quantidade',Marca,u.Usuario from Carros c inner join Usuarios u on u.Id = c.UsuInc where c.UsuInc = 1 or c.UsuInc = 2 GROUP BY Marca,u.Usuario order by Quantidade desc;




--Trazer somente os carros das marcas que Felipe cadastrou
		select c.Modelo from Carros c inner join Marcas m on c.Marca = m.Id where c.UsuInc = 1;

--Trazer somente os carros das marcas que Giomar cadastrou
		select c.Modelo from Carros c inner join Marcas m on c.Marca = m.Id where c.UsuInc = 2;




--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
		select count(m.Id) as 'Quantidade',c.Modelo from Carros c inner join Marcas m on c.Marca = m.Id where c.UsuInc = 1 GROUP BY c.Modelo ORDER BY Quantidade desc;

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
		select count(m.Id) as 'Quantidade',c.Modelo from Carros c inner join Marcas m on c.Marca = m.Id where c.UsuInc = 2 GROUP BY c.Modelo ORDER BY Quantidade asc;



--Trazer o valor total de vendas 2019 isolado
		select YEAR(DatInc) as 'Ano',SUM(Valor * Quantidade) as 'ValorTotal' FROM Vendas WHERE YEAR(DatInc) = 2019 GROUP BY YEAR(DatInc);

--Trazer a quantidade total de vendas 2019 isolado
		select YEAR(DatInc) as 'Ano',SUM(Quantidade) 'Quantidade' from Vendas where YEAR(DatInc) = 2019 GROUP BY YEAR(DatInc);




--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
		select YEAR(DatInc) as 'Ano',SUM(Valor * Quantidade) as 'ValorTotal' FROM Vendas GROUP BY YEAR(DatInc) order by ValorTotal desc;

--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
		select YEAR(DatInc) as 'Ano',SUM(Quantidade) 'Quantidade' from Vendas GROUP BY YEAR(DatInc) order by Quantidade asc;




--Trazer o mês de cada ano que retornou a maior quantidade de vendas
		select MONTH(DatInc) as 'Mes',SUM(Quantidade) 'Quantidade' from Vendas GROUP BY MONTH(DatInc) order by Quantidade asc;

--Trazer o mês de cada ano que retornou o maior valor de vendas
		select MONTH(DatInc) as 'Mes',SUM(Valor * Quantidade) as 'ValorTotal' FROM Vendas GROUP BY MONTH(DatInc) order by ValorTotal desc;




--Trazer o valor total de vendas que Felipe realizou
		select UsuInc,SUM(Valor * Quantidade) as 'Valor' from Vendas where UsuInc = 1  GROUP BY UsuInc;

--Trazer o valor total de vendas que Giomar realizou
		select UsuInc,SUM(Valor * Quantidade) as 'Valor' from Vendas where UsuInc = 2  GROUP BY UsuInc;




--Trazer a quantidade total de vendas que Felipe realizou
		select UsuInc,SUM(Quantidade) as 'Quantidade' from Vendas where UsuInc = 1  GROUP BY UsuInc;

--Trazer a quantidade de vendas que Giomar realizou
		select UsuInc,SUM(Quantidade) as 'Quantidade' from Vendas where UsuInc = 2  GROUP BY UsuInc;




--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
		select UsuInc,SUM(Quantidade) as 'Quantidade' from Vendas where UsuInc = 1 or UsuInc = 2 GROUP BY UsuInc

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
		select u.Usuario,SUM(Valor * Quantidade) as 'ValorTotal' from Vendas v inner join Usuarios u on u.Id = v.UsuInc where v.UsuInc = 1 or v.UsuInc = 2 GROUP BY u.Usuario




--Trazer  a marca mais vendida de todos os anos
		select TOP(1) v.Quantidade, m.Nome,YEAR(v.DatInc) as 'Ano' from Vendas v inner join Marcas m on v.Carro = m.Id ORDER BY v.Quantidade desc

--Trazer o valor total da marca mais vendida de todos os anos
		select TOP(1) v.Valor, m.Nome,YEAR(v.DatInc) as 'Ano' from Vendas v inner join Marcas m on v.Carro = m.Id ORDER BY v.Valor desc




--Trazer a quantidade do carro mais vendido de todos os anos
		select TOP(1) v.Quantidade, m.Nome,YEAR(v.DatInc) as 'Ano' from Vendas v inner join Marcas m on v.Carro = m.Id ORDER BY v.Quantidade desc

--Trazer o valor do carro mais vendido de todos os anos
		select TOP(1) v.Valor, m.Nome,YEAR(v.DatInc) as 'Ano' from Vendas v inner join Marcas m on v.Carro = m.Id ORDER BY v.Quantidade desc