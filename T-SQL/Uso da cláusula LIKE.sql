-- Essa consulta vai mostrar todos os dados de "Customers"
-- na qual salário começa com '200'. Neste caso, salário pode ser
-- 200, 2000, 20000, ...
SELECT * FROM Customers WHERE salary LIKE '200%';