-- Função SUBSTRING_INDEX
-- São passados 3 parâmetros a ela:
--  - Uma string principal (S)
--  - Uma string que atuará como delimitador (D)
--  - Um número (N)
-- A função retornará uma outra string, que conterá os primeiros
-- caracteres dela até a N-ésima ocorrência de D (não retorna a última
-- ocorrência de D).
--
-- Observação: N pode ser negativo ou positivo. Caso seja positivo, olha
-- do início ao fim da string. Caso seja negativo, olha do fim para o
-- início da string.

-- Neste exemplo, será retorna uma substring de 'www.mysql.com', na qual
-- conterá todos os caracteres da string até a 2ª ocorrência de '.', sem
-- contá-la.
SELECT SUBSTRING_INDEX('www.mysql.com', '.', 2);
-- Essa função retornará 'www.mysql'.