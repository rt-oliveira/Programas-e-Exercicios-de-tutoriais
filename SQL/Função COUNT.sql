-- Exemplo de uso da função COUNT

-- Neste exemplo, é retornado, simplemente,
-- a quantidade de registros na tabela "employee_tbl".
SELECT COUNT(*) FROM employee_tbl;

-- Já neste outro exemplo, é retornado a quantidade
-- de registros cujo nome seja "Zara"
SELECT COUNT(*) FROM employee_tbl
	WHERE name="Zara";
