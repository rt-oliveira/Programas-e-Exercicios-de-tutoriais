/*
Está procurando por um ID específico,
e ao achar o registro que satisfaz a condição,
atualiza o endereço do mesmo.
*/
UPDATE Customers SET address='Pune' WHERE id=6;

/*
Ao não colocar a cláusula WHERE no comando UPDATE,
TODOS os registros serão atualizados nos campos referenciados,
com os novos valores.
*/
UPDATE Customers SET address='Pune', salary=1000.00;