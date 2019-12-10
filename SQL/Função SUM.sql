-- Exemplo de uso da função SUM

-- Este exemplo mostra o somatório dos 'daily_typing_pages'
-- dos registros na tabela employee_tbl.
SELECT SUM(daily_typing_pages) FROM employee_tbl;

-- Já este outro exemplo mostra a soma das 'daily_typing_pages'
-- de cada nome na tabela employee_tbl.
SELECT name, SUM(daily_typing_pages) FROM employee_tbl
	GROUP BY name;
