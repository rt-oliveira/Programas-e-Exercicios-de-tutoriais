/*
Est� procurando por um ID espec�fico,
e ao achar o registro que satisfaz a condi��o,
atualiza o endere�o do mesmo.
*/
UPDATE Customers SET address='Pune' WHERE id=6;

/*
Ao n�o colocar a cl�usula WHERE no comando UPDATE,
TODOS os registros ser�o atualizados nos campos referenciados,
com os novos valores.
*/
UPDATE Customers SET address='Pune', salary=1000.00;