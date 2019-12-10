-- Exemplo de uso da função SQRT

-- Este primeiro exemplo faz o simples uso dele para identificar
-- a raiz quadrada de um número.
SELECT SQRT(16);

-- Já este outro exemplo faz o uso da função aplicado aos registros.
-- Está sendo recuperado, de cada registro da tabela employee_tbl,
-- o nome e a raiz quadrada do campo 'daily_typing_pages'.
SELECT name, SQRT(daily_typing_pages) FROM employee_tbl;
