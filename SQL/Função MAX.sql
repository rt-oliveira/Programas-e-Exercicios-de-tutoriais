-- Exemplo de uso da função MAX

-- Neste exemplo, é retornado o maior valor do campo
-- 'daily_typing_pages' dentre todos os registros da tabela
-- employee_tbl.
SELECT MAX(daily_typing_pages) FROM employee_tbl;

-- No segundo exemplo, abaixo, é consultado o maior valor de
-- 'daily_typing_pages' considerando, desta vez, o maior de
-- cada pessoa diferente, e não em relação a todos os registros.
SELECT MAX(daily_typing_pages) FROM employee_tbl;
	GROUP BY name;

-- Neste último exemplo, é mostrado o maior e o menor valor
-- de 'daily_typing_pages' dentre todos os registros da tabela 
-- employee_tbl.
SELECT MIN(daily_typing_pages) minimo, MAX(daily_typing_pages) maximo
FROM employee_tbl;
