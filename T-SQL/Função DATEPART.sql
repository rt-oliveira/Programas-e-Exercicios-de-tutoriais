-- Função DATEPART
-- Extra um elemento (o mês, o dia, o ano, ...) de uma determinada data.

-- Neste primeiro exemplo, é retornado o dia atual do Banco de Dados.
SELECT DATEPART(day, getdate()) as currentdate;

-- Neste outro exemplo, é mostrado o número do mês atual do Banco de Dados.
SELECT DATEPART(month, getdate()) as currentmonth;