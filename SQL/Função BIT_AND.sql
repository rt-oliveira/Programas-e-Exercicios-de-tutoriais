-- Exemplo de uso da função BIT_AND.

-- Está sendo feita a função BIT_AND em relação
-- a todos os valores de "Price" de um determinado
-- "Maker", isto é, está sendo feito um AND entre
-- todos os "Price" de um mesmo "Maker".
SELECT Maker, BIT_AND(Price) Bits
FROM Cars GROUP BY Maker;