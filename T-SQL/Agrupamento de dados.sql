-- Esta consulta está agrupando os salários dos Customers pelo nome, 
-- isto é, dado um nome, junta os salários relativos àquele nome, e
-- mostra a soma.
SELECT name, SUM(salary) as [sum of salary] FROM Customers GROUP BY name;