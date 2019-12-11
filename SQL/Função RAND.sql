-- Exemplo de uso da função RAND.

-- Neste primeiro exemplo são gerados 3 números aleatórios
-- entre 0 e 1.
SELECT RAND(), RAND(), RAND();

-- O segundo exemplo é semelhante ao primeiro, com a diferença
-- de que no primeiro RAND() é passado um argumento inteiro.
-- Este argumento inteiro indica a "semente", e fará com que sempre
-- seja gerado o mesmo número aleatório para este valor de "semente".
-- Ou seja, quando "semente" está passado como argumento, passando sempre
-- o mesmo número, será sempre retornado o mesmo número aleatório.
SELECT RAND(1), RAND(), RAND();

-- Este último exemplo mostra que é possível tornar aleatório a exibição
-- dos registros de uma consulta SQL. Usando RAND() como cláusula do 
-- ORDER BY, os registros sempre aparecerão randomizados, a menos que tenha
-- usado uma mesma semente.
SELECT * FROM employee_tbl ORDER BY RAND();
