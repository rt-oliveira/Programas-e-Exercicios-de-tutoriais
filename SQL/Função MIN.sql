-- Exemplo de uso da função MIN.

-- Este exemplo retorna o menor valor de 'daily_typing_pages'
-- que há na tabela employee_tbl.
SELECT MIN(daily_typing_pages)
	FROM employee_tbl;

-- Já este outro exemplo mostra o menor valor de 'daily_typing_pages'
-- que há para cada nome diferente existente na tabela employee_tbl.
SELECT id, name, MIN(daily_typing_pages)
	FROM employee_tbl GROUP BY name;
