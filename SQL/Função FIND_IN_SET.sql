-- Função FIND_IN_SET
-- Dado uma string S e uma lista de strings L
-- (L é uma única string contendo N substrings, separadas por -- vírgulas),
-- a função tentará buscar S em L. Achando, retorna o índice de
-- S em L (a partir de 1). Não achando, retorna 0.

-- Neste exemplo, é testado se a string 'b' existe na lista de strings 'a,b,c,d' (é uma única string contendo 4 substrings).
SELECT FIND_IN_SET('b', 'a,b,c,d');