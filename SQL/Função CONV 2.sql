-- Função CONV
-- Converte um número de uma base para outra base.
-- Se o número, a base de origem ou a base de destino forem NULL, retorna NULL.

-- Neste exemplo, será convertido o "número" 'a' da base 16 (hexadecimal) para a
-- base 2 (binária).
SELECT CONV('a',16,2);