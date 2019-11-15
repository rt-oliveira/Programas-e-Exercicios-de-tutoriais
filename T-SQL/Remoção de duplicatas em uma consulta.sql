-- A cláusula DISTINCT vai remover os registros
-- que são duplicados naquele(s) campo(s).

-- No caso desta consulta, serão apresentados todos os salários
-- diferentes que existem para os Customers, além de estarem
-- ordenados pelo mesmo.
SELECT DISTINCT salary FROM Customers ORDER by salary;