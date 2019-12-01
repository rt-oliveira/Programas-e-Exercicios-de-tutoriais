-- Exemplo de como criar e chamar uma stored procedure.

-- Está sendo criada uma Stored Procedure que, simplesmente,
-- recuperará todos os dados da tabela Customers.                                                         	
CREATE PROCEDURE SelectCustomersTableData
AS
    SELECT * FROM Customers;
GO

-- O comando abaixo demonstra como executar a
-- a stored procedure criada acima.   
EXECUTE SelectCustomersTableData;