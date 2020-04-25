-- Função LOCATE
-- Retorna a posição inicial da primeira ocorrência de uma string em outra (e, opcionalmente,
-- a partir de uma determinada posição).
-- Retorna 0 caso não ache uma string em outra.

-- Neste exemplo pode ser visto que a primeira ocorrência de 'bar' em 'foobarbar' acontece 
-- na posição 4.
SELECT LOCATE('bar','foobarbar');