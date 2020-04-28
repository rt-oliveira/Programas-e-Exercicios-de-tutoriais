-- Função POSITION
-- Funciona da mesma forma que a função LOCATE, onde são passadas duas strings (A e B), e é retornada a localização
-- da primeira ocorrência de A em B. Caso não ache, retorna 0.

-- Neste exemplo, baseado no exemplo da função LOCATE, será mostrado o índice da primeira ocorrência de 'bar' em 'foobarbar'.
SELECT POSITION('bar' IN 'foobarbar');