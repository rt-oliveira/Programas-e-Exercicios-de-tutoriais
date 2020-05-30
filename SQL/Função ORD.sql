-- Função ORD
-- Retorna o valor decimal de um caractere.
-- Se ele for um caractere de 1 único byte, é similar a fazer
-- ASCII(caractere).
-- Caso ele seja um caractere de mais de 1 byte, é retornado o seu
-- valor de acordo com a fórmula abaixo:
--		  (byte menos valioso)
--		+ (2º byte menos valioso) * 256
--		+ (3º byte menos valioso) * 256²
--		...

-- Nesse exemplo, é retornado o valor decimal do caractere '2'.
SELECT ORD('2');