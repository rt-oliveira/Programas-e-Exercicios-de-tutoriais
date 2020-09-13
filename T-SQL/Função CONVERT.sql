-- Função CONVERT
-- Converte um dado que está em um tipo de dado para outro.
--
-- Para mais informações:
-- https://docs.microsoft.com/pt-br/sql/t-sql/functions/cast-and-convert-transact-sql?view=sql-server-ver15

-- Abaixo estão 3 exemplos da função, usando padrões de data diferentes.
-- Nesse primeiro, usa-se o padrão com dia, mês e ano e horário completo
SELECT (VARCHAR(19), GETDATE());

-- Já nesse segundo exemplo, é mostrado a data atual no padrão mm-dd-aa.
SELECT (VARCHAR(10), GETDATE(), 10);

-- No terceiro exemplo, é mostrado a data atual no padrão mm-dd-aaaa.
SELECT (VARCHAR(10), GETDATE(), 110);