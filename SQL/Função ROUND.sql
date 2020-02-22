-- Função ROUND
-- Arredonda um número para o inteiro mais próximo, ou para
-- o número com X casas decimais mais próximo.

-- Neste primeiro exemplo, será retornado o inteiro
-- mais próximo de 5.693893, que é 6.
SELECT ROUND(5.693893);

-- Já neste segundo exemplo o mesmo número vai ser arredondado,
-- porém será feito o arredondamento com 2 casas decimais.
-- O número de 2 casas decimais mais próximo de 5.693893 é 5.69.
SELECT ROUND(5.693893,2);
