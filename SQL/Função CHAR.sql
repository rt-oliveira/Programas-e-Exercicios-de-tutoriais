-- Função CHAR
-- Dado uma lista de números, transformará cada número para o 
-- seu caractere respectivo, e concatenará todos eles em uma
-- única string.
--
-- Observação 1: caso algum desses valores seja NULL, os números
-- subsequentes não serão lidos, e será retornada uma string
-- com os caracteres concatenados até então.
--
-- Observação 2: os números podem ser passados em forma de strings,
-- que são interpretados da mesma forma.

-- Neste exemplo, são passados vários números que, ao serem convertidos
-- para caracteres, formam a string 'MySQL'.
SELECT CHAR(77, 121, 83, 81, '76');