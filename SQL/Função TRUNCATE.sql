-- Função TRUNCATE
-- Dado um número X, e a quantidade de casas decimais Y, retorna X truncado em Y
-- casas decimais.

-- Observação 1: se Y for 0, gera um número inteiro.
-- Observação 2: se Y for maior que 0, gera um inteiro com os Y menores dígitos inteiros truncados.

-- Neste exemplo o número 7.536432 está sendo truncado com 2 casas decimais.
SELECT TRUNCATE(7.536432,2);
