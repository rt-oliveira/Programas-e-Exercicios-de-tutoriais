-- Função SUBSTRING
-- Dado uma string (S), ele retornará uma substring (s).
-- Podem ser passados a posição inicial (a) e a quantidade de caracteres (b).
-- Caso informe somente (a), retornará (s) começando da posição (a).
-- Caso informe (a) e (b), retornará (s) começando da posição (a) e tendo (b) caracteres.

-- Há quatro sintaxes diferentes para esta função.

-- Nos dois primeiros, informando apenas a posição inicial.
SELECT SUBSTRING('Quadratically',5);

SELECT SUBSTRING('foobarbar' FROM 4);

-- Nesse próximo exemplo, é passada a posição inicial e a quantidade de caracteres.
SELECT SUBSTRING('Quadratically',5,6);