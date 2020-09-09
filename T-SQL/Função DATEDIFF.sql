-- Função DATEDIFF
-- Retorna a diferença de tempo entre duas datas em termos de uma grandeza de tempo
-- (como minutos, dias, horas, segundos, ...)
--
-- Para mais informações sobre a função, consultar:
-- https://docs.microsoft.com/pt-br/sql/t-sql/functions/datediff-transact-sql?view=sql-server-ver15

-- Neste exemplo, será mostrada a quantidade de horas entre 11/11/2015 e 16/11/2015.
Select datediff(hour, 2015-11-16, 2015-11-11) as differencehoursbetween20151116and20151111;