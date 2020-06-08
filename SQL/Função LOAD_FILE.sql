-- Função LOAD_FILE
-- Retorna o conteúdo de um arquivo.
-- Para usar a função é preciso...:
--	1. Que o arquivo esteja no servidor
--	2. Especificar o caminho completo do arquivo
--	3. Que tenha o privilégio de FILE
--	4. Que o arquivo possa ser lido
--	5. Que o arquivo tenha menos bytes que a quantidade
--	   especificada na propriedade 'max_allowed_packet'
--
-- Caso o arquivo não exista ou algum dos critérios
-- especificados não seja atendido, a função retorna NULL.

-- Neste exemplo, um determinado registro da tabela 'table_test'
-- terá o valor de um de seus campos alterados, e o novo valor
-- virá do conteúdo de um arquivo.
UPDATE table_test
SET blob_col = LOAD_FILE('/tmp/picture')
WHERE id=1;