-- Fun��o CONV
-- Converte um n�mero de uma base para outra base.
-- Se o n�mero, a base de origem ou a base de destino forem NULL, retorna NULL.

-- Neste exemplo, ser� convertido o "n�mero" 'a' da base 16 (hexadecimal) para a
-- base 2 (bin�ria).
SELECT CONV('a',16,2);