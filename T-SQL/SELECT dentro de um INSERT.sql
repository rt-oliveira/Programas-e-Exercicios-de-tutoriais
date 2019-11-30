-- Exemplo de sub-consulta em um comando INSERT.

-- Este comando está, basicamente, populando uma tabela,
-- chamada Customers_bkp, com os dados da tabela Customers.
-- Uma cópia.
INSERT INTO Customers_bkp
SELECT * FROM Customers
WHERE id IN (SELECT id FROM Customers);