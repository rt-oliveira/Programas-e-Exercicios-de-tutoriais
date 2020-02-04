-- A função INTERVAL tem como parâmetro no mínimo 2 número, sendo o primeiro (chamado N) obrigatoriamente
-- o número que será usado para comparação, e a partir do 2º uma lista de números. E retorna o índice 
-- (a partir de 0), do 1º número acima de N.
-- Neste exemplo, será retornado o índice do primeiro número acima de 6, que é 7.
-- Temos:
-- 	6 - O número a ser usado como comparação.
-- 	1,2,3,4,5,6,7,8,9,10 - A lista de números a ser usada para comparar com o número acima.
-- 	6 é maior que 1,2,3,4,5; igual ao 6, mas é menor que 7.
SELECT INTERVAL(6,1,2,3,4,5,6,7,8,9,10);