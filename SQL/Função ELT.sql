-- Função ELT
-- Retorna a n-ésima string passada como parâmetro dessa função.

-- Dado um número e um conjunto de strings, a função retornará a n-ésima string passada
-- como parâmetro dessa função.

-- Se o número passado for menor que 1 ou for maior que a quantidade de strings passadas,
-- a função retornará NULL.

-- Neste exemplo, será mostrada a primeira string passada como parâmetro da função, que,
-- neste caso, é a string 'ej'.
SELECT ELT(1, 'ej', 'Heja', 'hej', 'foo');
