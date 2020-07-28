-- Função PATINDEX
-- Função muito similar ao CHARINDEX, mas com a diferença de que ela, ao invés de procurar por substrings puramente,
-- procura por ocorrências de padrões dentro de uma determinada string.
-- Assim como a outra função, em casos em que o padrão não é encontrado, é retornado 0.

-- Neste exemplo, testa-se o padrão 'I%' (string começar com I) em 'INDIA'.
-- Será retornado 1.
SELECT PATINDEX('I%', 'INDIA');