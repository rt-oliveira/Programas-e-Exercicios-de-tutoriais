-- Fun��o STD
-- Mostra o desvio padr�o de um conjunto de dados.
-- Desvio padr�o = raiz quadrada da vari�ncia.

-- Neste exemplo � mostrado o desvio padr�o da coluna PRICE na tabela CARS.
SELECT STD(price) STD_DEVIATION FROM CARS;
