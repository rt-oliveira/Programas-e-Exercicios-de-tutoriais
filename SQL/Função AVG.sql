-- Exemplo de uso da função AVG.

-- Neste exemplo, é retorna a média de 'daily_typing_pages'
-- da tabela employee_tbl.
SELECT AVG(daily_typing_pages) FROM employee_tbl;

-- Já este outro exemplo mostra a média de 'daily_typing_pages'
-- por nome da tabela employee_tbl.
SELECT name, AVG(daily_typing_pages) FROM employee_tbl
	GROUP BY name;
