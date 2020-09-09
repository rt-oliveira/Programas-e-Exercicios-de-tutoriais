-- Função DATEADD
-- Adiciona uma porção de tempo a uma determinada data.
--
-- Para saber todas as informações:
-- https://docs.microsoft.com/pt-br/sql/t-sql/functions/dateadd-transact-sql?view=sql-server-ver15

-- Neste exemplo, será retornada a data equivalente a daqui a 10 dias.
Select dateadd(day, 10, getdate()) as after10daysdatetimefromcurrentdatetime;