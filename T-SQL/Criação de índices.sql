-- Exemplo de criação de índices no SQL Server, com T-SQL.

-- Neste exemplo está sendo criado um índice de coluna única
-- no campo ID da tabela Customers. Consultas dessa tabela,
-- que envolvam este campo, podem ser aceleradas, por causa deste índice.
CREATE INDEX singlecolumnindex
ON Customers (ID);

-- Já este outro exemplo mostra a criação de um outro índice. Mas a diferença,
-- neste caso, está no fato de ter sido criado um índice único, isto é, que não permite
-- duplicatas neste campo, logo, não haverão dois registros com nomes iguais na tabela Customers.
CREATE UNIQUE INDEX indice_unico
ON Customers(name);

-- Por último, há este exemplo de criação de um índice composto,
-- que é um índice como qualquer outro, mas que é formado por 2 ou mais colunas.
CREATE INDEX indice_composto
ON Customers(name,id);