-- Função REGEXP
-- Testa se uma determinada string respeita um determinado padrão. Caso verdade, retorna 1,
-- caso contrário, retorna 0.
-- Observação: 1- se a string e/ou o padrão for(em) NULL, a função retorna NULL.
--             2- a função não é case-sensitive

-- Abaixo vemos 3 exemplos dessa função, uma retornando 0, e as outras duas casos retornando 1.
-- Este caso retorna 0.
SELECT 'ABCDEF' REGEXP 'A%C%%';

-- Já os dois seguintes retornam 1.
SELECT 'ABCDE' REGEXP '.*';

SELECT 'new*\n*line' REGEXP 'new\\*.\\*line';