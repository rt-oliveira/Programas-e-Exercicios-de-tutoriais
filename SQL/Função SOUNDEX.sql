-- Função SOUNDEX
-- Retorna o código soundex de uma string.
-- Soundex é um algoritmo que foi criado por Robert C. Russell 
-- e Margaret King Odell, que tem o objeto de indexar strings
-- que são homófonas (que possuem o mesmo som) na língua inglesa.
-- Esse algoritmo retorna uma string de 4 caracteres, que o identifica.
--
-- Para mais informações sobre o algoritmo Soundex:
-- https://en.wikipedia.org/wiki/Soundex

-- Nesse exemplo, é retornada a string soundex da string 'Hello'
SELECT SOUNDEX('Hello');