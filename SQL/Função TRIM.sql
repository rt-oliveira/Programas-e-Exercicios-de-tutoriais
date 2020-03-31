-- Função TRIM
-- Retorna uma string sem os primeiros (ou últimos, ou ambos os casos) caracteres,
-- sem necessariamente ser caractere em branco.

-- Caso não seja passado como parâmetro além da string, será assumido que se deseja
-- remover todos os espaços em branco que hajam no início E no fim da string.

-- Neste primeiro exemplo, é mostrado uma string sem os espaços em branco no início
-- *E* no fim da string
SELECT TRIM('  bar   ');

-- Agora, neste segundo exemplo, é retornado uma string sem os seus primeiros específicos
-- removidos. Neste caso, pede-se para remover todos os 'x' que existem no início da string
SELECT TRIM(LEADING 'x' FROM 'xxxbarxxx');

-- Neste terceiro exemplo, é mostrado uma string sem os primeiros e os últimos caracteres
-- específicos removidos. Aqui foi pedido para ser removido os primeiros e os últimos
-- caracteres 'x' da string
SELECT TRIM(BOTH 'x' FROM 'xxxbarxxx');

-- Neste último exemplo, é retornado uma string sem os últimos caracteres. Porém, neste caso,
-- pede-se para remover os últimos caracteres que sejam igual a string 'xyz'.
-- Ou seja, todos os registros da string 'xyz' que tiverem no final da string serão removidos
SELECT TRIM(TRAILING 'xyz' FROM 'barxxyz');