-- Função QUOTENAME
-- Dado uma string, retorna a mesma adicionando um caractere delimitador 
-- (que pode ser passado ou é usado o padrão) no início e no fim.
-- Observação: Somente alguns caracteres podem ser passados como delimitador,
-- qualquer outro gerará NULL como resultado.
-- Para consultar quais são eles: https://docs.microsoft.com/pt-br/sql/t-sql/functions/quotename-transact-sql?view=sql-server-ver15

-- Neste exemplo, a string 'RAMA' vai ser retornada com aspas duplas no início e no fim.
SELECT QUOTENAME('RAMA', '"');