-- Exemplo de uso da função BIT_COUNT.

-- Serão mostrados quantos bits estão ativos na representação binária
-- dos números 2, 4 e 7.
SELECT BIT_COUNT(2) AS Dois,
			 BIT_COUNT(4) AS Quatro,
       BIT_COUNT(7) AS Sete;