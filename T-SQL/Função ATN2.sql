-- Fun��o ATN2
-- Retorna o valor do �ngulo, em radianos, entre o eixo X positivo e o raio no ponto (y,x).
-- Para mais informa��es: https://docs.microsoft.com/pt-br/sql/t-sql/functions/atn2-transact-sql?view=sql-server-ver15

-- Neste exemplo, ser� passado o ponto (x, y) (-1, 0), e ser� mostrado o �ngulo entre o eixo X positivo e este ponto.
SELECT ATN2(0, -1);