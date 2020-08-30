# T-SQL

## Exemplos em T-SQL de tutoriais

- [Funções](#fun%C3%A7%C3%B5es)
- [Funções de String](#fun%C3%A7%C3%B5es-de-string)
- [Sub-consultas](#sub-consultas)
- [Transações](#transa%C3%A7%C3%B5es)

| Nome                                  | Descrição                                                                                                                   | Site do Tutorial                                                                     | Arquivo                                                              |
|---------------------------------------|-----------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------|----------------------------------------------------------------------|
| Agrupamento de dados                  | Um exemplo de como usar a cláusula GROUP BY para agrupar dados.                                                             | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_group_by_clause.htm)   | [Arquivo](T-SQL/Agrupamento%20de%20dados.sql)                        |
| Atualização dos dados de uma tabela   | Mostra dois exemplos de como atualizar os dados de uma tabela.                                                              | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_update_statement.htm)  | [Arquivo](T-SQL/Atualização%20dos%20dados%20de%20uma%20tabela.sql)   |
| Criação de índices                    | Tem exemplos que mostram os diferentes tipos de índices que podem ser criados nas tabelas no SQL Server.                    | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_indexes.htm)           | [Arquivo](T-SQL/Criação%20de%20índices.sql)                          |
| Criação de tabelas                    | Um exemplo de como criar tabelas usando T-SQL.                                                                              | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_create_tables.htm)     | [Arquivo](T-SQL/Criação%20de%20tabelas.sql)                          |
| Inserção de dados em uma tabela       | Um exemplo de como inserir dados em uma tabela, com duas sintaxes diferentes.                                               | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_insert_statement.htm)  | [Arquivo](T-SQL/Inserção%20de%20dados%20em%20uma%20tabela.sql)       |
| Ordenação de resultados de um SELECT  | Mostra exemplos de como ordenar resultados de uma consulta SELECT com a cláusula ORDER BY.                                  | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_order_by_clause.htm)   | [Arquivo](T-SQL/Ordenação%20de%20resultados%20de%20um%20SELECT.sql)  |
| Remoção de dados de uma tabela        | Mostra dois exemplos de como remover alguns dos registros, ou todos, de uma determinada tabela.                             | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_delete_statement.htm)  | [Arquivo](T-SQL/Remoção%20de%20dados%20de%20uma%20tabela.sql)        |
| Remoção de duplicatas em uma consulta | Mostra um exemplo de que, usando a cláusula DISTINCT, apenas dados distintos serão mostrados, não haverão dados duplicados. | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_distinct_clause.htm)   | [Arquivo](T-SQL/Remoção%20de%20duplicatas%20em%20uma%20consulta.sql) |
| Remoção de tabelas                    | Um exemplo de como remover uma tabela inteira de uma vez só.                                                                | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_drop_tables.htm)       | [Arquivo](T-SQL/Remoção%20de%20tabelas.sql)                          |
| Seleção de dados de uma tabela        | Um exemplo que mostra como selecionar dados de uma tabela.                                                                  | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_select_statement.htm)  | [Arquivo](T-SQL/Seleção%20de%20dados%20de%20uma%20tabela.sql)        |
| Stored procedure                      | Um exemplo de como criar e executar stored procedures.                                                                      | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_stored_procedures.htm) | [Arquivo](T-SQL/Stored%20procedure.sql)                              |
| União de tabelas                      | Mostra como fazer união de tabelas, seja por simples cruzamento delas ou usando a cláusula JOIN.                            | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_joining_tables.htm)    | [Arquivo](T-SQL/União%20de%20tabelas.sql)                            |
| Uso da cláusula LIKE                  | Mostra um exemplo de como usar a cláusula LIKE.                                                                             | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_like_clause.htm)       | [Arquivo](T-SQL/Uso%20da%20cláusula%20LIKE.sql)                      |
| Uso da cláusula WHERE                 | Mostra exemplos de como usar a cláusula WHERE para filtrar registros em um SELECT.                                          | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_where_clause.htm)      | [Arquivo](T-SQL/Uso%20da%20cláusula%20WHERE.sql)                     |

## Funções

