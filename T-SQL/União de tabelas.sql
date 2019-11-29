-- Duas formas de fazer união de tabelas (JOIN)

-- Exemplo: Esta consulta recupera o ID, o nome 
--          e a idade de cada Customer, e a quantia paga
--          por eles em cada compra feita.

-- 1ª Forma
-- Fazendo um simples cruzamento de tabelas.
/* Quando é passado mais de uma tabela na cláusula FROM
	 é feito um cruzamento, isto é, todos os registros 
	 de uma tabela se relacionam com os todos os registros
	 da outra tabela.
*/
SELECT id, name, age, amount
  FROM Customers, Orders
  WHERE Customers.id = Orders.Customer_ID 
	
-- 2ª Forma
-- Usando a cláusula JOIN.
/* Usando esta cláusula você define as tabelas
	 que serão unidas, e com qual critério os registros
	 serão filtrados.
	 
	 Pode usar os operadores =, >, <, >=, <=, !=, BETWEEN, LIKE
	 para filtrar a união das tabelas.
*/
SELECT a.id, a.name, a.age, b.amount
  FROM Customers A INNER JOIN Orders B on a.id=b.Customer_Id