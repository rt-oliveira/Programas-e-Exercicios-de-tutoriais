-- Função RPAD
-- Dados 3 argumentos (uma string S, um número N e um caractere C), a função criará uma string T 
-- de N caracteres, onde todos os caracteres serão C, exceto os primeiros caracteres, que serão os 
-- os caracteres da string S.
-- Caso N seja menor que o comprimento de S, serão retornados os N primeiros caracteres de S.

-- Neste exemplo, será criada uma string de 5 caracteres, onde os três últimos caracteres serão '?'
-- e os dois primeiros serão os caracteres da string que foi passada ('hi').
SELECT RPAD('hi',5,'?');
-- Retornará 'hi???'
