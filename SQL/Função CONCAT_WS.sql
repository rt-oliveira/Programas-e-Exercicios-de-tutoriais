-- Função CONCAT_WS
-- Função similar ao CONCAT, com a diferença de que o primeiro parâmetro
-- será um separador, isto é, entre cada par de strings passada como
-- argumento (a partir da segunda), será adicionada a string que atua
-- como separador.

-- Observação: se a string de separador for NULL, o resultado da função
-- será NULL.

-- No exemplo abaixo 3 string são passadas para a função: ',', 'First name'
-- e 'Last name'. A primeira string (',') será usada como separador.
-- Entre a segunda e a terceira string haverá o separador, e assim será 
-- entre cada par de strings.
SELECT CONCAT_WS(',','First name','Last name');
