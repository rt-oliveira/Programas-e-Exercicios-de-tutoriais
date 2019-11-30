-- Exemplo de sub-consulta no comando UPDATE.

-- Neste exemplo, todos os "Customers" que tem, pelo menos
-- 27 anos de idade, tiveram seu salário reduzido a apenas
-- 25% do valor original.
UPDATE Customers
SET salary=salary*0.25
WHERE age IN (SELECT age FROM Customers_bkp
              WHERE age>=27)