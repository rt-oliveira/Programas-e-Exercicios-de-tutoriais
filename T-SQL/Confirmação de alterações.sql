-- Exemplo do comando COMMIT

-- Ao realizar os comandos abaixo, todas as remoções
-- de registros na tabela "Customers" serão confirmadas,
-- serão feitas.
BEGIN TRAN
DELETE FROM customers
WHERE age = 25
COMMIT