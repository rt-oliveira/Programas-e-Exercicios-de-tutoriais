-- Exemplo do comando ROLLBACK em transações.

-- Neste comandos abaixo, estão sendo feitas remoções de registros
-- na tabela Customers, porém, por causa do comando ROLLBACK, todas essas
-- remoções são desfeitas, isto é, nada é feito. 
BEGIN TRAN
DELETE FROM Customers
WHERE age = 25
ROLLBACK