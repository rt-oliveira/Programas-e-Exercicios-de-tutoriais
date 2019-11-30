-- Exemplo de sub-consulta em um comando SELECT

-- Está selecionando todos os dados daqueles "Customers"
-- cujo id está no grupo dos Customers que tem 4500 ou mais de salário.
SELECT * FROM Customers
WHERE id IN (SELECT id FROM Customers WHERE salary > 4500);