| Nome           | Descrição                                                                             | Site do Tutorial                                                                                  | Arquivo                               |
|----------------|---------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------|---------------------------------------|
| Função CEILING | Mostra um exemplo da função CEILING, que retorna o menor inteiro maior que um número. | [Site do tutorial](https://www.tutorialspoint.com/sql/sql-numeric-functions.htm#function_ceiling) | [Arquivo](T-SQL/Função%20CEILING.sql) |

## Funções de String

| Nome             | Descrição                                                                                                     | Site do Tutorial                                                                    | Arquivo                                 |
|------------------|---------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------|-----------------------------------------|
| Função ASCII     | Mostra um exemplo da função ASCII, que retorna o código ASCII de um caractere.                                | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20ASCII.sql)     |
| Função CHAR      | Mostra um exemplo da função CHAR, que retorna o caractere referente a um código ASCII.                        | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20CHAR.sql)      |
| Função CHARINDEX | Mostra um exemplo da função CHARINDEX, que retorna o índice da primeira ocorrência da uma string em outra.    | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20CHARINDEX.sql) |
| Função CONCAT    | Mostra um exemplo da função CONCAT, que concatena strings.                                                    | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20CONCAT.sql)    |
| Função LEFT      | Mostra um exemplo da função LEFT, que retorna os primeiros caracteres de uma string.                          | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20LEFT.sql)      |
| Função LEN       | Mostra um exemplo da função LEN, que retorna a quantidade de caracteres de uma string.                        | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20LEN.sql)       |
| Função LOWER     | Mostra um exemplo da função LOWER, que põe toda uma string em caracteres minúsculos.                          | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20LOWER.sql)     |
| Função LTRIM     | Mostra um exemplo da função LTRIM, que retira espaços em branco no início de uma string.                      | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20LTRIM.sql)     |
| Função NCHAR     | Mostra um exemplo da função NCHAR, que retorna o caractere referente a um código Unicode.                     | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20NCHAR.sql)     |
| Função PATINDEX  | Mostra um exemplo da função PATINDEX, que retorna o índice da primeira ocorrência de um padrão em uma string. | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20PATINDEX.sql)  |
| Função QUOTENAME | Mostra um exemplo da função QUOTENAME, que adiciona um delimitador no início e no fim de uma string.          | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20QUOTENAME.sql) |
| Função REPLACE   | Mostra um exemplo da função REPLACE, que substitui partes de uma string.                                      | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20REPLACE.sql)   |
| Função REPLICATE | Mostra um exemplo da função REPLICATE, que replica uma string N vezes.                                        | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20REPLICATE.sql) |
| Função REVERSE   | Mostra um exemplo da função REVERSE, que inverte a ordem das letras de uma string.                            | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20REVERSE.sql)   |
| Função RIGHT     | Mostra um exemplo da função RIGHT, que retorna os últimos caracteres de uma string.                           | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20RIGHT.sql)     |
| Função RTRIM     | Mostra um exemplo da função RTRIM, que retira espaços em branco no fim de uma string.                         | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20RTRIM.sql)     |
| Função SPACE     | Mostra um exemplo da função SPACE, que cria string em branco.                                                 | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20SPACE.sql)     |
| Função SUBSTRING | Mostra um exemplo da função SUBSTRING, que retorna uma parte de uma string.                                   | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20SUBSTRING.sql) |
| Função UNICODE   | Mostra um exemplo da função UNICODE, que retorna o código Unicode de um caractere.                            | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20UNICODE.sql)   |
| Função UPPER     | Mostra um exemplo da função UPPER, que põe toda uma string em caracteres maiúsculos.                          | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_string_functions.htm) | [Arquivo](T-SQL/Função%20UPPER.sql)     |

## Sub-consultas

| Nome                       | Descrição                                                   | Site do Tutorial                                                               | Arquivo                                                 |
|----------------------------|-------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------------------------------------|
| SELECT dentro de um DELETE | Um exemplo de como usar sub-consultas no comando DELETE.    | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_sub_queries.htm) | [Arquivo](T-SQL/SELECT%20dentro%20de%20um%20DELETE.sql) |
| SELECT dentro de um INSERT | Um exemplo de como usar sub-consultas em um comando INSERT. | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_sub_queries.htm) | [Arquivo](T-SQL/SELECT%20dentro%20de%20um%20INSERT.sql) |
| SELECT dentro de um SELECT | Um exemplo de como fazer sub-consulta no comando SELECT.    | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_sub_queries.htm) | [Arquivo](T-SQL/SELECT%20dentro%20de%20um%20SELECT.sql) |
| SELECT dentro de um UPDATE | Um exemplo de como usar sub-consultas em um comando UPDATE. | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_sub_queries.htm) | [Arquivo](T-SQL/SELECT%20dentro%20de%20um%20UPDATE.sql) |

## Transações

| Nome                      | Descrição                                            | Site do Tutorial                                                                | Arquivo                                            |
|---------------------------|------------------------------------------------------|---------------------------------------------------------------------------------|----------------------------------------------------|
| Alterações desfeitas      | Um exemplo de uso do comando ROLLBACK em transações. | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_transactions.htm) | [Arquivo](T-SQL/Alterações%20desfeitas.sql)        |
| Comando SAVE              | Um exemplo de uso do comando SAVE em transações.     | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_transactions.htm) | [Arquivo](T-SQL/Comando%20SAVE.sql)                |
| Confirmação de alterações | Um exemplo de uso do comando COMMIT em transações.   | [Site do tutorial](https://www.tutorialspoint.com/t_sql/t_sql_transactions.htm) | [Arquivo](T-SQL/Confirmação%20de%20alterações.sql) |
