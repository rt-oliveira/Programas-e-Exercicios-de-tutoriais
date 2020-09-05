-- Função STUFF
-- São passados 4 parâmetros para a função:
--  - Uma string S
--  - Um número N
--  - Um outro número Q
--  - Uma outra string T
-- A função substitui a substring de S que começa na posição N e com Q caracteres pela string T.

-- Neste exemplo, a substring que começa no 2º caractere e com 4 de tamanho será substituída por 'IJK'.
SELECT STUFF('ABCDEFGH', 2, 4, 'IJK');