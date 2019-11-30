-- Exemplo de sub-consulta no comando DELETE.

-- Neste exemplo, estão sendo removidos todos os "Customers"
-- que possuem, pelo menos, 27 anos de idade.
DELETE FROM Customers
WHERE age IN (SELECT age FROM Customers_bkp
              WHERE age>=27)