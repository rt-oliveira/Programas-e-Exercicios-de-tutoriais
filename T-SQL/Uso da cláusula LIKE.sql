-- Essa consulta vai mostrar todos os dados de "Customers"
-- na qual sal�rio come�a com '200'. Neste caso, sal�rio pode ser
-- 200, 2000, 20000, ...
SELECT * FROM Customers WHERE salary LIKE '200%';