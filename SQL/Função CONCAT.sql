-- Exemplo de uso da função CONCAT.

-- Este primeiro exemplo mostra a concatenação das strings
-- FIRST e SECOND.
SELECT CONCAT('FIRST','SECOND');

-- Este outro exemplo mostra a concatenação de três campos
-- da tabela employee_tbl.
SELECT CONCAT(id, name, work_date) FROM employee_tbl;
