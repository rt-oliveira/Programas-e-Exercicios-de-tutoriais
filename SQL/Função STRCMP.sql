-- Função STRCMP
-- Compara 2 strings. Se a função retornar 0, isto significa que as 2 strings são iguais.
-- Se a fnção retornar -1, isto significa que a primeira string é menor do que a segunda, de acordo com o critério
-- de ordenação atual (geralmente ordem alfabética).
-- Já se a função retornar 1, isto significará que a segunda string é menor que a primeira no critério usado.

-- Neste primeiro exemplo, é visto que as 2 strings são igual, pois a função retorna 0.
SELECT STRCMP('MOHD','MOHD');

-- Neste segundo exemplo, é visto que a primeira string é menor que a segunda, pois a função retorna -1.
SELECT STRCMP('AMOHD','MOHD');

-- Neste terceiro exemplo, é visto que a segunda string é menor que a primeira, pois a função retorna 1.
SELECT STRCMP('MOHD','AMOHD');