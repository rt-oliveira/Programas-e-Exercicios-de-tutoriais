-- Função ATN2
-- Retorna o valor do ângulo, em radianos, entre o eixo X positivo e o raio no ponto (y,x).
-- Para mais informações: https://docs.microsoft.com/pt-br/sql/t-sql/functions/atn2-transact-sql?view=sql-server-ver15

-- Neste exemplo, será passado o ponto (x, y) (-1, 0), e será mostrado o ângulo entre o eixo X positivo e este ponto.
SELECT ATN2(0, -1);