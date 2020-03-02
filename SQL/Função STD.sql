-- Função STD
-- Mostra o desvio padrão de um conjunto de dados.
-- Desvio padrão = raiz quadrada da variância.

-- Neste exemplo é mostrado o desvio padrão da coluna PRICE na tabela CARS.
SELECT STD(price) STD_DEVIATION FROM CARS;
