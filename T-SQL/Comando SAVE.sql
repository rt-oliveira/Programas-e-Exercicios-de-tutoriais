-- Exemplo de uso do comando SAVE em transações.

-- Neste exemplo, são feitas 3 remoções de registros
-- da tabela Customers, e entre cada comando DELETE
-- há um comando SAVE TRANSACTION para marcar um ponto
-- da transação. No final a transação dá um ROLLBACK
-- até o ponto 'sp2' da transação, isto é, as duas últimas
-- remoções serão desfeitas.
BEGIN TRAN
SAVE TRANSACTION sp1
DELETE FROM Customers WHERE id=1
SAVE TRANSACTION sp2
DELETE FROM Customers WHERE id=2
SAVE TRANSACTION sp3
DELETE FROM Customers WHERE id=3
ROLLBACK TRANSACTION sp2