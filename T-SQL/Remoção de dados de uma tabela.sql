-- Usando a cláusula WHERE, serão removidos somente alguns registros da tabela.
DELETE FROM Customers WHERE id=6;

-- Já sem a cláusula WHERE, serão removidos TODOS os registros da tabela.
DELETE FROM Customers;