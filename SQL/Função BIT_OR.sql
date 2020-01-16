-- Neste exemplo, está sendo feita a função
-- BIT_OR na coluna PRICE da tabela CARS,
-- agrupando os registros pelo campo MAKER.
SELECT MAKER, BIT_OR(PRICE) BITS
FROM CARS GROUP BY MAKER;